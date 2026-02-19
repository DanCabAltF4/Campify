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
    public partial class FormEstanciaServicios : Form
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
        private BindingList<Servicio> listaServicios = new();
        private BindingList<Servicio> listaServiciosEstancia = new();

        public List<Servicio> ListaFinalServicios { get; private set; } = new();


        // ----------------------------------
        // CONSTRUCTOR Y LOAD
        // ----------------------------------

        public FormEstanciaServicios(List<Servicio> serviciosEstancia, ApiCampify api)
        {
            InitializeComponent();
            listaServiciosEstancia = new BindingList<Servicio>(serviciosEstancia);
            _api = api;
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private async void FormEstanciaServicios_Load(object sender, EventArgs e)
        {
            try
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
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }



        // ----------------------------------
        // FUNCIONES DE LOS BOTONES
        // ----------------------------------

        /// <summary>
        /// Guarda la lista de servicios seleccionados y cierra el formulario
        /// </summary>
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
            if (e.RowIndex >= 0)
            {
                Servicio servicioSeleccionado = (Servicio)dvgListaServicios.Rows[e.RowIndex].DataBoundItem;
                listaServiciosEstancia.Add(servicioSeleccionado);
                listaServicios.Remove(servicioSeleccionado);
            }
        }

        private void dgvServiciosEstancia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Servicio servicioSeleccionado = (Servicio)dgvServiciosEstancia.Rows[e.RowIndex].DataBoundItem;
                listaServicios.Add(servicioSeleccionado);
                listaServiciosEstancia.Remove(servicioSeleccionado);
            }
        }

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
