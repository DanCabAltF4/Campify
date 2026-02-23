package com.example.campify

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import com.example.campify.data.remote.RetrofitClient
import com.example.campify.data.room.AppDatabase
import com.example.campify.navigation.CampifyNavigation
import com.example.campify.ui.theme.CampifyTheme
import com.example.campify.viewmodels.ApiModel
import com.example.kotlinapp.data.AuthRepository
import com.example.kotlinapp.data.SessionDataStore

class MainActivity : ComponentActivity() {
    private lateinit var apiModel: ApiModel
    private lateinit var session : SessionDataStore

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        apiModel = ApiModel(
            AuthRepository(
                api = RetrofitClient.auth(),
                session = session
            ),
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