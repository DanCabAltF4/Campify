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
    public partial class ucParcelaDatos : UserControl
    {

        public Parcela ParcelaActual { get; private set; }
        public ucParcelaDatos()
        {
            InitializeComponent();
            Limpiar();
        }

        /// <summary>
        /// Muestra los datos de la parcela en el control de usuario.
        /// </summary>
        public void MostrarDatos(Parcela p)
        {
            if (p == null)
            {
                Limpiar();
                return;
            }
            ParcelaActual = p;
            lblId.Text = p.Id.ToString();
            lblTipo.Text = p.Tipo.ToString();
            lblEstado.Text = p.Estado.ToString();
            lblPrecio.Text = $"{p.PrecioNoche} €";
            lblBanosCerca.Text = p.CercaBanos ? "Sí" : "No";
            lblVistas.Text = p.TieneVistas ? "Sí" : "No";
            lblSombra.Text = p.ZonaSombra ? "Sí" : "No";
            lblEntrada.Text = p.CercaEntrada ? "Sí" : "No";
            lblZonaTranquila.Text = p.ZonaTranquila ? "Sí" : "No";
        }

        /// <summary>
        /// Pone en blanco todos los campos del control de usuario cuando no hay parcela seleccionada.
        /// </summary>
        private void Limpiar()
        {
            lblId.Text = "";
            lblTipo.Text = "";
            lblEstado.Text = "";
            lblPrecio.Text = "";
            lblBanosCerca.Text = "";
            lblVistas.Text = "";
            lblSombra.Text = "";
            lblEntrada.Text = "";
            lblZonaTranquila.Text = "";
        }
    }
}