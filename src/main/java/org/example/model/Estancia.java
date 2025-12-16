package org.example.model;

import jakarta.persistence.*;

import java.time.LocalDate;
import java.util.LinkedHashSet;
import java.util.Set;

@Entity
@Table(name = "estancias")
public class Estancia {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;
    @Column(name = "check_in",nullable = false)
    private LocalDate checkIn;
    @Column(name = "check_out")
    private LocalDate checkOut;
    @Column(name = "numero_adultos",nullable = false)
    private int numeroAdultos;
    @Column(name = "numero_niños")
    private int numeroNinos;
    @Column(name = "numero_mascotas")
    private int numeroMascotas;
    @Column(name = "cantidad_equipaje_extra")
    private double cantidadEquipajeExtra;
    @Column(name = "coste_miscelaneo")
    private double costeMiscelaneo;
    @Column(name = "precio_final")
    private double precioFinal;

    //@ManyToOne
    //private Cliente cliente;
    //@ManyToOne
    //private Parcela parcelas;
    //@ManyToOne
    //private Empleado empleados;

    public Estancia() {
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public double getPrecioFinal() {
        return precioFinal;
    }

    public void setPrecioFinal(double precioFinal) {
        this.precioFinal = precioFinal;
    }

    public double getCosteMiscelaneo() {
        return costeMiscelaneo;
    }

    public void setCosteMiscelaneo(double costeMiscelaneo) {
        this.costeMiscelaneo = costeMiscelaneo;
    }

    public double getCantidadEquipajeExtra() {
        return cantidadEquipajeExtra;
    }

    public void setCantidadEquipajeExtra(double cantidadEquipajeExtra) {
        this.cantidadEquipajeExtra = cantidadEquipajeExtra;
    }

    public int getNumeroMascotas() {
        return numeroMascotas;
    }

    public void setNumeroMascotas(int numeroMascotas) {
        this.numeroMascotas = numeroMascotas;
    }

    public int getNumeroNinos() {
        return numeroNinos;
    }

    public void setNumeroNinos(int numeroNinos) {
        this.numeroNinos = numeroNinos;
    }

    public int getNumeroAdultos() {
        return numeroAdultos;
    }

    public void setNumeroAdultos(int numeroAdultos) {
        this.numeroAdultos = numeroAdultos;
    }

    public LocalDate getCheckOut() {
        return checkOut;
    }

    public void setCheckOut(LocalDate checkOut) {
        this.checkOut = checkOut;
    }

    public LocalDate getCheckIn() {
        return checkIn;
    }

    public void setCheckIn(LocalDate checkIn) {
        this.checkIn = checkIn;
    }
}
