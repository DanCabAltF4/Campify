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
    public partial class FormEstanciaClientes : Form
    {
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
            listaClientesEstancia= new BindingList<Cliente>(clientesEstancia);
            _api = api;
        }

        private async void FormEstanciaClientes_Load(object sender, EventArgs e)
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
            var form = new FormNuevoCliente(_api);
            if(form.ShowDialog(this) == DialogResult.OK && form.ClienteNuevo != null)
            {
                var nuevoCliente = form.ClienteNuevo;
                listaClientesEstancia.Add(nuevoCliente);
            }
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
    }
}
