package com.example.campify.views

import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.Build
import androidx.compose.material.icons.filled.Check
import androidx.compose.material.icons.filled.DateRange
import androidx.compose.material.icons.filled.Person
import androidx.compose.material.icons.filled.Refresh
import androidx.compose.material.icons.filled.Search
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
                it.estadoParcela.name.contains(searchText, ignoreCase = true) ||
                        it.id.toString().contains(searchText)
            }
        } else {
            parcelas
        }
    }

    Scaffold(
        topBar = { ListaTopBar(api) }
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
fun ListaTopBar(api: ApiModel) {

    Column {
        TopAppBar(
            title = {
                Column {
                    Row(verticalAlignment = Alignment.CenterVertically) {

                        Image(
                            painter = painterResource(R.drawable.campify_logo),
                            contentDescription = null,
                            modifier = Modifier.size(28.dp)
                        )

                        Spacer(Modifier.width(8.dp))

                        Text(
                            text = "Campify",
                            fontSize = 20.sp,
                            fontWeight = FontWeight.Bold,
                            color = Color.Black
                        )
                    }

                    Text(
                        text = "Gestión del parque",
                        fontSize = 12.sp,
                        color = Color.DarkGray
                    )
                }
            },
            actions = {
                IconButton(onClick = { api.cargarParcelas() }) {
                    Icon(
                        Icons.Default.Refresh,
                        contentDescription = "Recargar",
                        tint = Color.Black
                    )
                }
            },
            colors = TopAppBarDefaults.topAppBarColors(
                containerColor = fondoPrincipal
            )
        )

        Divider(color = Color(0x22000000), thickness = 1.dp)
    }
}





@Composable
fun SearchBar(value: String, onValueChange: (String) -> Unit) {

    OutlinedTextField(
        value = value,
        onValueChange = onValueChange,
        placeholder = { Text("Buscar por ID o estado") },
        leadingIcon = {
            Icon(
                imageVector = Icons.Default.Search,
                contentDescription = null
            )
        },
        singleLine = true,
        shape = RoundedCornerShape(14.dp),
        modifier = Modifier
            .fillMaxWidth()
            .padding(horizontal = 16.dp),
        colors = OutlinedTextFieldDefaults.colors(
            focusedBorderColor = fondoPrincipal,
            cursorColor = fondoPrincipal
        )
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
            .background(Color(0xFFE5E5E5), RoundedCornerShape(12.dp))
            .padding(4.dp),
        horizontalArrangement = Arrangement.SpaceEvenly
    ) {
        opciones.forEach { opcion ->

            val estaSeleccionada = opcion == seleccionada

            Box(
                modifier = Modifier
                    .weight(1f)
                    .background(
                        color = if (estaSeleccionada) fondoPrincipal2 else Color.Transparent,
                        shape = RoundedCornerShape(10.dp)
                    )
                    .clickable {
                        seleccionada = opcion
                        navController.navigate(
                            if (opcion == "Mapa") "Home" else "Lista"
                        )
                    }
                    .padding(vertical = 10.dp),
                contentAlignment = Alignment.Center
            ) {
                Text(
                    text = opcion,
                    color = if (estaSeleccionada) Color.White else Color.Gray,
                    fontWeight = FontWeight.SemiBold
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

    val (colorEstado, iconoEstado) = when (parcela.estadoParcela) {
        EstadoParcela.LIBRE -> colorLibre to Icons.Default.Check
        EstadoParcela.RESERVADA -> colorReservada to Icons.Default.DateRange
        EstadoParcela.INTERESADO -> colorInteresado to Icons.Default.Person
        EstadoParcela.MANTENIMIENTO -> colorMantenimiento to Icons.Default.Build
    }

    Card(
        modifier = Modifier
            .fillMaxWidth()
            .clickable { onClick() },
        shape = RoundedCornerShape(14.dp),
        elevation = CardDefaults.cardElevation(5.dp),
        colors = CardDefaults.cardColors(containerColor = Color.White)
    ) {
        Row(
            modifier = Modifier
                .fillMaxWidth()
                .padding(18.dp),
            verticalAlignment = Alignment.CenterVertically
        ) {

            // Barra lateral
            Box(
                modifier = Modifier
                    .width(6.dp)
                    .height(50.dp)
                    .background(colorEstado, RoundedCornerShape(4.dp))
            )

            Spacer(Modifier.width(16.dp))

            Column(modifier = Modifier.weight(1f)) {

                Text(
                    text = "Parcela ${parcela.id}",
                    fontSize = 17.sp,
                    fontWeight = FontWeight.Bold,
                    color = Color.Black
                )

                Spacer(Modifier.height(6.dp))

                Row(verticalAlignment = Alignment.CenterVertically) {

                    Icon(
                        imageVector = iconoEstado,
                        contentDescription = null,
                        tint = colorEstado,
                        modifier = Modifier.size(18.dp)
                    )

                    Spacer(Modifier.width(6.dp))

                    Text(
                        text = parcela.estadoParcela.name
                            .lowercase()
                            .replaceFirstChar { it.uppercase() },
                        fontSize = 14.sp,
                        color = colorEstado,
                        fontWeight = FontWeight.Medium
                    )
                }
            }
        }
    }
}


