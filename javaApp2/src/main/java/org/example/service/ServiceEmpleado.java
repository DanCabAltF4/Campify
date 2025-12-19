package org.example.service;

import org.example.model.Empleado;
import org.example.persistence.EmpleadoRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ServiceEmpleado implements IServiceEmpleado{

    private EmpleadoRepository repo;

    public ServiceEmpleado(EmpleadoRepository repo) {
        this.repo = repo;
    }

    @Override
    public Empleado insert(Empleado empleado) {
        return repo.save(empleado);
    }

    @Override
    public Empleado update(int id, Empleado empleado) {
        Empleado buscado = findById(id);
        if(buscado!=null){
            buscado.setNombre(empleado.getNombre());
            buscado.setApellidos(empleado.getApellidos());
            buscado.setDni(empleado.getDni());
            buscado.setTelefono(empleado.getTelefono());
            buscado.setId(empleado.getId());
            buscado.setActivo(empleado.isActivo());
            buscado.setPuesto(empleado.getPuesto());
            buscado = repo.save(buscado);
        }
        return buscado;
    }

    @Override
    public void delete(int id) {
        repo.deleteById(id);
    }

    @Override
    public Empleado findById(int id) {
        return repo.findById(id).orElse(null);
    }

    public List<Empleado> findAll() {
        return repo.findAll();
    }
}
