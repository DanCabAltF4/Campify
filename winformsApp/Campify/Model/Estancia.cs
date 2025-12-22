using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Model
{
    public class Estancia
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("checkIn")]
        public DateOnly CheckIn { get; set; }

        [JsonPropertyName("checkOut")]
        public DateOnly? CheckOut { get; set; }

        [JsonPropertyName("temporada")]
        public EnumTemporadas Temporada { get; set; }

        [JsonPropertyName("numeroAdultos")]
        public int NumeroAdultos { get; set; }

        [JsonPropertyName("numeroNinos")]
        public int NumeroNinos { get; set; }

        [JsonPropertyName("numeroMascotas")]
        public int NumeroMascotas { get; set; }

        [JsonPropertyName("cantidadEquipajeExtra")]
        public double CantidadEquipajeExtra { get; set; }

        [JsonPropertyName("costeMiscelaneo")]
        public double CargoAdicional { get; set; }

        [JsonPropertyName("precioFinal")]
        public double PrecioFinal { get; set; }

        [JsonPropertyName("parcela")]
        public Parcela Parcela { get; set; }

        [JsonPropertyName("empleado")]
        public Empleado Empleado { get; set; }

        [JsonPropertyName("clientes")]
        public List<Cliente> Clientes { get; set; }

        [JsonPropertyName("servicios")]
        public List<Servicio>? Servicios { get; set; }


        public Estancia()
        {
            Clientes = new List<Cliente>();
            Servicios = new List<Servicio>();
        }

        public Estancia(int id, DateOnly checkIn, DateOnly? checkOut, EnumTemporadas temporada, int numeroAdultos, int numeroNinos, int numeroMascotas, double cargoEquipajeExtra, double cargoAdicional, double precioFinal, Parcela parcela, List<Cliente> clientes, List<Servicio> servicios)
        {
            Id = id;
            CheckIn = checkIn;
            CheckOut = checkOut;
            Temporada = temporada;
            NumeroAdultos = numeroAdultos;
            NumeroNinos = numeroNinos;
            NumeroMascotas = numeroMascotas;
            CantidadEquipajeExtra = cargoEquipajeExtra;
            CargoAdicional = cargoAdicional;
            PrecioFinal = precioFinal;
            Parcela = parcela;
            Clientes = clientes;
            Servicios = servicios;
        }
    }
}
