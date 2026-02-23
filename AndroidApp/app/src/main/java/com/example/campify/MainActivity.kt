package com.example.campify

import android.annotation.SuppressLint
import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.navigation.compose.rememberNavController
import com.example.campify.data.room.AppDatabase
import com.example.campify.navigation.CampifyNavigation
import com.example.campify.ui.theme.CampifyTheme
import com.example.campify.viewmodels.ApiModel

class MainActivity : ComponentActivity() {
    private lateinit var apiModel: ApiModel


    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        apiModel = ApiModel(
            AppDatabase.getDatabase(this)
        )
        setContent {
            CampifyTheme {
                CampifyNavigation(
                    apiModel = apiModel
                )
            }
        }
    }
}