package com.example.kotlinapp.data.services

import com.example.kotlinapp.data.LoginRequest
import com.example.kotlinapp.data.LoginResponse
import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.POST

interface AuthService {
    @POST("auth/login")
    suspend fun login(
        @Body request: LoginRequest
    ): Response<LoginResponse>
}