package org.example.dto;

import com.fasterxml.jackson.annotation.JsonProperty;
import org.example.model.enums.PuestoTrabajo;

public record DtoEmpleado(
        @JsonProperty("id") Integer id,
        @JsonProperty("nombre") String nombre,
        @JsonProperty("apellidos") String apellidos,
        @JsonProperty("dni") String dni,
        @JsonProperty("telefono") String telefono,
        @JsonProperty("puesto") PuestoTrabajo puesto,
        @JsonProperty("activo") Boolean activo,
        @JsonProperty("email") String email
) {}
