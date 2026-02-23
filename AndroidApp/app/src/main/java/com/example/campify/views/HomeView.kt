package com.campify.views

import android.widget.Toast
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
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.navigation.NavHostController
import com.example.campify.R
import com.example.campify.ui.theme.fondoPrincipal
import com.example.campify.ui.theme.fondoPrincipal2
import com.example.campify.views.NavView

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun HomeView(navController: NavHostController) {
    val context = LocalContext.current

    Scaffold(
        topBar = { HomeTopBar(context) }
    ) { innerPadding ->
        Column(
            modifier = Modifier
                .fillMaxSize()
                .padding(innerPadding)
        ) {
            NavigationSegment(navController, seleccionInicial = "Mapa")
            Spacer(modifier = Modifier.height(8.dp))
            HomeContent()
        }
    }
}

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun HomeTopBar(context: android.content.Context) {

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
                            color = Color.Black
                        )
                    }

                    Text(
                        "Mapa del parque",
                        fontSize = 12.sp,
                        color = Color.DarkGray
                    )
                }
            },
            actions = {
                IconButton(onClick = {
                    Toast.makeText(context, "Volver a iniciar sesión", Toast.LENGTH_SHORT).show()
                }) {
                    Icon(
                        Icons.Default.AccountCircle,
                        contentDescription = "Perfil",
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
fun HomeTopBarTitle() {
    Row(verticalAlignment = Alignment.CenterVertically) {
        Image(
            painter = painterResource(R.drawable.campify_logo),
            contentDescription = "Logo Campify",
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

@Composable
fun LoginButton(context: android.content.Context) {
    IconButton(onClick = {
        Toast.makeText(context, "Volver a iniciar sesion", Toast.LENGTH_SHORT).show()
    }) {
        Icon(Icons.Filled.AccountCircle, contentDescription = "Configuración")
    }
}

// Botones de navegación estilo “SegmentedButton”
@Composable
fun NavigationSegment(navController: NavHostController, seleccionInicial: String) {

    val opciones = listOf("Mapa", "Lista")
    var seleccionada by remember { mutableStateOf(seleccionInicial) }

    Row(
        modifier = Modifier
            .fillMaxWidth()
            .padding(horizontal = 16.dp)
            .background(Color(0xFFE5E5E5), RoundedCornerShape(12.dp))
            .padding(4.dp),
        horizontalArrangement = Arrangement.SpaceEvenly
    ) {
        opciones.forEach { opcion ->

            val seleccionadaActual = opcion == seleccionada

            Box(
                modifier = Modifier
                    .weight(1f)
                    .background(
                        color = if (seleccionadaActual) fondoPrincipal2 else Color.Transparent,
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
                    color = if (seleccionadaActual) Color.White else Color.Gray,
                    fontWeight = FontWeight.SemiBold
                )
            }
        }
    }
}


@Composable
fun HomeContent() {

    Column(
        modifier = Modifier
            .fillMaxSize()
            .background(Color(0xFFEFEFEF))
            .padding(16.dp)
    ) {

        Text(
            "Mapa de parcelas",
            fontSize = 18.sp,
            fontWeight = FontWeight.SemiBold,
            color = Color.DarkGray
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
