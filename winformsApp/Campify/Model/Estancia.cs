using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Estancia
    {
        public int Id { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public EnumTemporadas Temporada { get; set; }
        public int NumeroAdultos { get; set; }
        public int NumeroNinos { get; set; }
        public int NumeroMascotas { get; set; }
        public double CargoEquipajeExtra { get; set; }
        public double CargoAdicional { get; set; }
        public double PrecioFinal { get; set; }
        public Parcela Parcela { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Servicio> Servicios { get; set; }

        public Estancia(int id, DateTime checkIn, DateTime checkOut, EnumTemporadas temporada, int numeroAdultos, int numeroNinos, int numeroMascotas, double cargoEquipajeExtra, double cargoAdicional, double precioFinal, Parcela parcela, List<Cliente> clientes, List<Servicio> servicios)
        {
            Id = id;
            CheckIn = checkIn;
            CheckOut = checkOut;
            Temporada = temporada;
            NumeroAdultos = numeroAdultos;
            NumeroNinos = numeroNinos;
            NumeroMascotas = numeroMascotas;
            CargoEquipajeExtra = cargoEquipajeExtra;
            CargoAdicional = cargoAdicional;
            PrecioFinal = precioFinal;
            Parcela = parcela;
            Clientes = clientes;
            Servicios = servicios;
        }
    }
}
