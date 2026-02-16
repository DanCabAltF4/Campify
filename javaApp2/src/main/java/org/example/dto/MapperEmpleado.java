package org.example.dto;

import org.example.model.Empleado;

public final class MapperEmpleado {

    private MapperEmpleado() {}

    public static DtoEmpleado toDto(Empleado e) {
        if (e == null) return null;

        return new DtoEmpleado(
                e.getId(),
                e.getNombre(),
                e.getApellidos(),
                e.getDni(),
                e.getTelefono(),
                e.getPuesto(),
                e.isActivo()
        );
    }

    public static Empleado toEntity(DtoEmpleado dto) {
        if (dto == null) return null;

        Empleado e = new Empleado();
        if (dto.id() != null) e.setId(dto.id());

        e.setNombre(dto.nombre());
        e.setApellidos(dto.apellidos());
        e.setDni(dto.dni());
        e.setTelefono(dto.telefono());
        e.setPuesto(dto.puesto());
        if (dto.activo() != null) e.setActivo(dto.activo());

        return e;
    }
}
