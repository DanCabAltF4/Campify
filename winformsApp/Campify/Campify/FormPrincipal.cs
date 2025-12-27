using Controles;
using Forms;
using Model;
using Repository;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace Campify
{
    public partial class FormPrincipal : Form
    {

        // ----------------------------------
        // DECLARACION DE VARIABLES Y OBJETOS
        // ----------------------------------

        private readonly ApiCampify _api = new ApiCampify("http://localhost:8080/");

        private Timer refreshTimer;


        // ----------------------------------
        // CONSTRUCTOR Y LOAD
        // ----------------------------------

        public FormPrincipal()
        {
            InitializeComponent();

            //Usado para refrescar los datos cada 5 segundos
            refreshTimer = new Timer();
            refreshTimer.Interval = 5000;
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarParcelas();
            CargarEmpleados();

        }



        // ----------------------------------
        // METODOS DEL FORMULARIO
        // ----------------------------------


        /// <summary>
        /// Refresca los datos de los flowlayout cada 5 segundos mediante el Timer definido en el constructor
        /// </summary>
        private void RefreshTimer_Tick(object? sender, EventArgs e)
        {
            CargarParcelas();
            CargarEmpleados();
        }


        /// <summary>
        /// Carga las parcelas desde la API en los user controls y los añade al flow layout panel.
        /// </summary>
        private async void CargarParcelas()
        {
            try
            {
                flpParcelas.Controls.Clear();
                List<Parcela> parcelas = await _api.GetAllAsync<Parcela>("api/parcelas");
                foreach (Parcela p in parcelas)
                {
                    ucParcela uc = new ucParcela();
                    uc.SetData(p);
                    uc.ParcelaClick += ParcelaClick;
                    flpParcelas.Controls.Add(uc);
                }
            }
            catch (HttpRequestException ex)
            {
                MostrarErrorConectarApi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Carga los empleados desde la API en los user controls y los añade al flow layout panel.
        /// </summary>
        private async void CargarEmpleados()
        {
            try
            {
                flpEmpleados.Controls.Clear();
                List<Empleado> empleados = await _api.GetAllAsync<Empleado>("api/empleados");
                foreach (Empleado emp in empleados)
                {
                    ucEmpleadosLista uc = new ucEmpleadosLista();
                    uc.SetData(emp);
                    uc.EmpleadoClick += EmpleadoClick;
                    flpEmpleados.Controls.Add(uc);
                }
            }
            catch (HttpRequestException ex)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Muestra un mensaje de error al no poder conectar con la API y ofrece reintentar o salir.
        /// </summary>
        private void MostrarErrorConectarApi()
        {
            var result = MessageBox.Show("No se pudo conectar a la API.\n¿Desea reintentar?", "Error de conexión", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            if (result == DialogResult.Retry)
            {
                CargarParcelas();
                CargarEmpleados();
            }
            else
            {
                Application.Exit();
            }
        }



        // ----------------------------------
        // FUNCIONES DE LOS BOTONES
        // ----------------------------------


        /// <summary>
        /// Muestra los datos de la parcela seleccionada en el user control de datos de parcela.
        /// Si la parcela tiene una estancia hoy (estado RESERVADA), también muestra la estancia en el user control de estancia actual.
        /// </summary>
        private async void ParcelaClick(object? sender, Parcela parcela)
        {
            ucParcelaDatos.MostrarDatos(parcela);
            btnDatos.PerformClick();
            if (parcela.Estado != EnumEstados.RESERVADA)
            {
                ucEstanciaActual1.Limpiar();
                return;
            }
            var estancias = await _api.GetAllAsync<Estancia>("api/estancias");
            var estanciaActual = estancias.FirstOrDefault(es => es.Parcela != null && es.Parcela.Id == parcela.Id);
            ucEstanciaActual1.SetData(estanciaActual);
        }


        /// <summary>
        /// Muestra los datos del empleado seleccionado de la lista en el user control de datos de empleado.
        /// </summary>
        private void EmpleadoClick(object? sender, Empleado empleado)
        {
            ucEmpleadoDatos1.MostrarDatos(empleado);

        }


        /// <summary>
        /// Cambia la vista de parcelas a modo mapa.
        /// </summary>
        private void btMapa_Click(object sender, EventArgs e)
        {
            flpParcelas.Visible = false;
            pbMapa.Visible = true;
        }


        /// <summary>
        /// Cambia la vista de parcelas a modo lista.
        /// </summary>
        private void btLista_Click(object sender, EventArgs e)
        {
            pbMapa.Visible = false;
            flpParcelas.Visible = true;
        }


        /// <summary>
        /// Abre el formulario para crear una nueva estancia (reserva) en la parcela seleccionada.
        /// </summary>
        private void btnReservar_Click(object sender, EventArgs e)
        {
            Parcela parcelaSeleccionada = ucParcelaDatos.ParcelaActual;
            if (parcelaSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una parcela para reservarla.", "Parcela no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (parcelaSeleccionada.Estado != EnumEstados.LIBRE)
            {
                MessageBox.Show("La parcela seleccionada no está libre.", "Parcela no libre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var form = new FormNuevaEstancia(parcelaSeleccionada);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                ucEstanciaActual1.SetData(form.EstanciaCreada);
                CargarParcelas();
            }
        }


        /// <summary>
        /// Cambia el panel principal a la vista de servicios.
        /// </summary>
        private void btnServicios_Click(object sender, EventArgs e)
        {
            pnlEmpleados.Visible = false;
            pnlParcelas.Visible = false;
            pnlEstancias.Visible = false;
            pnlServicios.Visible = true;
        }


        /// <summary>
        /// Cambia el panel principal a la vista de parcelas.
        /// </summary>
        private void btnParcelas_Click(object sender, EventArgs e)
        {
            pnlEmpleados.Visible = false;
            pnlServicios.Visible = false;
            pnlEstancias.Visible = false;
            pnlParcelas.Visible = true;
        }


        /// <summary>
        /// Cambia el panel principal a la vista de empleados.
        /// </summary>
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            pnlServicios.Visible = false;
            pnlParcelas.Visible = false;
            pnlEstancias.Visible = false;
            pnlEmpleados.Visible = true;
        }


        /// <summary>
        /// Cambia el panel principal a la vista de estancias.
        /// </summary>
        private void btnEstancias_Click(object sender, EventArgs e)
        {
            pnlParcelas.Visible = false;
            pnlEmpleados.Visible = false;
            pnlServicios.Visible = false;
            pnlEstancias.Visible = true;
        }


        /// <summary>
        /// Cambia el user control visible a la vista de datos de parcela.
        /// Cambia la visibilidad de los botones según la vista.
        /// </summary>
        private void btnDatos_Click(object sender, EventArgs e)
        {
            ucEstanciaActual1.Visible = false;
            ucHistorial1.Visible = false;
            ucParcelaDatos.Visible = true;

            btnClientesEstancia.Visible = false;
            btnServiciosEstancia.Visible = false;

            btnReservar.Visible = true;
            btnMantenimiento.Visible = true;
        }


        /// <summary>
        /// Cambia el user control visible a la vista de estancia actual.
        /// Cambia la visibilidad de los botones según la vista.
        /// </summary>
        private void btnEstanciaActual_Click(object sender, EventArgs e)
        {
            ucParcelaDatos.Visible = false;
            ucHistorial1.Visible = false;
            ucEstanciaActual1.Visible = true;

            btnReservar.Visible = false;
            btnMantenimiento.Visible = false;

            btnClientesEstancia.Visible = true;
            btnServiciosEstancia.Visible = true;
        }


        /// <summary>
        /// Cambia el user control visible a la vista de historial de estancias.
        /// </summary>
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            ucParcelaDatos.Visible = false;
            ucEstanciaActual1.Visible = false;
            ucHistorial1.Visible = true;

        }


        /// <summary>
        /// Altera el estado de la parcela seleccionada entre MANTENIMIENTO y LIBRE.
        /// </summary>
        private async void btnMantenimiento_Click(object sender, EventArgs e)
        {
            Parcela parcela = ucParcelaDatos.ParcelaActual;
            if (parcela == null)
            {
                MessageBox.Show("Debe seleccionar una parcela.", "Parcela no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (parcela.Estado == EnumEstados.MANTENIMIENTO)
            {
                parcela.Estado = EnumEstados.LIBRE;
            }
            else if (parcela.Estado == EnumEstados.LIBRE)
            {
                parcela.Estado = EnumEstados.MANTENIMIENTO;
            }
            await _api.Update("api/parcelas", parcela.Id, parcela);
            CargarParcelas();
            ucParcelaDatos.MostrarDatos(parcela);
        }


        /// <summary>
        /// Muestra mensaje de confirmación y elimina el empleado seleccionado mediante la API.
        /// Comrpueba que hay un empleado seleccionado.
        /// </summary>
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            Empleado empleado = ucEmpleadoDatos1.EmpleadoActual;
            if (empleado == null)
            {
                MessageBox.Show("Debe seleccionar un empleado para eliminarlo.", "Empleado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var result = MessageBox.Show("Se eliminará al empleado.\n¿Desea continuar?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await _api.Delete<Empleado>("api/empleados", ucEmpleadoDatos1.EmpleadoActual.Id);
                MessageBox.Show("Empleado eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEmpleados();
                ucEmpleadoDatos1.Limpiar();
            }
        }


        /// <summary>
        /// Abre el formulario de datos de empleado para crear uno nuevo.
        /// </summary>
        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            var form = new FormDatosEmpleado(null);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                CargarEmpleados();
                ucEmpleadoDatos1.MostrarDatos(form.EmpleadoGuardado);
            }
        }


        /// <summary>
        /// Abre el formulario de datos de empleado para editar el empleado seleccionado.
        /// Pasa el empleado seleccionado al formulario.
        /// </summary>
        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            var empleadoSeleccionado = ucEmpleadoDatos1.EmpleadoActual;
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un empleado para editarlo.", "Empleado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var form = new FormDatosEmpleado(empleadoSeleccionado);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                CargarEmpleados();
                ucEmpleadoDatos1.MostrarDatos(form.EmpleadoGuardado);
            }
        }


        /// <summary>
        /// Abre el formulario que muestra los clientes de la estancia actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClientesEstancia_Click(object sender, EventArgs e)
        {
            Parcela parcela = ucParcelaDatos.ParcelaActual;
            if (parcela.Estado != EnumEstados.RESERVADA)
            {
                MessageBox.Show("La parcela no tiene una estancia hoy.", "Estancia no activa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var estanciaActual = ucEstanciaActual1.EstanciaActual;
            var form = new FormVerClientesEstancia(estanciaActual);
            form.ShowDialog(this);
        }

        private void btnServiciosEstancia_Click(object sender, EventArgs e)
        {
            Parcela parcela = ucParcelaDatos.ParcelaActual;
            if (parcela.Estado != EnumEstados.RESERVADA)
            {
                MessageBox.Show("La parcela no tiene una estancia hoy.", "Estancia no activa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var estanciaActual = ucEstanciaActual1.EstanciaActual;
            var form = new FormVerServiciosEstancia(estanciaActual);
            form.ShowDialog(this);
        }
    }
}
