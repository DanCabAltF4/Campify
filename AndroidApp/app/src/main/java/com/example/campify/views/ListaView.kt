package com.example.campify.views

import androidx.compose.foundation.background
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.PaddingValues
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.unit.dp
import com.campify.views.EstadoParcela
import com.campify.views.Parcela

@Composable
fun ListaView(parcelas: List<Parcela>) {
    LazyColumn(
        modifier = Modifier.fillMaxSize(),
        contentPadding = PaddingValues(8.dp),
        verticalArrangement = Arrangement.spacedBy(8.dp)
    ) {
        items(parcelas) { parcela ->
            ParcelaItem(parcela)
        }
    }
}

@Composable
fun ParcelaItem(parcela: Parcela) {
    val color = when(parcela.estado) {
        EstadoParcela.VACIA -> Color(0xFFB28C5D)
        EstadoParcela.OCUPADA -> Color(0xFFF0D9A6)
        EstadoParcela.INTERESADO -> Color(0xFFC5E1A5)
    }

    Box(
        modifier = Modifier
            .fillMaxWidth()
            .background(color)
            .padding(16.dp)
    ) {
        Text(text = "Parcela ${parcela.numero} - ${parcela.estado.name}", color = Color.Black)
    }
}
