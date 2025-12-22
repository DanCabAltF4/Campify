package com.example.campify

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.activity.viewModels
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.material3.Text
import androidx.compose.runtime.LaunchedEffect
import androidx.compose.runtime.getValue
import androidx.compose.runtime.livedata.observeAsState
import com.example.campify.ui.theme.CampifyTheme
import com.example.campify.views.pruebaApi

class MainActivity : ComponentActivity() {

    private val viewModel: pruebaApi by viewModels()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        setContent {
            val parcelas by viewModel.parcelas

            // Llamada a la API una sola vez
            LaunchedEffect(Unit) {
                viewModel.cargarParcelas()
            }

            LazyColumn {
                items(parcelas) { parcela ->
                    Text("ID: ${parcela.id}")
                }
            }
        }
    }
}