using Controles;
using Forms;
using Model;

namespace Campify
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void CargarParcelas()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Parcela> parcelas = new List<Parcela>  //Cambiar por metodo para recibir parcelas de la BD por Spring
            {
                new Parcela(1, EnumTipos.PEQUENA, 50, false, true, false, false, false, EnumEstados.LIBRE, 2),
                new Parcela(2, EnumTipos.MEDIANA, 70, false, false, true, true, false, EnumEstados.RESERVADA, 3),
                new Parcela(3, EnumTipos.GRANDE, 70, false, false, false, false, false, EnumEstados.INTERESADO, 4),
                new Parcela(4, EnumTipos.MEDIANA, 70, true, true, true, true, true, EnumEstados.MANTENIMIENTO, 2),
            };
            foreach (Parcela p in parcelas)
            {
                ucParcela uc = new ucParcela();
                uc.SetData(p);
                uc.ParcelaDobleClick += ParcelaDobleClick;
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

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

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarParcelas();
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
            form.ShowDialog(this);
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
