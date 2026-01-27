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
    public partial class FormNuevoCliente : Form
    {
        // ----------------------------------
        // DECLARACION DE VARIABLES Y OBJETOS
        // ----------------------------------
        private readonly ApiCampify _api;

        public Cliente? ClienteNuevo { get; set; }
        public FormNuevoCliente(ApiCampify api)
        {
            InitializeComponent();
            _api = api;
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
                    string.IsNullOrWhiteSpace(txbEmail.Text) ||
                    string.IsNullOrWhiteSpace(txbCodigoPostal.Text) ||
                    string.IsNullOrWhiteSpace(txbEmail.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Crear un nuevo objeto Cliente con los datos ingresados
                Cliente nuevo = new Cliente
                {
                    Nombre = txbNombre.Text,
                    Apellidos = txbApellidos.Text,
                    Dni = txbDni.Text,
                    Direccion = txbDireccion.Text,
                    CPostal = txbCodigoPostal.Text,
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    Email = txbEmail.Text,
                    Telefono = txbTelefono.Text
                };
                // Guardar el nuevo cliente en la base de datos mediante la API y lo devuevlve al formulario de origen
                var resultado = await _api.Create<Cliente>("api/clientes", nuevo);
                ClienteNuevo = resultado;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error al guardar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
