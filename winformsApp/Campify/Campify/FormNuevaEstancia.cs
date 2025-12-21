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

        public Estancia EstanciaCreada { get; set; }


        // ----------------------------------
        // CONSTRUCTOR Y LOAD
        // ----------------------------------

        public FormNuevaEstancia(Parcela parcela)
        {
            InitializeComponent();
            _estancia = new Estancia();
            _estancia.Parcela = parcela;


            dtpCheckin.Value = DateTime.Today;
            dtpCheckout.ShowCheckBox = true;        // Muestra el checkbox para activar/desactivar el dtpCheckout
            dtpCheckout.Checked = false;            // Por defecto, el checkout no está activado
            dtpCheckout.Value = DateTime.Today;

            cbTemporada.DataSource = Enum.GetValues(typeof(Model.EnumTemporadas));
            cbTemporada.SelectedItem = Model.EnumTemporadas.ALTA;
            txbMascotas.Text = "0";
            txbEquipajeAdicional.Text = "0";
            txbCargoAdicional.Text = "0";

            CargarDatosParcela();
        }


        // ----------------------------------
        // METODOS DE LA CLASE
        // ----------------------------------

        private void CargarDatosParcela()
        {
            lblParcela.Text = _estancia.Parcela.Id.ToString();
        }



        //----------------------------------
        // FUNCIONES DE LOS BOTONES
        // ----------------------------------

        /// <summary>
        /// Guarda la nueva estancia creada mediante la API
        /// </summary>
        private async void btnGuardarReserva_Click(object sender, EventArgs e)
        {
            // Asignar los valores del formulario a la estancia
            _estancia.CheckIn = DateOnly.FromDateTime(dtpCheckin.Value.Date);
            _estancia.CheckOut = dtpCheckout.Checked ? DateOnly.FromDateTime(dtpCheckout.Value.Date) : null;
            _estancia.Temporada = (EnumTemporadas)cbTemporada.SelectedItem;
            _estancia.NumeroAdultos = 0;
            _estancia.NumeroNinos = 0;
            _estancia.NumeroMascotas = int.Parse(txbMascotas.Text);
            _estancia.CargoEquipajeExtra = double.Parse(txbEquipajeAdicional.Text);
            _estancia.CargoAdicional = double.Parse(txbCargoAdicional.Text);
            _estancia.Empleado = new Empleado { Id = 1 };           // Empleado por defecto, luego se cambiará al empleado logueado

            // Guardar la estancia mediante la API
            EstanciaCreada = await _api.Create<Estancia>("api/estancias", _estancia);
            MessageBox.Show("Estancia añadida.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Abre el formulario para seleccionar los clientes de la estancia
        /// </summary>
        private void btnClientes_Click(object sender, EventArgs e)
        {
            var form = new FormEstanciaClientes(_estancia.Clientes);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _estancia.Clientes = form.ListaFinalClientes;
                //lblAdultos.Text = _estancia.Clientes.Count.ToString();
            }
        }

        /// <summary>
        /// Abre el formulario para seleccionar los servicios de la estancia
        /// </summary>
        private void btnServicios_Click(object sender, EventArgs e)
        {
            var form = new FormEstanciaServicios(_estancia.Servicios);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _estancia.Servicios = form.ListaFinalServicios;
                //lblNinos.Text = _estancia.Servicios.Count.ToString();
            }
            
        }
    }
}
