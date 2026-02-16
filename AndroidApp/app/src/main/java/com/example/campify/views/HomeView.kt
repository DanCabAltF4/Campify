package com.campify.views

import android.widget.Toast
import androidx.annotation.DrawableRes
import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.*
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
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.layout.ContentScale
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.navigation.NavHostController
import com.example.campify.R
import com.example.campify.ui.theme.fondoPrincipal
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
    TopAppBar(
        title = { HomeTopBarTitle() },
        actions = { LoginButton(context) },
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
fun HomeContent() {
    Box(
        modifier = Modifier
            .fillMaxSize()
            .background(Color(0xFFEFEFEF))
            .padding(16.dp),
        contentAlignment = Alignment.Center
    ) {
        // Imagen del mapa
        MapaImagen(mapaResId = R.drawable.mapa)

        // Texto superpuesto (opcional)
        Text(
            "Mapa de parcelas",
            fontSize = 20.sp,
            color = Color.DarkGray,
            modifier = Modifier.align(Alignment.TopCenter)
        )
    }
}

@Composable
fun MapaImagen(@DrawableRes mapaResId: Int) {
    Image(
        painter = painterResource(id = mapaResId),
        contentDescription = "Mapa de la zona",
        modifier = Modifier.fillMaxSize(),
        contentScale = ContentScale.Fit
    )
}
