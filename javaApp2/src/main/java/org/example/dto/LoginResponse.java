package org.example.dto;

import com.fasterxml.jackson.annotation.JsonProperty;
import org.example.model.enums.PuestoTrabajo;

public record LoginResponse (

        @JsonProperty("token") String token,
        @JsonProperty("rol") PuestoTrabajo puesto,
        @JsonProperty("id") Integer id
){}
