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
    public partial class ucClientesLista : UserControl
    {

        public Cliente Cliente { get; set; }


        public ucClientesLista()
        {
            InitializeComponent();
        }


        public void SetData(Cliente cliente)
        {
            Cliente = cliente;
            lblNombre.Text = cliente.Nombre;
            lblApellidos.Text = cliente.Apellidos;
            lblFechaNac.Text = "Nacimiento: "+cliente.FechaNacimiento.ToShortDateString();
            BackColor = cliente.EsAdulto ? Color.LightGreen : Color.LightSlateGray;
        }



        // Evento que se dispara al hacer click en el user control o sus componentes
        public event EventHandler<Cliente> ClienteClick;

        private void lblNombre_Click(object sender, EventArgs e)
        {
            ClienteClick?.Invoke(this, Cliente);
        }

        private void lblApellidos_Click(object sender, EventArgs e)
        {
            ClienteClick?.Invoke(this, Cliente);
        }

        private void lblFechaNac_Click(object sender, EventArgs e)
        {
            ClienteClick?.Invoke(this, Cliente);
        }

        private void ucClientesLista_Click(object sender, EventArgs e)
        {
            ClienteClick?.Invoke(this, Cliente);
        }
    }
}
