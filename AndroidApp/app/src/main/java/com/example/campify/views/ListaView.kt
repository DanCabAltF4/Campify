package com.example.campify.views

import android.graphics.BitmapFactory
import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.*
import androidx.compose.material3.*
import androidx.compose.runtime.*
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.graphics.asImageBitmap
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
import android.util.Base64
import androidx.compose.ui.layout.ContentScale
import kotlin.io.encoding.ExperimentalEncodingApi

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun ListaView(navController: NavHostController, api: ApiModel) {
    val context = LocalContext.current
    var searchText by remember { mutableStateOf("") }
    val parcelas by api.parcelas

    // Estados de los checkboxes para filtros
    var filtroBano by remember { mutableStateOf(false) }
    var filtroEntrada by remember { mutableStateOf(false) }
    var filtroVistas by remember { mutableStateOf(false) }
    var filtroTranquila by remember { mutableStateOf(false) }
    var filtroSombra by remember { mutableStateOf(false) }

    // Estado del desplegable
    var showFiltros by remember { mutableStateOf(false) }

    LaunchedEffect(Unit) { api.cargarParcelas() }

    // Filtrado combinado: búsqueda + checkboxes
    val parcelasFiltradas = remember(parcelas, searchText, filtroBano, filtroEntrada, filtroVistas, filtroTranquila, filtroSombra) {
        parcelas.filter { parcela ->
            val textoOk = searchText.isEmpty() ||
                    (parcela.estadoParcela?.name ?: "").contains(searchText, ignoreCase = true) ||
                    parcela.id.toString().contains(searchText)
            val filtroOk = (!filtroBano || parcela.cercaBaño) &&
                    (!filtroEntrada || parcela.cercaEntrada) &&
                    (!filtroVistas || parcela.tieneVistas) &&
                    (!filtroTranquila || parcela.zonaTranquila) &&
                    (!filtroSombra || parcela.zonaSombra)
            textoOk && filtroOk
        }
    }


    val segmentBackground = dynamicColor(Color(0xFFE5E5E5), Color(0xFF2C2C2C))
    val textPrimary = dynamicColor(textoPrincipalLight, textoPrincipalDark)
    val textSecondary = dynamicColor(textoSecundarioLight, textoSecundarioDark)
    val botonActivoColor = dynamicColor(botonActivoLight, botonActivoDark)

    Scaffold(
        topBar = { ListaTopBar(api) },
    ) { innerPadding ->
        Column(
            modifier = Modifier
                .fillMaxSize()
                .padding(innerPadding)
        ) {
            NavigationSegment(navController, segmentBackground, botonActivoColor, textPrimary, textSecondary)
            Spacer(modifier = Modifier.height(8.dp))
            SearchBar(searchText, textPrimary) { searchText = it }

            Spacer(modifier = Modifier.height(8.dp))

            // Botón para desplegar/ocultar filtros
            Box(
                modifier = Modifier
                    .fillMaxWidth()
                    .padding(horizontal = 16.dp)
                    .background(dynamicColor(Color(0xFFE5E5E5), Color(0xFF2C2C2C)), RoundedCornerShape(12.dp))
                    .clickable { showFiltros = !showFiltros }
                    .padding(vertical = 12.dp),
                contentAlignment = Alignment.Center
            ) {
                Text(
                    text = if (showFiltros) "Ocultar filtros avanzados ▲" else "Mostrar filtros avanzados ▼",
                    fontWeight = FontWeight.Medium,
                    color = textPrimary
                )
            }

            // Filtros desplegables
            if (showFiltros) {
                FiltroCheckboxes(
                    filtroBano, { filtroBano = it },
                    filtroEntrada, { filtroEntrada = it },
                    filtroVistas, { filtroVistas = it },
                    filtroTranquila, { filtroTranquila = it },
                    filtroSombra, { filtroSombra = it },
                    botonActivoColor,
                    textPrimary
                )
                Spacer(modifier = Modifier.height(8.dp))
            }

            ParcelaList(parcelasFiltradas, navController)
        }
    }
}

