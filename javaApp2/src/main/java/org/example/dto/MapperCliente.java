package org.example.dto;

import org.example.dto.DtoCliente;
import org.example.model.Cliente;

public final class MapperCliente {

    private MapperCliente() {}

    public static DtoCliente toDto(Cliente c) {
        if (c == null) return null;

        return new DtoCliente(
                c.getId(),
                c.getNombre(),
                c.getApellidos(),
                c.getDni(),
                c.getDireccion(),
                c.getcPostal(),
                c.getFechaNacimiento(),
                c.getEmail(),
                c.getTelefono()
        );
    }

    public static Cliente toEntity(DtoCliente dto) {
        if (dto == null) return null;

        Cliente c = new Cliente();
        if (dto.id() != null) c.setId(dto.id());

        c.setNombre(dto.nombre());
        c.setApellidos(dto.apellidos());
        c.setDni(dto.dni());
        c.setDireccion(dto.direccion());
        c.setcPostal(dto.cPostal());
        c.setFechaNacimiento(dto.fechaNacimiento());
        c.setEmail(dto.email());
        c.setTelefono(dto.telefono());

        return c;
    }
}
