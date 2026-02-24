package com.example.campify.views

import android.content.Context
import android.widget.Toast
import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.rememberScrollState
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.foundation.verticalScroll
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.ArrowBack
import androidx.compose.material.icons.filled.Check
import androidx.compose.material.icons.filled.Close
import androidx.compose.material.icons.filled.DateRange
import androidx.compose.material.icons.filled.Person
import androidx.compose.material.icons.filled.Settings
import androidx.compose.material3.*
import androidx.compose.runtime.Composable
import androidx.compose.runtime.LaunchedEffect
import androidx.compose.runtime.getValue
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
import com.example.campify.data.model.enums.PuestoTrabajo
import com.example.campify.ui.theme.fondoPrincipal
import com.example.campify.viewmodels.ApiModel

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun DetailView(
    navController: NavHostController,
    api: ApiModel,
    id: Int?,
    rolUsuario: String?
) {
    val parcelas by api.parcelas
    LaunchedEffect(Unit) { api.cargarParcelas() }
    val parcela = parcelas.firstOrNull { it.id == id }

    Scaffold(
        topBar = { DetailTopBar(navController) },
        content = { innerPadding ->
            DetailContent(parcela, innerPadding, api, rolUsuario)
        }
    )
}


@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun DetailTopBar(navController: NavHostController) {
    Column {
        TopAppBar(
            title = {
                Column {
                    Row(verticalAlignment = Alignment.CenterVertically) {
                        Image(
                            painter = painterResource(R.drawable.campify_logo),
                            contentDescription = "Logo",
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
                }
            },
            navigationIcon = {
                IconButton(onClick = { navController.popBackStack() }) {
                    Icon(Icons.Filled.ArrowBack, contentDescription = "Volver")
                }
            },
            actions = {
                IconButton(onClick = { /* Aquí acción de configuración */ }) {
                    Icon(Icons.Filled.Settings, contentDescription = "Configuración")
                }
            },
            colors = TopAppBarDefaults.topAppBarColors(
                containerColor = fondoPrincipal,
                titleContentColor = Color.Black
            ),
            modifier = Modifier.height(72.dp)
        )
    }
}
// TopBar title con logo
@Composable
fun DetailContent(
    parcela: Parcela?,
    innerPadding: PaddingValues,
    api: ApiModel,
    rolUsuario: String?
) {
    parcela?.let {
        val scrollState = rememberScrollState()
        Column(
            modifier = Modifier
                .fillMaxSize()
                .verticalScroll(scrollState)
                .padding(innerPadding)
                .padding(16.dp)
        ) {
            ParcelaTitle(it)
            Spacer(Modifier.height(8.dp))
            ParcelaEstadoCard(it)
            Spacer(Modifier.height(16.dp))
            ParcelaCaracteristicas(it)
            Spacer(Modifier.height(16.dp))
            if (rolUsuario != "RECEPCIONISTA") {
                Text("Cambiar Estado", fontWeight = FontWeight.SemiBold, fontSize = 18.sp)
                EstadoParcelaSelector(parcela = it, rolUsuario = rolUsuario) { nuevoEstado ->
                    api.cambiarEstadoParcela(it.id, nuevoEstado)
                }
            }
        }
    } ?: run {
        Box(
            modifier = Modifier.fillMaxSize(),
            contentAlignment = Alignment.Center
        ) {
            Text("Parcela no encontrada", fontSize = 16.sp, color = Color.Gray)
        }
    }
}



@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun EstadoParcelaSelector(
    parcela: Parcela,
    rolUsuario: String?,
    onEstadoChange: (EstadoParcela) -> Unit
) {
    // Filtramos para que RESERVADA no aparezca
    val estados = EstadoParcela.values().filter { estado ->
        when (rolUsuario?.uppercase()) {
            "CAMPO" -> estado != EstadoParcela.MANTENIMIENTO && estado != EstadoParcela.RESERVADA
            else -> estado != EstadoParcela.RESERVADA // opcional, si no quieres RESERVADA para nadie
        }
    }

    Row(
        modifier = Modifier
            .fillMaxWidth()
            .padding(vertical = 8.dp),
        horizontalArrangement = Arrangement.spacedBy(12.dp)
    ) {
        estados.forEach { estado ->
            val (colorChip, icon) = when (estado) {
                EstadoParcela.LIBRE -> Color(0xFF4CAF50) to Icons.Filled.Check
                EstadoParcela.INTERESADO -> Color(0xFF2196F3) to Icons.Filled.Person
                EstadoParcela.MANTENIMIENTO -> Color(0xFFF44336) to Icons.Filled.Close
                else -> Color.Gray to Icons.Filled.Close
            }

            FilterChip(
                selected = parcela.estadoParcela == estado,
                onClick = { onEstadoChange(estado) },
                label = { Text("") },
                leadingIcon = { Icon(icon, contentDescription = estado.name) },
                colors = FilterChipDefaults.filterChipColors(
                    selectedContainerColor = colorChip,
                    selectedLabelColor = Color.White,
                    containerColor = Color(0xFFF0F0F0)
                ),
                shape = RoundedCornerShape(12.dp)
            )
        }
    }
}



// Fila para mostrar booleanos con icono ✔/✖
@Composable
fun BooleanRow(label: String, value: Boolean) {
    Row(
        verticalAlignment = Alignment.CenterVertically
    ) {
        Icon(
            imageVector = if (value) Icons.Filled.Check else Icons.Filled.Close,
            contentDescription = null,
            tint = if (value) Color(0xFF2E7D32) else Color(0xFFC62828)
        )
        Spacer(modifier = Modifier.width(8.dp))
        Text(label)
    }
}

@Composable
fun ParcelaTitle(parcela: Parcela) {
    Text(
        text = "Parcela ${parcela.id}",
        fontSize = 22.sp,
        fontWeight = FontWeight.Bold
    )
}

@Composable
fun ParcelaEstadoCard(parcela: Parcela) {
    Card(
        shape = RoundedCornerShape(12.dp),
        colors = CardDefaults.cardColors(containerColor = Color.White),
        elevation = CardDefaults.cardElevation(4.dp),
        modifier = Modifier.fillMaxWidth()
    ) {
        Row(
            modifier = Modifier.padding(16.dp),
            verticalAlignment = Alignment.CenterVertically
        ) {
            val (colorEstado, iconoEstado) = when (parcela.estadoParcela) {
                EstadoParcela.LIBRE -> Color(0xFF4CAF50) to Icons.Filled.Check
                EstadoParcela.RESERVADA -> Color(0xFFFFC107) to Icons.Filled.DateRange
                EstadoParcela.INTERESADO -> Color(0xFF2196F3) to Icons.Filled.Person
                EstadoParcela.MANTENIMIENTO -> Color(0xFFF44336) to Icons.Filled.Close
                null -> Color(0xFFF44336) to Icons.Filled.Close
            }

            Box(
                modifier = Modifier
                    .size(40.dp)
                    .background(colorEstado, RoundedCornerShape(8.dp)),
                contentAlignment = Alignment.Center
            ) {
                Icon(iconoEstado, contentDescription = null, tint = Color.White)
            }

            Spacer(Modifier.width(12.dp))

            Text(
                text = parcela.estadoParcela!!.name.replaceFirstChar { it.uppercase() },
                fontWeight = FontWeight.Medium,
                fontSize = 16.sp
            )
        }
    }
}

@Composable
fun ParcelaCaracteristicas(parcela: Parcela) {
    Text("Características", fontWeight = FontWeight.SemiBold, fontSize = 18.sp)
    Spacer(Modifier.height(8.dp))

    val booleanos = listOf(
        "Baño cercano" to parcela.cercaBaño,
        "Cerca de la entrada" to parcela.cercaEntrada,
        "Tiene vistas" to parcela.tieneVistas,
        "Zona tranquila" to parcela.zonaTranquila,
        "Zona con sombra" to parcela.zonaSombra
    )

    booleanos.forEach { (label, valor) ->
        BooleanCard(label, valor)
    }
}

@Composable
fun BooleanCard(label: String, valor: Boolean) {
    Card(
        shape = RoundedCornerShape(12.dp),
        colors = CardDefaults.cardColors(containerColor = Color.White),
        elevation = CardDefaults.cardElevation(2.dp),
        modifier = Modifier
            .fillMaxWidth()
            .padding(vertical = 4.dp)
    ) {
        Row(
            modifier = Modifier.padding(12.dp),
            verticalAlignment = Alignment.CenterVertically
        ) {
            Icon(
                imageVector = if (valor) Icons.Filled.Check else Icons.Filled.Close,
                contentDescription = null,
                tint = if (valor) Color(0xFF2E7D32) else Color(0xFFC62828)
            )
            Spacer(Modifier.width(8.dp))
            Text(label, fontSize = 15.sp)
        }
    }
}

