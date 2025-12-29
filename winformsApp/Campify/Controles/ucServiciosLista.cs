using Model;

namespace Controles
{
    public partial class ucServiciosLista : UserControl
    {

        /// <summary>
        /// Representa el servicio asociado al control de usuario
        /// </summary>
        public Servicio Servicio { get; set; }

        public ucServiciosLista()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Muestra en el control de usuario los datos del servicio pasado como parametro
        /// </summary>
        /// <param name="s"></param>
        public void SetData(Servicio s)
        {
            Servicio = s;
            lbId.Text = "Nª: " + s.Id;
            lbNombre.Text = s.Nombre;
            lbPrecio.Text = s.Precio.ToString("C2");
            BackColor = Color.LightGreen;
        }


        /// <summary>
        /// Evento que se dispara al hacer click en el control de usuario o cualquiera de los label
        /// </summary>
        public event EventHandler<Servicio> ServicioClick;


        /// <summary>
        /// Lanza el evebto ServicioClick al hacer click en cualquier partde del user control.
        /// </summary>
        private void ucServiciosLista_Click(object sender, EventArgs e)
        {
            ServicioClick?.Invoke(this, Servicio);
        }

        private void lbPrecio_Click(object sender, EventArgs e)
        {
            ServicioClick?.Invoke(this, Servicio);
        }

        private void lbNombre_Click(object sender, EventArgs e)
        {
            ServicioClick?.Invoke(this, Servicio);
        }

        private void lbId_Click(object sender, EventArgs e)
        {
            ServicioClick?.Invoke(this, Servicio);
        }
    }
}
