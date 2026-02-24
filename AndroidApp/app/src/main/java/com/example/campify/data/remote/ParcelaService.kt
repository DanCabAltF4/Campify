package com.example.campify.data.remote

import com.example.campify.data.model.Parcela
import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.GET
import retrofit2.http.PUT
import retrofit2.http.Path

interface ParcelaService {
    @GET("parcelas")
    suspend fun findAll(): Response<List<Parcela>>

    @GET("parcelas/{id}")
    suspend fun findById(
        @Path("id") id: Int
    ): Response<Parcela>

    @PUT("parcelas/{id}")
    suspend fun actualizarParcela(
        @Path("id") id: Int,
        @Body parcela: Parcela
    )


}