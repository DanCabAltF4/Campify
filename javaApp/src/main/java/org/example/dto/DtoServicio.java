package org.example.dto;

import com.fasterxml.jackson.annotation.JsonProperty;

public record DtoServicio(
        @JsonProperty("id") Integer id,
        @JsonProperty("nombre") String nombre,
        @JsonProperty("descripcion") String descripcion,
        @JsonProperty("precio") Double precio
) {}
