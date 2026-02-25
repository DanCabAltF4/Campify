package org.example.dto;

import org.example.model.Empleado;
import org.example.model.Estancia;
import org.example.model.Parcela;

public final class MapperEstancia {

    private MapperEstancia() {}

    public static DtoEstancia toDto(Estancia e) {
        if (e == null) return null;

        Integer parcelaId = (e.getParcela() != null) ? e.getParcela().getId() : null;
        Integer empleadoId = (e.getEmpleado() != null) ? e.getEmpleado().getId() : null;

        return new DtoEstancia(
                e.getId(),
                e.getCheckIn(),
                e.getCheckOut(),
                e.getTemporada(),
                e.getNumeroAdultos(),
                e.getNumeroNinos(),
                e.getNumeroMascotas(),
                e.getCantidadEquipajeExtra(),
                e.getCosteMiscelaneo(),
                e.getPrecioFinal(),
                parcelaId,
                empleadoId
        );
    }

    public static Estancia toEntity(DtoEstancia dto, Parcela parcelaResuelta, Empleado empleadoResuelto) {
        if (dto == null) return null;

        Estancia e = new Estancia();
        if (dto.id() != null) e.setId(dto.id());

        e.setCheckIn(dto.checkIn());
        e.setCheckOut(dto.checkOut());
        e.setTemporada(dto.temporada());
        if (dto.numeroAdultos() != null) e.setNumeroAdultos(dto.numeroAdultos());
        if (dto.numeroNinos() != null) e.setNumeroNinos(dto.numeroNinos());
        if (dto.numeroMascotas() != null) e.setNumeroMascotas(dto.numeroMascotas());
        if (dto.cantidadEquipajeExtra() != null) e.setCantidadEquipajeExtra(dto.cantidadEquipajeExtra());
        if (dto.costeMiscelaneo() != null) e.setCosteMiscelaneo(dto.costeMiscelaneo());
        if (dto.precioFinal() != null) e.setPrecioFinal(dto.precioFinal());

        e.setParcela(parcelaResuelta);
        e.setEmpleado(empleadoResuelto);
        return e;
    }
}
