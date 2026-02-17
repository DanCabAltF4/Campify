using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormVerServiciosEstancia : Form
    {

        //Atributos para menu superior
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;


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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
