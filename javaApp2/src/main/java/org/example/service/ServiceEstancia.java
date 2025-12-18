package org.example.service;

import jakarta.transaction.Transactional;
import org.example.model.Empleado;
import org.example.model.Estancia;
import org.example.persistence.*;
import org.springframework.stereotype.Service;

@Service
@Transactional
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


        if (estancia.getParcelas() != null) {
            estancia.setParcelas(
                    parcelaRepo.findById(estancia.getParcelas().getId())
                            .orElseThrow(() -> new RuntimeException("Parcela no existe"))
            );
        }

        if (estancia.getEmpleados() != null) {
            estancia.setEmpleados(
                    empleadoRepo.findById(estancia.getEmpleados().getId())
                            .orElseThrow(() -> new RuntimeException("Empleado no existe"))
            );
        }

        if (estancia.getCliente() != null && !estancia.getCliente().isEmpty()) {
            var clientesManaged = clienteRepo.findAllById(
                    estancia.getCliente().stream().map(c -> c.getId()).toList()
            );
            estancia.getCliente().clear();
            clientesManaged.forEach(estancia::addCliente);
        }

        // Servicios (gestión ManyToMany)
        if (estancia.getServicio() != null && !estancia.getServicio().isEmpty()) {
            var serviciosManaged = servicioRepo.findAllById(
                    estancia.getServicio().stream().map(s -> s.getId()).toList()
            );
            estancia.getServicio().clear();         // Limpiamos la lista original
            serviciosManaged.forEach(estancia::addServicio);
        }

        // Guardamos la estancia (Hibernate maneja cascadas si están configuradas)
        return repo.save(estancia);
    }




    @Override
    public Estancia update(int id, Estancia estancia) {
        Estancia buscada = findById(id);
        if (buscada == null) {
            throw new RuntimeException("Estancia no encontrada");
        }

        // Campos simples
        buscada.setCheckIn(estancia.getCheckIn());
        buscada.setCheckOut(estancia.getCheckOut());
        buscada.setCantidadEquipajeExtra(estancia.getCantidadEquipajeExtra());
        buscada.setCosteMiscelaneo(estancia.getCosteMiscelaneo());
        buscada.setNumeroAdultos(estancia.getNumeroAdultos());
        buscada.setNumeroNinos(estancia.getNumeroNinos());
        buscada.setNumeroMascotas(estancia.getNumeroMascotas());
        buscada.setPrecioFinal(estancia.getPrecioFinal());
        buscada.setTemporada(estancia.getTemporada());

        // Parcela
        if (estancia.getParcelas() != null) {
            buscada.setParcelas(
                    parcelaRepo.findById(estancia.getParcelas().getId())
                            .orElseThrow(() -> new RuntimeException("Parcela no existe"))
            );
        }

        // Empleado
        if (estancia.getEmpleados() != null) {
            buscada.setEmpleados(
                    empleadoRepo.findById(estancia.getEmpleados().getId())
                            .orElseThrow(() -> new RuntimeException("Empleado no existe"))
            );
        }

        // Clientes
        if (estancia.getCliente() != null) {
            buscada.getCliente().clear();
            var clientesManaged = clienteRepo.findAllById(
                    estancia.getCliente().stream().map(c -> c.getId()).toList()
            );
            clientesManaged.forEach(buscada::addCliente);
        }

        // Servicios
        if (estancia.getServicio() != null) {
            buscada.getServicio().clear();
            var serviciosManaged = servicioRepo.findAllById(
                    estancia.getServicio().stream().map(s -> s.getId()).toList()
            );
            serviciosManaged.forEach(buscada::addServicio);
        }

        return repo.save(buscada);
    }


    @Override
    public void delete(int id) {
        repo.deleteById(id);
    }

    @Override
    public Estancia findById(int id) {
        Estancia estancia = repo.findById(id).orElse(null);
        return estancia;
    }
}
