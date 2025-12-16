package org.example.model;

import javax.annotation.processing.Generated;

@Entity
public class Cliente {

    @Id
    private int id;

    private String nombre;
    private String apellidos;
    private String dni;
    private String direccion;
    private String cPostal;
    private DateTime fechaNacimiento;
}
