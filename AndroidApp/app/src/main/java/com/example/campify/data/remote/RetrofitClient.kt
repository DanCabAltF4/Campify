package com.example.campify.data.remote

import com.example.campify.data.model.enums.EstadoParcela
import com.example.kotlinapp.data.AuthInterceptor
import com.example.kotlinapp.data.services.AuthService
import okhttp3.OkHttpClient
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

object RetrofitClient {

    //private const val URL = "http://10.0.2.2:8080/api/"
    private const val URL = "https://api.raspiremote.org/api/"
    fun createLoginRetrofit(): Retrofit {
        return Retrofit.Builder().baseUrl(URL)
            .addConverterFactory(GsonConverterFactory.create())
            .build()
    }

    fun createAuthenticatedRetrofit(tokenProvider: () -> String?): Retrofit {
        val client = OkHttpClient.Builder()
            .addInterceptor(AuthInterceptor(tokenProvider))
            .build()
        return Retrofit.Builder()
            .baseUrl(URL)
            .client(client)
            .addConverterFactory(GsonConverterFactory.create())
            .build()
    }

    fun auth(): AuthService {
        return RetrofitClient.createLoginRetrofit().create(AuthService::class.java)
    }
    fun parcelas(tokenProvider: () -> String?) =
        createAuthenticatedRetrofit(tokenProvider).create(ParcelaService::class.java)
}