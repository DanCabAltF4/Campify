package org.example.service;

import org.example.model.Servicio;
import org.example.persistence.ServicioRepository;
import org.springframework.stereotype.Service;

@Service
public class ServiceServicio implements IServiceServicio{

    private ServicioRepository repo;

    public ServiceServicio(ServicioRepository repo){
        this.repo=repo;
    }

    @Override
    public Servicio insert(Servicio servicio) {
        return repo.save(servicio);
    }

    @Override
    public Servicio update(int id, Servicio nuevo) {
        Servicio buscado= findById(id);
        if(buscado!=null){
            buscado.setNombre(nuevo.getNombre());
            buscado.setDescripcion(nuevo.getDescripcion());
            buscado.setPrecio(nuevo.getPrecio());
            buscado=repo.save(buscado);
        }
        return buscado;
    }

    @Override
    public void delete(int id) {
        repo.deleteById(id);
    }

    @Override
    public Servicio findById(int id) {
        return repo.findById(id).orElse(null);
    }
}
