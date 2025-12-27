using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            nudNumMascotas.Value = 0;
            nudEquipajeAdicional.Value = 0;
            nudCargoAdicional.Value = 0;
            nudCargoAdicional.Controls[0].Visible = false;

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
            double cargoMascotas = ((int)nudNumMascotas.Value) * PRECIO_MASCOTA;
            double cargoEquipaje = ((double)nudEquipajeAdicional.Value) * PRECIO_EQUIPAJE_EXTRA;
            double cargoAdicional = (double)nudCargoAdicional.Value;
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

        /// <summary>
        /// Ordena estancias de la parcela por fecha y comprueba en estancia actual si hay disponibilidad
        /// Comprueba que check y checkout esta entre espacios de otras estancias
        /// </summary>
        private async Task<bool> ComprobarDisponibilidad()
        {
            var disponible = false;
            DateOnly checkinNuevo = DateOnly.FromDateTime(dtpCheckin.Value);
            DateOnly checkoutNuevo = DateOnly.FromDateTime(dtpCheckout.Value);
            var estancias = await _api.GetAllAsync<Estancia>("api/estancias");
            estancias = estancias.Where(est => est.Parcela.Id == _parcela.Id).ToList(); //Filtramos estancias por parcela
            estancias.Sort((x, y) => x.CheckIn.CompareTo(y.CheckIn));        //Ordenamos por fecha de checkin

            switch (estancias.Count)
            {
                // 0 estancias
                case 0:
                    disponible = Disponibilidad0Estancias(estancias, checkinNuevo, checkoutNuevo);
                    break;

                // 1 estancia
                case 1:
                    disponible = Disponibilidad1Estancia(estancias, checkinNuevo, checkoutNuevo);
                    break;

                // 2 o mas estancias
                default:
                    disponible = Disponibilidad2Estancias(estancias, checkinNuevo, checkoutNuevo);
                    break;
            }
            return disponible;
        }

        /// <summary>
        /// Comprueba si la fecha de checkin es anterioir a la de checkot en caso de haber checkout.
        /// </summary>

        private bool Disponibilidad0Estancias(List<Estancia> estancias, DateOnly checkinNuevo, DateOnly checkoutNuevo)
        {
            // Con fecha de checkout
            if(dtpCheckout.Checked && checkinNuevo < checkoutNuevo)
            {
                return true;
            }
            // Sin fecha de checkout
            else if (!dtpCheckout.Checked)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Comprueba si la estancia actual se solapa con la estancia ya guardada
        /// </summary>
        /// <returns></returns>
        private bool Disponibilidad1Estancia(List<Estancia> estancias, DateOnly checkinNuevo, DateOnly checkoutNuevo)
        {
            // Sin fecha de checkout en estancia guardada
            if (estancias.First().CheckOut == null)
            {
                // ckInNueva < ckOutNueva < ckInGuardada
                if (dtpCheckout.Checked && checkoutNuevo <= estancias.First().CheckIn && checkinNuevo < checkoutNuevo)
                {
                    return true;
                }
            }
            // Con fecha de checkout en estancia guardada
            else
            {
                // POSTERIOR - ckoutNueva == null   ->   ckoutGuardada < ckinNueva
                if (!dtpCheckout.Checked && estancias.First().CheckOut.Value <= checkinNuevo)
                {
                    return true;
                }
                // POSTERIOR - ckoutNueva != null    ->   ckoutGuardada < ckinNueva < ckoutNueva
                else if(dtpCheckout.Checked && estancias.First().CheckOut <= checkinNuevo && checkinNuevo < checkoutNuevo)
                {
                    return true;
                }
                // ANTERIOR - ckoutNueva != null    ->   ckinNueva < ckoutNueva < ckinGuardada
                else if(dtpCheckout.Checked && checkinNuevo < checkoutNuevo && checkoutNuevo <= estancias.First().CheckIn)
                {
                    return true;
                }
            }
            return false;
        }


        private bool Disponibilidad2Estancias(List<Estancia> estancias, DateOnly checkinNuevo, DateOnly checkoutNuevo)
        {
            // ANTERIOR A TODAS -> ckoutNueva != null     ->   ckinNueva < ckoutNueva < ckinGuardada
            if (dtpCheckout.Checked && checkinNuevo < checkoutNuevo && checkoutNuevo <= estancias.First().CheckIn)
            {
                return true;
            }
            // POSTERIOR A TODAS -> ckoutGuardada != null
            if (estancias.Last().CheckOut != null)
            {
                // ckoutNueva == null     -> ckoutGuardada < ckinNueva
                if (!dtpCheckout.Checked && estancias.Last().CheckOut.Value <= checkinNuevo)
                {
                    return true;
                }
                // ckoutNueva != null     -> ckoutGuardada < ckinNueva < ckoutNueva
                if (dtpCheckout.Checked && estancias.Last().CheckOut.Value <= checkinNuevo && checkinNuevo < checkoutNuevo)
                {
                    return true;
                }
            }
            // INTERIOIR ENTRE 2 
            for (int i = 0; i < estancias.Count - 1; i++)
            {
                // ckoutGuardada[i] != null  &&  ckoutNueva !=null
                if (estancias[i].CheckOut != null && dtpCheckout.Checked)
                {
                    // ckoutGuardada < ckinNueva < ckoutNueva < ckinGuardada[i+1]     
                    if (estancias[i].CheckOut.Value <= checkinNuevo && checkinNuevo < checkoutNuevo && checkoutNuevo <= estancias[i + 1].CheckIn)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        //----------------------------------
        // FUNCIONES DE LOS BOTONES Y EVENTOS
        // ----------------------------------

        /// <summary>
        /// Guarda la nueva estancia creada mediante la API
        /// </summary>
        private async void btnGuardarReserva_Click(object sender, EventArgs e)
        {
            bool disponible=  await ComprobarDisponibilidad();
            if (disponible)
            {
                // Asignar los valores del formulario a la estancia
                _estancia.CheckIn = DateOnly.FromDateTime(dtpCheckin.Value.Date);
                _estancia.CheckOut = dtpCheckout.Checked ? DateOnly.FromDateTime(dtpCheckout.Value.Date) : null;
                _estancia.Temporada = (EnumTemporadas)cbTemporada.SelectedItem;
                _estancia.NumeroAdultos = 0;
                _estancia.NumeroNinos = 0;
                _estancia.NumeroMascotas = (int)nudNumMascotas.Value;
                _estancia.CantidadEquipajeExtra = (double)nudEquipajeAdicional.Value;
                _estancia.CargoAdicional = (double)nudCargoAdicional.Value;
                string valor = lblPrecioFinal.Text.Split(' ')[0];
                _estancia.PrecioFinal = double.Parse(valor);
                _estancia.Empleado = new Empleado { Id = 1 };           // Empleado por defecto, luego se cambiará al empleado logueado

                // Guardar la estancia mediante la API
                EstanciaCreada = await _api.Create<Estancia>("api/estancias", _estancia);
                MessageBox.Show("Estancia añadida.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Parcela no disponible en esas fechas");
            }
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

        private void cbTemporada_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularPrecioTotal();
        }

        private void nudNumMascotas_ValueChanged(object sender, EventArgs e)
        {
            CalcularPrecioTotal();
        }

        private void nudEquipajeAdicional_ValueChanged(object sender, EventArgs e)
        {
            CalcularPrecioTotal();
        }

        private void nudCargoAdicional_ValueChanged(object sender, EventArgs e)
        {
            CalcularPrecioTotal();
        }


        /// <summary>
        /// Cambia el caracter . por , para los decimales en el numericUpDown de cargo adicional
        /// </summary>
        private void nudCargoAdicional_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
                SendKeys.Send(",");
            }
        }

        private void dtpCheckin_Leave(object sender, EventArgs e)
        {
            CalcularPrecioTotal();
        }

        private void dtpCheckout_Leave(object sender, EventArgs e)
        {
            CalcularPrecioTotal();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            ComprobarDisponibilidad();
        }
    }
}
