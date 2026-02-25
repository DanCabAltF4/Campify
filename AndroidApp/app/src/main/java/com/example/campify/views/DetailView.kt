package com.example.campify.views

import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.rememberScrollState
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.foundation.verticalScroll
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.*
import androidx.compose.material3.*
import androidx.compose.runtime.Composable
import androidx.compose.runtime.LaunchedEffect
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.rememberCoroutineScope
import androidx.compose.runtime.setValue
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
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
import kotlinx.coroutines.launch

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

    val snackbarHostState = remember { SnackbarHostState() } // <-- snackbars

    Scaffold(
        topBar = { DetailTopBar(navController) },
        snackbarHost = { SnackbarHost(hostState = snackbarHostState) }, // <-- host
        content = { innerPadding ->
            DetailContent(parcela, innerPadding, api, rolUsuario, snackbarHostState)
        }
    )
}

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun DetailTopBar(navController: NavHostController) {
    val containerColor = dynamicColor(fondoPrincipalLight, fondoPrincipalDark)
    val textColor = dynamicColor(textoPrincipalLight, textoPrincipalDark)
    Column {
        TopAppBar(
            title = {
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
                        color = textColor
                    )
                }
            },
            navigationIcon = {
                IconButton(onClick = { navController.popBackStack() }) {
                    Icon(Icons.Filled.ArrowBack, contentDescription = "Volver", tint = textColor)
                }
            },
            actions = {
                IconButton(onClick = { /* acción */ }) {
                    Icon(Icons.Filled.Settings, contentDescription = "Configuración", tint = textColor)
                }
            },
            colors = TopAppBarDefaults.topAppBarColors(containerColor = containerColor, titleContentColor = textColor),
            modifier = Modifier.height(72.dp)
        )
    }
}

