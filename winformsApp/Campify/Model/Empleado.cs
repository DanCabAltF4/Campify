using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Model
{
    public class Empleado
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
        [JsonPropertyName("apellidos")]
        public string Apellidos { get; set; }
        [JsonPropertyName("dni")]
        public string Dni { get; set; }
        [JsonPropertyName("telefono")]
        public string Telefono { get; set; }
        [JsonPropertyName("puesto")]
        public EnumPuestos Puesto { get; set; } 
        [JsonPropertyName("activo")]
        public bool Activo { get; set; }


        public Empleado(int id, string nombre, string apellidos, string dni, string telefono, EnumPuestos puesto, bool activo)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Dni = dni;
            Telefono = telefono;
            Puesto = puesto;
            Activo = activo;
        }
    }
}
