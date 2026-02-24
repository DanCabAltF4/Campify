using Campify;
using Dto;
using Model;
using Repository;
using System.Runtime.InteropServices;

namespace Forms
{
    public partial class Login : Form
    {
        //Atributos para menu superior
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;


        //Atributos de la clase
        private readonly ApiCampify _api = new ApiCampify("http://localhost:8080/");

        public Login()
        {
            InitializeComponent();
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }


        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }


        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var req = new LoginRequest
                {
                    Email = tbUsuario.Text,
                    Password = tbPassword.Text
                };

                var res = await _api.LoginAsync(req);
                if (res == null)
                {
                    MessageBox.Show("El usuario o la contraseña introducidos no son válidos.", "Credenciales inválidas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Session.Login(res.Token, res.Id, res.Puesto);

                using (var form = new FormPrincipal(_api))
                {
                    var result = form.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                    {
                        Session.Logout();

                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // Permite mover la ventana al hacer click y arrastrar el panel superior
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
