package com.example.campify.views

import android.graphics.BitmapFactory
import android.util.Base64
import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.combinedClickable
import androidx.compose.foundation.gestures.detectTransformGestures
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.PaddingValues
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.size
import androidx.compose.foundation.layout.width
import androidx.compose.foundation.layout.wrapContentHeight
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
import androidx.compose.material3.Card
import androidx.compose.material3.CardDefaults
import androidx.compose.material3.Checkbox
import androidx.compose.material3.CheckboxDefaults
import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.material3.HorizontalDivider
import androidx.compose.material3.Icon
import androidx.compose.material3.IconButton
import androidx.compose.material3.OutlinedTextField
import androidx.compose.material3.OutlinedTextFieldDefaults
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Text
import androidx.compose.material3.TopAppBar
import androidx.compose.material3.TopAppBarDefaults
import androidx.compose.runtime.Composable
import androidx.compose.runtime.LaunchedEffect
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableFloatStateOf
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.geometry.Offset
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.graphics.asImageBitmap
import androidx.compose.ui.graphics.graphicsLayer
import androidx.compose.ui.input.pointer.pointerInput
import androidx.compose.ui.layout.ContentScale
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.compose.ui.window.Dialog
import androidx.navigation.NavHostController
import com.example.campify.R
import com.example.campify.data.model.Parcela
import com.example.campify.data.model.enums.EstadoParcela
import com.example.campify.ui.theme.botonActivoDark
import com.example.campify.ui.theme.botonActivoLight
import com.example.campify.ui.theme.colorInteresado
import com.example.campify.ui.theme.colorLibre
import com.example.campify.ui.theme.colorMantenimiento
import com.example.campify.ui.theme.colorReservada
import com.example.campify.ui.theme.dynamicColor
import com.example.campify.ui.theme.fondoPrincipalDark
import com.example.campify.ui.theme.fondoPrincipalLight
import com.example.campify.ui.theme.fondoTarjetaDark
import com.example.campify.ui.theme.fondoTarjetaLight
import com.example.campify.ui.theme.textoPrincipalDark
import com.example.campify.ui.theme.textoPrincipalLight
import com.example.campify.ui.theme.textoSecundarioDark
import com.example.campify.ui.theme.textoSecundarioLight
import com.example.campify.viewmodels.ApiModel
import androidx.compose.foundation.combinedClickable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.setValue
import androidx.compose.ui.res.stringResource
import androidx.compose.ui.window.Dialog
import com.example.campify.data.model.enums.TipoParcela
import kotlin.io.encoding.ExperimentalEncodingApi

