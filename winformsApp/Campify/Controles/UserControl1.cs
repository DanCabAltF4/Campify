using Model;

namespace Controles
{
    public partial class ucParcela : UserControl
{
        private int IdParcela { get; set; }
  
        public ucParcela()
        {
            InitializeComponent();
        }

        public void SetData(Parcela p)
        {
            IdParcela = p.Id;
            lblId.Text = p.Id.ToString();
            lblTipo.Text = p.tipo.ToString();
            lblEstado.Text = p.estado.ToString();
            lblPrecioNoche.Text = p.PrecioPorNoche.ToString("C2");
        }

    }
}
