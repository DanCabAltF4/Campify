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
    public partial class FormEstanciaClientes : Form
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

        private BindingList<Cliente> listaClientes = new();
        private BindingList<Cliente> listaClientesEstancia = new();

        public List<Cliente> ListaFinalClientes { get; private set; } = new();


        // ----------------------------------
        // CONSTRUCTOR Y LOAD
        // ----------------------------------

        public FormEstanciaClientes(List<Cliente> clientesEstancia, ApiCampify api)
        {
            InitializeComponent();
            listaClientesEstancia = new BindingList<Cliente>(clientesEstancia);
            _api = api;
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private async void FormEstanciaClientes_Load(object sender, EventArgs e)
        {
            try
            {
                listaClientes = new BindingList<Cliente>(await _api.GetAllAsync<Cliente>("api/clientes"));
                // Elimina de la lista general los clientes que ya están en la estancia
                foreach (var cliente in listaClientesEstancia)
                {
                    Cliente? clienteEstancia = null;
                    foreach (var c in listaClientes)
                    {
                        if (c.Id == cliente.Id)
                        {
                            clienteEstancia = c;
                            break;
                        }
                    }
                    if (clienteEstancia != null)
                    {
                        listaClientes.Remove(clienteEstancia);
                    }
                }
                dgvListaClientes.DataSource = listaClientes;
                dgvClientesEstancia.DataSource = listaClientesEstancia;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }


        //----------------------------------
        //FUNCIONES DE LOS BOTONES
        // ----------------------------------

        /// <summary>
        /// Guarda la lista de clientes asignados a la estancia y cierra el formulario
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ListaFinalClientes = listaClientesEstancia.ToList();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Abre el formulario para crear un nuevo cliente
        /// </summary>
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormNuevoCliente(_api, null);
            if (form.ShowDialog(this) == DialogResult.OK && form.ClienteNuevo != null)
            {
                var nuevoCliente = form.ClienteNuevo;
                listaClientesEstancia.Add(nuevoCliente);
            }
            this.Show();
        }


        /// <summary>
        /// Mueve cliente de la lista general a la lista de la estancia con doble click
        /// </summary>
        private void dgvListaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Cliente clienteSeleccionado = (Cliente)dgvListaClientes.Rows[e.RowIndex].DataBoundItem;
                listaClientes.Remove(clienteSeleccionado);
                listaClientesEstancia.Add(clienteSeleccionado);
            }
        }

        /// <summary>
        /// Mueve cliente de la lista de la estancia a la lista general con doble click
        /// </summary>

        private void dgvClientesEstancia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Cliente cliente = (Cliente)dgvClientesEstancia.Rows[e.RowIndex].DataBoundItem;
                listaClientesEstancia.Remove(cliente);
                listaClientes.Add(cliente);
            }
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
