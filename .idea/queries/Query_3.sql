ALTER TABLE estancia_servicios
    DROP FOREIGN KEY FKekf6mulih86w9g112mrbm1gs6,
    DROP FOREIGN KEY FKi1ejdyfc114wqddbucl4o4fhx;

ALTER TABLE estancia_servicios
    ADD CONSTRAINT FKekf6mulih86w9g112mrbm1gs6
        FOREIGN KEY (id_estancia) REFERENCES estancias(id)
            ON DELETE CASCADE,
    ADD CONSTRAINT FKi1ejdyfc114wqddbucl4o4fhx
        FOREIGN KEY (id_servicio) REFERENCES servicios(id)
            ON DELETE CASCADE;

