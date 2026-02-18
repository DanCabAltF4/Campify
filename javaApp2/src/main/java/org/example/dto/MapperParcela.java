package org.example.dto;

import org.example.model.Parcela;

public final class MapperParcela {

    private MapperParcela() {}

    public static DtoParcela toDto(Parcela p) {
        if (p == null) return null;

        return new DtoParcela(
                p.getId(),
                p.getTipo_parcela(),
                p.getPrecio_noche(),
                p.isCerca_baño(),
                p.isTiene_vistas(),
                p.isZona_sombra(),
                p.isCerca_entrada(),
                p.isZona_tranquila(),
                p.getEstado_parcela()
        );
    }

    public static Parcela toEntity(DtoParcela dto) {
        if (dto == null) return null;

        Parcela p = new Parcela();
        if (dto.id() != null) p.setId(dto.id());

        p.setTipo_parcela(dto.tipoParcela());
        if (dto.precioNoche() != null) p.setPrecio_noche(dto.precioNoche());
        if (dto.cercaBano() != null) p.setCerca_baño(dto.cercaBano());
        if (dto.tieneVistas() != null) p.setTiene_vistas(dto.tieneVistas());
        if (dto.zonaSombra() != null) p.setZona_sombra(dto.zonaSombra());
        if (dto.cercaEntrada() != null) p.setCerca_entrada(dto.cercaEntrada());
        if (dto.zonaTranquila() != null) p.setZona_tranquila(dto.zonaTranquila());

        p.setEstado_parcela(dto.estadoParcela());
        return p;
    }
}
