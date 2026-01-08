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
    public partial class FormDatosServicio : Form
    {
        // ----------------------------------
        // DECLARACION DE VARIABLES Y OBJETOS
        // ----------------------------------
        private readonly ApiCampify _api = new ApiCampify("http://localhost:8080/");
        private Servicio _servicio;

        public Servicio ServicioGuardado { get; set; }



        // -----------------------------
        // CONSTRUCTOR Y LOAD
        // -----------------------------

        public FormDatosServicio(Servicio servicioSeleccionado)
        {
            InitializeComponent();
            _servicio = servicioSeleccionado;

            CargarDatosServicio();
        }



        // ----------------------------
        // METODOS DEL FORMULARIO
        // ----------------------------

        private void CargarDatosServicio()
        {
            if (_servicio != null)
            {
                lblId.Text = _servicio.Id.ToString();
                nupPrecio.Value = (decimal)_servicio.Precio;
                txbNombre.Text = _servicio.Nombre;
                txbDescripcion.Text = _servicio.Descripcion;
            }
        }



        //------------------------------
        // FUNCIONES DE LOS BOTONES
        // -----------------------------


        /// <summary>
        /// Cierra el formulario sin guardar cambios.
        /// </summary>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        /// <summary>
        /// Si el servicio es nuevo (Id=0), lo crea mediante la API.
        /// Si el servicio ya existe (Id!=0), actualiza sus datos mediante la API.
        /// </summary>
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // Asigna los valores de los controles al servicio
            if (_servicio == null) _servicio = new Servicio(); // Asegura que _servicio no sea null
            _servicio.Nombre = txbNombre.Text;
            _servicio.Precio = (double)nupPrecio.Value;
            _servicio.Descripcion = txbDescripcion.Text;

            // Comprueba si es un servicio nuevo o existente y llama a la API correspondiente
            if (_servicio.Id == 0)
            {
                ServicioGuardado = await _api.Create<Servicio>("api/servicios", _servicio);
                MessageBox.Show("Servicio creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se modificará el servicio.\n¿Desea continuar?", "Confirmar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                ServicioGuardado = await _api.Update<Servicio>("api/servicios", _servicio.Id, _servicio);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
