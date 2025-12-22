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
        private const double PRECIO_MASCOTA = 5.0;
        private const double PRECIO_EQUIPAJE_EXTRA = 5.0;
        private const double PRECIO_POR_CHECKBOX = 5.0;
        private const double PRECIO_POR_TEMP_ALTA = 10.0;
        private const double PRECIO_POR_TEMP_MEDIA = 5.0;

        private readonly ApiCampify _api = new ApiCampify("http://localhost:8080/");
        private Estancia _estancia;
        private Parcela _parcela;

        public Estancia EstanciaCreada { get; set; }


        // ----------------------------------
        // CONSTRUCTOR Y LOAD
        // ----------------------------------

        public FormNuevaEstancia(Parcela parcela)
        {
            InitializeComponent();
            _estancia = new Estancia();
            _parcela = parcela;
            _estancia.Parcela = parcela;


            dtpCheckin.Value = DateTime.Today;
            dtpCheckout.ShowCheckBox = true;        // Muestra el checkbox para activar/desactivar el dtpCheckout
            dtpCheckout.Checked = false;            // Por defecto, el checkout no está activado
            dtpCheckout.Value = DateTime.Today;

            cbTemporada.DataSource = Enum.GetValues(typeof(Model.EnumTemporadas));
            cbTemporada.SelectedItem = Model.EnumTemporadas.BAJA;
            txbMascotas.Text = "0";
            txbEquipajeAdicional.Text = "0";
            txbCargoAdicional.Text = "0";

            CargarDatosParcela();
        }


        // ----------------------------------
        // METODOS DEL FORMULARIO
        // ----------------------------------

        /// <summary>
        /// Muestra los datos de la parcela a reservar en el formulario
        /// </summary>
        private void CargarDatosParcela()
        {
            lblParcela.Text = _estancia.Parcela.Id.ToString();
            lblPrecioNoche.Text = $"{_estancia.Parcela.PrecioNoche} €";
            CalcularPrecioTotal();
        }

        /// <summary>
        /// Calcula el precio total de la estancia en función de los datos introducidos
        /// </summary>
        private void CalcularPrecioTotal()
        {
            int numeroNoches = 1;
            if (dtpCheckout.Checked)
            {
                numeroNoches = (dtpCheckout.Value.Date - dtpCheckin.Value.Date).Days;
                if (numeroNoches < 1)
                {
                    numeroNoches = 1; // Evitar 0 noches o negativas
                }
            }
            // Cálculo de los cargos adicionales
            double precioBase = numeroNoches * _estancia.Parcela.PrecioNoche;
            double cargoMascotas = (int.TryParse(txbMascotas.Text, out int mascotas) ? mascotas : 0) * PRECIO_MASCOTA;
            double cargoEquipaje = (double.TryParse(txbEquipajeAdicional.Text, out double cargoEq) ? cargoEq : 0) * PRECIO_EQUIPAJE_EXTRA;
            double cargoAdicional = double.TryParse(txbCargoAdicional.Text, out double cargoAd) ? cargoAd : 0;
            double cargoTemporada = 0;
            switch ((EnumTemporadas)cbTemporada.SelectedItem)
            {
                case EnumTemporadas.BAJA:
                    // No hay cargo adicional en temporada baja
                    break;
                case EnumTemporadas.MEDIA:
                    cargoTemporada = PRECIO_POR_TEMP_MEDIA;
                    break;
                case EnumTemporadas.ALTA:
                    cargoTemporada = PRECIO_POR_TEMP_ALTA;
                    break;
            }
            // Cargos por características de la parcela marcadas en los CheckBox
            if (_parcela.CercaBanos == true)
            {
                precioBase += PRECIO_POR_CHECKBOX;
            }
            if (_parcela.TieneVistas == true)
            {
                precioBase += PRECIO_POR_CHECKBOX;
            }
            if (_parcela.ZonaSombra == true)
            {
                precioBase += PRECIO_POR_CHECKBOX;
            }
            if (_parcela.CercaEntrada == true)
            {
                precioBase += PRECIO_POR_CHECKBOX;
            }
            if (_parcela.ZonaTranquila == true)
            {
                precioBase += PRECIO_POR_CHECKBOX;
            }
            // Cálculo del precio final
            double precioTotal = precioBase + cargoMascotas + cargoEquipaje + cargoAdicional + cargoTemporada;
            lblPrecioFinal.Text = $"{precioTotal} €";
        }


        //----------------------------------
        // FUNCIONES DE LOS BOTONES Y EVENTOS
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
            _estancia.CantidadEquipajeExtra = double.Parse(txbEquipajeAdicional.Text);
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
            }

        }

        private void txbMascotas_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbMascotas.Text))
            {
                _estancia.NumeroMascotas = 0;
            }
            else
            {
                _estancia.NumeroMascotas = int.Parse(txbMascotas.Text);
            }
            CalcularPrecioTotal();
        }

        private void txbEquipajeAdicional_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbEquipajeAdicional.Text))
            {
                _estancia.CantidadEquipajeExtra = 0;
            }
            else
            {
                _estancia.CantidadEquipajeExtra = int.Parse(txbEquipajeAdicional.Text);
            }
            CalcularPrecioTotal();
        }

        private void txbCargoAdicional_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbCargoAdicional.Text))
            {
                _estancia.CargoAdicional = 0;
            }
            else
            {
                _estancia.CargoAdicional = double.Parse(txbCargoAdicional.Text);
            }
            CalcularPrecioTotal();
        }

        private void cbTemporada_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularPrecioTotal();
        }
    }
}
