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
    public partial class FormEstanciaClientes : Form
    {
        public FormEstanciaClientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            var form = new FormNuevoCliente();
            form.ShowDialog(this);
        }
    }
}
