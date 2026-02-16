package com.example.campify.navigation

import androidx.compose.runtime.Composable
import androidx.navigation.NavHostController
import androidx.navigation.NavType
import androidx.navigation.compose.NavHost
import androidx.navigation.compose.composable
import androidx.navigation.navArgument
import com.campify.views.HomeView
import com.example.campify.data.model.enums.EstadoParcela
import com.example.campify.data.model.Parcela
import com.example.campify.viewmodels.ApiModel
import com.example.campify.views.DetailView
import com.example.campify.views.ListaView
import com.example.campify.views.NavView

private var apiModel = ApiModel()
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
            ListaView(navController, apiModel)
        }

        composable(route = "detail/{id}", arguments = listOf(navArgument("id") { type = NavType.IntType })
        ) { backStackEntry ->
            val id = backStackEntry.arguments?.getInt("id")
            DetailView(navController, apiModel, id)
        }
    }
}
