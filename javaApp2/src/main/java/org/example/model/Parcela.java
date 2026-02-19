package org.example.model;

import jakarta.persistence.*;
import org.example.model.enums.EstadoParcela;
import org.example.model.enums.TipoParcela;

@Entity(name = "parcelas")
public class Parcela {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;

    @Column(name = "tipo_parcela")
    @Enumerated(EnumType.STRING)
    private TipoParcela tipo_parcela;

    @Column(name = "precio_noche")
    private double precio_noche;

    @Column(name = "cerca_baño")
    private boolean cerca_baño;

    @Column(name = "tiene_vistas")
    private boolean tiene_vistas;

    @Column(name = "zona_sombra")
    private boolean zona_sombra;

    @Column(name = "cerca_entrada")
    private boolean cerca_entrada;

    @Column(name = "zona_tranquila")
    private boolean zona_tranquila;

    @Column(name = "estado_parcela")
    @Enumerated(EnumType.STRING)
    private EstadoParcela estado_parcela;


    public Parcela() {
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public double getPrecio_noche() {
        return precio_noche;
    }

    public void setPrecio_noche(double precio_noche) {
        this.precio_noche = precio_noche;
    }

    public boolean isCerca_baño() {
        return cerca_baño;
    }

    public void setCerca_baño(boolean cerca_baño) {
        this.cerca_baño = cerca_baño;
    }

    public boolean isTiene_vistas() {
        return tiene_vistas;
    }

    public boolean isCerca_entrada() {
        return cerca_entrada;
    }

    public boolean isZona_tranquila() {
        return zona_tranquila;
    }

    public void setTiene_vistas(boolean tiene_vistas) {
        this.tiene_vistas = tiene_vistas;
    }

    public boolean isZona_sombra() {
        return zona_sombra;
    }

    public void setZona_sombra(boolean zona_sombra) {
        this.zona_sombra = zona_sombra;
    }

    public TipoParcela getTipo_parcela() {
        return tipo_parcela;
    }

    public void setTipo_parcela(TipoParcela tipo_parcela) {
        this.tipo_parcela = tipo_parcela;
    }

    public EstadoParcela getEstado_parcela() {
        return estado_parcela;
    }

    public void setEstado_parcela(EstadoParcela estado_parcela) {
        this.estado_parcela = estado_parcela;
    }

    public void setCerca_entrada(boolean cerca_entrada) {
        this.cerca_entrada = cerca_entrada;
    }

    public void setZona_tranquila(boolean zona_tranquila) {
        this.zona_tranquila = zona_tranquila;
    }

    @Override
    public String toString() {
        return "Parcela{" +
                "tipo_parcela=" + tipo_parcela +
                ", precio_noche=" + precio_noche +
                ", cerca_baño=" + cerca_baño +
                ", tiene_vistas=" + tiene_vistas +
                ", zona_sombra=" + zona_sombra +
                ", estado_parcela=" + estado_parcela +
                ", id=" + id +
                '}';
    }
}
