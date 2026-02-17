package com.example.campify.data.room.mapper

import com.example.campify.data.model.Parcela
import com.example.campify.data.room.entity.ParcelaEntity

fun Parcela.toEntity() = ParcelaEntity(
    id = id,
    cerca_baño = cerca_baño,
    cerca_entrada = cerca_entrada,
    precio_noche = precio_noche,
    tiene_vistas = tiene_vistas,
    zona_sombra = zona_sombra,
    zona_tranquila = zona_tranquila,
    estado_parcela = estado_parcela,
    tipo_parcela = tipo_parcela
)

fun ParcelaEntity.toDomain() = Parcela(
    id = id,
    cerca_baño = cerca_baño,
    cerca_entrada = cerca_entrada,
    precio_noche = precio_noche,
    tiene_vistas = tiene_vistas,
    zona_sombra = zona_sombra,
    zona_tranquila = zona_tranquila,
    estado_parcela = estado_parcela,
    tipo_parcela = tipo_parcela
)