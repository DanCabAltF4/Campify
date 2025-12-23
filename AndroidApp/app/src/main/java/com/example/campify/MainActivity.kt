package com.example.campify

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.navigation.compose.rememberNavController
import com.example.campify.navigation.CampifyNavigation
import com.example.campify.ui.theme.CampifyTheme

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContent {
            CampifyTheme {
                val navController = rememberNavController()
                CampifyNavigation(navController = navController)
            }
        }
    }
}