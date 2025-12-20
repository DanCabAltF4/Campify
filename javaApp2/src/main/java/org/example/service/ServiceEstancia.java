package org.example.service;

import jakarta.transaction.Transactional;
import org.example.model.Estancia;
import org.example.model.Parcela;
import org.example.model.enums.EstadoParcela;
import org.example.persistence.*;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
@Transactional
public class ServiceEstancia implements IServiceEstancia {

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
        if (estancia.getParcela() != null) {
            Parcela parcela = parcelaRepo.findById(estancia.getParcela().getId())
                    .orElseThrow(() -> new RuntimeException("Parcela no existe"));
            // Cambia el estado de la parcela a ocupada
            parcela.setEstado_parcela(EstadoParcela.RESERVADA);
            parcelaRepo.save(parcela);
            estancia.setParcela(parcela);

        }
        if (estancia.getEmpleado() != null) {
            estancia.setEmpleado(
                    empleadoRepo.findById(estancia.getEmpleado().getId())
                            .orElseThrow(() -> new RuntimeException("Empleado no existe"))
            );
        }
        if (estancia.getClientes() != null && !estancia.getClientes().isEmpty()) {
            var clientesManaged = clienteRepo.findAllById(
                    estancia.getClientes().stream().map(c -> c.getId()).toList()
            );
            estancia.getClientes().clear();
            clientesManaged.forEach(estancia::addCliente);
        }

        // Servicios (gestión ManyToMany)
        if (estancia.getServicios() != null && !estancia.getServicios().isEmpty()) {
            var serviciosManaged = servicioRepo.findAllById(
                    estancia.getServicios().stream().map(s -> s.getId()).toList()
            );
            estancia.getServicios().clear();         // Limpiamos la lista original
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
        if (estancia.getParcela() != null) {
            buscada.setParcela(
                    parcelaRepo.findById(estancia.getParcela().getId())
                            .orElseThrow(() -> new RuntimeException("Parcela no existe"))
            );
        }

        // Empleado
        if (estancia.getEmpleado() != null) {
            buscada.setEmpleado(
                    empleadoRepo.findById(estancia.getEmpleado().getId())
                            .orElseThrow(() -> new RuntimeException("Empleado no existe"))
            );
        }

        // Clientes
        if (estancia.getClientes() != null) {
            buscada.getClientes().clear();
            var clientesManaged = clienteRepo.findAllById(
                    estancia.getClientes().stream().map(c -> c.getId()).toList()
            );
            clientesManaged.forEach(buscada::addCliente);
        }

        // Servicios
        if (estancia.getServicios() != null) {
            buscada.getServicios().clear();
            var serviciosManaged = servicioRepo.findAllById(
                    estancia.getServicios().stream().map(s -> s.getId()).toList()
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

    public List<Estancia> findAll() {
        return repo.findAll();
    }
}
