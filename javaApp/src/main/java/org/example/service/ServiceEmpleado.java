package org.example.service;

import org.example.model.Empleado;
import org.example.persistence.EmpleadoRepository;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ServiceEmpleado implements IServiceEmpleado{

    private EmpleadoRepository repo;
    private final PasswordEncoder encoder;

    public ServiceEmpleado(EmpleadoRepository repo, PasswordEncoder encoder) {
        this.repo = repo;
        this.encoder = encoder;
    }

    @Override
    public Empleado insert(Empleado empleado) {
        empleado.setPassword(encoder.encode(empleado.getPassword()));
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
            buscado.setActivo(empleado.isActivo());
            buscado.setPuesto(empleado.getPuesto());
            buscado.setEmail(empleado.getEmail());

            String passNueva = empleado.getPassword();
            if (passNueva != null && !passNueva.isBlank()) {
                buscado.setPassword(encoder.encode(passNueva));
            }

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
