package com.example.campify.data.room.entity

import androidx.room.Entity
import androidx.room.PrimaryKey
import com.example.campify.data.model.enums.EstadoParcela
import com.example.campify.data.model.enums.TipoParcela

@Entity(tableName = "parcelas")
data class ParcelaEntity(
    @PrimaryKey val id: Int,
    val tipo_parcela: TipoParcela,
    val precio_noche: Double,
    val cerca_baño: Boolean,
    val tiene_vistas: Boolean,
    val zona_sombra: Boolean,
    val cerca_entrada: Boolean,
    val zona_tranquila: Boolean,
    val estado_parcela: EstadoParcela,
    val imagen_parcela: String?
)


