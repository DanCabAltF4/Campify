package com.example.campify.data.model

import com.example.campify.data.model.enums.EstadoParcela
import com.example.campify.data.model.enums.TipoParcela

data class Parcela(
    var id: Int,
    var tipoParcela: TipoParcela,
    var precioNoche: Double,
    var cercaBaño: Boolean,
    var tieneVistas: Boolean,
    var zonaSombra: Boolean,
    val cercaEntrada: Boolean,
    val zonaTranquila: Boolean,
    var estadoParcela: EstadoParcela
)