@Composable
fun ListaView(navController: NavHostController, api: ApiModel) {
    LocalContext.current
    var searchText by remember { mutableStateOf("") }
    val parcelas by api.parcelas

    //Estados para mostrar popUp de la imagen
    var selectedParcelaForPopup by remember { mutableStateOf<Parcela?>(null) }
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
    val parcelasFiltradas = remember(
        parcelas,
        searchText,
        filtroBano,
        filtroEntrada,
        filtroVistas,
        filtroTranquila,
        filtroSombra
    ) {
        parcelas.filter { parcela ->

            val estadoEnum = parcela.estadoParcela

            val estadoEs = when (estadoEnum) {
                EstadoParcela.LIBRE -> "Libre"
                EstadoParcela.RESERVADA -> "Reservada"
                EstadoParcela.INTERESADO -> "Interesado"
                EstadoParcela.MANTENIMIENTO -> "Mantenimiento"
                null -> ""
            }

            val estadoEn = when (estadoEnum) {
                EstadoParcela.LIBRE -> "Available"
                EstadoParcela.RESERVADA -> "Reserved"
                EstadoParcela.INTERESADO -> "Interested"
                EstadoParcela.MANTENIMIENTO -> "Maintenance"
                null -> ""
            }

            val textoOk = searchText.isEmpty() ||
                    estadoEs.contains(searchText, true) ||
                    estadoEn.contains(searchText, true) ||
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
                .background(dynamicColor(Color(0xFFF3F3F3), Color(0xFF171717)))
        ) {

            NavigationSegment(
                navController,
                segmentBackground,
                botonActivoColor,
                textSecondary
            )
            Spacer(modifier = Modifier.height(8.dp))
            SearchBar(searchText, textPrimary) { searchText = it }

            Spacer(modifier = Modifier.height(8.dp))

            // Botón para desplegar/ocultar filtros
            Box(
                modifier = Modifier
                    .fillMaxWidth()
                    .padding(horizontal = 16.dp)
                    .background(
                        dynamicColor(Color(0xFFE5E5E5), Color(0xFF2C2C2C)),
                        RoundedCornerShape(12.dp)
                    )
                    .clickable { showFiltros = !showFiltros }
                    .padding(vertical = 12.dp),
                contentAlignment = Alignment.Center
            ) {
                Text(
                    text = if (showFiltros) stringResource(R.string.filter_hide) else stringResource(R.string.filter_show),
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
            ParcelaList(parcelasFiltradas, navController) { parcela ->
                selectedParcelaForPopup = parcela
            }
        }
    }
    selectedParcelaForPopup?.let { parcela ->
        ImagenPopUp(parcela = parcela, onDismiss = { selectedParcelaForPopup = null })
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
            .background(
                dynamicColor(Color(0xFFF7F7F7), Color(0xFF1C1C1C)),
                RoundedCornerShape(12.dp)
            )
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
                    Text(stringResource(R.string.filter_bathroom), color = textColor)
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
                    Text(stringResource(R.string.filter_entrance), color = textColor)
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
                    Text(stringResource(R.string.filter_views), color = textColor)
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
                    Text(stringResource(R.string.filter_quiet), color = textColor)
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
                    Text(stringResource(R.string.filter_shade), color = textColor)
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
                        text = stringResource(R.string.list_subtitle),
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

        HorizontalDivider(color = dynamicColor(Color(0x22000000), Color(0x22FFFFFF)), thickness = 1.dp)
    }
}

// SearchBar
@Composable
fun SearchBar(value: String, textColor: Color, onValueChange: (String) -> Unit) {
    OutlinedTextField(
        value = value,
        onValueChange = onValueChange,
        placeholder = { Text(stringResource(R.string.search_placeholder), color = textColor) },
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
    textSecondary: Color
) {
    val mapa = stringResource(R.string.nav_map)
    val lista = stringResource(R.string.nav_list)
    val opciones = listOf(mapa, lista)
    var seleccionada by remember { mutableStateOf(lista) }

    Row(
        modifier = Modifier
            .fillMaxWidth()
            .padding(horizontal = 16.dp)
            .background(backgroundColor, RoundedCornerShape(12.dp))
            .padding(4.dp),
        horizontalArrangement = Arrangement.SpaceEvenly
    ) {
        opciones.forEach { opcion ->

            val seleccionadaActual = opcion == seleccionada

            Box(
                modifier = Modifier
                    .weight(1f)
                    .background(
                        color = if (seleccionadaActual) botonActivoColor else Color.Transparent,
                        shape = RoundedCornerShape(10.dp)
                    )
                    .clickable {
                        seleccionada = opcion
                        navController.navigate(if (opcion == mapa) "Home" else "Lista")
                    }
                    .padding(vertical = 10.dp),
                contentAlignment = Alignment.Center
            ) {
                Text(
                    text = opcion,
                    color = if (seleccionadaActual) Color.White else textSecondary,
                    fontWeight = FontWeight.SemiBold
                )
            }
        }
    }
}

// ParcelaList
@Composable
fun ParcelaList(
    parcelas: List<Parcela>,
    navController: NavHostController,
    onDoubleClick: (Parcela) -> Unit // New parameter
) {
    LazyColumn(
        modifier = Modifier
            .fillMaxSize(),
        contentPadding = PaddingValues(horizontal = 16.dp, vertical = 8.dp),
        verticalArrangement = Arrangement.spacedBy(12.dp)
    ) {
        items(parcelas) { parcela ->
            ParcelaItem(
                parcela = parcela,
                onClick = { navController.navigate("detail/${parcela.id}") },
                onDoubleClick = { onDoubleClick(parcela) }
            )
        }
    }
}

// ParcelaItem y ParcelaThumbnail
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
        colors = CardDefaults.cardColors(
            containerColor = dynamicColor(
                fondoTarjetaLight,
                fondoTarjetaDark
            )
        )
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
fun ParcelaItem(parcela: Parcela, onClick: () -> Unit, onDoubleClick: () -> Unit) {
    val (colorEstado, iconoEstado) = when (parcela.estadoParcela) {
        EstadoParcela.LIBRE -> colorLibre to Icons.Default.Check
        EstadoParcela.RESERVADA -> colorReservada to Icons.Default.DateRange
        EstadoParcela.INTERESADO -> colorInteresado to Icons.Default.Person
        EstadoParcela.MANTENIMIENTO -> colorMantenimiento to Icons.Default.Build
    }
    remember(parcela.imagenParcela) {
        parcela.imagenParcela?.substringAfter("base64,", parcela.imagenParcela)
            ?.let { base64ToBitmap(it) }
    }
    Card(
        modifier = Modifier
            .combinedClickable(
                onClick = onClick,
                onDoubleClick = onDoubleClick
            ),
        shape = RoundedCornerShape(14.dp),
        elevation = CardDefaults.cardElevation(5.dp),
        colors = CardDefaults.cardColors(
            containerColor = dynamicColor(
                fondoTarjetaLight,
                fondoTarjetaDark
            )
        )
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
                    text = "${stringResource(R.string.parcel_name)} ${parcela.id}",
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
                    val estadoTraducido = when (parcela.estadoParcela?.name) {
                        "LIBRE" -> stringResource(R.string.parcel_status_free)
                        "RESERVADA" -> stringResource(R.string.parcel_status_reserved)
                        "INTERESADO" -> stringResource(R.string.parcel_status_interested)
                        "MANTENIMIENTO" -> stringResource(R.string.parcel_status_maintenance)
                        else -> "Desconocido"
                    }

                    Text(
                        text = estadoTraducido,
                        fontSize = 14.sp,
                        color = colorEstado
                    )
                }

                Spacer(Modifier.height(4.dp))

                val tipoTraducido = when (parcela.tipoParcela) {
                    TipoParcela.NORMAL -> stringResource(R.string.parcel_type_normal)
                    TipoParcela.SEMIPARCELA -> stringResource(R.string.parcel_type_semi)
                    else -> "Desconocido"
                }

                Text(
                    text = "${stringResource(R.string.parcel_type_label)}: $tipoTraducido",
                    fontSize = 14.sp,
                    color = dynamicColor(textoSecundarioLight, textoSecundarioDark)
                )
            }

            Spacer(Modifier.width(12.dp))

            ParcelaThumbnail(parcela.imagenParcela)
        }
    }
}

