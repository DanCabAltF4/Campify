using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
        [JsonPropertyName("apellidos")]
        public string Apellidos { get; set; }
        [JsonPropertyName("dni")]
        public string Dni { get; set; }
        [JsonPropertyName("direccion")]
        public string Direccion { get; set; }
        [JsonPropertyName("cPostal")]
        public string CPostal { get; set; }
        [JsonPropertyName("fechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("telefono")]
        public string Telefono { get; set; }

        public Cliente()
        {
        }

        public Cliente( string nombre, string apellidos, string dni, string direccion, string cPostal, DateTime fechaNacimiento, string email, string telefono)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Dni = dni;
            Direccion = direccion;
            CPostal = cPostal;
            FechaNacimiento = fechaNacimiento;
            Email = email;
            Telefono = telefono;
        }
    }
}
