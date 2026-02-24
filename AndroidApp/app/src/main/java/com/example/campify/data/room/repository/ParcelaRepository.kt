package com.example.campify.data.room.repository

import android.util.Log
import com.example.campify.data.model.Parcela
import com.example.campify.data.model.enums.EstadoParcela
import com.example.campify.data.remote.ParcelaService
import com.example.campify.data.room.dao.ParcelaDAO
import com.example.campify.data.room.mapper.toDomain
import com.example.campify.data.room.mapper.toEntity

class ParcelaRepository(
    private val api: ParcelaService,
    private val dao: ParcelaDAO
) {

    suspend fun cambiarEstado(id: Int, estado: EstadoParcela) {
        val response = api.cambiarEstado(id, estado)
        if (response.isSuccessful) {
            response.body()?.let {
                dao.update(it.toEntity())
            }
        }
    }

    suspend fun syncParcelas() {
        val remotas = api.findAll()
        if (remotas.isSuccessful) {
            var remotasBody = remotas.body()
            dao.clear()
            dao.insertAll(remotasBody!!.map { it.toEntity() })
        }else{
            Log.e("ERROR","Busqueda de parcelas fallida")
        }
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