@Composable
fun ImagenPopUp(parcela: Parcela, onDismiss: () -> Unit) {
    Dialog(onDismissRequest = onDismiss) {
        val bitmap = remember(parcela.imagenParcela) {
            parcela.imagenParcela
                ?.let { raw ->
                    val base64Data = raw.substringAfter("base64,", raw)
                    base64ToBitmap(base64Data)
                }
        }
        var scale by remember { mutableFloatStateOf(1f) }
        var offset by remember { mutableStateOf(Offset.Zero) }

        Box(
            modifier = Modifier
                .fillMaxWidth()
                .wrapContentHeight()
                .pointerInput(Unit) {
                    detectTransformGestures { _, pan, zoom, _ ->
                        scale = (scale * zoom).coerceIn(1f, 5f) // límite de zoom 1x a 5x
                        offset = Offset(
                            x = (offset.x + pan.x).coerceIn(-1000f, 1000f),
                            y = (offset.y + pan.y).coerceIn(-1000f, 1000f)
                        )
                    }
                },
            contentAlignment = Alignment.Center
        ) {
            if (bitmap != null) {
                Image(
                    bitmap = bitmap.asImageBitmap(),
                    contentDescription = null,
                    modifier = Modifier
                        .fillMaxSize()
                        .graphicsLayer(
                            scaleX = scale,
                            scaleY = scale,
                            translationX = offset.x,
                            translationY = offset.y
                        ),
                    contentScale = ContentScale.Fit
                )
            } else {
                LaunchedEffect(Unit) { onDismiss() }
            }

        }
    }
}