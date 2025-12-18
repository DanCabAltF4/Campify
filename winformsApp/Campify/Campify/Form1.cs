using Controles;
using Model;

namespace Campify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CargarParcelas()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Parcela> parcelas = new List<Parcela>
            {
                new Parcela(1, EnumTipos.PEQUENA, 50, false, false, false, false, false, EnumEstados.LIBRE, 4),
                new Parcela(2, EnumTipos.MEDIANA, 70, false, false, false, false, false, EnumEstados.RESERVADA, 4),
                new Parcela(3, EnumTipos.GRANDE, 70, false, false, false, false, false, EnumEstados.OCUPADA, 4),
                new Parcela(4, EnumTipos.MEDIANA, 70, false, false, false, false, false, EnumEstados.MANTENIMIENTO, 4),
            };
            foreach (Parcela p in parcelas)
            {
                ucParcela uc = new ucParcela();
                uc.SetData(p);
                flowLayoutPanel1.Controls.Add(uc);
            }
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
    }
}
