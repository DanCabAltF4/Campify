using Controles;
using Model;
using Repository;
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
    public partial class FormsVerImagen : Form
    {
        //Atributos para menu superior
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;


        // Atributos de la clase
        private ApiCampify _api;
        private Parcela _parcela;

        public FormsVerImagen(ApiCampify api, Parcela parcela)
        {
            InitializeComponent();
            _api = api;
            _parcela = parcela;
        }

        private void FormsVerImagen_Load(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            
            String imgBase64 = _parcela.Imagen;


            if(imgBase64 == null)
            {
                pbImagen.Image = null;
                return;
            }

            byte[] imgBytes = Convert.FromBase64String(imgBase64);
            using (var ms = new MemoryStream(imgBytes))
            {
                pbImagen.Image = Image.FromStream(ms);
                pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            }

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

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }


    }
}
