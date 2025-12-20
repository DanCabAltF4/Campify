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
        // DECLARACION DE VARIABLES Y OBJETOS
        //private readonly Parcela _parcela;
        private Estancia _estancia;
        public FormNuevaEstancia(Parcela parcela)
        {
            InitializeComponent();
            _estancia = new Estancia();
            _estancia.Parcela = parcela;

            //_parcela = parcela;

            dtpCheckin.Value = DateTime.Today;
            dtpCheckout.Value = DateTime.Today;
            cbTemporada.DataSource = Enum.GetValues(typeof(Model.EnumTemporadas));

            CargarDatosParcela();
        }


        // ----------------------------------
        // METODOS PRINCIPALES

        private void CargarDatosParcela()
        {
            lblParcela.Text = _estancia.Parcela.Id.ToString();
        }



        //----------------------------------
        // FUNCIONES DE LOS BOTONES

        private void btnGuardarReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var form = new FormEstanciaClientes(_estancia.Clientes);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _estancia.Clientes = form.ListaFinalClientes;
                lblAdultos.Text = _estancia.Clientes.Count.ToString();
            }
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            var form = new FormEstanciaServicios(_estancia.Servicios);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _estancia.Servicios = form.ListaFinalServicios;
                lblNinos.Text = _estancia.Servicios.Count.ToString();
            }
            
        }
    }
}
