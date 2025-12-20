using Controles;
using Forms;
using Model;
using Repository;

namespace Campify
{
    public partial class FormPrincipal : Form
    {

        private readonly ApiCampify _api = new ApiCampify("http://localhost:8080/");
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarParcelas();
        }



        // ----------------------------------
        // METODOS PRINCIPALES


        private async void CargarParcelas()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                List<Parcela> parcelas = await _api.GetAllAsync<Parcela>("api/parcelas");
                foreach (Parcela p in parcelas)
                {
                    ucParcela uc = new ucParcela();
                    uc.SetData(p);
                    uc.ParcelaDobleClick += ParcelaDobleClick;
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("No se pudo conectar a la API- ¿Está corriendo Spring?", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // ----------------------------------
        // FUNCIONES DE LOS BOTONES

        private void ParcelaDobleClick(object? sender, Parcela e)
        {
            ucParcelaDatos.MostrarDatos(e);
        }

        private void btMapa_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            pbMapa.Visible = true;
        }

        private void btLista_Click(object sender, EventArgs e)
        {
            pbMapa.Visible = false;
            flowLayoutPanel1.Visible = true;
        }


        private void btnReservar_Click(object sender, EventArgs e)
        {
            Parcela p = ucParcelaDatos.ParcelaActual;
            if (p == null)
            {
                MessageBox.Show("Debe seleccionar una parcela para reservarla.", "Parcela no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (p.Estado != EnumEstados.LIBRE)
            {
                MessageBox.Show("La parcela seleccionada no está libre.", "Parcela no libre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var form = new FormNuevaEstancia(p);
            if(form.ShowDialog(this) == DialogResult.OK)
            {
                CargarParcelas();
            }
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            pnlEmpleados.Visible = false;
            pnlParcelas.Visible = false;
            pnlServicios.Visible = true;
        }

        private void btnParcelas_Click(object sender, EventArgs e)
        {
            pnlEmpleados.Visible = false;
            pnlServicios.Visible = false;
            pnlParcelas.Visible = true;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            pnlServicios.Visible = false;
            pnlParcelas.Visible = false;
            pnlEmpleados.Visible = true;
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            ucEstanciaActual1.Visible = false;
            ucHistorial1.Visible = false;
            ucParcelaDatos.Visible = true;
        }

        private void btnEstanciaActual_Click(object sender, EventArgs e)
        {
            ucParcelaDatos.Visible = false;
            ucHistorial1.Visible = false;
            ucEstanciaActual1.Visible = true;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            ucParcelaDatos.Visible = false;
            ucEstanciaActual1.Visible = false;
            ucHistorial1.Visible = true;

        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            Parcela parcela = ucParcelaDatos.ParcelaActual;
            parcela.Estado = EnumEstados.MANTENIMIENTO;
            CargarParcelas();
        }
    }
}
