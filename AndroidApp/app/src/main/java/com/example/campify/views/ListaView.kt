package com.example.campify.views

import android.widget.Toast
import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.Refresh
import androidx.compose.material.icons.filled.Settings
import androidx.compose.material3.*
import androidx.compose.runtime.*
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.navigation.NavHostController
import com.example.campify.R
import com.example.campify.data.model.Parcela
import com.example.campify.data.model.enums.EstadoParcela
import com.example.campify.ui.theme.*
import com.example.campify.viewmodels.ApiModel

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun ListaView(navController: NavHostController, api: ApiModel) {
    val context = LocalContext.current
    var searchText by remember { mutableStateOf("") }
    val parcelas by api.parcelas

    // Cargar las parcelas al iniciar la vista
    LaunchedEffect(Unit) { api.cargarParcelas() }

    // Filtrar parcelas según texto de búsqueda
    val parcelasFiltradas = remember(parcelas, searchText) {
        if (searchText.isNotEmpty()) {
            parcelas.filter {
                it.estado_parcela.name.contains(searchText, ignoreCase = true) ||
                        it.id.toString().contains(searchText)
            }
        } else {
            parcelas
        }
    }

    Scaffold(
        topBar = { ListaTopBar(context, api) }
    ) { innerPadding ->
        Column(
            modifier = Modifier
                .fillMaxSize()
                .padding(innerPadding)
        ) {
            NavigationButtons(navController)
            Spacer(modifier = Modifier.height(8.dp))
            SearchBar(searchText) { searchText = it }
            Spacer(modifier = Modifier.height(8.dp))
            ParcelaList(parcelasFiltradas, navController)
        }
    }
}

// TopBar de la lista con logo y botón de recarga
@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun ListaTopBar(context: android.content.Context, api: ApiModel) {
    TopAppBar(
        title = { ListaTopBarTitle() },
        actions = {
            IconButton(onClick = { api.cargarParcelas() }) {
                Icon(Icons.Filled.Refresh, contentDescription = "Recargar Parcelas")
            }
        },
        colors = TopAppBarDefaults.topAppBarColors(
            containerColor = fondoPrincipal,
            titleContentColor = Color.Black
        )
    )
}

// Composable de título del TopBar (logo + texto)
@Composable
fun ListaTopBarTitle() {
    Row(verticalAlignment = Alignment.CenterVertically) {
        Image(
            painter = painterResource(R.drawable.campify_logo),
            contentDescription = "Logo",
            modifier = Modifier.size(32.dp)
        )
        Spacer(modifier = Modifier.width(8.dp))
        Text("Campify")
    }
}

// Botones de navegación Mapa / Lista
@Composable
fun NavigationButtons(navController: NavHostController) {
    Row(
        modifier = Modifier
            .fillMaxWidth()
            .background(fondoPrincipal),
        horizontalArrangement = Arrangement.SpaceEvenly
    ) {
        Button(
            onClick = { navController.navigate("Home") },
            colors = ButtonDefaults.buttonColors(containerColor = botonInactivo)
        ) {
            Text("Mapa", color = Color.Black)
        }

        Button(
            onClick = { navController.navigate("Lista") },
            colors = ButtonDefaults.buttonColors(containerColor = botonActivo)
        ) {
            Text("Lista", color = Color.Black)
        }
    }
}

// Campo de búsqueda de parcelas
@Composable
fun SearchBar(value: String, onValueChange: (String) -> Unit) {
    OutlinedTextField(
        value = value,
        onValueChange = onValueChange,
        label = { Text("Buscar parcela (id o estado)") },
        modifier = Modifier
            .fillMaxWidth()
            .padding(horizontal = 8.dp)
    )
}

// Lista de parcelas en LazyColumn
@Composable
fun ParcelaList(parcelas: List<Parcela>, navController: NavHostController) {
    LazyColumn(
        modifier = Modifier.fillMaxSize(),
        contentPadding = PaddingValues(8.dp),
        verticalArrangement = Arrangement.spacedBy(8.dp)
    ) {
        items(parcelas) { parcela ->
            ParcelaItem(parcela) {
                navController.navigate("detail/${parcela.id}")
            }
        }
    }
}

// Composable individual de cada parcela
@Composable
fun ParcelaItem(parcela: Parcela, onClick: () -> Unit) {
    val color = when (parcela.estado_parcela) {
        EstadoParcela.LIBRE -> colorLibre
        EstadoParcela.RESERVADA -> colorReservada
        EstadoParcela.INTERESADO -> colorInteresado
        EstadoParcela.MANTENIMIENTO -> colorMantenimiento
    }

    Box(
        modifier = Modifier
            .fillMaxWidth()
            .background(color)
            .padding(16.dp)
            .clickable { onClick() }
    ) {
        Text(
            text = "Parcela ${parcela.id} - ${parcela.estado_parcela.name}",
            color = Color.Black,
            fontSize = 16.sp
        )
    }
}
