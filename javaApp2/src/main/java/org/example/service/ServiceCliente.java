package org.example.service;

import org.example.model.Cliente;
import org.example.persistence.ClienteRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ServiceCliente implements IServiceCliente {

    private ClienteRepository repo;

    public ServiceCliente(ClienteRepository repo){
        this.repo=repo;
    }

    @Override
    public Cliente insert(Cliente cliente) {
        return repo.save(cliente);
    }

    @Override
    public Cliente update(int id, Cliente nuevo) {
        Cliente buscado = findById(id);
        if(buscado!=null){
            buscado.setNombre(nuevo.getNombre());
            buscado.setApellidos(nuevo.getApellidos());
            buscado.setDni(nuevo.getDni());
            buscado.setDireccion(nuevo.getDireccion());
            buscado.setcPostal(nuevo.getcPostal());
            buscado.setFechaNacimiento(nuevo.getFechaNacimiento());
            buscado.setEmail(nuevo.getEmail());
            buscado.setTelefono(nuevo.getTelefono());
            buscado= repo.save(buscado);
        }
        return buscado;
    }

    @Override
    public void delete(int id) {
        repo.deleteById(id);
    }

    @Override
    public Cliente findById(int id) {
        return repo.findById(id).orElse(null);
    }

    public List<Cliente> findAll(){
        return repo.findAll();
    }
}
