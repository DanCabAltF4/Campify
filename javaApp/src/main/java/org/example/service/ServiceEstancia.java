package org.example.service;

import jakarta.transaction.Transactional;
import org.example.model.Cliente;
import org.example.model.Estancia;
import org.example.model.Parcela;
import org.example.model.enums.EstadoParcela;
import org.example.persistence.*;
import org.springframework.stereotype.Service;

import java.time.LocalDate;
import java.time.Period;
import java.util.List;

@Service
@Transactional
public class ServiceEstancia implements IServiceEstancia {

    private final EstanciaRepository repo;
    private final ClienteRepository clienteRepo;
    private final ServicioRepository servicioRepo;
    private final ParcelaRepository parcelaRepo;
    private final EmpleadoRepository empleadoRepo;
    private final ServicePdfClientes servicePdf;

    public ServiceEstancia(
            EstanciaRepository repo,
            ClienteRepository clienteRepo,
            ServicioRepository servicioRepo,
            ParcelaRepository parcelaRepo,
            EmpleadoRepository empleadoRepo,
            ServicePdfClientes servicePdf
    ) {
        this.repo = repo;
        this.clienteRepo = clienteRepo;
        this.servicioRepo = servicioRepo;
        this.parcelaRepo = parcelaRepo;
        this.empleadoRepo = empleadoRepo;
        this.servicePdf = servicePdf;
    }

    @Override
    public Estancia insert(Estancia estancia) {
        if (estancia.getParcela() != null) {
            Parcela parcela = parcelaRepo.findById(estancia.getParcela().getId())
                    .orElseThrow(() -> new RuntimeException("Parcela no existe"));
            // Cambia el estado de la parcela a ocupada
            cambiarEstadoParcela(estancia, parcela);
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
        recalcularNumAdultosYNinos(estancia);

        // Servicios (gestión ManyToMany)
        if (estancia.getServicios() != null && !estancia.getServicios().isEmpty()) {
            var serviciosManaged = servicioRepo.findAllById(
                    estancia.getServicios().stream().map(s -> s.getId()).toList()
            );
            estancia.getServicios().clear();         // Limpiamos la lista original
            serviciosManaged.forEach(estancia::addServicio);
        }

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
        recalcularNumAdultosYNinos(buscada);

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

    // -------------------
    // METODOS PRIVADOS
    // -------------------

    // Cambia el estado de parcela a RESERVADO si hoy esta entre checkin y checkout
    private void cambiarEstadoParcela(Estancia estancia, Parcela parcela) {
        LocalDate hoy = LocalDate.now();
        LocalDate checkin = estancia.getCheckIn();
        LocalDate checkout = estancia.getCheckOut();

        boolean ocupada;
        if (checkout != null) {
            ocupada = !hoy.isBefore(checkin) && hoy.isBefore(checkout);
        } else {
            ocupada = !hoy.isBefore(checkin);
        }

        if (ocupada) {
            parcela.setEstado_parcela(EstadoParcela.RESERVADA);
            parcelaRepo.save(parcela);
        }
    }

    //Calcula el numero de adultos y de niños en la fecha de checkin
    private void recalcularNumAdultosYNinos(Estancia estancia) {
        LocalDate checkin = estancia.getCheckIn();
        int adultos = 0;
        int ninos = 0;

        if (estancia.getClientes() != null) {
            for (Cliente c : estancia.getClientes()) {
                LocalDate fechaNac = c.getFechaNacimiento();
                int edad = Period.between(fechaNac, checkin).getYears();
                if (edad >= 18) adultos++;
                else ninos++;
            }
        }
        estancia.setNumeroAdultos(adultos);
        estancia.setNumeroNinos(ninos);
    }


    // Genera y devuelve un archivo pdf con la información de los clientes de una estancia
    public byte[] generarPdfClientes(int id) {
        Estancia estancia = repo.findById(id).orElseThrow(() -> new RuntimeException("Estancia no encontrada"));
        return servicePdf.buildClientesPdf(estancia);
    }
}













