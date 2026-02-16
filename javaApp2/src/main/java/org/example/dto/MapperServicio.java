package org.example.dto;

import org.example.model.Servicio;

public final class MapperServicio {

    private MapperServicio() {}

    public static DtoServicio toDto(Servicio s) {
        if (s == null) return null;

        return new DtoServicio(
                s.getId(),
                s.getNombre(),
                s.getDescripcion(),
                s.getPrecio()
        );
    }

    public static Servicio toEntity(DtoServicio dto) {
        if (dto == null) return null;

        Servicio s = new Servicio();
        if (dto.id() != null) s.setId(dto.id());

        s.setNombre(dto.nombre());
        s.setDescripcion(dto.descripcion());
        if (dto.precio() != null) s.setPrecio(dto.precio());

        return s;
    }
}
