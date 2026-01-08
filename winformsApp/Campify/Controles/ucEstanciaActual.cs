using Model;

namespace Controles
{
    public partial class ucEstanciaActual : UserControl
    {
        // ---------------------------
        // DECLARACION DE VARIABLES
        // ---------------------------
    

        /// <summary>
        /// Representa la estancia asociada al usercontrol
        /// </summary>
        public Estancia EstanciaActual { get; set; }


        public ucEstanciaActual()
        {
            InitializeComponent();
            Limpiar();
        }


        /// <summary>
        /// Rellena el control con los datos de la estancia proporcionada.
        /// </summary>
        public void SetData(Estancia estancia)
        {
            if (estancia == null)
            {
                Limpiar();
                return;
            }
            EstanciaActual = estancia;
            lblParcela.Text = estancia.Parcela.Id.ToString();
            lblCheckin.Text = estancia.CheckIn.ToString("dd/MM/yyyy");
            lblCheckout.Text = estancia.CheckOut.HasValue ? estancia.CheckOut.Value.ToString("dd/MM/yyyy") : "-";
            lblTemporada.Text = estancia.Temporada.ToString();
            lblPrecioNoche.Text = $"{estancia.Parcela.PrecioNoche} €";
            lblAdultos.Text = estancia.NumeroAdultos.ToString();
            lblNinos.Text = estancia.NumeroNinos.ToString();
            lblMascotas.Text = estancia.NumeroMascotas.ToString();
            lblEquipajeAdicional.Text = $"{estancia.CantidadEquipajeExtra} €";
            lblCargoAdicional.Text = $"{estancia.CargoAdicional} €";
            lblPrecioFinal.Text = $"{estancia.PrecioFinal} €";
        }

        /// <summary>
        /// Limpia los campos en el control.
        /// </summary>
        public void Limpiar()
        {
            lblParcela.Text = "";
            lblCheckin.Text = "";
            lblCheckout.Text = "";
            lblTemporada.Text = "";
            lblPrecioNoche.Text = "";
            lblAdultos.Text = "";
            lblNinos.Text = "";
            lblMascotas.Text = "";
            lblEquipajeAdicional.Text = "";
            lblCargoAdicional.Text = "";
            lblPrecioFinal.Text = "";
        }
    }
}
