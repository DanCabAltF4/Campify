package com.example.campify.views

import android.content.Context
import android.util.Log
import android.widget.Toast
import androidx.compose.foundation.Image
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.ArrowBack
import androidx.compose.material.icons.filled.ArrowDropDown
import androidx.compose.material.icons.filled.Check
import androidx.compose.material.icons.filled.Close
import androidx.compose.material.icons.filled.DateRange
import androidx.compose.material.icons.filled.Person
import androidx.compose.material.icons.filled.Settings
import androidx.compose.material3.*
import androidx.compose.runtime.Composable
import androidx.compose.runtime.LaunchedEffect
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.text.TextStyle
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.navigation.NavHostController
import androidx.navigation.compose.currentBackStackEntryAsState
import com.example.campify.R
import com.example.campify.data.model.Parcela
import com.example.campify.data.model.enums.EstadoParcela
import com.example.campify.ui.theme.fondoPrincipal
import com.example.campify.viewmodels.ApiModel

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun DetailView(
    navController: NavHostController,
    api: ApiModel,
    id: Int?
) {
    val context = LocalContext.current
    val parcelas by api.parcelas

    // Primera carga al entrar a la pantalla
    LaunchedEffect(Unit) {
        api.cargarParcelas()
    }


    Scaffold(
        topBar = {
            TopAppBar(
                title = { DetailTopBarTitle() },
                navigationIcon = { BackButton(navController) },
                actions = { ConfigButton(context) },
                colors = TopAppBarDefaults.topAppBarColors(
                    containerColor = fondoPrincipal,
                    titleContentColor = Color.Black
                )
            )
        }
    ) { innerPadding ->
        // Se usa let para reevaluar la parcela dinámicamente cada recomposición
        parcelas.firstOrNull { it.id == id }?.let { parcela ->
            ContentDetailView(
                innerPadding = innerPadding,
                parcela = parcela,
                api = api
            )
        }
    }
}

// TopBar title con logo
@Composable
fun DetailTopBarTitle() {
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

// Botón de retroceso
@Composable
fun BackButton(navController: NavHostController) {
    IconButton(onClick = { navController.popBackStack() }) {
        Icon(Icons.Filled.ArrowBack, contentDescription = "Volver")
    }
}

// Botón de configuración
@Composable
fun ConfigButton(context: Context) {
    IconButton(onClick = {
        Toast.makeText(context, "Configuración", Toast.LENGTH_SHORT).show()
    }) {
        Icon(
            imageVector = Icons.Filled.Settings,
            contentDescription = "Configuración"
        )
    }
}

// Contenido del detalle de la parcela
@Composable
fun ContentDetailView(
    innerPadding: PaddingValues,
    parcela: Parcela,
    api: ApiModel
) {
    Column(
        modifier = Modifier
            .padding(innerPadding)
            .padding(16.dp)
            .fillMaxSize()
    ) {
        Text("Parcela: ${parcela.id}", fontWeight = FontWeight.Bold, fontSize = 20.sp)
        Spacer(modifier = Modifier.height(4.dp))
        Text("Estado: ${parcela.estado_parcela.name}", fontWeight = FontWeight.Medium)
        Spacer(modifier = Modifier.height(8.dp))

        // Características booleanas
        BooleanRow("Baño cercano", parcela.cerca_baño)
        BooleanRow("Cerca de la entrada", parcela.cerca_entrada)
        BooleanRow("Tiene vistas", parcela.tiene_vistas)
        BooleanRow("Zona tranquila", parcela.zona_tranquila)
        BooleanRow("Zona con sombra", parcela.zona_sombra)
        Spacer(modifier = Modifier.height(8.dp))

        Text("Estado:", fontWeight = FontWeight.Medium)
        EstadoParcelaSelector(parcela = parcela) { nuevoEstado ->
            api.cambiarEstadoParcela(parcela.id, nuevoEstado)
        }
    }
}


@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun EstadoParcelaSelector(
    parcela: Parcela,
    onEstadoChange: (EstadoParcela) -> Unit
) {
    val estados = EstadoParcela.values()

    Row(
        modifier = Modifier
            .fillMaxWidth()
            .padding(vertical = 8.dp),
        horizontalArrangement = Arrangement.spacedBy(12.dp)
    ) {
        estados.forEach { estado ->
            val icon = when (estado) {
                EstadoParcela.LIBRE -> Icons.Filled.Check
                EstadoParcela.RESERVADA -> Icons.Filled.DateRange
                EstadoParcela.INTERESADO -> Icons.Filled.Person
                EstadoParcela.MANTENIMIENTO -> Icons.Filled.Close
            }

            FilterChip(
                selected = parcela.estado_parcela == estado, // siempre usa el estado actual
                onClick = { onEstadoChange(estado) },
                label = { Text("") },
                leadingIcon = { Icon(icon, contentDescription = estado.name) },
                colors = FilterChipDefaults.filterChipColors(
                    selectedContainerColor = when (estado) {
                        EstadoParcela.LIBRE -> Color(0xFF4CAF50)
                        EstadoParcela.RESERVADA -> Color(0xFFFFC107)
                        EstadoParcela.INTERESADO -> Color(0xFF2196F3)
                        EstadoParcela.MANTENIMIENTO -> Color(0xFFF44336)
                    },
                    selectedLabelColor = Color.White,
                    containerColor = Color.LightGray
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

