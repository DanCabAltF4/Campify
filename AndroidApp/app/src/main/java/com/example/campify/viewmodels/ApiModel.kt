package com.example.campify.viewmodels

import android.util.Log
import androidx.compose.runtime.State
import androidx.compose.runtime.mutableStateOf
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.campify.data.model.Parcela
import com.example.campify.data.model.enums.EstadoParcela
import com.example.campify.data.remote.RetrofitClient
import com.example.campify.data.room.AppDatabase
import com.example.campify.data.room.repository.ParcelaRepository
import com.example.kotlinapp.data.AuthRepository
import kotlinx.coroutines.flow.MutableStateFlow
import kotlinx.coroutines.flow.asStateFlow
import kotlinx.coroutines.flow.first
import kotlinx.coroutines.launch
import kotlinx.coroutines.runBlocking


class ApiModel(private val authRepository: AuthRepository, private val roomDB: AppDatabase) : ViewModel() {

    val token = authRepository.token
    val rol = authRepository.rol
    private val parcelasService = RetrofitClient.parcelas(tokenProvider())
    private val repo = ParcelaRepository(parcelasService, roomDB.parcelaDao())
    val parcelas = mutableStateOf<List<Parcela>>(emptyList())


    fun tokenProvider(): ()-> String? = {
        runBlocking { token.first()}
    }
    fun inicializarParcelas() {
        viewModelScope.launch {
            try {
                // Trae datos del API y los mete en Room
                repo.syncParcelas()

                // Lee los datos ya guardados en Room y actualiza el estado
                parcelas.value = repo.getParcelas()
            } catch (e: Exception) {
                Log.e("API", "Error inicializando parcelas", e)
            }
        }
    }


    fun cargarParcelas() {
        viewModelScope.launch {
            try {
                // Primero sincroniza Room con los datos del API
                repo.syncParcelas()

                // Luego lee los datos ya guardados en Room y actualiza la UI
                parcelas.value = repo.getParcelas()
            } catch (e: Exception) {
                Log.e("API", "Error cargando parcelas", e)
            }
        }
    }


    fun cambiarEstadoParcela(id: Int, nuevoEstado: EstadoParcela) {
        // Actualizamos localmente la lista para la UI
        val parcelaActualizada = parcelas.value.map { p ->
            if (p.id == id) p.copy(estadoParcela = nuevoEstado) else p
        }
        parcelas.value = parcelaActualizada

        // Preparamos el objeto completo
        val parcelaParaEnviar = parcelaActualizada.first { it.id == id }

        viewModelScope.launch {
            try {
                // Actualizar primero Room
                repo.updateLocal(parcelaParaEnviar)

                // Luego enviar al API
                repo.actualizarParcela(parcelaParaEnviar)
            } catch (e: Exception) {
                Log.e("API", "Error actualizando parcela", e)
            }
        }
    }


    //Login Stuff
    private val _loginState = MutableStateFlow<LoginState>(LoginState.Waiting)

    fun login(email: String, password: String) {
        viewModelScope.launch {
            val result = authRepository.login(email, password)
            _loginState.value = if (result) LoginState.Valid else LoginState.Invalid
            if (result) {
                onLoginSuccess() // sincroniza rutas después de login
            }
        }
    }

    fun onLoginSuccess() {
        viewModelScope.launch {
        }
    }

    fun logout() {
        viewModelScope.launch {
            authRepository.logout()
            _loginState.value = LoginState.Expired
        }
    }

    fun resetLoginState() {
        _loginState.value = LoginState.Waiting
    }

    sealed class LoginState() {
        object Valid : LoginState()
        object Invalid : LoginState()
        object Waiting : LoginState()
        object Expired : LoginState()
    }

    val loginState = _loginState.asStateFlow()

    fun checkAuth() {
        viewModelScope.launch {
            val response = parcelasService.findAll()
            _loginState.value = when (response.code()) {
                200 -> LoginState.Valid
                401 -> LoginState.Expired //Buscamos este codigo, ver si ha caducado el token
                else -> LoginState.Invalid
            }
        }
    }
}