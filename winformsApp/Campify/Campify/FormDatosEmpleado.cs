using Model;
using Repository;

namespace Campify
{
    public partial class FormDatosEmpleado : Form
    {
        // ----------------------------------
        // DECLARACION DE VARIABLES Y OBJETOS
        // ----------------------------------
        private readonly ApiCampify _api = new ApiCampify("http://localhost:8080/");
        private Empleado _empleadoSeleccionado;

        public Empleado EmpleadoGuardado { get; set; }



        // ----------------------------
        // CONSTRUCTOR Y LOAD
        // ----------------------------

        public FormDatosEmpleado(Empleado empleadoSeleccionado)
        {
            InitializeComponent();
            _empleadoSeleccionado = empleadoSeleccionado;

            cbPuesto.DataSource = Enum.GetValues(typeof(EnumPuestos));
            cbPuesto.SelectedItem = EnumPuestos.CAMPO;

            CargarDatosEmpleado();
        }


        // ----------------------------
        // METODOS DEL FORMULARIO
        // ----------------------------

        private void CargarDatosEmpleado()
        {
            if (_empleadoSeleccionado != null)
            {
                lblId.Text = _empleadoSeleccionado.Id.ToString();
                txbNombre.Text = _empleadoSeleccionado.Nombre;
                txbApellidos.Text = _empleadoSeleccionado.Apellidos;
                txbDni.Text = _empleadoSeleccionado.Dni;
                txbTelefono.Text = _empleadoSeleccionado.Telefono;
                cbPuesto.SelectedItem = _empleadoSeleccionado.Puesto;
                chbActivo.Checked = _empleadoSeleccionado.Activo;
            }
        }



        // ----------------------------
        // FUNCIONES DE LOS BOTONES
        // ----------------------------

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
