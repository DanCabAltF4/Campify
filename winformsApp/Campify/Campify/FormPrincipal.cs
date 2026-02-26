using Controles;
using Forms;
using Model;
using Repository;
using System.Runtime.InteropServices;

namespace Campify
{
    public partial class FormPrincipal : Form
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
        private List<Parcela> _parcelas;


        // ----------------------------------
        // CONSTRUCTOR Y LOAD
        // ----------------------------------

        public FormPrincipal(ApiCampify api)
        {
            InitializeComponent();
            _api = api;
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            cbFiltroEstado.DataSource = Enum.GetValues(typeof(EnumEstados));
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            btnParcelas.BackColor = Color.FromArgb(160, 210, 140);
            OcultarBotonesPorRol();
            await CargarDatosPorRol();
        }



        // ----------------------------------
        // METODOS DEL FORMULARIO
        // ----------------------------------


        // BARRA SUPERIOR 

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Logout();
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



        // OCULTAR BOTONES Y CARGAR DATOS POR ROL

        private void OcultarBotonesPorRol()
        {
            switch (Session.Rol)
            {
                case "ADMINISTRADOR":
                    break;

                case "RECEPCIONISTA":
                    OcultarAdmin();
                    break;

                case "CAMPO":
                    OcultarAdmin();
                    OcultarRecepcion();
                    break;
            }
        }

        private void OcultarAdmin()
        {
            btnEmpleados.Visible = false;
            btnNuevoEmpleado.Visible = false;
            btnEditarEmpleado.Visible = false;
            btnEliminarEmpleado.Visible = false;

            btnNuevaParcela.Visible = false;
            btnEditarParcela.Visible = false;
            btnEliminarParcela.Visible = false;

            btnEliminarServicio.Visible = false;
            btnEliminarCliente.Visible = false;
        }

        private void OcultarRecepcion()
        {
            btnClientes.Visible = false;
            btnNuevoCliente.Visible = false;
            btnEditarCliente.Visible = false;

            btnReservar.Visible = false;
            btnClientesEstancia.Visible = false;
            btnServiciosEstancia.Visible = false;


            btnNuevoServicio.Visible = false;
            btnEditarServicio.Visible = false;

            btnEditarEstancia.Visible = false;
            btnEliminarEstancia.Visible = false;
        }

        private async Task CargarDatosPorRol()
        {
            await CargarParcelas();
            await CargarServicios();
            await CargarEstancias();
            if (Session.Rol != "CAMPO") await CargarClientes();
            if (Session.Rol == "ADMINISTRADOR") await CargarEmpleados();
        }




        // CARGA DE DATOS

