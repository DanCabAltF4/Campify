using Model;

namespace Controles
{
    public partial class ucEstanciasLista : UserControl
    {

        /// <summary>
        /// Representa la estancia asociada al control de usuario.
        /// </summary>
        public Estancia Estancia { get; set; }


        public ucEstanciasLista()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Muestra en el control de usuario los datos de la estancia pasada como parametro.
        /// </summary>
        public void SetData(Estancia estancia)
        {
            Estancia = estancia;
            lblId.Text = "ID: " + estancia.Id;
            lblParcela.Text = "Parcela " + estancia.Parcela.Id.ToString();
            lblCheckin.Text = estancia.CheckIn.ToString();
            lblCheckout.Text = estancia.CheckOut.ToString();
            CambiarColorFondo();
        }


        /// <summary>
        /// Cambia el color del usercontrol a rojo si la estancia esta activa hoy
        /// </summary>
        private void CambiarColorFondo()
        {
            DateOnly hoy  = DateOnly.FromDateTime(DateTime.Now);

            bool activa = Estancia.CheckIn <= hoy && (Estancia.CheckOut == null || hoy < Estancia.CheckOut.Value);
            if (activa) BackColor = Color.LightCoral;
            else BackColor = Color.LightGreen;
        }


        /// <summary>
        /// Evento que se disppara al hacer click en el user control de la estancia o alguno de los textos.
        /// </summary>
        public event EventHandler<Estancia> EstanciaClick;


        /// <summary>
        /// Lanza el evento EstanciaClick al hacer click en el user control de la estancia o un elemento de texto.
        /// </summary>
        private void ucEstanciasLista_Click(object sender, EventArgs e)
        {
            EstanciaClick?.Invoke(this, Estancia);
        }

        private void lblId_Click(object sender, EventArgs e)
        {
            EstanciaClick?.Invoke(this, Estancia);
        }

        private void lblParcela_Click(object sender, EventArgs e)
        {
            EstanciaClick?.Invoke(this, Estancia);
        }

        private void lblCheckin_Click(object sender, EventArgs e)
        {
            EstanciaClick?.Invoke(this, Estancia);
        }

        private void lblCheckout_Click(object sender, EventArgs e)
        {
            EstanciaClick?.Invoke(this, Estancia);
        }
    }
}
