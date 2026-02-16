package com.example.campify.viewmodels

import android.util.Log
import androidx.compose.runtime.mutableStateOf
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.campify.data.model.Parcela
import com.example.campify.data.model.enums.EstadoParcela
import com.example.campify.data.remote.RetrofitClient
import com.example.campify.data.remote.RetrofitClient.parcela
import com.example.campify.repository.ParcelaRepository
import kotlinx.coroutines.launch

class ApiModel : ViewModel() {

    private val repo = ParcelaRepository(RetrofitClient.parcela)
    val parcelas = mutableStateOf<List<Parcela>>(emptyList())

    fun cargarParcelas() {
        viewModelScope.launch {
            try {
                parcelas.value = repo.listar()
            } catch (e: Exception) {
                // Manejo de error simple
                Log.e("API", "Error cargando parcelas", e)
            }
        }
    }

    fun cambiarEstadoParcela(id: Int, nuevoEstado: EstadoParcela) {
        // Actualizamos localmente
        val parcelaActualizada = parcelas.value.map { p ->
            if (p.id == id) p.copy(estado_parcela = nuevoEstado) else p
        }
        parcelas.value = parcelaActualizada

        // Preparamos el objeto completo para enviar
        val parcelaParaEnviar = parcelaActualizada.first { it.id == id }

        viewModelScope.launch {
            try {
                repo.actualizarParcela(parcelaParaEnviar)
            } catch (e: Exception) {
                Log.e("API", "Error actualizando parcela", e)
            }
        }
    }


}