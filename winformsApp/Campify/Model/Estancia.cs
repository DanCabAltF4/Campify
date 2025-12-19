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

        [JsonPropertyName("check_in")]
        public DateTime CheckIn { get; set; }

        [JsonPropertyName("check_out")]
        public DateTime CheckOut { get; set; }

        [JsonPropertyName("temporada")]
        public EnumTemporadas Temporada { get; set; }

        [JsonPropertyName("numero_adultos")]
        public int NumeroAdultos { get; set; }

        [JsonPropertyName("numero_niños")]
        public int NumeroNinos { get; set; }

        [JsonPropertyName("numero_mascotas")]
        public int NumeroMascotas { get; set; }

        [JsonPropertyName("cantidad_equipaje_extra")]
        public double CargoEquipajeExtra { get; set; }

        [JsonPropertyName("coste_miscelaneo")]
        public double CargoAdicional { get; set; }

        [JsonPropertyName("precio_final")]
        public double PrecioFinal { get; set; }

        [JsonPropertyName("id_parcela")]
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
