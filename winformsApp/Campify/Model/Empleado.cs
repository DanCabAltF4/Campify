using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public EnumPuestos Puesto { get; set; }
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
