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
    public partial class FormEstanciaServicios : Form
    {
        // DECLARACION DE VARIABLES Y OBJETOS
        private readonly ApiCampify _api = new ApiCampify("http://localhost:8080/");
        private BindingList<Servicio> listaServicios = new();
        private BindingList<Servicio> listaServiciosEstancia = new();

        public List<Servicio> ListaFinalServicios { get; private set; } = new();


        // CONSTRUCTOR Y LOAD

        public FormEstanciaServicios(List<Servicio> serviciosEstancia)
        {
            InitializeComponent();
            listaServiciosEstancia = new BindingList<Servicio>(serviciosEstancia);
        }

        private async void FormEstanciaServicios_Load(object sender, EventArgs e)
        {
            listaServicios = new BindingList<Servicio>(await _api.GetAllAsync<Servicio>("api/servicios"));
            // Elimina de la lista general los servicios que ya están en la estancia
            foreach (var servicio in listaServiciosEstancia)
            {
                Servicio? servicioEstancia = null;
                foreach (var s in listaServicios)
                {
                    if (s.Id == servicio.Id)
                    {
                        servicioEstancia = s;
                        break;
                    }
                }
                if (servicioEstancia != null)
                {
                    listaServicios.Remove(servicioEstancia);
                }
            }
            dvgListaServicios.DataSource = listaServicios;
            dgvServiciosEstancia.DataSource = listaServiciosEstancia;
        }

        // ----------------------------------
        // FUNCIONES DE LOS BOTONES

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ListaFinalServicios = listaServiciosEstancia.ToList();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        /// <summary>
        /// Mueve el servicio seleccionado de la lista general a la lista de la estancia con doble click
        /// </summary>
        private void dvgListaServicios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Servicio servicioSeleccionado = (Servicio)dvgListaServicios.Rows[e.RowIndex].DataBoundItem;
            listaServiciosEstancia.Add(servicioSeleccionado);
            listaServicios.Remove(servicioSeleccionado);
        }

        private void dgvServiciosEstancia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Servicio servicioSeleccionado = (Servicio)dgvServiciosEstancia.Rows[e.RowIndex].DataBoundItem;
            listaServicios.Add(servicioSeleccionado);
            listaServiciosEstancia.Remove(servicioSeleccionado);
        }
    }
}
