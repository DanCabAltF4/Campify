package com.example.campify.views

import android.widget.Toast
import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.Refresh
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
import androidx.navigation.NavHostController
import com.example.campify.R
import com.example.campify.data.model.enums.EstadoParcela
import com.example.campify.data.model.Parcela
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import com.example.campify.ui.theme.botonActivo
import com.example.campify.ui.theme.botonInactivo
import com.example.campify.ui.theme.colorBloqueada
import com.example.campify.ui.theme.colorInteresado
import com.example.campify.ui.theme.colorLibre
import com.example.campify.ui.theme.colorReservada
import com.example.campify.ui.theme.fondoPrincipal
import com.example.campify.viewmodels.ApiModel
import kotlin.toString

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun ListaView(navController: NavHostController, api: ApiModel) {
    val context = LocalContext.current
    var searchText by remember { mutableStateOf("") }
    val parcelas by api.parcelas
    api.cargarParcelas()
    // Filtrar parcelas según búsqueda
    val parcelasFiltradas = if (!searchText.isEmpty()) {
        try {
            parcelas.filter {
                it.estado_parcela.name.contains(searchText, ignoreCase = true) ||
                        it.id.toString().contains(searchText)
            }
        } catch (e: NumberFormatException) {
            TODO("Not yet implemented")
        }
    } else{
        parcelas
    }


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
                        api.cargarParcelas()
                    }) {
                        Icon(
                            imageVector = Icons.Filled.Refresh,
                            contentDescription = "Recargar Parcelas"
                        )
                    }
                },
                colors = TopAppBarDefaults.topAppBarColors(
                    containerColor = fondoPrincipal,
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
                    .background(fondoPrincipal),
                horizontalArrangement = Arrangement.SpaceEvenly
            ) {
                Button(
                    onClick = { navController.navigate(NavView.Home.name) },
                    colors = ButtonDefaults.buttonColors(containerColor = botonInactivo)
                ) {
                    Text("Mapa", color = Color.Black)
                }

                Button(
                    onClick = { navController.navigate(NavView.Lista.name) },
                    colors = ButtonDefaults.buttonColors(containerColor = botonActivo)
                ) {
                    Text("Lista", color = Color.Black)
                }
            }

            Spacer(modifier = Modifier.height(8.dp))

            // Campo de búsqueda
            OutlinedTextField(
                value = searchText,
                onValueChange = { searchText = it },
                label = { Text("Buscar parcela (id o estado)") },
                modifier = Modifier
                    .fillMaxWidth()
                    .padding(horizontal = 8.dp)
            )

            Spacer(modifier = Modifier.height(8.dp))

            LazyColumn(
                modifier = Modifier.fillMaxSize(),
                contentPadding = PaddingValues(8.dp),
                verticalArrangement = Arrangement.spacedBy(8.dp)
            ) {
                items(parcelasFiltradas) { parcela ->
                    ParcelaItem(parcela)
                }
            }
        }
    }
}


@Composable
fun ParcelaItem(parcela: Parcela) {
    val color = when (parcela.estado_parcela) {
        EstadoParcela.LIBRE -> colorLibre
        EstadoParcela.RESERVADA -> colorReservada
        EstadoParcela.INTERESADO -> colorInteresado
        EstadoParcela.BLOQUEADA -> colorBloqueada
    }

    Box(
        modifier = Modifier
            .fillMaxWidth()
            .background(color)
            .padding(16.dp)
    ) {
        Text(
            text = "Parcela ${parcela.id} - ${parcela.estado_parcela.name}",
            color = Color.Black,
            fontSize = 16.sp
        )
    }
}
