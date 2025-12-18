package org.example.service;

import org.example.model.Empleado;
import org.example.model.Estancia;
import org.example.persistence.*;
import org.springframework.stereotype.Service;

@Service
public class ServiceEstancia implements IServiceEstancia{

    private EstanciaRepository repo;
    private ClienteRepository clienteRepo;
    private ServicioRepository servicioRepo;
    private ParcelaRepository parcelaRepo;
    private EmpleadoRepository empleadoRepo;

    public ServiceEstancia(
            EstanciaRepository repo,
            ClienteRepository clienteRepo,
            ServicioRepository servicioRepo,
            ParcelaRepository parcelaRepo,
            EmpleadoRepository empleadoRepo
    ) {
        this.repo = repo;
        this.clienteRepo = clienteRepo;
        this.servicioRepo = servicioRepo;
        this.parcelaRepo = parcelaRepo;
        this.empleadoRepo = empleadoRepo;
    }

    @Override
    public Estancia insert(Estancia estancia) {

        // Parcela
        if (estancia.getParcelas() != null) {
            estancia.setParcelas(
                    parcelaRepo.findById(estancia.getParcelas().getId())
                            .orElseThrow(() -> new RuntimeException("Parcela no existe"))
            );
        }

        // Empleado
        if (estancia.getEmpleados() != null) {
            estancia.setEmpleados(
                    empleadoRepo.findById(estancia.getEmpleados().getId())
                            .orElseThrow(() -> new RuntimeException("Empleado no existe"))
            );
        }


        // Clientes
        if (estancia.getCliente() != null && !estancia.getCliente().isEmpty()) {
            estancia.setCliente(
                    clienteRepo.findAllById(
                            estancia.getCliente().stream().map(c -> c.getId()).toList()
                    )
            );
        }

        // Servicios
        if (estancia.getServicio() != null && !estancia.getServicio().isEmpty()) {
            estancia.setServicio(
                    servicioRepo.findAllById(
                            estancia.getServicio().stream().map(s -> s.getId()).toList()
                    )
            );
        }

        // Guardamos la estancia
        return repo.save(estancia);
    }


    @Override
    public Estancia update(int id, Estancia estancia) {
        Estancia buscada = findById(id);
        if(buscada!=null){
            buscada.setCheckIn(estancia.getCheckIn());
            buscada.setCheckOut(estancia.getCheckOut());
            buscada.setCantidadEquipajeExtra(estancia.getCantidadEquipajeExtra());
            buscada.setCosteMiscelaneo(estancia.getCosteMiscelaneo());
            buscada.setNumeroAdultos(estancia.getNumeroAdultos());
            buscada.setNumeroNinos(estancia.getNumeroNinos());
            buscada.setNumeroMascotas(estancia.getNumeroMascotas());
            buscada.setPrecioFinal(estancia.getPrecioFinal());
            buscada.setTemporada(estancia.getTemporada());
            buscada.setServicio(estancia.getServicio());
            buscada.setCliente(estancia.getCliente());
            buscada.setEmpleados(estancia.getEmpleados());
        }
        return repo.save(buscada);
    }

    @Override
    public void delete(int id) {
        repo.deleteById(id);
    }

    @Override
    public Estancia findById(int id) {
        return repo.findById(id).orElse(null);
    }
}
