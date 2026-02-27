package com.example.campify.data.remote

import okhttp3.OkHttpClient
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

object RetrofitClient {

    //private const val URL = "http://10.0.2.2:8080/api/"
    private const val URL = "https://api.raspiremote.org/api/"
    private fun createLoginRetrofit(): Retrofit {
        return Retrofit.Builder().baseUrl(URL)
            .addConverterFactory(GsonConverterFactory.create())
            .build()
    }

    private fun createAuthenticatedRetrofit(tokenProvider: () -> String?): Retrofit {
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
        return createLoginRetrofit().create(AuthService::class.java)
    }
    fun parcelas(tokenProvider: () -> String?): ParcelaService =
        createAuthenticatedRetrofit(tokenProvider).create(ParcelaService::class.java)
}