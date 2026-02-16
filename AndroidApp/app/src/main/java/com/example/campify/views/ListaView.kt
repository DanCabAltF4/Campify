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
import androidx.compose.ui.text.font.FontWeight
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

    LaunchedEffect(Unit) { api.cargarParcelas() }

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
            NavigationSegment(navController)
            Spacer(modifier = Modifier.height(8.dp))
            SearchBar(searchText) { searchText = it }
            Spacer(modifier = Modifier.height(8.dp))
            ParcelaList(parcelasFiltradas, navController)
        }
    }
}

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
        colors = TopAppBarDefaults.mediumTopAppBarColors(
            containerColor = fondoPrincipal,
            titleContentColor = Color.Black
        ),
        modifier = Modifier
            .fillMaxWidth()
            .height(64.dp)
    )
}

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

@Composable
fun ListaTopBarTitle() {
    Row(verticalAlignment = Alignment.CenterVertically) {
        Image(
            painter = painterResource(R.drawable.campify_logo),
            contentDescription = "Logo",
            modifier = Modifier.size(36.dp)
        )
        Spacer(modifier = Modifier.width(12.dp))
        Text(
            "Campify",
            fontSize = 22.sp,
            color = Color.Black,
            fontWeight = FontWeight.Bold
        )
    }
}

// Reemplazo de botones por SegmentedButton-like
@Composable
fun NavigationSegment(navController: NavHostController) {
    val opciones = listOf("Mapa", "Lista")
    var seleccionada by remember { mutableStateOf("Lista") }

    Row(
        modifier = Modifier
            .fillMaxWidth()
            .padding(horizontal = 16.dp)
            .background(Color(0xFFE0E0E0), shape = MaterialTheme.shapes.small),
        horizontalArrangement = Arrangement.SpaceEvenly
    ) {
        opciones.forEach { opcion ->
            // Cada "botón" ahora es un Box que ocupa más área
            Box(
                modifier = Modifier
                    .weight(1f) // ocupa el mismo espacio horizontal
                    .padding(4.dp) // espacio interno entre botones
                    .background(
                        color = if (opcion == seleccionada) Color(0xFF90CAF9) else Color.Transparent,
                        shape = MaterialTheme.shapes.small
                    )
                    .clickable {
                        seleccionada = opcion
                        navController.navigate(if (opcion == "Mapa") "Home" else "Lista")
                    }
                    .padding(vertical = 12.dp), // padding interno para clic más cómodo
                contentAlignment = Alignment.Center
            ) {
                Text(
                    text = opcion,
                    color = if (opcion == seleccionada) Color.Black else Color.Gray,
                    fontWeight = FontWeight.Medium
                )
            }
        }
    }
}


@Composable
fun ParcelaList(parcelas: List<Parcela>, navController: NavHostController) {
    LazyColumn(
        modifier = Modifier.fillMaxSize(),
        contentPadding = PaddingValues(horizontal = 16.dp, vertical = 8.dp),
        verticalArrangement = Arrangement.spacedBy(12.dp)
    ) {
        items(parcelas) { parcela ->
            ParcelaItem(parcela) { navController.navigate("detail/${parcela.id}") }
        }
    }
}

@Composable
fun ParcelaItem(parcela: Parcela, onClick: () -> Unit) {
    val colorFondo = when (parcela.estado_parcela) {
        EstadoParcela.LIBRE -> colorLibre
        EstadoParcela.RESERVADA -> colorReservada
        EstadoParcela.INTERESADO -> colorInteresado
        EstadoParcela.MANTENIMIENTO -> colorMantenimiento
    }

    Card(
        modifier = Modifier
            .fillMaxWidth()
            .clickable { onClick() },
        colors = CardDefaults.cardColors(containerColor = colorFondo),
        shape = MaterialTheme.shapes.medium,
        elevation = CardDefaults.cardElevation(4.dp)
    ) {
        Row(
            modifier = Modifier
                .fillMaxWidth()
                .padding(16.dp),
            verticalAlignment = Alignment.CenterVertically
        ) {
            Text(
                text = "Parcela ${parcela.id}",
                fontWeight = FontWeight.Bold,
                fontSize = 16.sp,
                color = Color.Black
            )
            Spacer(modifier = Modifier.weight(1f))
            Text(
                text = parcela.estado_parcela.name.lowercase()
                    .replaceFirstChar { it.uppercase() },
                color = Color.Black
            )
        }
    }
}
