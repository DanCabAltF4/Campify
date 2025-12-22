package com.example.campify.navigation

import androidx.compose.runtime.Composable
import androidx.navigation.NavHostController
import androidx.navigation.compose.NavHost
import androidx.navigation.compose.composable
import com.campify.views.HomeView
import com.example.campify.data.model.enums.EstadoParcela
import com.example.campify.data.model.Parcela
import com.example.campify.views.ListaView
import com.example.campify.views.NavView

@Composable
fun CampifyNavigation(navController: NavHostController) {
    NavHost(
        navController = navController,
        startDestination = NavView.Home.name
    ) {
        composable(NavView.Home.name) {
            HomeView(navController)
        }

        composable(NavView.Lista.name) {
            ListaView(navController,generarParcelas())
        }
    }
}

@Composable
private fun generarParcelas(): List<Parcela> {
    return listOf(
        Parcela("Roble Norte", EstadoParcela.LIBRE),
        Parcela("Pino Sur", EstadoParcela.INTERESADO),
        Parcela("Cedro Central", EstadoParcela.RESERVADA),
        Parcela("Abeto Este", EstadoParcela.LIBRE),
        Parcela("Olmo Oeste", EstadoParcela.BLOQUEADA),
        Parcela("Haya Norte", EstadoParcela.LIBRE),
        Parcela("Ciprés Sur", EstadoParcela.INTERESADO),
        Parcela("Secuoya Central", EstadoParcela.LIBRE),
        Parcela("Sauce Este", EstadoParcela.RESERVADA),
        Parcela("Arce Oeste", EstadoParcela.LIBRE),
        Parcela("Nogal Norte", EstadoParcela.BLOQUEADA),
        Parcela("Aliso Sur", EstadoParcela.INTERESADO),
        Parcela("Fresno Central", EstadoParcela.LIBRE),
        Parcela("Caoba Este", EstadoParcela.RESERVADA),
        Parcela("Encina Oeste", EstadoParcela.LIBRE),
        Parcela("Olivo Norte", EstadoParcela.BLOQUEADA),
        Parcela("Abedul Sur", EstadoParcela.LIBRE),
        Parcela("Eucalipto Central", EstadoParcela.INTERESADO),
        Parcela("Tejo Este", EstadoParcela.RESERVADA),
        Parcela("Robinia Oeste", EstadoParcela.LIBRE),
        Parcela("Pino Blanco", EstadoParcela.RESERVADA),
        Parcela("Cedro Rojo", EstadoParcela.LIBRE),
        Parcela("Abeto Azul", EstadoParcela.INTERESADO),
        Parcela("Olmo Plateado", EstadoParcela.LIBRE),
        Parcela("Haya Roja", EstadoParcela.BLOQUEADA),
        Parcela("Ciprés Verde", EstadoParcela.LIBRE),
        Parcela("Secuoya Dorada", EstadoParcela.RESERVADA),
        Parcela("Sauce Gris", EstadoParcela.LIBRE),
        Parcela("Arce Amarillo", EstadoParcela.INTERESADO),
        Parcela("Nogal Marrón", EstadoParcela.BLOQUEADA),
        Parcela("Aliso Plateado", EstadoParcela.LIBRE),
        Parcela("Fresno Verde", EstadoParcela.RESERVADA),
        Parcela("Caoba Roja", EstadoParcela.LIBRE),
        Parcela("Encina Dorada", EstadoParcela.INTERESADO),
        Parcela("Olivo Azul", EstadoParcela.LIBRE),
        Parcela("Abedul Gris", EstadoParcela.BLOQUEADA),
        Parcela("Eucalipto Plateado", EstadoParcela.LIBRE),
        Parcela("Tejo Verde", EstadoParcela.RESERVADA),
        Parcela("Robinia Roja", EstadoParcela.INTERESADO),
        Parcela("Pino Dorado", EstadoParcela.LIBRE)
    )
}