using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class ucEmpleadoDatos : UserControl
    {

        public Empleado EmpleadoActual { get; private set; }

        public ucEmpleadoDatos()
        {
            InitializeComponent();
            Limpiar();
        }


        /// <summary>
        /// Muestra los datos del empleado pasado como parametro en el control de usuario.
        /// </summary>
        public void MostrarDatos(Empleado e)
        {
            if (e == null)
            {
                Limpiar();
                return;
            }
            EmpleadoActual = e;
            lblId.Text = e.Id.ToString();
            lblNombre.Text = e.Nombre;
            lblApellidos.Text = e.Apellidos;
            lblPuesto.Text = e.Puesto.ToString();
            lblActivo.Text = e.Activo ? "Sí" : "No";
            lblDni.Text = e.Dni;
            lblTelefono.Text = e.Telefono;
        }


        public void Limpiar()
        {
            lblId.Text = "";
            lblNombre.Text = "";
            lblApellidos.Text = "";
            lblPuesto.Text = "";
            lblActivo.Text = "";
            lblDni.Text = "";
            lblTelefono.Text = "";
        }
    }
}
