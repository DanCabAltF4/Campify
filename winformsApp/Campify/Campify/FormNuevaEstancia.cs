using Model;
using Repository;
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
        // ----------------------------------
        // DECLARACION DE VARIABLES Y OBJETOS
        // ----------------------------------
        private readonly ApiCampify _api = new ApiCampify("http://localhost:8080/");
        private Estancia _estancia;
        public FormNuevaEstancia(Parcela parcela)
        {
            InitializeComponent();
            _estancia = new Estancia();
            _estancia.Parcela = parcela;


            dtpCheckin.Value = DateTime.Today;
            dtpCheckout.Value = DateTime.Today;
            cbTemporada.DataSource = Enum.GetValues(typeof(Model.EnumTemporadas));
            cbTemporada.SelectedItem = Model.EnumTemporadas.ALTA;

            CargarDatosParcela();
        }


        // ----------------------------------
        // METODOS PRINCIPALES
        // ----------------------------------

        private void CargarDatosParcela()
        {
            lblParcela.Text = _estancia.Parcela.Id.ToString();
        }



        //----------------------------------
        // FUNCIONES DE LOS BOTONES
        // ----------------------------------

        private async void btnGuardarReserva_Click(object sender, EventArgs e)
        {
            // Asignar los valores del formulario a la estancia
            _estancia.CheckIn = dtpCheckin.Value.Date;
            _estancia.CheckOut = dtpCheckout.Value.Date;
            _estancia.Temporada = (EnumTemporadas)cbTemporada.SelectedItem;
            _estancia.NumeroAdultos = lblAdultos.Text != "" ? int.Parse(lblAdultos.Text) : 0;
            _estancia.NumeroNinos = lblNinos.Text != "" ? int.Parse(lblNinos.Text) : 0;
            _estancia.NumeroMascotas = int.Parse(txbMascotas.Text);
            _estancia.CargoEquipajeExtra = double.Parse(txbEquipajeAdicional.Text);
            _estancia.CargoAdicional = double.Parse(txbCargoAdicional.Text);
            _estancia.Empleado = new Empleado { Id = 1 };           // Empleado por defecto, luego se cambiará al empleado logueado

            // Guardar la estancia mediante la API
            await _api.Create<Estancia>("api/estancias", _estancia);
            MessageBox.Show("Estancia añadida.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
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
