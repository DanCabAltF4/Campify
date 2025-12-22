package com.example.campify.repository

import com.example.campify.data.remote.ParcelaService

class ParcelaRepository(private val api: ParcelaService) {
    suspend fun listar() = api.getParcelas()
}