@Composable
fun FiltroCheckboxes(
    filtroBano: Boolean, onBanoChange: (Boolean) -> Unit,
    filtroEntrada: Boolean, onEntradaChange: (Boolean) -> Unit,
    filtroVistas: Boolean, onVistasChange: (Boolean) -> Unit,
    filtroTranquila: Boolean, onTranquilaChange: (Boolean) -> Unit,
    filtroSombra: Boolean, onSombraChange: (Boolean) -> Unit,
    botonActivoColor: Color,
    textColor: Color
) {
    Column(
        modifier = Modifier
            .padding(horizontal = 16.dp)
            .background(dynamicColor(Color(0xFFF7F7F7), Color(0xFF1C1C1C)), RoundedCornerShape(12.dp))
            .padding(12.dp)
    ) {
        Row(
            modifier = Modifier.fillMaxWidth(),
            horizontalArrangement = Arrangement.SpaceBetween
        ) {
            Column {
                Row(verticalAlignment = Alignment.CenterVertically) {
                    Checkbox(
                        checked = filtroBano,
                        onCheckedChange = onBanoChange,
                        colors = CheckboxDefaults.colors(
                            checkedColor = botonActivoColor,
                            uncheckedColor = dynamicColor(Color.Gray, Color.LightGray),
                            checkmarkColor = dynamicColor(Color.White, Color.Black)
                        )
                    )
                    Text("Baño cercano", color = textColor)
                }
                Row(verticalAlignment = Alignment.CenterVertically) {
                    Checkbox(
                        checked = filtroEntrada,
                        onCheckedChange = onEntradaChange,
                        colors = CheckboxDefaults.colors(
                            checkedColor = botonActivoColor,
                            uncheckedColor = dynamicColor(Color.Gray, Color.LightGray),
                            checkmarkColor = dynamicColor(Color.White, Color.Black)
                        )
                    )
                    Text("Cerca entrada", color = textColor)
                }
                Row(verticalAlignment = Alignment.CenterVertically) {
                    Checkbox(
                        checked = filtroVistas,
                        onCheckedChange = onVistasChange,
                        colors = CheckboxDefaults.colors(
                            checkedColor = botonActivoColor,
                            uncheckedColor = dynamicColor(Color.Gray, Color.LightGray),
                            checkmarkColor = dynamicColor(Color.White, Color.Black)
                        )
                    )
                    Text("Tiene vistas", color = textColor)
                }
            }
            Column {
                Row(verticalAlignment = Alignment.CenterVertically) {
                    Checkbox(
                        checked = filtroTranquila,
                        onCheckedChange = onTranquilaChange,
                        colors = CheckboxDefaults.colors(
                            checkedColor = botonActivoColor,
                            uncheckedColor = dynamicColor(Color.Gray, Color.LightGray),
                            checkmarkColor = dynamicColor(Color.White, Color.Black)
                        )
                    )
                    Text("Zona tranquila", color = textColor)
                }
                Row(verticalAlignment = Alignment.CenterVertically) {
                    Checkbox(
                        checked = filtroSombra,
                        onCheckedChange = onSombraChange,
                        colors = CheckboxDefaults.colors(
                            checkedColor = botonActivoColor,
                            uncheckedColor = dynamicColor(Color.Gray, Color.LightGray),
                            checkmarkColor = dynamicColor(Color.White, Color.Black)
                        )
                    )
                    Text("Zona con sombra", color = textColor)
                }
            }
        }
    }
}

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun ListaTopBar(api: ApiModel) {
    val containerColor = dynamicColor(fondoPrincipalLight, fondoPrincipalDark)
    val textColor = dynamicColor(textoPrincipalLight, textoPrincipalDark)
    val secondaryText = dynamicColor(textoSecundarioLight, textoSecundarioDark)

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
                            color = textColor
                        )
                    }

                    Text(
                        text = "Gestión del parque",
                        fontSize = 12.sp,
                        color = secondaryText
                    )
                }
            },
            actions = {
                IconButton(onClick = { api.cargarParcelas() }) {
                    Icon(
                        Icons.Default.Refresh,
                        contentDescription = "Recargar",
                        tint = textColor
                    )
                }
            },
            colors = TopAppBarDefaults.topAppBarColors(containerColor = containerColor)
        )

        Divider(color = dynamicColor(Color(0x22000000), Color(0x22FFFFFF)), thickness = 1.dp)
    }
}

// SearchBar
@Composable
fun SearchBar(value: String, textColor: Color, onValueChange: (String) -> Unit) {
    OutlinedTextField(
        value = value,
        onValueChange = onValueChange,
        placeholder = { Text("Buscar por ID o estado", color = textColor) },
        leadingIcon = {
            Icon(Icons.Default.Search, contentDescription = null, tint = textColor)
        },
        singleLine = true,
        shape = RoundedCornerShape(14.dp),
        modifier = Modifier
            .fillMaxWidth()
            .padding(horizontal = 16.dp),
        colors = OutlinedTextFieldDefaults.colors(
            focusedBorderColor = dynamicColor(fondoPrincipalLight, fondoPrincipalDark),
            cursorColor = textColor,
            unfocusedBorderColor = dynamicColor(Color.Gray, Color.LightGray)
        )
    )
}

