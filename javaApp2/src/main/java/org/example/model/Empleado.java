package org.example.model;

import jakarta.persistence.*;
import org.example.model.enums.PuestoTrabajo;

@Entity
@Table(name = "empleados")
public class Empleado {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;
    @Column(length = 50,nullable = false)
    private String nombre;
    @Column(length = 100,nullable = false)
    private String apellidos;
    @Column(columnDefinition = "CHAR(9)",nullable = false)
    private String dni;
    @Column(columnDefinition = "CHAR(9)",nullable = true)
    private String telefono;
    @Enumerated(EnumType.STRING)
    @Column(nullable = false)
    private PuestoTrabajo puesto;
    @Column(nullable = false)
    private boolean activo;
    @Column(length = 100, nullable = false, unique = true)
    private String email;
    @Column(length = 60, nullable = false)
    private String password;


    public Empleado() {
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellidos() {
        return apellidos;
    }

    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }

    public String getDni() {
        return dni;
    }

    public void setDni(String dni) {
        this.dni = dni;
    }

    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public PuestoTrabajo getPuesto() {
        return puesto;
    }

    public void setPuesto(PuestoTrabajo puesto) {
        this.puesto = puesto;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }
}
