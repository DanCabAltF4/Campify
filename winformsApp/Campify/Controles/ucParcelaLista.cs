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
            lblId.Text = "Número: " + p.Id.ToString();
            lblTipo.Text = p.Tipo.ToString();
            lblEstado.Text = p.Estado.ToString();
            lblPrecioNoche.Text = p.PrecioNoche.ToString("C2");
            BackColor = p.Estado switch
            {
                EnumEstados.LIBRE => Color.LightGreen,
                EnumEstados.RESERVADA => Color.OrangeRed,
                EnumEstados.INTERESADO => Color.YellowGreen,
                EnumEstados.MANTENIMIENTO => Color.RebeccaPurple
            };
        }

        /// <summary>
        /// Lanza el evento ParcelaDobleClick al hacer doble clic en el user control de la parcela.
        /// </summary>
        private void ucParcela_DoubleClick(object sender, EventArgs e)
        {
            ParcelaDobleClick?.Invoke(this, Parcela);
        }

        /// <summary>
        /// Evento que se dispara al hacer doble clic en el user control de la parcela.
        /// </summary>
        public event EventHandler<Parcela> ParcelaDobleClick;


    }
}
