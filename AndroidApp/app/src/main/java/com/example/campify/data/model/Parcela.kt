package com.example.campify.data.model

import com.example.campify.data.model.enums.EstadoParcela
import com.example.campify.data.model.enums.TipoParcela

data class Parcela(
    var id: Int,
    var tipo_parcela: TipoParcela,
    var precio_noche: Double,
    var cerca_baño: Boolean,
    var tiene_vistas: Boolean,
    var zona_sombra: Boolean,
    var estado_parcela: EstadoParcela
)