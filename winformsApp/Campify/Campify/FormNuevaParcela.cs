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
    public partial class FormNuevaParcela : Form
    {
        //Atributos para menu superior
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;


        //Atributos del formulario
        private ApiCampify _api;
        private Parcela? _parcela;
        private string? _archivoSeleccionado64;
        public Parcela ParcelaCreada { get; private set; }



        // Constructor y load
        public FormNuevaParcela(ApiCampify api, Parcela? parcela)
        {
            InitializeComponent();
            _api = api;
            _parcela = parcela;

            cbTipoParcela.DataSource = Enum.GetValues(typeof(EnumTipos));
        }

        private void FormNuevaParcela_Load(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            if (_parcela == null)
            {
                btnGuardar.Text = "Crear";
                lbltxtId.Text = "---";
                ckCercaBaño.Checked = false;
                ckTieneVistas.Checked = false;
                ckZonaSombra.Checked = false;
                ckCercaEntrada.Checked = false;
                ckZonaTranquila.Checked = false;
                cbTipoParcela.SelectedIndex = 0;
                nudPrecioNoche.Value = 0;
                pbImagen.Image = null;
            }
            else
            {
                btnGuardar.Text = "Actualizar";
                lbltxtId.Text = _parcela.Id.ToString();
                ckCercaBaño.Checked = _parcela.CercaBanos;
                ckTieneVistas.Checked = _parcela.TieneVistas;
                ckZonaSombra.Checked = _parcela.ZonaSombra;
                ckCercaEntrada.Checked = _parcela.CercaEntrada;
                ckZonaTranquila.Checked = _parcela.ZonaTranquila;
                cbTipoParcela.SelectedItem = _parcela.Tipo;
                nudPrecioNoche.Value = (decimal)_parcela.PrecioNoche;
                if (!string.IsNullOrEmpty(_parcela.Imagen))
                {
                    byte[] bytes = Convert.FromBase64String(_parcela.Imagen);
                    using var ms = new MemoryStream(bytes);
                    pbImagen.Image = Image.FromStream(ms);
                    pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
                    _archivoSeleccionado64 = _parcela.Imagen;
                }
            }
        }



        // Metodos de la barra superior
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        // Metodo referente al boton de subir imagen
        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecciona una imágen";
                ofd.Filter = "Imágenes|*.png;*.jpg;*.jpeg";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (ofd.ShowDialog() != DialogResult.OK) return;

                byte[] bytes = File.ReadAllBytes(ofd.FileName);
                _archivoSeleccionado64 = Convert.ToBase64String(bytes);

                // Previsualizar
                pbImagen.Image?.Dispose();
                using var ms = new MemoryStream(bytes);
                pbImagen.Image = Image.FromStream(ms);
                pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }




        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (nudPrecioNoche.Value <= 0)
                {
                    MessageBox.Show("El precio por noche no puede ser 0.", "Precio inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Parcela nueva = _parcela ?? new Parcela();

                nueva.CercaBanos = ckCercaBaño.Checked;
                nueva.TieneVistas = ckTieneVistas.Checked;
                nueva.ZonaSombra = ckZonaSombra.Checked;
                nueva.CercaEntrada = ckCercaEntrada.Checked;
                nueva.ZonaTranquila = ckZonaTranquila.Checked;
                nueva.Tipo = (EnumTipos)cbTipoParcela.SelectedItem;
                nueva.PrecioNoche = (double)nudPrecioNoche.Value;
                nueva.Imagen = _archivoSeleccionado64;

                if(nueva.Id == 0)
                {
                    nueva = await _api.Create<Parcela>("api/parcelas", nueva);
                    MessageBox.Show("Parcela creada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    nueva = await _api.Update("api/parcelas", _parcela.Id, nueva);
                    MessageBox.Show("Parcela actualizada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                _parcela = nueva;
                ParcelaCreada = nueva;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ApiCampify.MensajeErrorHttp(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