@Composable
fun DetailContent(
    parcela: Parcela?,
    innerPadding: PaddingValues,
    api: ApiModel,
    rolUsuario: String?,
    snackbarHostState: SnackbarHostState
) {
    parcela?.let {
        val scrollState = rememberScrollState()
        Column(
            modifier = Modifier
                .fillMaxSize()
                .verticalScroll(scrollState)
                .background(dynamicColor(Color(0xFFF3F3F3), Color(0xFF171717)))
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
                Text(
                    "Cambiar Estado",
                    fontWeight = FontWeight.SemiBold,
                    fontSize = 18.sp,
                    color = MaterialTheme.colorScheme.onBackground
                )
                EstadoParcelaSelector(
                    parcela = it,
                    rolUsuario = rolUsuario
                ) { nuevoEstado ->
                    api.cambiarEstadoParcela(it.id, nuevoEstado)
                }
            }
        }
    }?: run {
        Box(
            modifier = Modifier
                .fillMaxSize()
                .background(dynamicColor(fondoPrincipalLight, fondoPrincipalDark)),
            contentAlignment = Alignment.Center
        ) {
            Text("Parcela no encontrada", fontSize = 16.sp, color = dynamicColor(Color.Gray, Color.LightGray))
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
    val estados = EstadoParcela.values().filter { estado ->
        when (rolUsuario?.uppercase()) {
            "CAMPO" -> estado != EstadoParcela.MANTENIMIENTO && estado != EstadoParcela.RESERVADA
            else -> estado != EstadoParcela.RESERVADA
        }
    }

    // Estado para controlar si se muestra el diálogo y qué estado quiere cambiar
    var estadoSeleccionado by remember { mutableStateOf<EstadoParcela?>(null) }
    var mostrarDialogo by remember { mutableStateOf(false) }

    Row(
        modifier = Modifier
            .fillMaxWidth()
            .padding(vertical = 8.dp),
        horizontalArrangement = Arrangement.spacedBy(12.dp)
    ) {
        estados.forEach { estado ->
            val (colorChip, icon) = when (estado) {
                EstadoParcela.LIBRE -> colorLibre to Icons.Filled.Check
                EstadoParcela.INTERESADO -> colorInteresado to Icons.Filled.Person
                EstadoParcela.MANTENIMIENTO -> colorMantenimiento to Icons.Filled.Close
                else -> Color.Gray to Icons.Filled.Close
            }

            FilterChip(
                selected = parcela.estadoParcela == estado,
                onClick = {
                    estadoSeleccionado = estado
                    mostrarDialogo = true // <-- abrir diálogo
                },
                label = { Text("", color = MaterialTheme.colorScheme.onBackground) },
                leadingIcon = { Icon(icon, contentDescription = estado.name, tint = Color.White) },
                colors = FilterChipDefaults.filterChipColors(
                    selectedContainerColor = colorChip,
                    selectedLabelColor = Color.White,
                    containerColor = dynamicColor(Color(0xFFF0F0F0), Color(0xFF2C2C2C))
                ),
                shape = RoundedCornerShape(12.dp)
            )
        }
    }

    // Diálogo de confirmación
    if (mostrarDialogo && estadoSeleccionado != null) {
        ConfirmDialog(
            estado = estadoSeleccionado!!,
            onConfirm = {
                onEstadoChange(it)
                mostrarDialogo = false
            },
            onDismiss = { mostrarDialogo = false }
        )
    }
}


@Composable
fun ConfirmDialog(
    estado: EstadoParcela,
    onConfirm: (EstadoParcela) -> Unit,
    onDismiss: () -> Unit
) {
    AlertDialog(
        onDismissRequest = onDismiss,
        title = {
            Text(
                text = "Confirmación",
                fontWeight = FontWeight.Bold,
                fontSize = 20.sp,
                color = dynamicColor(Color(0xFF000000), Color(0xFFFFFFFF))
            )
        },
        text = {
            Text(
                "¿Estás seguro que quieres cambiar el estado a ${estado.name}?",
                fontSize = 16.sp,
                color = MaterialTheme.colorScheme.onBackground
            )
        },
        confirmButton = {
            TextButton(
                onClick = { onConfirm(estado) },
                colors = ButtonDefaults.textButtonColors(
                    contentColor = Color.White,
                    containerColor = dynamicColor(botonActivoLight, botonActivoDark)
                ),
                shape = RoundedCornerShape(12.dp)
            ) { Text("Sí", fontWeight = FontWeight.Bold) }
        },
        dismissButton = {
            TextButton(
                onClick = onDismiss,
                colors = ButtonDefaults.textButtonColors(
                    contentColor = MaterialTheme.colorScheme.onBackground
                ),
                shape = RoundedCornerShape(12.dp)
            ) { Text("No", fontWeight = FontWeight.Medium) }
        },
        shape = RoundedCornerShape(16.dp),
        containerColor = dynamicColor(Color(0xFFF0F0F0), Color(0xFF2C2C2C))
    )
}

@Composable
fun BooleanRow(label: String, value: Boolean) {
    Row(verticalAlignment = Alignment.CenterVertically) {
        Icon(
            imageVector = if (value) Icons.Filled.Check else Icons.Filled.Close,
            contentDescription = null,
            tint = if (value) Color(0xFF2E7D32) else Color(0xFFC62828)
        )
        Spacer(modifier = Modifier.width(8.dp))
        Text(label, color = dynamicColor(textoPrincipalLight, textoPrincipalDark))
    }
}

@Composable
fun ParcelaTitle(parcela: Parcela) {
    Text(
        text = "Parcela ${parcela.id}",
        fontSize = 22.sp,
        fontWeight = FontWeight.Bold,
        color = dynamicColor(textoPrincipalLight, textoPrincipalDark)
    )
}

@Composable
fun ParcelaEstadoCard(parcela: Parcela) {
    val cardColor = dynamicColor(fondoTarjetaLight, fondoTarjetaDark)
    val textColor = dynamicColor(textoPrincipalLight, textoPrincipalDark)

    Card(
        shape = RoundedCornerShape(12.dp),
        colors = CardDefaults.cardColors(containerColor = cardColor),
        elevation = CardDefaults.cardElevation(4.dp),
        modifier = Modifier.fillMaxWidth()
    ) {
        Row(modifier = Modifier.padding(16.dp), verticalAlignment = Alignment.CenterVertically) {
            val (colorEstado, iconoEstado) = when (parcela.estadoParcela) {
                EstadoParcela.LIBRE -> colorLibre to Icons.Filled.Check
                EstadoParcela.RESERVADA -> colorReservada to Icons.Filled.DateRange
                EstadoParcela.INTERESADO -> colorInteresado to Icons.Filled.Person
                EstadoParcela.MANTENIMIENTO -> colorMantenimiento to Icons.Filled.Close
                null -> Color.Gray to Icons.Filled.Close
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
                fontSize = 16.sp,
                color = textColor
            )
        }
    }
}

@Composable
fun ParcelaCaracteristicas(parcela: Parcela) {
    Text(
        "Características",
        fontWeight = FontWeight.SemiBold,
        fontSize = 18.sp,
        color = dynamicColor(textoPrincipalLight, textoPrincipalDark)
    )
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
        colors = CardDefaults.cardColors(containerColor = dynamicColor(fondoTarjetaLight, fondoTarjetaDark)),
        elevation = CardDefaults.cardElevation(2.dp),
        modifier = Modifier
            .fillMaxWidth()
            .padding(vertical = 4.dp)
    ) {
        Row(modifier = Modifier.padding(12.dp), verticalAlignment = Alignment.CenterVertically) {
            Icon(
                imageVector = if (valor) Icons.Filled.Check else Icons.Filled.Close,
                contentDescription = null,
                tint = if (valor) Color(0xFF2E7D32) else Color(0xFFC62828)
            )
            Spacer(modifier = Modifier.width(8.dp))
            Text(label, fontSize = 15.sp, color = dynamicColor(textoPrincipalLight, textoPrincipalDark))
        }
    }
}