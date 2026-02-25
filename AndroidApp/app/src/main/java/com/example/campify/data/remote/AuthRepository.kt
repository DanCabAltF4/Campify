package com.example.kotlinapp.data

import com.example.kotlinapp.data.services.AuthService

import kotlinx.coroutines.flow.first
import kotlinx.coroutines.runBlocking

class AuthRepository(
    private val api: AuthService,
    private val session: SessionDataStore
) {
    val token = session.tokenFlow
    val rol = session.roleFlow

    suspend fun login(email: String, password: String): Boolean {
        val response = api.login(LoginRequest(email, password))
        response.code()
        return if (response.isSuccessful && response.body() != null) {
            val loginResponse = response.body()!!
            session.saveSession(loginResponse.token, loginResponse.rol)
            true
        } else {
            false
        }
    }
    suspend fun logout(){
        session.clearSession()
    }
}