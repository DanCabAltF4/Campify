package org.example.model;

import jakarta.persistence.*;

import javax.annotation.processing.Generated;
import java.time.LocalDateTime;

@Entity(name = "clientes")
public class Cliente {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;
    @Column(length = 50)
    private String nombre;
    @Column(length = 100)
    private String apellidos;
    @Column(length = 9)
    private String dni;
    private String direccion;
    private String cPostal;
    private LocalDateTime fechaNacimiento;
}
