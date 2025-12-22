package com.example.campify

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.padding
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Modifier
import androidx.compose.ui.tooling.preview.Preview
import com.campify.views.HomeViewCampify
import com.example.campify.model.EstadoParcela
import com.example.campify.model.Parcela
import com.example.campify.ui.theme.CampifyTheme
import com.example.campify.views.ListaView

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContent {
            HomeViewCampify()
            //ListaView(generarParcelas())
        }
    }
}

@Composable
private fun generarParcelas(): List<Parcela> {
    return listOf(
        Parcela("245", EstadoParcela.RESERVADA),
        Parcela("246", EstadoParcela.LIBRE),
        Parcela("247", EstadoParcela.INTERESADO),
        Parcela("248", EstadoParcela.LIBRE),
        Parcela("249", EstadoParcela.BLOQUEADA)
    )
}