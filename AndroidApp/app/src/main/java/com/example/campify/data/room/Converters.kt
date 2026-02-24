package com.example.campify.data.room

import androidx.room.TypeConverter
import com.example.campify.data.model.enums.EstadoParcela
import com.example.campify.data.model.enums.TipoParcela

class Converters {

    @TypeConverter
    fun fromEstado(value: EstadoParcela?): String? = value?.name

    @TypeConverter
    fun toEstado(value: String?): EstadoParcela? =
        value?.let { EstadoParcela.valueOf(it) }

    @TypeConverter
    fun fromTipo(value: TipoParcela?): String? = value?.name

    @TypeConverter
    fun toTipo(value: String?): TipoParcela? =
        value?.let { TipoParcela.valueOf(it) }
}