        /// <summary>
        /// Carga las parcelas desde la API en los user controls y los añade al flow layout panel.
        /// </summary>
        private async Task CargarParcelas()
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
            _parcelas = parcelas;
        }

        // Carga en el flowlayout la lista de parcelas ya filtradas
        private void CargarParcelasFiltradas(List<Parcela> listaFiltrada)
        {
            flpParcelas.Controls.Clear();
            foreach (Parcela p in listaFiltrada)
            {
                ucParcela uc = new ucParcela();
                uc.SetData(p);
                uc.ParcelaClick += ParcelaClick;
                flpParcelas.Controls.Add(uc);
            }
        }


        /// <summary>
        /// Carga los empleados desde la API en los user controls y los añade al flow layout panel.
        /// </summary>
        private async Task CargarEmpleados()
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


        /// <summary>
        /// Carga los servicios desde la API en los user control y los inserta en el flowlayoutpanel.
        /// </summary>
        private async Task CargarServicios()
        {
            flpServicios.Controls.Clear();
            List<Servicio> servicios = await _api.GetAllAsync<Servicio>("api/servicios");
            foreach (Servicio ser in servicios)
            {
                ucServiciosLista uc = new ucServiciosLista();
                uc.SetData(ser);
                uc.ServicioClick += ServicioClick;
                flpServicios.Controls.Add(uc);
            }
        }


        /// <summary>
        /// Carga las estancias desde la APi en los user control y los inserta en el flowlayoutpanel.
        /// </summary>
        /// <returns></returns>
        public async Task CargarEstancias()
        {
            flpEstancias.Controls.Clear();
            List<Estancia> estancias = await _api.GetAllAsync<Estancia>("api/estancias");
            estancias = estancias.OrderBy(est => est.CheckIn).ToList();
            foreach (Estancia est in estancias)
            {
                ucEstanciasLista uc = new ucEstanciasLista();
                uc.SetData(est);
                uc.EstanciaClick += EstanciaClick;
                flpEstancias.Controls.Add(uc);
            }

        }


        private async Task CargarHistorial()
        {
            if (ucParcelaDatos.ParcelaActual == null)
            {
                MessageBox.Show("Debe seleccionar una parcela para ver su historial.", "Parcela no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                flpHistorial.Controls.Clear();
                List<Estancia> estancias = await _api.GetAllAsync<Estancia>("api/estancias");
                estancias = estancias.Where(est => est.Parcela != null && est.Parcela.Id == ucParcelaDatos.ParcelaActual.Id).ToList();
                estancias = estancias.OrderBy(est => est.CheckIn).ToList();
                foreach (Estancia est in estancias)
                {
                    ucHistorial uc = new ucHistorial();
                    uc.SetData(est);
                    flpHistorial.Controls.Add(uc);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarClientes()
        {
            flpClientes.Controls.Clear();
            List<Cliente> clientes = await _api.GetAllAsync<Cliente>("api/clientes");
            foreach (Cliente cliente in clientes)
            {
                ucClientesLista uc = new ucClientesLista();
                uc.SetData(cliente);
                uc.ClienteClick += ClienteClick;
                flpClientes.Controls.Add(uc);
            }
        }




        // ----------------------------------
        // FUNCIONES DE LOS BOTONES
        // ----------------------------------


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Logout();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }



        //------------------- PARTE DEL PANEL DE PARCELAS -----------------------


        /// <summary>
        /// Cambia el panel principal a la vista de parcelas.
        /// </summary>
        private async void btnParcelas_Click(object sender, EventArgs e)
        {
            pnlEmpleados.Visible = false;
            pnlServicios.Visible = false;
            pnlEstancias.Visible = false;
            pnlClientes.Visible = false;
            pnlParcelas.Visible = true;

            btnParcelas.BackColor = Color.FromArgb(160, 210, 140);
            btnServicios.BackColor = Color.FromArgb(197, 239, 170);
            btnEstancias.BackColor = Color.FromArgb(197, 239, 170);
            btnClientes.BackColor = Color.FromArgb(197, 239, 170);
            btnEmpleados.BackColor = Color.FromArgb(197, 239, 170);

            try
            {
                await CargarParcelas();

                if (String.Equals(Session.Rol, "CAMPO"))
                {
                    btnReservar.Visible = false;
                    btnClientesEstancia.Visible = false;
                    btnServiciosEstancia.Visible = false;
                }

                if (!String.Equals(Session.Rol, "CAMPO"))
                {
                    btnClientes.Visible = true;
                    await CargarClientes();
                }

                if (String.Equals(Session.Rol, "ADMINISTRADOR"))
                {
                    btnEmpleados.Visible = true;
                    await CargarEmpleados();
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


        private void pbMapa_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            using (var form = new FormVerMapa())
            {
                form.ShowDialog(this);
            }
            this.Show();
        }


        // Parte referente al panel de filtros
        private void btnFiltros_Click(object sender, EventArgs e)
        {
            if (pnlDatos.Visible == true) pnlDatos.Visible = false; else pnlDatos.Visible = true;

            if (pnlFiltros.Visible == true)
            {
                pnlFiltros.Visible = false;
                ckFiltroBaño.Checked = false;
                ckFiltroEntrada.Checked = false;
                ckFiltroEstado.Checked = false;
                ckFiltroPrecioMin.Checked = false;
                ckFiltroPrecioMax.Checked = false;
                ckFiltroSombra.Checked = false;
                ckFiltroTranquilo.Checked = false;
                ckFiltroVistas.Checked = false;
            }
            else
            {
                pnlFiltros.Visible = true;
            }
        }


        private void ckFiltroEstado_CheckedChanged(object sender, EventArgs e)
        {
            cbFiltroEstado.Enabled = !cbFiltroEstado.Enabled;
        }

        private void ckFiltroPrecio_CheckedChanged(object sender, EventArgs e)
        {
            nudFiltroPrecioMin.Enabled = !nudFiltroPrecioMin.Enabled;
        }

        private void ckFiltroPrecioMax_CheckedChanged(object sender, EventArgs e)
        {
            nudFiltroPrecioMax.Enabled = !nudFiltroPrecioMax.Enabled;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var filtro = ConstruirFiltroParcela();
            var pred = ParcelaFiltering.BuildPredicate(filtro);

            if (ckFiltroPrecioMin.Checked && ckFiltroPrecioMax.Checked && nudFiltroPrecioMin.Value > nudFiltroPrecioMax.Value)
            {
                MessageBox.Show("El precio mínimo no puede ser mayor que el máximo.", "Filtro de precio",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var filtradas = _parcelas.Where(pred).ToList();
            CargarParcelasFiltradas(filtradas);
        }

        public class ParcelaFilter
        {
            public bool? CercaBanos { get; set; }
            public bool? TieneVistas { get; set; }
            public bool? ZonaSombra { get; set; }
            public bool? CercaEntrada { get; set; }
            public bool? ZonaTranquila { get; set; }
            public EnumEstados? Estado { get; set; }
            public double? PrecioMin { get; set; }
            public double? PrecioMax { get; set; }
        }

        private ParcelaFilter ConstruirFiltroParcela()
        {
            return new ParcelaFilter
            {
                CercaBanos = ckFiltroBaño.Checked ? true : (bool?)null,
                TieneVistas = ckFiltroVistas.Checked ? true : (bool?)null,
                ZonaSombra = ckFiltroSombra.Checked ? true : (bool?)null,
                CercaEntrada = ckFiltroEntrada.Checked ? true : (bool?)null,
                ZonaTranquila = ckFiltroTranquilo.Checked ? true : (bool?)null,

                Estado = ckFiltroEstado.Checked
                    ? (cbFiltroEstado.SelectedItem is EnumEstados e ? e : (EnumEstados?)null)
                    : null,

                PrecioMin = ckFiltroPrecioMin.Checked ? (double)nudFiltroPrecioMin.Value : null,
                PrecioMax = ckFiltroPrecioMax.Checked ? (double)nudFiltroPrecioMax.Value : null
            };
        }

        public static class ParcelaFiltering
        {
            public static Func<Parcela, bool> BuildPredicate(ParcelaFilter f)
            {
                return p =>
                    // Checks booleanos
                    (f.CercaBanos == null || p.CercaBanos == f.CercaBanos.Value) &&
                    (f.TieneVistas == null || p.TieneVistas == f.TieneVistas.Value) &&
                    (f.ZonaSombra == null || p.ZonaSombra == f.ZonaSombra.Value) &&
                    (f.CercaEntrada == null || p.CercaEntrada == f.CercaEntrada.Value) &&
                    (f.ZonaTranquila == null || p.ZonaTranquila == f.ZonaTranquila.Value) &&

                    // Estado
                    (f.Estado == null || p.Estado == f.Estado.Value) &&

                    // Precio (min/max independientes)
                    (f.PrecioMin == null || p.PrecioNoche >= f.PrecioMin.Value) &&
                    (f.PrecioMax == null || p.PrecioNoche <= f.PrecioMax.Value);
            }
        }



        // -- PANEL DATOS

        /// <summary>
        /// Cambia el user control visible a la vista de datos de parcela.
        /// Cambia la visibilidad de los botones según la vista.
        /// </summary>
        private void btnDatos_Click(object sender, EventArgs e)
        {
            ucEstanciaActual1.Visible = false;
            flpHistorial.Visible = false;
            ucParcelaDatos.Visible = true;

            btnClientesEstancia.Visible = false;
            btnServiciosEstancia.Visible = false;
            btnImagen.Visible = true;

            if (String.Equals(Session.Rol, "CAMPO")) btnReservar.Visible = false; else btnReservar.Visible = true;
            btnMantenimiento.Visible = true;
        }


        /// <summary>
        /// Muestra los datos de la parcela seleccionada en el user control de datos.
        /// Si la parcela tiene una estancia hoy (estado RESERVADA), también muestra la estancia en el user control de estancia actual.
        /// </summary>
        private async void ParcelaClick(object? sender, Parcela parcela)
        {
            try
            {
                // Datos de parcela
                ucParcelaDatos.MostrarDatos(parcela);
                btnDatos.PerformClick();
                if (parcela.Estado != EnumEstados.RESERVADA)
                {
                    ucEstanciaActual1.Limpiar();
                    return;
                }
                // Datos de estancia actual
                var estancias = await _api.GetAllAsync<Estancia>("api/estancias");
                DateOnly hoy = DateOnly.FromDateTime(DateTime.Today);
                var estanciaActual = estancias.FirstOrDefault(es =>
                    es.Parcela != null &&
                    es.Parcela.Id == parcela.Id &&
                    ((es.CheckOut == null && es.CheckIn <= hoy) ||
                    (es.CheckOut != null && es.CheckIn <= hoy && hoy < es.CheckOut.Value))
                    );
                ucEstanciaActual1.SetData(estanciaActual);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// Abre formulario para ver la imágen de la parcela
        /// </summary>
        private void btnImagen_Click(object sender, EventArgs e)
        {
            if (ucParcelaDatos.ParcelaActual == null)
            {
                MessageBox.Show("Debe seleccionar una parcela para ver su imagen.", "Parcela no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ucParcelaDatos.ParcelaActual.Imagen == null)
            {
                MessageBox.Show("La parcela seleccionada no tiene una imagen.", "Sin imagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.Hide();
            using (var form = new FormsVerImagen(_api, ucParcelaDatos.ParcelaActual))
            {
                form.ShowDialog(this);
            }
            this.Show();
        }


        /// <summary>
        /// Abre formulario para crear nueva parcela
        /// </summary>
        private async void btnNuevaParcela_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var form = new FormNuevaParcela(_api, null))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    ucParcelaDatos.MostrarDatos(form.ParcelaCreada);
                    btnDatos.PerformClick();
                    await CargarParcelas();
                }
            }
            this.Show();
        }


        /// <summary>
        /// Abre formulario y carga datos de parcela para editarla
        /// </summary>
        private async void btnEditarParcela_Click(object sender, EventArgs e)
        {
            if (ucParcelaDatos.ParcelaActual == null)
            {
                MessageBox.Show("Debe seleccionar una parcela para editarla.", "Parcela no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var form = new FormNuevaParcela(_api, ucParcelaDatos.ParcelaActual))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    ucParcelaDatos.MostrarDatos(form.ParcelaCreada);
                    btnDatos.PerformClick();
                    await CargarParcelas();
                }
            }

        }


        /// <summary>
        /// Elimina la parcela seleccionada
        /// </summary>
        private async void btnEliminarParcela_Click(object sender, EventArgs e)
        {
            if (ucParcelaDatos.ParcelaActual == null)
            {
                MessageBox.Show("Debe seleccionar una parcela para eliminarla.", "Parcela no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Se eliminará la parcela seleccionada.\n¿Desea continuar?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idParcela = ucParcelaDatos.ParcelaActual.Id;
                await _api.Delete<Parcela>("api/parcelas", idParcela);
                MessageBox.Show("Parcela eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CargarParcelas();
            }

        }


        /// <summary>
        /// Abre el formulario para crear una nueva estancia (reserva) en la parcela seleccionada.
        /// </summary>
        private async void btnReservar_Click(object sender, EventArgs e)
        {
            try
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

                var form = new FormNuevaEstancia(parcelaSeleccionada, _api, null);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    ucEstanciaActual1.SetData(form.EstanciaCreada);
                    await CargarParcelas();
                }

                // Descargar ficha de clientes de la estancia 
                int idEstancia = ucEstanciaActual1.EstanciaActual.Id;
                byte[] pdfBytes = await _api.GetBytesAsync($"/api/estancias/{idEstancia}/clientes/pdf");

                string rutaDescargas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

                int idParcela = ucEstanciaActual1.EstanciaActual.Parcela.Id;
                string fecha = DateOnly.FromDateTime(DateTime.Now).ToString("dd-MM-yyyy");
                string rutaCompleta = Path.Combine(rutaDescargas, $"Parcela_{idParcela}_{fecha}_clientes.pdf");

                await File.WriteAllBytesAsync(rutaCompleta, pdfBytes);

                MessageBox.Show($"PDF guardado en:\n{rutaCompleta}");

            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// Altera el estado de la parcela seleccionada entre MANTENIMIENTO y LIBRE.
        /// </summary>
        private async void btnMantenimiento_Click(object sender, EventArgs e)
        {
            try
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
                await CargarParcelas();
                ucParcelaDatos.MostrarDatos(parcela);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // -- PANEL ESTANCIA ACTUAL

        /// <summary>
        /// Cambia el user control visible a la vista de estancia actual.
        /// Cambia la visibilidad de los botones según la vista.
        /// </summary>
        private void btnEstanciaActual_Click(object sender, EventArgs e)
        {
            ucParcelaDatos.Visible = false;
            flpHistorial.Visible = false;
            ucEstanciaActual1.Visible = true;

            btnReservar.Visible = false;
            btnMantenimiento.Visible = false;
            btnImagen.Visible = false;

            btnClientesEstancia.Visible = true;
            btnServiciosEstancia.Visible = true;
        }


        /// <summary>
        /// Abre el formulario que muestra los clientes de la estancia actual
        /// </summary>
        private void btnClientesEstancia_Click(object sender, EventArgs e)
        {
            Parcela parcela = ucParcelaDatos.ParcelaActual;
            if (parcela == null)
            {
                MessageBox.Show("Debe seleccionar una parcela para ver sus clientes y servicios.", "Parcela no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (parcela.Estado != EnumEstados.RESERVADA)
            {
                MessageBox.Show("La parcela no tiene una estancia hoy.", "Estancia no activa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var estanciaActual = ucEstanciaActual1.EstanciaActual;

            this.Hide();
            using (var form = new FormVerClientesEstancia(estanciaActual))
            {
                form.ShowDialog(this);
            }
            this.Show();
        }


        /// <summary>
        /// Abre el formulario que muestra los servicios de la estancia actual
        /// </summary>
        private void btnServiciosEstancia_Click(object sender, EventArgs e)
        {
            Parcela parcela = ucParcelaDatos.ParcelaActual;
            if (parcela.Estado != EnumEstados.RESERVADA)
            {
                MessageBox.Show("La parcela no tiene una estancia hoy.", "Estancia no activa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var estanciaActual = ucEstanciaActual1.EstanciaActual;
            this.Hide();
            using (var form = new FormVerServiciosEstancia(estanciaActual))
            {
                form.ShowDialog(this);
            }
            this.Show();
        }


        // -- PANEL HISTORIAL DE ESTANCIAS

        /// <summary>
        /// Cambia el user control visible a la vista de historial de estancias.
        /// </summary>
        private async void btnHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                ucParcelaDatos.Visible = false;
                ucEstanciaActual1.Visible = false;
                btnImagen.Visible = false;
                flpHistorial.Visible = true;
                await CargarHistorial();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private bool _cargandoParcelas = false;
        private async void btnRefrescarParcelas_Click(object sender, EventArgs e)
        {
            if (_cargandoParcelas) return;

            _cargandoParcelas = true;
            btnRefrescarParcelas.Enabled = false;

            try
            {
                await CargarParcelas();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                _cargandoParcelas = false;
                btnRefrescarParcelas.Enabled = true;
            }
        }



        //------------------- PARTE DEL PANEL DE EMPLEADOS -----------------------


        /// <summary>
        /// Cambia el panel principal a la vista de empleados.
        /// </summary>
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            pnlServicios.Visible = false;
            pnlParcelas.Visible = false;
            pnlEstancias.Visible = false;
            pnlClientes.Visible = false;
            pnlEmpleados.Visible = true;

            btnParcelas.BackColor = Color.FromArgb(197, 239, 170);
            btnServicios.BackColor = Color.FromArgb(197, 239, 170);
            btnEstancias.BackColor = Color.FromArgb(197, 239, 170);
            btnClientes.BackColor = Color.FromArgb(197, 239, 170);
            btnEmpleados.BackColor = Color.FromArgb(160, 210, 140);
        }


        /// <summary>
        /// Muestra los datos del empleado seleccionado de la lista en el user control de datos de empleado.
        /// </summary>
        private void EmpleadoClick(object? sender, Empleado empleado)
        {
            ucEmpleadoDatos1.MostrarDatos(empleado);

        }


        /// <summary>
        /// Abre el formulario de datos de empleado para crear uno nuevo.
        /// </summary>
        private async void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                var form = new FormDatosEmpleado(null, _api);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    await CargarEmpleados();
                    ucEmpleadoDatos1.MostrarDatos(form.EmpleadoGuardado);
                }
                this.Show();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// Abre el formulario de datos de empleado para editar el empleado seleccionado.
        /// Pasa el empleado seleccionado al formulario.
        /// </summary>
        private async void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                var empleadoSeleccionado = ucEmpleadoDatos1.EmpleadoActual;
                if (empleadoSeleccionado == null)
                {
                    MessageBox.Show("Debe seleccionar un empleado para editarlo.", "Empleado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var form = new FormDatosEmpleado(empleadoSeleccionado, _api);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    await CargarEmpleados();
                    ucEmpleadoDatos1.MostrarDatos(form.EmpleadoGuardado);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// Muestra mensaje de confirmación y elimina el empleado seleccionado mediante la API.
        /// Comrpueba que hay un empleado seleccionado.
        /// </summary>
        private async void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            try
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
                    await CargarEmpleados();
                    ucEmpleadoDatos1.Limpiar();
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private bool _cargandoEmpleados = false;
        private async void btnRefrescarEmpleados_Click(object sender, EventArgs e)
        {
            if (_cargandoEmpleados) return;

            _cargandoEmpleados = true;
            btnRefrescarEmpleados.Enabled = false;

            try
            {
                await CargarEmpleados();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                _cargandoEmpleados = false;
                btnRefrescarEmpleados.Enabled = true;
            }
        }


        //------------------- PARTE DEL PANEL DE SERVICIOS -----------------------


        /// <summary>
        /// Cambia el panel principal a la vista de servicios.
        /// </summary>
        private void btnServicios_Click(object sender, EventArgs e)
        {
            pnlEmpleados.Visible = false;
            pnlParcelas.Visible = false;
            pnlEstancias.Visible = false;
            pnlClientes.Visible = false;
            pnlServicios.Visible = true;

            btnParcelas.BackColor = Color.FromArgb(197, 239, 170);
            btnServicios.BackColor = Color.FromArgb(160, 210, 140);
            btnEstancias.BackColor = Color.FromArgb(197, 239, 170);
            btnClientes.BackColor = Color.FromArgb(197, 239, 170);
            btnEmpleados.BackColor = Color.FromArgb(197, 239, 170);
        }


        /// <summary>
        /// Muestra los datos del servicio seleccionado de la lista en el user control de datos del servicio.
        /// </summary>
        private void ServicioClick(object? sender, Servicio servicio)
        {
            ucServicioDatos1.MostrarDatos(servicio);
        }


        /// <summary>
        /// Abre formulario para crear nuevo servicio.
        /// </summary>
        private async void btnNuevoServicio_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                var form = new FormDatosServicio(null, _api);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    await CargarServicios();
                    ucServicioDatos1.MostrarDatos(form.ServicioGuardado);
                }
                this.Show();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// Abre formulario para editar datos del servicio
        /// Pasa servicio seleccionado como parametro
        /// </summary>
        private async void btnEditarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                var servicioSeleccionado = ucServicioDatos1.ServicioActual;
                if (servicioSeleccionado == null)
                {
                    MessageBox.Show("Debe seleccionar un servicio para editarlo.", "Servicio no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var form = new FormDatosServicio(servicioSeleccionado, _api);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    await CargarServicios();
                    ucServicioDatos1.MostrarDatos(form.ServicioGuardado);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// Muestra mensaje de confirmación y elimina el servicio seleccionado mediante la API.
        /// Comprueba que hay un servicio seleccionado.
        /// </summary>
        private async void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                Servicio servicio = ucServicioDatos1.ServicioActual;
                if (servicio == null)
                {
                    MessageBox.Show("Debe seleccionar un servicio para eliminarlo.", "Servicio no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var result = MessageBox.Show("Se eliminará el servicio.\n¿Desea continuar?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    await _api.Delete<Servicio>("api/servicios", ucServicioDatos1.ServicioActual.Id);
                    MessageBox.Show("Servicio eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CargarServicios();
                    ucServicioDatos1.Limpiar();
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private bool _cargandoServicios = false;
        private async void btnRefrescarServicios_Click(object sender, EventArgs e)
        {
            if (_cargandoServicios) return;

            _cargandoServicios = true;
            btnRefrescarServicios.Enabled = false;

            try
            {
                await CargarServicios();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                _cargandoServicios = false;
                btnRefrescarServicios.Enabled = true;
            }
        }



        //------------------- PARTE DEL PANEL DE ESTANCIAS -----------------------


        /// <summary>
        /// Cambia el panel principal a la vista de estancias.
        /// </summary>
        private void btnEstancias_Click(object sender, EventArgs e)
        {
            pnlParcelas.Visible = false;
            pnlEmpleados.Visible = false;
            pnlServicios.Visible = false;
            pnlClientes.Visible = false;
            pnlEstancias.Visible = true;

            btnParcelas.BackColor = Color.FromArgb(197, 239, 170);
            btnServicios.BackColor = Color.FromArgb(197, 239, 170);
            btnEstancias.BackColor = Color.FromArgb(160, 210, 140);
            btnClientes.BackColor = Color.FromArgb(197, 239, 170);
            btnEmpleados.BackColor = Color.FromArgb(197, 239, 170);
        }


        /// <summary>
        /// 
        /// </summary>
        private void EstanciaClick(object? sender, Estancia estancia)
        {
            ucEstanciaActual2.SetData(estancia);
        }


        private async void btnDescargarFicha_Click(object sender, EventArgs e)
        {
            if (ucEstanciaActual2.EstanciaActual == null)
            {
                MessageBox.Show("Debe seleccionar una estancia para descargar su ficha.", "Estancia no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEstancia = ucEstanciaActual2.EstanciaActual.Id;
            byte[] pdfBytes = await _api.GetBytesAsync($"/api/estancias/{idEstancia}/clientes/pdf");

            string rutaDescargas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

            int idParcela = ucEstanciaActual2.EstanciaActual.Parcela.Id;
            string fecha = DateOnly.FromDateTime(DateTime.Now).ToString("dd-MM-yyyy");
            string rutaCompleta = Path.Combine(rutaDescargas, $"Parcela_{idParcela}_{fecha}_clientes.pdf");

            await File.WriteAllBytesAsync(rutaCompleta, pdfBytes);

            MessageBox.Show($"PDF guardado en:\n{rutaCompleta}");

        }


        /// <summary>
        /// 
        /// </summary>
        private bool _cargandoEstancias = false;
        private async void btnRefrescarEstancias_Click(object sender, EventArgs e)
        {
            if (_cargandoEstancias) return;

            _cargandoEstancias = true;
            btnRefrescarEstancias.Enabled = false;

            try
            {
                await CargarEstancias();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                _cargandoEstancias = false;
                btnRefrescarEstancias.Enabled = true;
            }
        }



        private async void btnEditarEstancia_Click(object sender, EventArgs e)
        {
            try
            {
                var estancia = ucEstanciaActual2.EstanciaActual;
                if (estancia == null)
                {
                    MessageBox.Show("Debe seleccionar una estancia para editarla.", "Estancia no seleccionada",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var form = new FormNuevaEstancia(estancia.Parcela, _api, estancia);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    await CargarEstancias();
                    ucEstanciaActual2.SetData(form.EstanciaCreada);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private async void btnEliminarEstancia_Click(object sender, EventArgs e)
        {
            try
            {
                Estancia estancia = ucEstanciaActual2.EstanciaActual;
                if (estancia == null)
                {
                    MessageBox.Show("Debe seleccionar una estancia para eliminarla.", "Estancia no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var result = MessageBox.Show("Se eliminará la estancia.\n¿Desea continuar?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    await _api.Delete<Estancia>("api/estancias", ucEstanciaActual2.EstanciaActual.Id);
                    MessageBox.Show("Estancia eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CargarEstancias();
                    await CargarParcelas();
                    ucEstanciaActual2.Limpiar();
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        //------------------- PARTE DEL PANEL DE CLIENTES -----------------------

        private void btnClientes_Click(object sender, EventArgs e)
        {
            pnlParcelas.Visible = false;
            pnlEmpleados.Visible = false;
            pnlServicios.Visible = false;
            pnlEstancias.Visible = false;
            pnlClientes.Visible = true;

            btnParcelas.BackColor = Color.FromArgb(197, 239, 170);
            btnServicios.BackColor = Color.FromArgb(197, 239, 170);
            btnEstancias.BackColor = Color.FromArgb(197, 239, 170);
            btnClientes.BackColor = Color.FromArgb(160, 210, 140);
            btnEmpleados.BackColor = Color.FromArgb(197, 239, 170);

            if (!String.Equals(Session.Rol, "ADMINISTRADOR"))
            {
                btnEliminarCliente.Visible = false;
                btnEliminarServicio.Visible = false;
            }
        }


        private bool _cargandoClientes = false;
        private async void RefrescarClientes(object sender, EventArgs e)
        {
            if (_cargandoClientes) return;

            _cargandoClientes = true;
            btnRefrescarClientes.Enabled = false;
            try
            {
                await CargarClientes();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                _cargandoClientes = false;
                btnRefrescarClientes.Enabled = true;
            }
        }



        private void ClienteClick(object? sender, Cliente e)
        {
            ucClienteDatos1.MostrarDatos(e);
        }



        private async void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = ucClienteDatos1.ClienteActual;
                if (cliente == null)
                {
                    MessageBox.Show("Debe seleccionar un cliente para eliminarlo.", "Cliente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var result = MessageBox.Show("Se eliminará el cliente.\n¿Desea continuar?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    await _api.Delete<Cliente>("api/clientes", cliente.Id);
                    MessageBox.Show("Cliente eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CargarClientes();
                    ucClienteDatos1.Limpiar();

                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private async void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FormNuevoCliente(_api, null);
                if (form.ShowDialog(this) == DialogResult.OK && form.ClienteNuevo != null)
                {
                    var nuevoCliente = form.ClienteNuevo;
                    await CargarClientes();
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private async void btnEditarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = ucClienteDatos1.ClienteActual;
                if (cliente == null)
                {
                    MessageBox.Show("Debe seleccionar un cliente para editarlo.", "Cliente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var form = new FormNuevoCliente(_api, cliente);
                if (form.ShowDialog(this) == DialogResult.OK && form.ClienteNuevo != null)
                {
                    var nuevoCliente = form.ClienteNuevo;
                    await CargarClientes();
                    ucClienteDatos1.MostrarDatos(form.ClienteNuevo);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void lblCreditos_DoubleClick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int numero = rnd.Next(1, 251);
            string msj = (numero == 1) ? ("Desarrollado por:\n\n-ChatGPT\n-Copilot\n-Gemini\n-Base44\n-Sudor y lágrimas") : ("Desarrollado por:\n\n-Daniel Cabeza\n-Oriol Fernández\n-Miguel Inglés\n-Raul Buenaga\n-Francisco Sitjar");
            MessageBox.Show(msj, "Créditos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
