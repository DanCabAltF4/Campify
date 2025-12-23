package com.example.campify.viewmodels

import android.util.Log
import androidx.compose.runtime.mutableStateOf
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.campify.data.model.Parcela
import com.example.campify.data.remote.RetrofitClient
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
}