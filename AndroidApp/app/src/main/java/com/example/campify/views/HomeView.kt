package com.campify.views

import android.widget.Toast
import androidx.annotation.DrawableRes
import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.layout.*
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.Settings
import androidx.compose.material3.*
import androidx.compose.runtime.Composable
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.layout.ContentScale
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.navigation.NavHostController
import com.example.campify.R
import com.example.campify.ui.theme.botonActivo
import com.example.campify.ui.theme.botonInactivo
import com.example.campify.ui.theme.fondoPrincipal
import com.example.campify.views.NavView

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun HomeView(navController: NavHostController) {
    val context = LocalContext.current

    Scaffold(
        // TopBar con logo y botón de configuración
        topBar = { HomeTopBar(context) }
    ) { innerPadding ->

        Column(
            modifier = Modifier
                .fillMaxSize()
                .padding(innerPadding)
        ) {
            // Botones de navegación (Mapa / Lista)
            NavigationButtons(navController)

            Spacer(modifier = Modifier.height(8.dp))

            // Contenido principal de la Home (mapa)
            HomeContent()
        }
    }
}

// Composable del TopBar con logo y botón de configuración
@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun HomeTopBar(context: android.content.Context) {
    TopAppBar(
        title = { HomeTopBarTitle() },
        actions = { ConfigButton(context) },
        colors = TopAppBarDefaults.topAppBarColors(
            containerColor = fondoPrincipal,
            titleContentColor = Color.Black
        )
    )
}

// Composable del título del TopBar (logo + texto)
@Composable
fun HomeTopBarTitle() {
    Row(verticalAlignment = Alignment.CenterVertically) {
        Image(
            painter = painterResource(R.drawable.campify_logo),
            contentDescription = "Logo Campify",
            modifier = Modifier.size(32.dp)
        )
        Spacer(modifier = Modifier.width(8.dp))
        Text("Campify")
    }
}

// Composable del botón de configuración
@Composable
fun ConfigButton(context: android.content.Context) {
    IconButton(onClick = {
        Toast.makeText(context, "Configuración", Toast.LENGTH_SHORT).show()
    }) {
        Icon(
            imageVector = Icons.Filled.Settings,
            contentDescription = "Configuración"
        )
    }
}

// Composable para los botones de navegación "Mapa" y "Lista"
@Composable
fun NavigationButtons(navController: NavHostController) {
    Row(
        modifier = Modifier
            .fillMaxWidth()
            .background(fondoPrincipal),
        horizontalArrangement = Arrangement.SpaceEvenly
    ) {
        Button(
            onClick = { navController.navigate(NavView.Home.name) },
            colors = ButtonDefaults.buttonColors(containerColor = botonActivo)
        ) {
            Text("Mapa", color = Color.Black)
        }

        Button(
            onClick = { navController.navigate(NavView.Lista.name) },
            colors = ButtonDefaults.buttonColors(containerColor = botonInactivo)
        ) {
            Text("Lista", color = Color.Black)
        }
    }
}

// Composable para el contenido principal de la Home (mapa)
@Composable
fun HomeContent() {
    Box(
        modifier = Modifier
            .fillMaxSize()
            .background(Color.LightGray),
        contentAlignment = Alignment.Center
    ) {
        // Texto descriptivo
        Text("Mapa de parcelas", fontSize = 20.sp, color = Color.DarkGray)

        // Imagen del mapa
        MapaImagen(mapaResId = R.drawable.mapa)
    }
}

// Composable para mostrar la imagen del mapa
@Composable
fun MapaImagen(
    @DrawableRes mapaResId: Int
) {
    Image(
        painter = painterResource(id = mapaResId),
        contentDescription = "Mapa de la zona",
        modifier = Modifier.fillMaxSize(),
        contentScale = ContentScale.Fit
    )
}
