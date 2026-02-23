package com.example.campify.views

import android.widget.Toast
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
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
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.text.input.PasswordVisualTransformation
import androidx.compose.ui.text.input.VisualTransformation
import androidx.compose.ui.unit.dp
import androidx.navigation.NavController
import com.example.campify.viewmodels.ApiModel

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun LoginView(
    navController: NavController,
    apiModel: ApiModel,
) {
    // Local UI state
    var email by remember { mutableStateOf("") }
    var password by remember { mutableStateOf("") }
    val context = LocalContext.current
    val loginState by apiModel.loginState.collectAsState()
    LaunchedEffect(loginState) {
        when (loginState) {
            apiModel.LoginState.Valid -> navController.popBackStack("List",false)
            apiModel.LoginState.Invalid -> {
                Toast.makeText(
                    context, "Inicio de Sesión Invalido", Toast.LENGTH_SHORT
                ).show()
                apiModel.resetLoginState()
            }

            else -> Unit
        }
    }
    Scaffold(
        topBar = {
            TopAppBar(
                title = {
                    Text("LOGIN")
                }, colors = TopAppBarDefaults.topAppBarColors(
                    containerColor = fondoPrincipal, titleContentColor = Color.Black
                )
            )
        }) { padding ->
        Column(
            modifier = Modifier
                .padding(padding)
                .padding(16.dp)
                .fillMaxSize(),
            verticalArrangement = Arrangement.spacedBy(16.dp)
        ) {

            // Email field
            OutlinedTextField(
                value = email,
                onValueChange = { email = it.trim() },
                label = { Text("Email") },
                modifier = Modifier.fillMaxWidth(),
                colors = OutlinedTextFieldDefaults.colors(
                    focusedBorderColor = botonActivo,
                    focusedLabelColor = botonActivo,
                    cursorColor = Color.Black
                )
            )

            var passwordVisible by remember { mutableStateOf(false) }
            OutlinedTextField(
                value = password,
                onValueChange = { password = it.trim() },
                label = { Text("Password") },
                visualTransformation = if (passwordVisible) VisualTransformation.None
                else PasswordVisualTransformation(),
                modifier = Modifier.fillMaxWidth(),
                colors = OutlinedTextFieldDefaults.colors(
                    focusedBorderColor = botonActivo,
                    focusedLabelColor = botonActivo,
                    cursorColor = Color.Black
                ),
                trailingIcon = {
                    val icon = if (passwordVisible) Icons.Default.KeyboardArrowDown
                    else Icons.Default.KeyboardArrowUp
                    IconButton(
                        onClick = { passwordVisible = !passwordVisible }) {
                        Icon(
                            imageVector = icon, contentDescription = null
                        )
                    }
                })


            // Login button
            TextButton(
                onClick = {
                    apiModel.login(email, password)


                }, modifier = Modifier.fillMaxWidth(), colors = ButtonDefaults.textButtonColors(
                    contentColor = botonActivoTexto, containerColor = botonActivo
                )
            ) {
                Text("Login")
            }
        }
    }
}
