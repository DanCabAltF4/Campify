namespace Campify
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            pbLogo = new PictureBox();
            btnEmpleados = new Button();
            btnParcelas = new Button();
            pbAjustes = new PictureBox();
            btnServicios = new Button();
            pnlServicios = new Panel();
            btnDatos = new Button();
            btnReservar = new Button();
            btLista = new Button();
            btnHistorial = new Button();
            panelMapaLista = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pbMapa = new PictureBox();
            btnEstanciaActual = new Button();
            panelDatos = new Panel();
            ucEstanciaActual1 = new Controles.ucEstanciaActual();
            ucParcelaDatos = new Controles.ucParcelaDatos();
            ucHistorial1 = new Controles.ucHistorial();
            btMapa = new Button();
            pnlParcelas = new Panel();
            btnMantenimiento = new Button();
            pnlEmpleados = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAjustes).BeginInit();
            panelMapaLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMapa).BeginInit();
            panelDatos.SuspendLayout();
            pnlParcelas.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(0, -5);
            pbLogo.Margin = new Padding(3, 4, 3, 4);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(106, 116);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // btnEmpleados
            // 
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEmpleados.ForeColor = Color.FromArgb(44, 79, 29);
            btnEmpleados.Location = new Point(427, 16);
            btnEmpleados.Margin = new Padding(3, 4, 3, 4);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(137, 59);
            btnEmpleados.TabIndex = 1;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnParcelas
            // 
            btnParcelas.FlatAppearance.BorderSize = 0;
            btnParcelas.FlatStyle = FlatStyle.Flat;
            btnParcelas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnParcelas.ForeColor = Color.FromArgb(44, 79, 29);
            btnParcelas.Location = new Point(121, 16);
            btnParcelas.Margin = new Padding(3, 4, 3, 4);
            btnParcelas.Name = "btnParcelas";
            btnParcelas.Size = new Size(137, 59);
            btnParcelas.TabIndex = 2;
            btnParcelas.Text = "Parcelas";
            btnParcelas.UseVisualStyleBackColor = true;
            btnParcelas.Click += btnParcelas_Click;
            // 
            // pbAjustes
            // 
            pbAjustes.Image = (Image)resources.GetObject("pbAjustes.Image");
            pbAjustes.Location = new Point(846, 16);
            pbAjustes.Margin = new Padding(3, 4, 3, 4);
            pbAjustes.Name = "pbAjustes";
            pbAjustes.Size = new Size(50, 56);
            pbAjustes.SizeMode = PictureBoxSizeMode.Zoom;
            pbAjustes.TabIndex = 3;
            pbAjustes.TabStop = false;
            // 
            // btnServicios
            // 
            btnServicios.FlatAppearance.BorderSize = 0;
            btnServicios.FlatStyle = FlatStyle.Flat;
            btnServicios.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnServicios.ForeColor = Color.FromArgb(44, 79, 29);
            btnServicios.Location = new Point(265, 16);
            btnServicios.Margin = new Padding(3, 4, 3, 4);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(137, 59);
            btnServicios.TabIndex = 10;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = true;
            btnServicios.Click += btnServicios_Click;
            // 
            // pnlServicios
            // 
            pnlServicios.Location = new Point(0, 115);
            pnlServicios.Name = "pnlServicios";
            pnlServicios.Size = new Size(913, 483);
            pnlServicios.TabIndex = 19;
            pnlServicios.Visible = false;
            // 
            // btnDatos
            // 
            btnDatos.BackColor = Color.FromArgb(255, 222, 171);
            btnDatos.FlatAppearance.BorderSize = 0;
            btnDatos.FlatStyle = FlatStyle.Flat;
            btnDatos.Font = new Font("Segoe UI", 12F);
            btnDatos.ForeColor = Color.FromArgb(95, 65, 0);
            btnDatos.Location = new Point(489, -3);
            btnDatos.Margin = new Padding(0);
            btnDatos.Name = "btnDatos";
            btnDatos.Size = new Size(131, 48);
            btnDatos.TabIndex = 11;
            btnDatos.Text = "Datos";
            btnDatos.UseVisualStyleBackColor = false;
            btnDatos.Click += btnDatos_Click;
            // 
            // btnReservar
            // 
            btnReservar.BackColor = Color.Peru;
            btnReservar.FlatAppearance.BorderSize = 0;
            btnReservar.FlatStyle = FlatStyle.Flat;
            btnReservar.Font = new Font("Segoe UI", 12F);
            btnReservar.ForeColor = Color.FromArgb(255, 222, 171);
            btnReservar.Location = new Point(489, 433);
            btnReservar.Margin = new Padding(0);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(226, 45);
            btnReservar.TabIndex = 9;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = false;
            btnReservar.Click += btnReservar_Click;
            // 
            // btLista
            // 
            btLista.BackColor = Color.Peru;
            btLista.FlatAppearance.BorderSize = 0;
            btLista.FlatStyle = FlatStyle.Flat;
            btLista.Font = new Font("Segoe UI", 12F);
            btLista.ForeColor = Color.FromArgb(255, 222, 171);
            btLista.Location = new Point(224, 0);
            btLista.Margin = new Padding(0);
            btLista.Name = "btLista";
            btLista.Size = new Size(127, 45);
            btLista.TabIndex = 13;
            btLista.Text = "Lista";
            btLista.UseVisualStyleBackColor = false;
            btLista.Click += btLista_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.FromArgb(255, 222, 171);
            btnHistorial.FlatAppearance.BorderSize = 0;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Segoe UI", 12F);
            btnHistorial.ForeColor = Color.FromArgb(95, 65, 0);
            btnHistorial.Location = new Point(773, -3);
            btnHistorial.Margin = new Padding(0);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(137, 48);
            btnHistorial.TabIndex = 6;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = false;
            // 
            // panelMapaLista
            // 
            panelMapaLista.Controls.Add(flowLayoutPanel1);
            panelMapaLista.Controls.Add(pbMapa);
            panelMapaLista.Location = new Point(1, 45);
            panelMapaLista.Margin = new Padding(0);
            panelMapaLista.Name = "panelMapaLista";
            panelMapaLista.Size = new Size(488, 433);
            panelMapaLista.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(488, 433);
            flowLayoutPanel1.TabIndex = 15;
            flowLayoutPanel1.Visible = false;
            // 
            // pbMapa
            // 
            pbMapa.Dock = DockStyle.Fill;
            pbMapa.Image = (Image)resources.GetObject("pbMapa.Image");
            pbMapa.Location = new Point(0, 0);
            pbMapa.Margin = new Padding(0);
            pbMapa.Name = "pbMapa";
            pbMapa.Size = new Size(488, 433);
            pbMapa.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMapa.TabIndex = 15;
            pbMapa.TabStop = false;
            // 
            // btnEstanciaActual
            // 
            btnEstanciaActual.BackColor = Color.FromArgb(255, 222, 171);
            btnEstanciaActual.FlatAppearance.BorderSize = 0;
            btnEstanciaActual.FlatStyle = FlatStyle.Flat;
            btnEstanciaActual.Font = new Font("Segoe UI", 12F);
            btnEstanciaActual.ForeColor = Color.FromArgb(95, 65, 0);
            btnEstanciaActual.Location = new Point(619, -3);
            btnEstanciaActual.Margin = new Padding(0);
            btnEstanciaActual.Name = "btnEstanciaActual";
            btnEstanciaActual.Size = new Size(154, 48);
            btnEstanciaActual.TabIndex = 5;
            btnEstanciaActual.Text = "Estancia actual";
            btnEstanciaActual.UseVisualStyleBackColor = false;
            btnEstanciaActual.Click += btnEstanciaActual_Click;
            // 
            // panelDatos
            // 
            panelDatos.Controls.Add(ucParcelaDatos);
            panelDatos.Controls.Add(ucEstanciaActual1);
            panelDatos.Controls.Add(ucHistorial1);
            panelDatos.Location = new Point(489, 45);
            panelDatos.Margin = new Padding(0);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(421, 388);
            panelDatos.TabIndex = 17;
            // 
            // ucEstanciaActual1
            // 
            ucEstanciaActual1.Location = new Point(0, 0);
            ucEstanciaActual1.Name = "ucEstanciaActual1";
            ucEstanciaActual1.Size = new Size(422, 388);
            ucEstanciaActual1.TabIndex = 21;
            // 
            // ucParcelaDatos
            // 
            ucParcelaDatos.Location = new Point(0, 0);
            ucParcelaDatos.Margin = new Padding(0);
            ucParcelaDatos.Name = "ucParcelaDatos";
            ucParcelaDatos.Size = new Size(421, 388);
            ucParcelaDatos.TabIndex = 0;
            // 
            // ucHistorial1
            // 
            ucHistorial1.Location = new Point(0, 0);
            ucHistorial1.Name = "ucHistorial1";
            ucHistorial1.Size = new Size(422, 388);
            ucHistorial1.TabIndex = 21;
            // 
            // btMapa
            // 
            btMapa.BackColor = Color.Peru;
            btMapa.FlatAppearance.BorderSize = 0;
            btMapa.FlatStyle = FlatStyle.Flat;
            btMapa.Font = new Font("Segoe UI", 12F);
            btMapa.ForeColor = Color.FromArgb(255, 222, 171);
            btMapa.Location = new Point(57, 0);
            btMapa.Margin = new Padding(0);
            btMapa.Name = "btMapa";
            btMapa.Size = new Size(127, 45);
            btMapa.TabIndex = 12;
            btMapa.Text = "Mapa";
            btMapa.UseVisualStyleBackColor = false;
            btMapa.Click += btMapa_Click;
            // 
            // pnlParcelas
            // 
            pnlParcelas.Controls.Add(btnMantenimiento);
            pnlParcelas.Controls.Add(btMapa);
            pnlParcelas.Controls.Add(btLista);
            pnlParcelas.Controls.Add(panelMapaLista);
            pnlParcelas.Controls.Add(btnDatos);
            pnlParcelas.Controls.Add(btnEstanciaActual);
            pnlParcelas.Controls.Add(btnHistorial);
            pnlParcelas.Controls.Add(btnReservar);
            pnlParcelas.Controls.Add(panelDatos);
            pnlParcelas.Location = new Point(0, 117);
            pnlParcelas.Name = "pnlParcelas";
            pnlParcelas.Size = new Size(913, 480);
            pnlParcelas.TabIndex = 18;
            // 
            // btnMantenimiento
            // 
            btnMantenimiento.BackColor = Color.Peru;
            btnMantenimiento.FlatAppearance.BorderSize = 0;
            btnMantenimiento.FlatStyle = FlatStyle.Flat;
            btnMantenimiento.Font = new Font("Segoe UI", 12F);
            btnMantenimiento.ForeColor = Color.FromArgb(255, 222, 171);
            btnMantenimiento.Location = new Point(715, 433);
            btnMantenimiento.Margin = new Padding(0);
            btnMantenimiento.Name = "btnMantenimiento";
            btnMantenimiento.Size = new Size(195, 45);
            btnMantenimiento.TabIndex = 18;
            btnMantenimiento.Text = "Mantenimiento";
            btnMantenimiento.UseVisualStyleBackColor = false;
            btnMantenimiento.Click += btnMantenimiento_Click;
            // 
            // pnlEmpleados
            // 
            pnlEmpleados.Location = new Point(1, 115);
            pnlEmpleados.Name = "pnlEmpleados";
            pnlEmpleados.Size = new Size(913, 483);
            pnlEmpleados.TabIndex = 20;
            pnlEmpleados.Visible = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(915, 597);
            Controls.Add(pnlParcelas);
            Controls.Add(pnlServicios);
            Controls.Add(pnlEmpleados);
            Controls.Add(btnServicios);
            Controls.Add(pbAjustes);
            Controls.Add(btnParcelas);
            Controls.Add(btnEmpleados);
            Controls.Add(pbLogo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPrincipal";
            Text = "Daniel capullo";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAjustes).EndInit();
            panelMapaLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMapa).EndInit();
            panelDatos.ResumeLayout(false);
            pnlParcelas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Button btnEmpleados;
        private Button btnParcelas;
        private PictureBox pbAjustes;
        private Button btnServicios;
        private Panel pnlServicios;
        private Button btnDatos;
        private Button btnReservar;
        private Button btLista;
        private Button btnHistorial;
        private Panel panelMapaLista;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pbMapa;
        private Button btnEstanciaActual;
        private Panel panelDatos;
        private Controles.ucParcelaDatos ucParcelaDatos;
        private Button btMapa;
        private Panel pnlParcelas;
        private Panel pnlEmpleados;
        private Controles.ucEstanciaActual ucEstanciaActual1;
        private Controles.ucHistorial ucHistorial1;
        private Button btnMantenimiento;
    }
}
