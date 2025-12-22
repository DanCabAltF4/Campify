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
    public partial class FormVerClientesEstancia : Form
    {

        // ------------------------
        // DECLARACION DE VARIABLES
        // ------------------------
        private Estancia _estanciaActual;



        // ------------------------
        // COSTRUCTOR Y LOAD
        // ------------------------

        public FormVerClientesEstancia(Estancia estanciaActual)
        {
            InitializeComponent();
            _estanciaActual = estanciaActual;
            dgvVerClientesEstancia.DataSource = estanciaActual.Clientes.ToList();
        }



        // ------------------------
        // FUNCIONES DE LOS BOTONES
        // ------------------------
        private void Volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
