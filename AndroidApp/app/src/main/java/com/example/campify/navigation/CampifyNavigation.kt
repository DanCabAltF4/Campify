package com.example.campify.navigation

import androidx.compose.runtime.Composable
import androidx.navigation.NavType
import androidx.navigation.compose.NavHost
import androidx.navigation.compose.composable
import androidx.navigation.compose.rememberNavController
import androidx.navigation.navArgument
import com.campify.views.HomeView
import com.example.campify.viewmodels.ApiModel
import com.example.campify.views.DetailView
import com.example.campify.views.ListaView
import com.example.campify.views.LoginView
import com.example.campify.views.NavView

@Composable
fun CampifyNavigation(apiModel: ApiModel) {
    val navController = rememberNavController()
    NavHost(
        navController = navController,
        startDestination = NavView.Home.name
    ) {
        composable(NavView.Home.name) {
            HomeView(navController,apiModel)
        }

        composable("Login"){
            LoginView(navController, apiModel)
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
