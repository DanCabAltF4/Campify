package org.example.service;

import org.example.model.Estancia;
import org.example.model.Parcela;
import org.example.model.enums.EstadoParcela;
import org.example.persistence.EstanciaRepository;
import org.example.persistence.ParcelaRepository;
import org.springframework.stereotype.Service;

import java.time.LocalDate;
import java.util.List;

@Service
public class ServiceParcela implements  IServiceParcela{

    private ParcelaRepository repoParcela;
    private EstanciaRepository repoEstancia;

    public ServiceParcela(ParcelaRepository repoParcela, EstanciaRepository repoEstancia) {
        this.repoParcela = repoParcela;
        this.repoEstancia= repoEstancia;
    }

    @Override
    public Parcela insert(Parcela parcela) {
        return repoParcela.save(parcela);
    }

    @Override
    public Parcela update(int id, Parcela parcela) {
        Parcela buscada = findById(id);
        if(buscada!=null){
            buscada.setEstado_parcela(parcela.getEstado_parcela());
            buscada.setTipo_parcela(parcela.getTipo_parcela());
            buscada.setCerca_baño(parcela.isCerca_baño());
            buscada.setTiene_vistas(parcela.isTiene_vistas());
            buscada.setPrecio_noche(parcela.getPrecio_noche());
            buscada.setZona_sombra(parcela.isZona_sombra());
            repoParcela.save(buscada);
        }
        return buscada;
    }

    @Override
    public void delete(int id) {
        Parcela buscada = findById(id);
        if(buscada!=null){
            repoParcela.delete(buscada);
        }
    }

    @Override
    public Parcela findById(int id) {
        Parcela parcela = repoParcela.findById(id).orElse(null);
        return parcela;
    }

    public List<Parcela> findAll() {
        List<Parcela> parcelas = repoParcela.findAll();
        List<Estancia> estancias = repoEstancia.findAll();
        comprobarEstadoParcelas(parcelas, estancias);
        return repoParcela.findAll();
    }


    /*
        Comprueba las estancias de cada parcela para cambiar su estado a LIBRE o RESERVADO en la fecha de consulta
     */
    private void comprobarEstadoParcelas(List<Parcela> parcelas, List<Estancia> estancias) {
        LocalDate hoy = LocalDate.now();
        for(Parcela parcela : parcelas){
            boolean ocupadaHoy= false;
            for(Estancia estancia : estancias){
                if(parcela.getId() == estancia.getParcela().getId()){
                    LocalDate checkin = estancia.getCheckIn();
                    LocalDate checkout = estancia.getCheckOut();
                    if(checkout == null){
                        ocupadaHoy = !hoy.isBefore(checkin);
                    }else{
                        ocupadaHoy = !hoy.isBefore(checkin) && hoy.isBefore(checkout);
                    }
                    if(ocupadaHoy){
                        break;
                    }
                }
            }
            EstadoParcela nuevoEstado = ocupadaHoy ? EstadoParcela.RESERVADA : EstadoParcela.LIBRE;
            if(parcela.getEstado_parcela() != nuevoEstado){
                parcela.setEstado_parcela(nuevoEstado);
                repoParcela.save(parcela);
            }
        }
    }
}
