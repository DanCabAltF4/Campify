package org.example.dto;

import com.fasterxml.jackson.annotation.JsonProperty;
import org.example.model.enums.EstadoParcela;
import org.example.model.enums.TipoParcela;
import org.springframework.boot.jackson.autoconfigure.JacksonProperties;

public record DtoParcela(
        @JsonProperty("id") Integer id,
        @JsonProperty("tipoParcela") TipoParcela tipoParcela,
        @JsonProperty("precioNoche") Double precioNoche,
        @JsonProperty("cercaBano") Boolean cercaBano,
        @JsonProperty("tieneVistas") Boolean tieneVistas,
        @JsonProperty("zonaSombra") Boolean zonaSombra,
        @JsonProperty("cercaEntrada") Boolean cercaEntrada,
        @JsonProperty("zonaTranquila") Boolean zonaTranquila,
        @JsonProperty("estadoParcela") EstadoParcela estadoParcela,
        @JsonProperty("imagen") String imagen
) {}
