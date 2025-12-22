package com.example.campify.views

import android.widget.Toast
import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.Settings
import androidx.compose.material3.*
import androidx.compose.runtime.Composable
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import com.example.campify.R
import com.example.campify.model.EstadoParcela
import com.example.campify.model.Parcela

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun ListaView(parcelas: List<Parcela>) {
    val context = LocalContext.current

    Scaffold(
        topBar = {
            TopAppBar(
                title = {
                    Row(verticalAlignment = Alignment.CenterVertically) {
                        Image(
                            painter = painterResource(R.drawable.campify_logo),
                            contentDescription = "Logo",
                            modifier = Modifier.size(32.dp)
                        )
                        Spacer(modifier = Modifier.width(8.dp))
                        Text("Campify")
                    }
                },
                actions = {
                    IconButton(onClick = {
                        Toast.makeText(context, "Configuración", Toast.LENGTH_SHORT).show()
                    }) {
                        Icon(
                            imageVector = Icons.Filled.Settings,
                            contentDescription = "Configuración"
                        )
                    }
                },
                colors = TopAppBarDefaults.topAppBarColors(
                    containerColor = Color(0xFFD7EAC1),
                    titleContentColor = Color.Black
                )
            )
        }
    ) { innerPadding ->

        Column(
            modifier = Modifier
                .fillMaxSize()
                .padding(innerPadding)
        ) {

            Row(
                modifier = Modifier
                    .fillMaxWidth()
                    .background(Color(0xFFD7EAC1)),
                horizontalArrangement = Arrangement.SpaceEvenly
            ) {
                Button(
                    onClick = {/* futuro: navegar a Mapa */},
                    colors = ButtonDefaults.buttonColors(containerColor = Color(0xFFD7EAC1))
                ) {
                    Text("Mapa", color = Color.Black)
                }

                Button(
                    onClick = { /* futuro: navegar a ListaView */ },
                    colors = ButtonDefaults.buttonColors(containerColor = Color(0xFFD7EAC1))
                ) {
                    Text("Lista", color = Color.Black)
                }
            }

            Spacer(modifier = Modifier.height(8.dp))

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
    }
}

@Composable
fun ParcelaItem(parcela: Parcela) {
    val color = when (parcela.estado) {
        EstadoParcela.LIBRE -> Color(0xFFB28C5D)       // marrón claro
        EstadoParcela.RESERVADA -> Color(0xFFF0D9A6)  // beige
        EstadoParcela.INTERESADO -> Color(0xFFC5E1A5) // verde claro
        EstadoParcela.BLOQUEADA -> Color(0xFFB0BEC5)  // gris azulado
    }

    Box(
        modifier = Modifier
            .fillMaxWidth()
            .background(color)
            .padding(16.dp)
    ) {
        Text(
            text = "Parcela ${parcela.numero} - ${parcela.estado.name}",
            color = Color.Black,
            fontSize = 16.sp
        )
    }
}
