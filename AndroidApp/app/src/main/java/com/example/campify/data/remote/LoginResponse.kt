package com.example.kotlinapp.data

import com.example.campify.data.model.enums.PuestoTrabajo

data class LoginResponse(
    val id: Int,
    val token: String,
    val rol : PuestoTrabajo
)
