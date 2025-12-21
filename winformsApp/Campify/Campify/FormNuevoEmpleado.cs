using Model;

namespace Campify
{
    public partial class FormNuevoEmpleado : Form
    {

        // ----------------------------
        // CONSTRUCTOR Y LOAD
        // ----------------------------

        public FormNuevoEmpleado()
        {
            InitializeComponent();
            cbPuesto.DataSource = Enum.GetValues(typeof(EnumPuestos));
            cbPuesto.SelectedItem = EnumPuestos.CAMPO;
        }


        // ----------------------------
        // METODOS DEL FORMULARIO
        // ----------------------------

        public void Limpiar() { 
            txbNombre.Text ="";
            txbApellidos.Text = "";
            txbDni.Text = "";
            txbTelefono.Text = "";
            cbPuesto.SelectedItem = EnumPuestos.CAMPO;
            chbActivo.Checked = true;
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
