using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class ucHistorial : UserControl
    {
        public Estancia Estancia { get; set; }

        public ucHistorial()
        {
            InitializeComponent();
        }


        public void SetData(Estancia estancia)
        {
            Estancia = estancia;
            lblId.Text = "ID: " + estancia.Id;
            lblCheckin.Text = estancia.CheckIn.ToString();
            lblCheckout.Text = estancia.CheckOut.ToString();
            CambiarColorFondo();
        }

        private void CambiarColorFondo()
        {
            DateOnly hoy = DateOnly.FromDateTime(DateTime.Now);

            bool activa = Estancia.CheckIn <= hoy && (Estancia.CheckOut == null || hoy < Estancia.CheckOut.Value);
            if (activa) BackColor = Color.LightCoral;
            else BackColor = Color.LightGreen;
        }
    }
}
