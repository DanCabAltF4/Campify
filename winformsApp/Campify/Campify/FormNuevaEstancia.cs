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

namespace Forms
{
    public partial class FormNuevaEstancia : Form
    {

        private readonly Parcela _parcela;
        public FormNuevaEstancia( Parcela parcela)
        {
            InitializeComponent();
            _parcela = parcela;

            dtpCheckin.Value = DateTime.Today;
            dtpCheckout.Value = DateTime.Today;
            cbTemporada.DataSource = Enum.GetValues(typeof(Model.EnumTemporadas));

            CargarDatosParcela();
        }

        private void CargarDatosParcela()
        {
            lblParcela.Text = _parcela.Id.ToString();
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
