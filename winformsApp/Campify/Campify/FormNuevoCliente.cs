using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormNuevoCliente : Form
    {
        //Atributos para menu superior
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;


        // ----------------------------------
        // DECLARACION DE VARIABLES Y OBJETOS
        // ----------------------------------
        private readonly ApiCampify _api;
        private Cliente? _cliente;

        public Cliente? ClienteNuevo { get; set; }

        public FormNuevoCliente(ApiCampify api, Cliente? cliente)
        {
            InitializeComponent();
            _api = api;
            _cliente = cliente;
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            if (_cliente != null)
            {
                txbNombre.Text = _cliente.Nombre;
                txbApellidos.Text = _cliente.Apellidos;
                txbDni.Text = _cliente.Dni;
                txbDireccion.Text = _cliente.Direccion;
                txbCodigoPostal.Text = _cliente.CPostal;
                dtpFechaNacimiento.Value = _cliente.FechaNacimiento;
                txbEmail.Text = _cliente.Email;
                txbTelefono.Text = _cliente.Telefono;

                btnGuardar.Text = "Actualizar";
            }
        }



        // ----------------------------------
        // FUNCIONES DE LOS BOTONES
        // ----------------------------------

        /// <summary>
        /// Guardar el nuevo cliente creado y lo devuelve al formulario de origen
        /// </summary>
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validaciones evitar campos vacíos antes de enviar a la API
                if (string.IsNullOrWhiteSpace(txbNombre.Text) ||
                    string.IsNullOrWhiteSpace(txbApellidos.Text) ||
                    string.IsNullOrWhiteSpace(txbDni.Text) ||
                    string.IsNullOrWhiteSpace(txbDireccion.Text) ||
                    string.IsNullOrWhiteSpace(txbCodigoPostal.Text) ||
                    string.IsNullOrWhiteSpace(txbEmail.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Crear un nuevo objeto Cliente con los datos ingresados
                Cliente nuevo = _cliente ?? new Cliente();

                nuevo.Nombre = txbNombre.Text;
                nuevo.Apellidos = txbApellidos.Text;
                nuevo.Dni = txbDni.Text;
                nuevo.Direccion = txbDireccion.Text;
                nuevo.CPostal = txbCodigoPostal.Text;
                nuevo.FechaNacimiento = dtpFechaNacimiento.Value;
                nuevo.Email = txbEmail.Text;
                nuevo.Telefono = txbTelefono.Text;

                if (nuevo.Id == 0)
                {
                    nuevo = await _api.Create<Cliente>("api/clientes", nuevo);
                    MessageBox.Show("Cliente creado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    nuevo = await _api.Update("api/clientes", _cliente.Id, nuevo);
                    MessageBox.Show("Cliente actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                _cliente = nuevo;
                ClienteNuevo = nuevo;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        /// <summary>
        /// Cerrar el formulario sin guardar ningún cliente
        /// </summary>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
