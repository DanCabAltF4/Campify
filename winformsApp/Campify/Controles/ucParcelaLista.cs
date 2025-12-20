using Model;

namespace Controles
{
    public partial class ucParcela : UserControl
    {

        /// <summary>
        /// Representa la parcela asociada al control de usuario.
        /// </summary>
        public Parcela Parcela { get; set; }

        public ucParcela()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Muestra en el control de usuario los datos de la parcela dada como parámetro.
        /// </summary>
        public void SetData(Parcela p)
        {
            Parcela = p;
            lblId.Text = "Nº: " + p.Id.ToString();
            lblTipo.Text = p.Tipo.ToString();
            lblEstado.Text = p.Estado.ToString();
            lblPrecioNoche.Text = p.PrecioNoche.ToString("C2");
            BackColor = p.Estado switch
            {
                EnumEstados.LIBRE => Color.LightGreen,
                EnumEstados.RESERVADA => Color.OrangeRed,
                EnumEstados.INTERESADO => Color.YellowGreen,
                EnumEstados.MANTENIMIENTO => Color.Plum
            };
        }

        /// <summary>
        /// Lanza el evento ParcelaDobleClick al hacer clic en el user control de la parcela o un elemento de texto.
        /// </summary>
        private void lblId_Click(object sender, EventArgs e)
        {
            ParcelaDobleClick?.Invoke(this, Parcela);
        }

        private void lblTipo_Click(object sender, EventArgs e)
        {
            ParcelaDobleClick?.Invoke(this, Parcela);
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {
            ParcelaDobleClick?.Invoke(this, Parcela);
        }

        private void lblPrecioNoche_Click(object sender, EventArgs e)
        {
            ParcelaDobleClick?.Invoke(this, Parcela);
        }

        private void ucParcela_Click(object sender, EventArgs e)
        {
            ParcelaDobleClick?.Invoke(this, Parcela);
        }

        /// <summary>
        /// Evento que se dispara al hacer doble clic en el user control de la parcela.
        /// </summary>
        public event EventHandler<Parcela> ParcelaDobleClick;


    }
}
