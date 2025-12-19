package org.example.service;

import org.example.model.Parcela;
import org.example.persistence.ParcelaRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ServiceParcela implements  IServiceParcela{

    private ParcelaRepository repo;

    public ServiceParcela(ParcelaRepository repo) {
        this.repo = repo;
    }

    @Override
    public Parcela insert(Parcela parcela) {
        return repo.save(parcela);
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
            repo.save(buscada);
        }
        return buscada;
    }

    @Override
    public void delete(int id) {
        Parcela buscada = findById(id);
        if(buscada!=null){
            repo.delete(buscada);
        }
    }

    @Override
    public Parcela findById(int id) {
        Parcela parcela = repo.findById(id).orElse(null);
        return parcela;
    }

    public List<Parcela> findAll() {
        return repo.findAll();
    }
}
