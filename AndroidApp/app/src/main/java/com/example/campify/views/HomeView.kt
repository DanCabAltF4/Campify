package com.campify.views

import android.content.Context
import androidx.annotation.DrawableRes
import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.gestures.detectTransformGestures
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.AccountCircle
import androidx.compose.material3.*
import androidx.compose.runtime.Composable
import androidx.compose.runtime.LaunchedEffect
import androidx.compose.runtime.collectAsState
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.geometry.Offset
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.graphics.graphicsLayer
import androidx.compose.ui.input.pointer.pointerInput
import androidx.compose.ui.layout.ContentScale
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.res.stringResource
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.navigation.NavHostController
import com.example.campify.R
import com.example.campify.ui.theme.botonActivoDark
import com.example.campify.ui.theme.botonActivoLight
import com.example.campify.ui.theme.dynamicColor
import com.example.campify.ui.theme.fondoPrincipal2
import com.example.campify.ui.theme.fondoPrincipalDark
import com.example.campify.ui.theme.fondoPrincipalLight
import com.example.campify.ui.theme.textoPrincipalDark
import com.example.campify.ui.theme.textoPrincipalLight
import com.example.campify.ui.theme.textoSecundarioDark
import com.example.campify.ui.theme.textoSecundarioLight
import com.example.campify.viewmodels.ApiModel
import kotlinx.coroutines.flow.firstOrNull

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun HomeView(navController: NavHostController, apiModel: ApiModel) {
    val context = LocalContext.current

    val loginState by apiModel.loginState.collectAsState()
    LaunchedEffect(Unit) {
        if (apiModel.token.firstOrNull() != null) {
            apiModel.checkAuth()
        } else {
            navController.navigate("Login")
        }
    }
    LaunchedEffect(loginState) {
        when (loginState) {
            ApiModel.LoginState.Valid -> Unit
            ApiModel.LoginState.Waiting -> Unit
            else -> navController.navigate("Login")
        }
    }

    val segmentSelectedColor = dynamicColor(fondoPrincipal2, fondoPrincipal2) // puedes definir otro para oscuro
    val textPrimary = dynamicColor(textoPrincipalLight, textoPrincipalDark)
    val textSecondary = dynamicColor(textoSecundarioLight, textoSecundarioDark)

    Scaffold(
        topBar = { HomeTopBar(context, navController, apiModel) }
    ) { innerPadding ->
        Column(
            modifier = Modifier
                .fillMaxSize()
                .padding(innerPadding)
                .background(dynamicColor(Color(0xFFF3F3F3), Color(0xFF171717)))
        ) {
            NavigationSegment(navController, seleccionInicial = stringResource(R.string.nav_map), segmentSelectedColor, textPrimary, textSecondary)
            Spacer(modifier = Modifier.height(8.dp))
            HomeContent(textPrimary, textSecondary)
        }
    }
}

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun HomeTopBar(context: Context, navController: NavHostController, apiModel: ApiModel) {
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
                            "Campify",
                            fontSize = 20.sp,
                            fontWeight = FontWeight.Bold,
                            color = textColor
                        )
                    }

                    Text(
                        text = stringResource(R.string.map_subtitle),
                        fontSize = 12.sp,
                        color = secondaryText
                    )
                }
            },
            actions = {
                IconButton(onClick = {
                    navController.navigate("Login")
                    apiModel.logout()
                }) {
                    Icon(
                        Icons.Default.AccountCircle,
                        contentDescription = "Perfil",
                        tint = textColor
                    )
                }
            },
            colors = TopAppBarDefaults.topAppBarColors(
                containerColor = containerColor
            )
        )

        Divider(color = dynamicColor(Color(0x22000000), Color(0x22FFFFFF)), thickness = 1.dp)
    }
}

// Segmented navigation actualizado
@Composable
fun NavigationSegment(
    navController: NavHostController,
    seleccionInicial: String,
    segmentSelectedColor: Color,
    textPrimary: Color,
    textSecondary: Color
) {
    val mapa = stringResource(R.string.nav_map)
    val lista = stringResource(R.string.nav_list)
    val opciones = listOf(mapa, lista)
    var seleccionada by remember { mutableStateOf(seleccionInicial) }

    Row(
        modifier = Modifier
            .fillMaxWidth()
            .padding(horizontal = 16.dp)
            .background(dynamicColor(Color(0xFFE5E5E5), Color(0xFF2C2C2C)), RoundedCornerShape(12.dp))
            .padding(4.dp),
        horizontalArrangement = Arrangement.SpaceEvenly
    ) {
        opciones.forEach { opcion ->

            val seleccionadaActual = opcion == seleccionada

            Box(
                modifier = Modifier
                    .weight(1f)
                    .background(
                        color = if (seleccionadaActual) dynamicColor(botonActivoLight, botonActivoDark
                        ) else Color.Transparent,
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

// HomeContent con colores dinámicos
@Composable
fun HomeContent(textPrimary: Color, textSecondary: Color) {

    Column(
        modifier = Modifier
            .fillMaxSize()
            .padding(16.dp)
    ) {

        Text(
            stringResource(R.string.map_title),
            fontSize = 18.sp,
            fontWeight = FontWeight.SemiBold,
            color = textSecondary
        )

        Spacer(Modifier.height(12.dp))

        Card(
            shape = RoundedCornerShape(16.dp),
            elevation = CardDefaults.cardElevation(6.dp)
        ) {
            MapaImagenZoomable(mapaResId = R.drawable.mapa)
        }
    }
}


@Composable
fun MapaImagenZoomable(@DrawableRes mapaResId: Int) {
    var scale by remember { mutableStateOf(1f) }
    var offset by remember { mutableStateOf(Offset.Zero) }

    Box(
        modifier = Modifier
            .fillMaxSize()
            .pointerInput(Unit) {
                detectTransformGestures { _, pan, zoom, _ ->
                    scale = (scale * zoom).coerceIn(1f, 5f) // límite de zoom 1x a 5x
                    offset = Offset(
                        x = (offset.x + pan.x).coerceIn(-1000f, 1000f),
                        y = (offset.y + pan.y).coerceIn(-1000f, 1000f)
                    )
                }
            }
    ) {
        Image(
            painter = painterResource(id = mapaResId),
            contentDescription = "Mapa de la zona",
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
    }
}
