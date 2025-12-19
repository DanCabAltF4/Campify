using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormNuevaEstancia : Form
    {
        public FormNuevaEstancia()
        {
            InitializeComponent();
        }

        private void btnGuardarReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var form = new FormEstanciaClientes();
            form.ShowDialog(this);
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            var form = new FormEstanciaServicios();
            form.ShowDialog(this);
        }
    }
}
