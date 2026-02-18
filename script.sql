drop database if exists campifydb;
create database campifydb;
use campifydb;

-- =========================
-- CLIENTES (USUARIOS LOGIN)
-- =========================

create table clientes
(
    id               int auto_increment primary key,
    fecha_nacimiento date         not null,
    nombre           varchar(50)  not null,
    apellidos        varchar(100) not null,
    email            varchar(100) not null,
    direccion        varchar(150) not null,
    c_postal         char(5)      not null,
    dni              char(9)      not null unique,
    telefono         char(9)      null
);

-- =========================
-- EMPLEADOS
-- =========================

create table empleado
(
    id        int auto_increment primary key,
    activo    bit not null,
    nombre    varchar(50) not null,
    apellidos varchar(100) not null,
    dni       char(9) not null unique,
    telefono  char(9) null,
    email     varchar(50) not null,
    password  varchar(60) not null,
    puesto    enum ('ADMINISTRADOR', 'CAMPO', 'RECEPCIONISTA') not null
);

-- =========================
-- PARCELAS
-- =========================

create table parcelas
(
    id             int auto_increment primary key,
    cerca_baño     bit null,
    cerca_entrada  bit not null,
    precio_noche   double null,
    tiene_vistas   bit null,
    zona_sombra    bit null,
    zona_tranquila bit not null,
    estado_parcela enum ('INTERESADO', 'LIBRE', 'MANTENIMIENTO', 'RESERVADA') null,
    tipo_parcela   enum ('NORMAL', 'SEMIPARCELA') null
);

-- =========================
-- ESTANCIAS
-- =========================

create table estancias
(
    id                      int auto_increment primary key,
    cantidad_equipaje_extra double null,
    check_in                date not null,
    check_out               date null,
    coste_miscelaneo        double null,
    id_empleado             int null,
    id_parcela              int null,
    numero_adultos          int not null,
    numero_mascotas         int null,
    numero_niños            int null,
    precio_final            double null,
    temporada               enum ('ALTA', 'BAJA', 'MEDIA') not null,

    constraint fk_estancia_empleado
        foreign key (id_empleado)
            references empleado (id)
            on update cascade
            on delete cascade,

    constraint fk_estancia_parcela
        foreign key (id_parcela)
            references parcelas (id)
            on update cascade
            on delete cascade
);

-- =========================
-- RELACION CLIENTES - ESTANCIA
-- =========================

create table clientes_estancia
(
    id_cliente  int not null,
    id_estancia int not null,

    constraint fk_cliente_estancia_cliente
        foreign key (id_cliente)
            references clientes (id)
            on update cascade
            on delete cascade,

    constraint fk_cliente_estancia_estancia
        foreign key (id_estancia)
            references estancias (id)
            on update cascade
            on delete cascade
);

-- =========================
-- SERVICIOS
-- =========================

create table servicios
(
    id          int auto_increment primary key,
    precio      decimal(10,2) not null,
    nombre      varchar(100) not null,
    descripcion varchar(255) null
);

-- =========================
-- RELACION ESTANCIA - SERVICIOS
-- =========================

create table estancia_servicios
(
    id_estancia int not null,
    id_servicio int not null,

    constraint fk_estancia_servicio_estancia
        foreign key (id_estancia)
            references estancias (id)
            on update cascade
            on delete cascade,

    constraint fk_estancia_servicio_servicio
        foreign key (id_servicio)
            references servicios (id)
            on update cascade
            on delete cascade
);

-- =========================
-- DATOS DE PRUEBA
-- =========================

-- CLIENTES (sin password)
insert into clientes (fecha_nacimiento, nombre, apellidos, email, direccion, c_postal, dni, telefono) values
('1990-05-14', 'Carlos', 'Gómez Ruiz', 'carlos@email.com', 'Calle Mayor 12', '39001', '12345678A', '600123456'),
('1985-11-02', 'Laura', 'Fernández Díaz', 'laura@email.com', 'Av. Cantabria 45', '39005', '87654321B', '611987654'),
('2000-08-22', 'Miguel', 'Inglés Pérez', 'miguel@email.com', 'Calle Montaña 7', '39300', '11223344C', '622334455');


-- EMPLEADOS (con email + password)
-- IMPORTANTE: sustituye estos hashes por los tuyos reales de BCrypt
insert into empleado (activo, nombre, apellidos, dni, telefono, email, password, puesto) values
(1, 'Ana',    'Martínez López', '99887766D', '633445566', 'ana@campify.com',
 '$2a$10$uG9m7mZf3Q4b7o3mH0YcMe6Z7r5vC8f8g4CzQv8bQvPZlF4Zk7QnK', 'ADMINISTRADOR'),
(1, 'Javier', 'Santos Pérez',   '88776655E', '644556677', 'javier@campify.com',
 '$2a$10$uG9m7mZf3Q4b7o3mH0YcMe6Z7r5vC8f8g4CzQv8bQvPZlF4Zk7QnK', 'RECEPCIONISTA'),
(1, 'Lucía',  'Ortega Ramos',   '77665544F', '655667788', 'lucia@campify.com',
 '$2a$10$uG9m7mZf3Q4b7o3mH0YcMe6Z7r5vC8f8g4CzQv8bQvPZlF4Zk7QnK', 'CAMPO');


-- PARCELAS
insert into parcelas (cerca_baño, cerca_entrada, precio_noche, tiene_vistas, zona_sombra, zona_tranquila, estado_parcela, tipo_parcela) values
(1, 1, 25.00, 1, 1, 1, 'LIBRE', 'NORMAL'),
(0, 0, 18.00, 0, 1, 1, 'LIBRE', 'SEMIPARCELA'),
(1, 0, 30.00, 1, 0, 0, 'RESERVADA', 'NORMAL');


-- ESTANCIAS
insert into estancias (cantidad_equipaje_extra, check_in, check_out, coste_miscelaneo, id_empleado, id_parcela,
                       numero_adultos, numero_mascotas, numero_niños, precio_final, temporada)
values
(2, '2026-07-10', '2026-07-15', 15.00, 2, 1, 2, 1, 0, 150.00, 'ALTA'),
(1, '2026-03-05', '2026-03-07',  5.00, 2, 2, 2, 0, 1,  70.00, 'MEDIA'),
(0, '2026-01-12', '2026-01-14',  0.00, 3, 3, 1, 0, 0,  60.00, 'BAJA');


-- CLIENTES_ESTANCIA
insert into clientes_estancia (id_cliente, id_estancia) values
(1, 1),
(2, 2),
(3, 3);


-- SERVICIOS
insert into servicios (precio, nombre, descripcion) values
(5.00, 'Electricidad', 'Conexión eléctrica'),
(3.50, 'Ducha caliente', 'Acceso a duchas'),
(10.00, 'Lavandería', 'Servicio completo');


-- ESTANCIA_SERVICIOS
insert into estancia_servicios (id_estancia, id_servicio) values
(1, 1),
(1, 2),
(2, 2),
(3, 3);
