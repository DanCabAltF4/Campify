using Model;
using Repository;
using System.Runtime.InteropServices;

namespace Campify
{
    public partial class FormDatosEmpleado : Form
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
        private Empleado? _empleado;

        public Empleado EmpleadoGuardado { get; set; }



        // ----------------------------
        // CONSTRUCTOR Y LOAD
        // ----------------------------

        public FormDatosEmpleado(Empleado empleadoSeleccionado, ApiCampify api)
        {
            InitializeComponent();
            _empleado = empleadoSeleccionado;
            _api = api;

            cbPuesto.DataSource = Enum.GetValues(typeof(EnumPuestos));
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            if(_empleado == null)
            {
                lbltxtId.Text = "---";
                txbDni.Text = "";
                chbActivo.Checked = true;
                txbNombre.Text = "";
                txbApellidos.Text = "";

            }

                cbPuesto.SelectedItem = EnumPuestos.CAMPO;


            CargarDatosEmpleado();
        }


        // ----------------------------
        // METODOS DEL FORMULARIO
        // ----------------------------

        private void CargarDatosEmpleado()
        {
            if (_empleado != null)
            {
                lblId.Text = _empleado.Id.ToString();
                txbNombre.Text = _empleado.Nombre;
                txbApellidos.Text = _empleado.Apellidos;
                txbDni.Text = _empleado.Dni;
                txbTelefono.Text = _empleado.Telefono;
                cbPuesto.SelectedItem = _empleado.Puesto;
                chbActivo.Checked = _empleado.Activo;
            }
        }



        // ----------------------------
        // FUNCIONES DE LOS BOTONES
        // ----------------------------

        /// <summary>
        /// Cierra el formulario sin guardar cambios.
        /// </summary>

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        /// <summary>
        /// Si el empleado es nuevo (Id=0), lo crea mediante la API.
        /// Si el empleado ya existe (Id!=0), actualiza sus datos mediante la API.
        /// </summary>
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Asigna los valores de los controles al empleado
                if (_empleado == null) _empleado = new Empleado(); // Asegura que _empleado no sea null
                _empleado.Nombre = txbNombre.Text;
                _empleado.Apellidos = txbApellidos.Text;
                _empleado.Dni = txbDni.Text;
                _empleado.Telefono = txbTelefono.Text;
                _empleado.Puesto = (EnumPuestos)cbPuesto.SelectedItem;
                _empleado.Activo = chbActivo.Checked;

                // Comprueba si es un empleado nuevo o existente y llama a la API correspondiente
                if (_empleado.Id == 0)
                {
                    EmpleadoGuardado = await _api.Create<Empleado>("api/empleados", _empleado);
                    MessageBox.Show("Empleado creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se modificará al empleado.\n¿Desea continuar?", "Confirmar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    EmpleadoGuardado = await _api.Update<Empleado>("api/empleados", _empleado.Id, _empleado);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
