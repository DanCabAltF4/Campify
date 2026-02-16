package com.example.campify.repository

import com.example.campify.data.model.Parcela
import com.example.campify.data.model.enums.EstadoParcela
import com.example.campify.data.remote.ParcelaService
import com.example.campify.data.remote.dto.EstadoParcelaRequest

class ParcelaRepository(private val api: ParcelaService) {
    suspend fun listar() = api.getParcelas()

    suspend fun actualizarParcela(parcela: Parcela) =
        api.actualizarParcela(parcela.id, parcela)

}