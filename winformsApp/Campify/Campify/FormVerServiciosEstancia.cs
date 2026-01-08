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

namespace Forms
{
    public partial class FormVerServiciosEstancia : Form
    {

        // ---------------------------
        // DECLARACION DE VARIABLES
        // ---------------------------
        private Estancia _estanciaActual;


        // -------------------------------
        // CONSTRUCTOR Y LOAD
        //--------------------------------

        public FormVerServiciosEstancia(Estancia estanciaActual)
        {
            InitializeComponent();
            _estanciaActual = estanciaActual;
            dgvVerServiciosEstancia.DataSource = estanciaActual.Servicios.ToList();
            dgvVerServiciosEstancia.AutoResizeColumns();
            lblParcelaFecha.Text = "Servicios de parcela nº " + estanciaActual.Parcela.Id + "  del  " + estanciaActual.CheckIn + "  al  " + estanciaActual.CheckOut;
        }



        // -------------------------------
        // FUNCIONES DE LOS BOTONES
        // -------------------------------

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
