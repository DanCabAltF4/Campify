namespace Forms
{
    partial class FormNuevaEstancia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevaEstancia));
            nudCargoAdicional = new NumericUpDown();
            btnGuardarReserva = new Button();
            btnClientes = new Button();
            btnServicios = new Button();
            lbltxtParcela = new Label();
            lbltxtCheckout = new Label();
            lbltxtMascotas = new Label();
            lbltxtTemporada = new Label();
            lbltxtPrecioFinal = new Label();
            lbltxtCheckin = new Label();
            lbltxtNinos = new Label();
            lbltxtEquipajeAdicional = new Label();
            lbltxtCargoAdicional = new Label();
            lbltxtAdultos = new Label();
            cbTemporada = new ComboBox();
            lblParcela = new Label();
            lblAdultos = new Label();
            lblNinos = new Label();
            lblPrecioFinal = new Label();
            dtpCheckin = new DateTimePicker();
            dtpCheckout = new DateTimePicker();
            lblPrecioNoche = new Label();
            lbltxtPrecioNoche = new Label();
            nudNumMascotas = new NumericUpDown();
            nudEquipajeAdicional = new NumericUpDown();
            button1 = new Button();
            pnlTop = new Panel();
            lblFechaHora = new Label();
            btnMinimizar = new Button();
            lblTitulo = new Label();
            btnSalir = new Button();
            tmFechaHora = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)nudCargoAdicional).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumMascotas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEquipajeAdicional).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // nudCargoAdicional
            // 
            nudCargoAdicional.DecimalPlaces = 2;
            nudCargoAdicional.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudCargoAdicional.Location = new Point(507, 286);
            nudCargoAdicional.Margin = new Padding(3, 2, 3, 2);
            nudCargoAdicional.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudCargoAdicional.Name = "nudCargoAdicional";
            nudCargoAdicional.Size = new Size(64, 23);
            nudCargoAdicional.TabIndex = 37;
            nudCargoAdicional.ValueChanged += nudCargoAdicional_ValueChanged;
            nudCargoAdicional.KeyPress += nudCargoAdicional_KeyPress;
            // 
            // btnGuardarReserva
            // 
            btnGuardarReserva.BackColor = Color.Peru;
            btnGuardarReserva.FlatAppearance.BorderSize = 0;
            btnGuardarReserva.FlatStyle = FlatStyle.Flat;
            btnGuardarReserva.Font = new Font("Segoe UI", 12F);
            btnGuardarReserva.ForeColor = Color.FromArgb(255, 222, 171);
            btnGuardarReserva.Location = new Point(466, 390);
            btnGuardarReserva.Margin = new Padding(0);
            btnGuardarReserva.Name = "btnGuardarReserva";
            btnGuardarReserva.Size = new Size(94, 32);
            btnGuardarReserva.TabIndex = 0;
            btnGuardarReserva.Text = "Guardar";
            btnGuardarReserva.UseVisualStyleBackColor = false;
            btnGuardarReserva.Click += btnGuardarReserva_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.YellowGreen;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 10F);
            btnClientes.Location = new Point(33, 282);
            btnClientes.Margin = new Padding(3, 2, 3, 2);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(151, 25);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnServicios
            // 
            btnServicios.BackColor = Color.YellowGreen;
            btnServicios.FlatAppearance.BorderSize = 0;
            btnServicios.FlatStyle = FlatStyle.Flat;
            btnServicios.Font = new Font("Segoe UI", 10F);
            btnServicios.Location = new Point(221, 283);
            btnServicios.Margin = new Padding(3, 2, 3, 2);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(151, 25);
            btnServicios.TabIndex = 2;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = false;
            btnServicios.Click += btnServicios_Click;
            // 
            // lbltxtParcela
            // 
            lbltxtParcela.AutoSize = true;
            lbltxtParcela.Location = new Point(33, 63);
            lbltxtParcela.Name = "lbltxtParcela";
            lbltxtParcela.Size = new Size(48, 15);
            lbltxtParcela.TabIndex = 3;
            lbltxtParcela.Text = "Parcela:";
            // 
            // lbltxtCheckout
            // 
            lbltxtCheckout.AutoSize = true;
            lbltxtCheckout.Location = new Point(33, 166);
            lbltxtCheckout.Name = "lbltxtCheckout";
            lbltxtCheckout.Size = new Size(64, 15);
            lbltxtCheckout.TabIndex = 7;
            lbltxtCheckout.Text = "Check out:";
            // 
            // lbltxtMascotas
            // 
            lbltxtMascotas.AutoSize = true;
            lbltxtMascotas.Location = new Point(399, 166);
            lbltxtMascotas.Name = "lbltxtMascotas";
            lbltxtMascotas.Size = new Size(77, 15);
            lbltxtMascotas.TabIndex = 10;
            lbltxtMascotas.Text = "Nº Mascotas:";
            // 
            // lbltxtTemporada
            // 
            lbltxtTemporada.AutoSize = true;
            lbltxtTemporada.Location = new Point(33, 224);
            lbltxtTemporada.Name = "lbltxtTemporada";
            lbltxtTemporada.Size = new Size(70, 15);
            lbltxtTemporada.TabIndex = 11;
            lbltxtTemporada.Text = "Temporada:";
            // 
            // lbltxtPrecioFinal
            // 
            lbltxtPrecioFinal.AutoSize = true;
            lbltxtPrecioFinal.Location = new Point(33, 385);
            lbltxtPrecioFinal.Name = "lbltxtPrecioFinal";
            lbltxtPrecioFinal.Size = new Size(69, 15);
            lbltxtPrecioFinal.TabIndex = 12;
            lbltxtPrecioFinal.Text = "Precio final:";
            // 
            // lbltxtCheckin
            // 
            lbltxtCheckin.AutoSize = true;
            lbltxtCheckin.Location = new Point(33, 116);
            lbltxtCheckin.Name = "lbltxtCheckin";
            lbltxtCheckin.Size = new Size(50, 15);
            lbltxtCheckin.TabIndex = 13;
            lbltxtCheckin.Text = "Chek in:";
            // 
            // lbltxtNinos
            // 
            lbltxtNinos.AutoSize = true;
            lbltxtNinos.Location = new Point(399, 116);
            lbltxtNinos.Name = "lbltxtNinos";
            lbltxtNinos.Size = new Size(58, 15);
            lbltxtNinos.TabIndex = 18;
            lbltxtNinos.Text = "Nº Niños:";
            // 
            // lbltxtEquipajeAdicional
            // 
            lbltxtEquipajeAdicional.AutoSize = true;
            lbltxtEquipajeAdicional.Location = new Point(399, 224);
            lbltxtEquipajeAdicional.Name = "lbltxtEquipajeAdicional";
            lbltxtEquipajeAdicional.Size = new Size(106, 15);
            lbltxtEquipajeAdicional.TabIndex = 17;
            lbltxtEquipajeAdicional.Text = "Equipaje adicional:";
            // 
            // lbltxtCargoAdicional
            // 
            lbltxtCargoAdicional.AutoSize = true;
            lbltxtCargoAdicional.Location = new Point(399, 288);
            lbltxtCargoAdicional.Name = "lbltxtCargoAdicional";
            lbltxtCargoAdicional.Size = new Size(93, 15);
            lbltxtCargoAdicional.TabIndex = 15;
            lbltxtCargoAdicional.Text = "Cargo adicional:";
            // 
            // lbltxtAdultos
            // 
            lbltxtAdultos.AutoSize = true;
            lbltxtAdultos.Location = new Point(399, 63);
            lbltxtAdultos.Name = "lbltxtAdultos";
            lbltxtAdultos.Size = new Size(68, 15);
            lbltxtAdultos.TabIndex = 14;
            lbltxtAdultos.Text = "Nº Adultos:";
            // 
            // cbTemporada
            // 
            cbTemporada.FormattingEnabled = true;
            cbTemporada.Location = new Point(116, 222);
            cbTemporada.Margin = new Padding(3, 2, 3, 2);
            cbTemporada.Name = "cbTemporada";
            cbTemporada.Size = new Size(86, 23);
            cbTemporada.TabIndex = 22;
            cbTemporada.SelectedIndexChanged += cbTemporada_SelectedIndexChanged;
            // 
            // lblParcela
            // 
            lblParcela.AutoSize = true;
            lblParcela.Location = new Point(90, 63);
            lblParcela.Name = "lblParcela";
            lblParcela.Size = new Size(38, 15);
            lblParcela.TabIndex = 23;
            lblParcela.Text = "label1";
            // 
            // lblAdultos
            // 
            lblAdultos.AutoSize = true;
            lblAdultos.Location = new Point(479, 63);
            lblAdultos.Name = "lblAdultos";
            lblAdultos.Size = new Size(13, 15);
            lblAdultos.TabIndex = 24;
            lblAdultos.Text = "0";
            // 
            // lblNinos
            // 
            lblNinos.AutoSize = true;
            lblNinos.Location = new Point(466, 116);
            lblNinos.Name = "lblNinos";
            lblNinos.Size = new Size(13, 15);
            lblNinos.TabIndex = 25;
            lblNinos.Text = "0";
            // 
            // lblPrecioFinal
            // 
            lblPrecioFinal.AutoSize = true;
            lblPrecioFinal.Location = new Point(114, 385);
            lblPrecioFinal.Name = "lblPrecioFinal";
            lblPrecioFinal.Size = new Size(0, 15);
            lblPrecioFinal.TabIndex = 27;
            // 
            // dtpCheckin
            // 
            dtpCheckin.Location = new Point(91, 112);
            dtpCheckin.Margin = new Padding(3, 2, 3, 2);
            dtpCheckin.Name = "dtpCheckin";
            dtpCheckin.Size = new Size(282, 23);
            dtpCheckin.TabIndex = 30;
            dtpCheckin.Leave += dtpCheckin_Leave;
            // 
            // dtpCheckout
            // 
            dtpCheckout.Location = new Point(106, 163);
            dtpCheckout.Margin = new Padding(3, 2, 3, 2);
            dtpCheckout.Name = "dtpCheckout";
            dtpCheckout.Size = new Size(267, 23);
            dtpCheckout.TabIndex = 31;
            dtpCheckout.Leave += dtpCheckout_Leave;
            // 
            // lblPrecioNoche
            // 
            lblPrecioNoche.AutoSize = true;
            lblPrecioNoche.Location = new Point(123, 347);
            lblPrecioNoche.Name = "lblPrecioNoche";
            lblPrecioNoche.Size = new Size(0, 15);
            lblPrecioNoche.TabIndex = 34;
            // 
            // lbltxtPrecioNoche
            // 
            lbltxtPrecioNoche.AutoSize = true;
            lbltxtPrecioNoche.Location = new Point(33, 347);
            lbltxtPrecioNoche.Name = "lbltxtPrecioNoche";
            lbltxtPrecioNoche.Size = new Size(79, 15);
            lbltxtPrecioNoche.TabIndex = 33;
            lbltxtPrecioNoche.Text = "Precio noche:";
            // 
            // nudNumMascotas
            // 
            nudNumMascotas.Location = new Point(487, 165);
            nudNumMascotas.Margin = new Padding(3, 2, 3, 2);
            nudNumMascotas.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudNumMascotas.Name = "nudNumMascotas";
            nudNumMascotas.Size = new Size(49, 23);
            nudNumMascotas.TabIndex = 35;
            nudNumMascotas.ValueChanged += nudNumMascotas_ValueChanged;
            // 
            // nudEquipajeAdicional
            // 
            nudEquipajeAdicional.Location = new Point(522, 222);
            nudEquipajeAdicional.Margin = new Padding(3, 2, 3, 2);
            nudEquipajeAdicional.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudEquipajeAdicional.Name = "nudEquipajeAdicional";
            nudEquipajeAdicional.Size = new Size(48, 23);
            nudEquipajeAdicional.TabIndex = 36;
            nudEquipajeAdicional.ValueChanged += nudEquipajeAdicional_ValueChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.FromArgb(255, 222, 171);
            button1.Location = new Point(331, 390);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(94, 32);
            button1.TabIndex = 38;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(197, 239, 100);
            pnlTop.Controls.Add(lblFechaHora);
            pnlTop.Controls.Add(btnMinimizar);
            pnlTop.Controls.Add(lblTitulo);
            pnlTop.Controls.Add(btnSalir);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(3, 2, 3, 2);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(612, 27);
            pnlTop.TabIndex = 39;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Segoe UI", 8F);
            lblFechaHora.Location = new Point(242, 9);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(0, 13);
            lblFechaHora.TabIndex = 40;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(532, 1);
            btnMinimizar.Margin = new Padding(3, 2, 3, 2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(28, 24);
            btnMinimizar.TabIndex = 9;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(9, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(81, 15);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Nueva reserva";
            lblTitulo.MouseDown += pnlTop_MouseDown;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(565, 1);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(38, 24);
            btnSalir.TabIndex = 7;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // tmFechaHora
            // 
            tmFechaHora.Enabled = true;
            tmFechaHora.Interval = 1000;
            tmFechaHora.Tick += tmFechaHora_Tick;
            // 
            // FormNuevaEstancia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(612, 446);
            Controls.Add(pnlTop);
            Controls.Add(button1);
            Controls.Add(nudCargoAdicional);
            Controls.Add(nudEquipajeAdicional);
            Controls.Add(nudNumMascotas);
            Controls.Add(lblPrecioNoche);
            Controls.Add(lbltxtPrecioNoche);
            Controls.Add(dtpCheckout);
            Controls.Add(dtpCheckin);
            Controls.Add(lblPrecioFinal);
            Controls.Add(lblNinos);
            Controls.Add(lblAdultos);
            Controls.Add(lblParcela);
            Controls.Add(cbTemporada);
            Controls.Add(lbltxtNinos);
            Controls.Add(lbltxtEquipajeAdicional);
            Controls.Add(lbltxtCargoAdicional);
            Controls.Add(lbltxtAdultos);
            Controls.Add(lbltxtCheckin);
            Controls.Add(lbltxtPrecioFinal);
            Controls.Add(lbltxtTemporada);
            Controls.Add(lbltxtMascotas);
            Controls.Add(lbltxtCheckout);
            Controls.Add(lbltxtParcela);
            Controls.Add(btnServicios);
            Controls.Add(btnClientes);
            Controls.Add(btnGuardarReserva);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormNuevaEstancia";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrar nueva estancia";
            ((System.ComponentModel.ISupportInitialize)nudCargoAdicional).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumMascotas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEquipajeAdicional).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarReserva;
        private Button btnClientes;
        private Button btnServicios;
        private Label lbltxtParcela;
        private Label lbltxtCheckout;
        private Label lbltxtMascotas;
        private Label lbltxtTemporada;
        private Label lbltxtPrecioFinal;
        private Label lbltxtCheckin;
        private Label lbltxtNinos;
        private Label lbltxtEquipajeAdicional;
        private Label lbltxtCargoAdicional;
        private Label lbltxtAdultos;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox cbTemporada;
        private Label lblParcela;
        private Label lblAdultos;
        private Label lblNinos;
        private Label lblPrecioFinal;
        private DateTimePicker dtpCheckin;
        private DateTimePicker dtpCheckout;
        private Label lblPrecioNoche;
        private Label lbltxtPrecioNoche;
        private NumericUpDown nudNumMascotas;
        private NumericUpDown nudEquipajeAdicional;
        private NumericUpDown nudCargoAdicional;
        private Button button1;
        private Panel pnlTop;
        private Button btnMinimizar;
        private Label lblTitulo;
        private Button btnSalir;
        private Label lblFechaHora;
        private System.Windows.Forms.Timer tmFechaHora;
    }
}