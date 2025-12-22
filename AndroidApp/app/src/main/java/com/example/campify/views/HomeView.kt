package com.campify.views

import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.material3.*
import androidx.compose.runtime.*
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.compose.ui.platform.LocalContext
import android.widget.Toast
import androidx.annotation.DrawableRes
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.Settings
import androidx.compose.ui.layout.ContentScale
import com.example.campify.R
import com.example.campify.model.EstadoParcela
import com.example.campify.model.Parcela
import com.example.campify.views.ListaView


// Datos de ejemplo
val parcelasSample = listOf(
    Parcela("245", EstadoParcela.RESERVADA),
    Parcela("246", EstadoParcela.LIBRE),
    Parcela("247", EstadoParcela.INTERESADO),
    Parcela("248", EstadoParcela.LIBRE),
)

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun HomeViewCampify() {
    val context = LocalContext.current

    Scaffold(
        topBar = {
            TopAppBar(
                title = {
                    Row(verticalAlignment = Alignment.CenterVertically) {
                        Image(
                            painter = painterResource(R.drawable.campify_logo),
                            contentDescription = "Logo Campify",
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
                    onClick = { /* futuro: navegar a Mapa */ },
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

            // Contenido por defecto: mapa
            Box(
                modifier = Modifier
                    .fillMaxSize()
                    .background(Color.LightGray),
                contentAlignment = Alignment.Center
            ) {
                Text("Mapa de parcelas", fontSize = 20.sp, color = Color.DarkGray)
                MapaImagen(mapaResId = R.drawable.mapa)
            }
        }
    }
}

@Composable
fun MapaImagen(
    @DrawableRes mapaResId: Int
) {
    Image(
        painter = painterResource(id = mapaResId),
        contentDescription = "Mapa de la zona",
        modifier = Modifier.fillMaxSize(),
        contentScale = ContentScale.Fit
    )
}