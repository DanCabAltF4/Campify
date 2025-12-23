package com.example.campify.views

import android.widget.Toast
import androidx.compose.foundation.Image
import androidx.compose.foundation.layout.*
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.ArrowBack
import androidx.compose.material.icons.filled.Check
import androidx.compose.material.icons.filled.Close
import androidx.compose.material.icons.filled.Settings
import androidx.compose.material3.*
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
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
import com.example.campify.R
import com.example.campify.data.model.Parcela
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
    api.cargarParcelas()
    Scaffold(
        // TopBar con logo, título y botones
        topBar = {
            TopAppBar(
                title = { TopBarTitle() },
                navigationIcon = { BackButton(navController) },
                actions = { ConfigButton(context) },
                colors = TopAppBarDefaults.topAppBarColors(
                    containerColor = fondoPrincipal,
                    titleContentColor = Color.Black
                )
            )
        }
    ) { innerPadding ->
        // Contenido principal de la parcela
        ContentDetailView(
            innerPadding = innerPadding,
            parcelas = parcelas,
            id = id
        )
    }
}

// TopBar title con logo
@Composable
fun TopBarTitle() {
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

// Contenido del detalle de la parcela
@Composable
fun ContentDetailView(
    innerPadding: PaddingValues,
    parcelas: List<Parcela>,
    id: Int?
) {
    val parcela = parcelas.firstOrNull { it.id == id } ?: return

    Column(
        modifier = Modifier
            .padding(innerPadding)
            .padding(16.dp)
            .fillMaxSize()
    ) {

        // Información principal de la parcela
        Box(
            modifier = Modifier
                .fillMaxWidth()
                .weight(0.4f)
        ) {
            Column {
                Spacer(modifier = Modifier.height(8.dp))
                Text(
                    text = "Parcela: ${parcela.id}",
                    fontWeight = FontWeight.Bold,
                    fontSize = 20.sp
                )
                Spacer(modifier = Modifier.height(6.dp))
                Text(
                    text = "Estado: ${parcela.estado_parcela.name}",
                    fontWeight = FontWeight.Medium
                )
                Spacer(modifier = Modifier.height(6.dp))

                // Características booleanas de la parcela
                BooleanRow("Baño cercano", parcela.cerca_baño)
                BooleanRow("Cerca de la entrada", parcela.cerca_entrada)
                BooleanRow("Tiene vistas", parcela.tiene_vistas)
                BooleanRow("Zona tranquila", parcela.zona_tranquila)
                BooleanRow("Zona con sombra", parcela.zona_sombra)
                Spacer(modifier = Modifier.height(8.dp))
            }
        }

        // Descripción de la parcela
        descripcion("Descripción", parcela)
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

// Descripción de la parcela
@Composable
private fun ColumnScope.descripcion(titulo: String, parcela: Parcela) {
    Column(
        modifier = Modifier
            .fillMaxWidth()
            .weight(0.6f)
    ) {
        Text(
            text = titulo,
            fontWeight = FontWeight.Bold
        )
    }
}
