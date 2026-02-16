package org.example.dto;

import com.fasterxml.jackson.annotation.JsonProperty;

import java.time.LocalDate;

public record DtoCliente(
        @JsonProperty("id") Integer id,
        @JsonProperty("nombre") String nombre,
        @JsonProperty("apellidos") String apellidos,
        @JsonProperty("dni") String dni,
        @JsonProperty("direccion") String direccion,
        @JsonProperty("cPostal") String cPostal,
        @JsonProperty("fechaNacimiento") LocalDate fechaNacimiento,
        @JsonProperty("email") String email,
        @JsonProperty("telefono") String telefono
) {}
