package com.example.campify.data.remote

import android.content.Context
import androidx.datastore.core.DataStore
import androidx.datastore.preferences.core.Preferences
import androidx.datastore.preferences.core.edit
import androidx.datastore.preferences.core.stringPreferencesKey
import androidx.datastore.preferences.preferencesDataStore
import com.example.campify.data.model.enums.PuestoTrabajo
import kotlinx.coroutines.flow.Flow
import kotlinx.coroutines.flow.map

// Extensión para crear una instancia de DataStore ligada al contexto de la aplicación
private val Context.dataStore: DataStore<Preferences> by preferencesDataStore(name = "session")

class SessionDataStore(private val context: Context) {

    // Clave para guardar el token en DataStore
    private val TOKEN_KEY = stringPreferencesKey("jwt_token")
    private val ROLE_KEY = stringPreferencesKey("user_role")

    val tokenFlow: Flow<String?> = context.dataStore.data.map { prefs -> prefs[TOKEN_KEY] }
    val roleFlow: Flow<String?> = context.dataStore.data.map { prefs -> prefs[ROLE_KEY] }

    // Función para guardar el token y rol de forma asíncrona
    suspend fun saveSession(token: String, role: PuestoTrabajo) {

        context.dataStore.edit { preferences ->
            preferences[TOKEN_KEY] = token
            preferences[ROLE_KEY] = role.toString()
        }
    }

    // Función para limpiar el token y rol (por ejemplo, al cerrar sesión)
    suspend fun clearSession() {
        context.dataStore.edit { preferences ->
            preferences.remove(TOKEN_KEY)
            preferences.remove(ROLE_KEY)
        }
    }

}

