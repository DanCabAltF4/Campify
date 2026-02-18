package com.example.campify.data.room.repository

import com.example.campify.data.model.Parcela
import com.example.campify.data.remote.ParcelaService
import com.example.campify.data.room.dao.ParcelaDAO
import com.example.campify.data.room.mapper.toDomain
import com.example.campify.data.room.mapper.toEntity

class ParcelaRepository(
    private val api: ParcelaService,
    private val dao: ParcelaDAO
) {

    suspend fun syncParcelas() {
        val remotas = api.getParcelas()
        dao.clear()
        dao.insertAll(remotas.map { it.toEntity() })
    }

    suspend fun getParcelas(): List<Parcela> =
        dao.getAll().map { it.toDomain() }

    // Actualiza primero en Room
    suspend fun updateLocal(parcela: Parcela) {
        dao.update(parcela.toEntity())
    }

    // Actualiza Room y API
    suspend fun actualizarParcela(parcela: Parcela) {
        // Primero Room
        updateLocal(parcela)
        // Luego API
        api.actualizarParcela(parcela.id, parcela)
    }
}
