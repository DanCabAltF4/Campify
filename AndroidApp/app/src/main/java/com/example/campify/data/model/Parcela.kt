package com.example.campify.data.model

import com.example.campify.data.model.enums.EstadoParcela
import com.example.campify.data.model.enums.TipoParcela
import com.google.gson.annotations.SerializedName

data class Parcela(
    @SerializedName("id") var id: Int,
    @SerializedName("tipo_parcela") var tipoParcela: TipoParcela,
    @SerializedName("precio_noche") var precioNoche: Double,
    @SerializedName("cerca_baño") var cercaBaño: Boolean,
    @SerializedName("tiene_vistas") var tieneVistas: Boolean,
    @SerializedName("zona_sombra") var zonaSombra: Boolean,
    @SerializedName("cerca_entrada") val cercaEntrada: Boolean,
    @SerializedName("zona_tranquila") val zonaTranquila: Boolean,
    @SerializedName("estado_parcela") var estadoParcela: EstadoParcela,
    @SerializedName("imagen") val imagenParcela: String?
)