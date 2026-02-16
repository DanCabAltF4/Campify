package org.example.dto;

import com.fasterxml.jackson.annotation.JsonProperty;
import org.example.model.enums.Temporada;

import java.time.LocalDate;
import java.util.List;

public record DtoEstancia(
        @JsonProperty("id") Integer id,
        @JsonProperty("checkIn") LocalDate checkIn,
        @JsonProperty("checkOut") LocalDate checkOut,
        @JsonProperty("temporada") Temporada temporada,
        @JsonProperty("numeroAdultos") Integer numeroAdultos,
        @JsonProperty("numeroNinos") Integer numeroNinos,
        @JsonProperty("numeroMascotas") Integer numeroMascotas,
        @JsonProperty("cantidadEquipajeExtra") Double cantidadEquipajeExtra,
        @JsonProperty("costeMiscelaneo") Double costeMiscelaneo,
        @JsonProperty("precioFinal") Double precioFinal,

        @JsonProperty("parcelaId") Integer parcelaId,
        @JsonProperty("empleadoId") Integer empleadoId
) {}
