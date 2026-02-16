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
    public partial class ucClienteDatos : UserControl
    {
        public Cliente ClienteActual { get; private set; }


        public ucClienteDatos()
        {
            InitializeComponent();
            Limpiar();
        }

        public void MostrarDatos(Cliente cliente)
        {
            if (cliente == null)
            {
                Limpiar();
                return;
            }
            ClienteActual = cliente;
            lblNombre.Text = cliente.Nombre;
            lblApellidos.Text = cliente.Apellidos;
            lblDni.Text = cliente.Dni.ToString();
            lblTelefono.Text = cliente.Telefono;
            lblFechaNac.Text = cliente.FechaNacimiento.ToShortDateString();
            lblDireccion.Text = $"{cliente.Direccion}, {cliente.CPostal}"
            ;
            lblEmail.Text = cliente.Email;
        }


        public void Limpiar()
        {
            lblNombre.Text = "";
            lblApellidos.Text = "";
            lblDni.Text = "";
            lblTelefono.Text = "";
            lblFechaNac.Text = "";
            lblEmail.Text = "";
            lblDireccion.Text = "";
        }
    }
}
