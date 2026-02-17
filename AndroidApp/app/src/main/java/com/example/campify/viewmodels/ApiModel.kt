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
import com.example.campify.data.room.AppDatabase
import com.example.campify.data.room.repository.ParcelaRepository
import kotlinx.coroutines.launch

class ApiModel(private val roomDB: AppDatabase) : ViewModel() {

    private val repo = ParcelaRepository(parcela, roomDB.parcelaDao())
    val parcelas = mutableStateOf<List<Parcela>>(emptyList())

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
            if (p.id == id) p.copy(estado_parcela = nuevoEstado) else p
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



}