using Controles;
using Forms;
using Model;

namespace Campify
{
    public partial class FormsPrincipal : Form
    {
        public FormsPrincipal()
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
                new Parcela(3, EnumTipos.GRANDE, 70, false, false, false, false, false, EnumEstados.OCUPADA, 4),
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
            var form = new FormsNuevaEstancia();
            form.ShowDialog(this);
        }
    }
}
