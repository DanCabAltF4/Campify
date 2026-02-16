package com.example.campify.data.remote

import com.example.campify.data.model.Parcela
import com.example.campify.data.remote.dto.EstadoParcelaRequest
import retrofit2.http.Body
import retrofit2.http.GET
import retrofit2.http.PUT
import retrofit2.http.Path
import retrofit2.http.Query

interface ParcelaService {
    @GET("parcelas")
    suspend fun getParcelas(): List<Parcela>

    @PUT("parcelas/{id}")
    suspend fun actualizarParcela(
        @Path("id") id: Int,
        @Body parcela: Parcela
    )



}