// NavigationSegment
@Composable
fun NavigationSegment(
    navController: NavHostController,
    backgroundColor: Color,
    botonActivoColor: Color,
    textPrimary: Color,
    textSecondary: Color
) {
    val opciones = listOf("Mapa", "Lista")
    var seleccionada by remember { mutableStateOf("Lista") }

    Row(
        modifier = Modifier
            .fillMaxWidth()
            .padding(horizontal = 16.dp)
            .background(backgroundColor, RoundedCornerShape(12.dp))
            .padding(4.dp),
        horizontalArrangement = Arrangement.SpaceEvenly
    ) {
        opciones.forEach { opcion ->

            val estaSeleccionada = opcion == seleccionada

            Box(
                modifier = Modifier
                    .weight(1f)
                    .background(
                        color = if (estaSeleccionada) botonActivoColor else Color.Transparent,
                        shape = RoundedCornerShape(10.dp)
                    )
                    .clickable {
                        seleccionada = opcion
                        navController.navigate(if (opcion == "Mapa") "Home" else "Lista")
                    }
                    .padding(vertical = 10.dp),
                contentAlignment = Alignment.Center
            ) {
                Text(
                    text = opcion,
                    color = if (estaSeleccionada) dynamicColor(Color.White, Color.Black)
                    else textSecondary,
                    fontWeight = FontWeight.SemiBold
                )
            }
        }
    }
}

// ParcelaList
@Composable
fun ParcelaList(parcelas: List<Parcela>, navController: NavHostController) {
    LazyColumn(
        modifier = Modifier
            .fillMaxSize(),
        contentPadding = PaddingValues(horizontal = 16.dp, vertical = 8.dp),
        verticalArrangement = Arrangement.spacedBy(12.dp)
    ) {
        items(parcelas) { parcela ->
            ParcelaItem(parcela) { navController.navigate("detail/${parcela.id}") }
        }
    }
}

// ParcelaItem y ParcelaThumbnail
@OptIn(ExperimentalEncodingApi::class)
fun base64ToBitmap(base64: String): android.graphics.Bitmap? {
    return try {
        val decodedBytes = Base64.decode(base64, Base64.DEFAULT)
        BitmapFactory.decodeByteArray(decodedBytes, 0, decodedBytes.size)
    } catch (e: Exception) {
        e.printStackTrace()
        null
    }
}

@Composable
fun ParcelaThumbnail(base64: String?) {
    val bitmap = remember(base64) {
        base64?.substringAfter("base64,", base64)?.let { base64ToBitmap(it) }
    }

    Card(
        shape = RoundedCornerShape(12.dp),
        modifier = Modifier.size(80.dp),
        colors = CardDefaults.cardColors(containerColor = dynamicColor(fondoTarjetaLight, fondoTarjetaDark))
    ) {
        if (bitmap != null) {
            Image(
                bitmap = bitmap.asImageBitmap(),
                contentDescription = null,
                contentScale = ContentScale.Crop,
                modifier = Modifier.fillMaxSize()
            )
        } else {
            Image(
                painter = painterResource(R.drawable.campify_logo),
                contentDescription = null,
                contentScale = ContentScale.Crop,
                modifier = Modifier.fillMaxSize()
            )
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
        null -> Color.Gray to Icons.Default.Clear
    }

    Card(
        modifier = Modifier
            .fillMaxWidth()
            .clickable { onClick() },
        shape = RoundedCornerShape(14.dp),
        elevation = CardDefaults.cardElevation(5.dp),
        colors = CardDefaults.cardColors(containerColor = dynamicColor(fondoTarjetaLight, fondoTarjetaDark))
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
                    .height(70.dp)
                    .background(colorEstado, RoundedCornerShape(4.dp))
            )

            Spacer(Modifier.width(12.dp))

            Column(modifier = Modifier.weight(1f)) {
                Text(
                    text = "Parcela ${parcela.id}",
                    fontSize = 17.sp,
                    fontWeight = FontWeight.Bold,
                    color = dynamicColor(textoPrincipalLight, textoPrincipalDark)
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
                        text = parcela.estadoParcela?.name
                            ?.lowercase()
                            ?.replaceFirstChar { it.uppercase() }
                            ?: "Desconocido",
                        fontSize = 14.sp,
                        color = colorEstado
                    )
                }

                Spacer(Modifier.height(4.dp))

                Text(
                    text = "Tipo: ${parcela.tipoParcela?.name ?: "Desconocido"}",
                    fontSize = 14.sp,
                    color = dynamicColor(textoSecundarioLight, textoSecundarioDark)
                )
            }

            Spacer(Modifier.width(12.dp))

            ParcelaThumbnail(parcela.imagenParcela)
        }
    }
}
