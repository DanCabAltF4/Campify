package com.example.campify.data.remote

import com.example.campify.data.model.Parcela
import retrofit2.http.GET

interface ParcelaService {
    @GET("parcelas")
    suspend fun getParcelas(): List<Parcela>
}