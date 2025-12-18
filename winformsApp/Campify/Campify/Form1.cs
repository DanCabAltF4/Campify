namespace Campify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMapa_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            pbMapa.Visible = true;
        }

        private void btLista_Click(object sender, EventArgs e)
        {
            pbMapa.Visible = false;
            flowLayoutPanel1.Visible = true;
        }
    }
}
