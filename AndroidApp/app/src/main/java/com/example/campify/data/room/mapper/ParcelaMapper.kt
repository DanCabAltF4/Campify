package com.example.campify.data.room.mapper

import com.example.campify.data.model.Parcela
import com.example.campify.data.room.entity.ParcelaEntity

fun Parcela.toEntity() = ParcelaEntity(
    id = id,
    cerca_baño = cercaBaño,
    cerca_entrada = cercaEntrada,
    precio_noche = precioNoche,
    tiene_vistas = tieneVistas,
    zona_sombra = zonaSombra,
    zona_tranquila = zonaTranquila,
    estado_parcela = estadoParcela,
    tipo_parcela = tipoParcela
)

fun ParcelaEntity.toDomain() = Parcela(
    id = id,
    cercaBaño = cerca_baño,
    cercaEntrada = cerca_entrada,
    precioNoche = precio_noche,
    tieneVistas = tiene_vistas,
    zonaSombra = zona_sombra,
    zonaTranquila = zona_tranquila,
    estadoParcela = estado_parcela,
    tipoParcela = tipo_parcela
)