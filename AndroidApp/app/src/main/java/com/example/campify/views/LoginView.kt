package com.example.campify.views

import android.widget.Toast
import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.size
import androidx.compose.foundation.layout.width
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.KeyboardArrowDown
import androidx.compose.material.icons.filled.KeyboardArrowUp
import androidx.compose.material3.ButtonDefaults
import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.material3.Icon
import androidx.compose.material3.IconButton
import androidx.compose.material3.OutlinedTextField
import androidx.compose.material3.OutlinedTextFieldDefaults
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Text
import androidx.compose.material3.TextButton
import androidx.compose.material3.TopAppBar
import androidx.compose.material3.TopAppBarDefaults
import androidx.compose.runtime.Composable
import androidx.compose.runtime.LaunchedEffect
import androidx.compose.runtime.collectAsState
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.res.stringResource
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.text.input.PasswordVisualTransformation
import androidx.compose.ui.text.input.VisualTransformation
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.navigation.NavController
import com.example.campify.R
import com.example.campify.ui.theme.botonActivo
import com.example.campify.ui.theme.botonActivoTexto
import com.example.campify.ui.theme.dynamicColor
import com.example.campify.ui.theme.fondoPrincipalDark
import com.example.campify.ui.theme.fondoPrincipalLight
import com.example.campify.ui.theme.textoPrincipalDark
import com.example.campify.ui.theme.textoPrincipalLight
import com.example.campify.viewmodels.ApiModel

@Composable
fun LoginView(navController: NavController, apiModel: ApiModel) {
    var email by remember { mutableStateOf("") }
    var password by remember { mutableStateOf("") }
    val context = LocalContext.current
    val loginState by apiModel.loginState.collectAsState()
    var passwordVisible by remember { mutableStateOf(false) }
    val textoError = stringResource(R.string.login_error)
    LaunchedEffect(loginState) {
        when (loginState) {
            is ApiModel.LoginState.Valid -> {
                navController.navigate("Home") {
                    popUpTo("Login") { inclusive = true }
                }
            }

            is ApiModel.LoginState.Invalid -> {
                Toast.makeText(context, textoError, Toast.LENGTH_SHORT).show()
                apiModel.resetLoginState()
            }

            else -> Unit
        }
    }

    val textColor = dynamicColor(textoPrincipalLight, textoPrincipalDark)

    Scaffold(
        topBar = { LoginTopBar() },
    ) { padding ->
        // Fondo completo primero
        Box(
            modifier = Modifier
                .fillMaxSize()
                .background(dynamicColor(Color(0xFFF3F3F3), Color(0xFF171717))) // fondo total
        ) {
            Column(
                modifier = Modifier
                    .padding(padding) // padding del Scaffold
                    .fillMaxSize()
                    .padding(16.dp),
                verticalArrangement = Arrangement.Center,
                horizontalAlignment = Alignment.CenterHorizontally
            ) {
                // Aquí va tu caja interna con TextFields y botón
                Column(
                    modifier = Modifier
                        .fillMaxWidth()
                        .background(
                            dynamicColor(Color(0xFFF7F7F7), Color(0xFF2C2C2C)),
                            RoundedCornerShape(16.dp)
                        )
                        .padding(24.dp),
                    verticalArrangement = Arrangement.spacedBy(16.dp)
                ) {

                    // Email
                    OutlinedTextField(
                        value = email,
                        onValueChange = { email = it.trim() },
                        label = { Text(stringResource(R.string.login_email), color = textColor) },
                        modifier = Modifier.fillMaxWidth(),
                        colors = OutlinedTextFieldDefaults.colors(
                            focusedBorderColor = botonActivo,
                            focusedLabelColor = botonActivo,
                            unfocusedBorderColor = dynamicColor(Color.Gray, Color.LightGray)
                        ),
                    )

                    // Password
                    OutlinedTextField(
                        value = password,
                        onValueChange = { password = it.trim() },
                        label = { Text(stringResource(R.string.login_password), color = textColor) },
                        visualTransformation = if (passwordVisible) VisualTransformation.None
                        else PasswordVisualTransformation(),
                        modifier = Modifier.fillMaxWidth(),
                        colors = OutlinedTextFieldDefaults.colors(
                            focusedBorderColor = botonActivo,
                            focusedLabelColor = botonActivo,
                            unfocusedBorderColor = dynamicColor(Color.Gray, Color.LightGray)
                        ),
                        trailingIcon = {
                            val icon = if (passwordVisible) Icons.Default.KeyboardArrowDown
                            else Icons.Default.KeyboardArrowUp
                            IconButton(onClick = { passwordVisible = !passwordVisible }) {
                                Icon(
                                    imageVector = icon,
                                    contentDescription = null,
                                    tint = textColor
                                )
                            }
                        }
                    )

                    // Login button
                    TextButton(
                        onClick = { apiModel.login(email, password) },
                        modifier = Modifier.fillMaxWidth(),
                        colors = ButtonDefaults.textButtonColors(
                            containerColor = botonActivo,
                            contentColor = botonActivoTexto
                        )
                    ) {
                        Text(stringResource(R.string.login_placeholder))
                    }
                }
            }
        }
    }
}


@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun LoginTopBar() {
    val textColor = dynamicColor(textoPrincipalLight, textoPrincipalDark)
    val bgColor = dynamicColor(fondoPrincipalLight, fondoPrincipalDark)

    Column {
        TopAppBar(
            title = {
                Row(verticalAlignment = Alignment.CenterVertically) {
                    Image(
                        painter = painterResource(id = R.drawable.campify_logo),
                        contentDescription = "Logo",
                        modifier = Modifier.size(28.dp)
                    )
                    Spacer(modifier = Modifier.width(8.dp))
                    Column {
                        Text(
                            "Campify",
                            fontWeight = FontWeight.Bold,
                            fontSize = 20.sp,
                            color = textColor
                        )
                        Text(
                            stringResource(R.string.login_subtitle),
                            fontSize = 12.sp,
                            color = dynamicColor(Color.DarkGray, Color.LightGray)
                        )
                    }
                }
            },
            colors = TopAppBarDefaults.topAppBarColors(
                containerColor = bgColor,
                titleContentColor = textColor
            )
        )
    }
}