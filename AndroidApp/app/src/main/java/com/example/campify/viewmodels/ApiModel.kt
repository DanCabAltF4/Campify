package com.example.campify.viewmodels

import android.util.Log
import androidx.compose.runtime.mutableStateOf
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.campify.data.model.Parcela
import com.example.campify.data.remote.RetrofitClient
import com.example.campify.repository.ParcelaRepository
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import kotlinx.coroutines.withContext

class ApiModel : ViewModel() {

    private val repo = ParcelaRepository(RetrofitClient.parcela)
    val parcelas = mutableStateOf<List<Parcela>>(emptyList())

    fun cargarParcelas() {
        viewModelScope.launch(Dispatchers.IO) { // Ejecuta en hilo de IO
            try {
                val lista = repo.listar()
                // Para actualizar la UI, cambiamos al hilo principal
                withContext(Dispatchers.Main) {
                    parcelas.value = lista
                }
            } catch (e: Exception) {
                Log.e("API", "Error cargando parcelas", e)
            }
        }
    }
}