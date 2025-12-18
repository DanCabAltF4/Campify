package org.example.model;

import com.fasterxml.jackson.annotation.JsonManagedReference;
import jakarta.persistence.*;
import org.example.model.enums.Temporada;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.LinkedHashSet;
import java.util.List;
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
    @Enumerated(EnumType.STRING)
    @Column(nullable = false)
    private Temporada temporada;
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

    @ManyToMany(cascade = CascadeType.MERGE)
    @JoinTable(
            name = "clientes_estancia",
            joinColumns = @JoinColumn(name = "id_estancia"),
            inverseJoinColumns = @JoinColumn(name = "id_cliente")
    )
    @JsonManagedReference
    private List<Cliente> cliente = new ArrayList<>();

    @ManyToMany(cascade = CascadeType.MERGE)
    @JoinTable(
            name = "estancia_servicios",
            joinColumns = @JoinColumn(name = "id_estancia"),
            inverseJoinColumns = @JoinColumn(name = "id_servicio")
    )
    @JsonManagedReference
    private List<Servicio> servicio = new ArrayList<>();


    @ManyToOne
    @JoinColumn(name = "id_parcela")
    private Parcela parcelas;
    @ManyToOne
    @JoinColumn(name = "id_empleado")
    private Empleado empleados;


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

    public Temporada getTemporada() {
        return temporada;
    }

    public void setTemporada(Temporada temporada) {
        this.temporada = temporada;
    }

    public List<Servicio> getServicio() {
        return servicio;
    }

    public void setServicio(List<Servicio> servicio) {
        this.servicio = servicio;
    }

    public List<Cliente> getCliente() {
        return cliente;
    }

    public void setCliente(List<Cliente> cliente) {
        this.cliente = cliente;
    }

    public Parcela getParcelas() {
        return parcelas;
    }

    public void setParcelas(Parcela parcelas) {
        this.parcelas = parcelas;
    }

    public Empleado getEmpleados() {
        return empleados;
    }

    public void setEmpleados(Empleado empleados) {
        this.empleados = empleados;
    }

    public void addCliente(Cliente cliente){
        getCliente().add(cliente);
        cliente.getEstancia().add(this);
    }

    public void removeCliente(Cliente cliente){
        getServicio().remove(servicio);
        cliente.getEstancia().remove(this);
    }

    public void addServicio(Servicio servicio){
        getServicio().add(servicio);
        servicio.getEstancia().add(this);
    }

    public void removeServicio(Servicio servicio){
        getServicio().remove(servicio);
        servicio.getEstancia().remove(this);
    }

    @Override
    public String toString() {
        return "Estancia{" +
                "id=" + id +
                ", checkIn=" + checkIn +
                ", checkOut=" + checkOut +
                ", temporada=" + temporada +
                ", numeroAdultos=" + numeroAdultos +
                ", numeroNinos=" + numeroNinos +
                ", numeroMascotas=" + numeroMascotas +
                ", cantidadEquipajeExtra=" + cantidadEquipajeExtra +
                ", costeMiscelaneo=" + costeMiscelaneo +
                ", precioFinal=" + precioFinal +
                '}';
    }

}
