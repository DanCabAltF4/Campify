using Model;

namespace Controles
{
    public partial class ucServicioDatos : UserControl
    {

        /// <summary>
        /// Representa el servicio asociado al usercontrol
        /// </summary>
        public Servicio  ServicioActual { get; set; }

        public ucServicioDatos()
        {
            InitializeComponent();
            Limpiar();
        }


        /// <summary>
        /// Muestra los datos del servicio pasado como parametro en el control de usuario.
        /// </summary>
        public void MostrarDatos(Servicio s)
        {
            if(s == null)
            {
                Limpiar();
                return;
            }
            ServicioActual = s;
            lblId.Text = s.Id.ToString();
            lblPrecio.Text = s.Precio.ToString("C2");
            lblNombre.Text = s.Nombre.ToString();
            lblDescripcion.Text = s.Descripcion.ToString();
        }


        public void Limpiar()
        {
            lblId.Text = "";
            lblPrecio.Text = "";
            lblNombre.Text = "";
            lblDescripcion.Text = "";
        }
    }
}
