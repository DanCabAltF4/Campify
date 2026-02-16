using Campify;
using Dto;
using Model;
using Repository;
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
    public partial class Login : Form
    {

        private readonly ApiCampify _api = new ApiCampify("http://localhost:8080/");

        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var req = new LoginRequest
            {
                Email = tbUsuario.Text,
                Password = tbPassword.Text
            };

            var res = await _api.LoginAsync(req);
            if(res == null)
            {
                MessageBox.Show("El usuario o la contraseña introducidos no son válidos.", "Credenciales inválidas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Session.Login(res.Token, res.Id, res.Puesto);

            using (var form = new FormPrincipal(_api))
            {
                var result = form.ShowDialog(this);
                if(result == DialogResult.Cancel)
                {
                    Session.Logout();

                }
            }
        }
    }
}
