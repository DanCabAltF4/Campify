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
            txbEquipajeAdicional = new TextBox();
            txbCargoAdicional = new TextBox();
            dtpCheckin = new DateTimePicker();
            dtpCheckout = new DateTimePicker();
            txbMascotas = new TextBox();
            lblPrecioNoche = new Label();
            lbltxtPrecioNoche = new Label();
            SuspendLayout();
            // 
            // btnGuardarReserva
            // 
            btnGuardarReserva.BackColor = Color.Peru;
            btnGuardarReserva.FlatAppearance.BorderSize = 0;
            btnGuardarReserva.FlatStyle = FlatStyle.Flat;
            btnGuardarReserva.Font = new Font("Segoe UI", 12F);
            btnGuardarReserva.ForeColor = Color.FromArgb(255, 222, 171);
            btnGuardarReserva.Location = new Point(434, 467);
            btnGuardarReserva.Name = "btnGuardarReserva";
            btnGuardarReserva.Size = new Size(107, 67);
            btnGuardarReserva.TabIndex = 0;
            btnGuardarReserva.Text = "Guardar reserva";
            btnGuardarReserva.UseVisualStyleBackColor = false;
            btnGuardarReserva.Click += btnGuardarReserva_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.YellowGreen;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 10F);
            btnClientes.Location = new Point(81, 488);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(94, 33);
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
            btnServicios.Location = new Point(243, 488);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(94, 33);
            btnServicios.TabIndex = 2;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = false;
            btnServicios.Click += btnServicios_Click;
            // 
            // lbltxtParcela
            // 
            lbltxtParcela.AutoSize = true;
            lbltxtParcela.Location = new Point(40, 43);
            lbltxtParcela.Name = "lbltxtParcela";
            lbltxtParcela.Size = new Size(59, 20);
            lbltxtParcela.TabIndex = 3;
            lbltxtParcela.Text = "Parcela:";
            // 
            // lbltxtCheckout
            // 
            lbltxtCheckout.AutoSize = true;
            lbltxtCheckout.Location = new Point(40, 169);
            lbltxtCheckout.Name = "lbltxtCheckout";
            lbltxtCheckout.Size = new Size(77, 20);
            lbltxtCheckout.TabIndex = 7;
            lbltxtCheckout.Text = "Check out:";
            // 
            // lbltxtMascotas
            // 
            lbltxtMascotas.AutoSize = true;
            lbltxtMascotas.Location = new Point(458, 169);
            lbltxtMascotas.Name = "lbltxtMascotas";
            lbltxtMascotas.Size = new Size(95, 20);
            lbltxtMascotas.TabIndex = 10;
            lbltxtMascotas.Text = "Nº Mascotas:";
            // 
            // lbltxtTemporada
            // 
            lbltxtTemporada.AutoSize = true;
            lbltxtTemporada.Location = new Point(40, 245);
            lbltxtTemporada.Name = "lbltxtTemporada";
            lbltxtTemporada.Size = new Size(88, 20);
            lbltxtTemporada.TabIndex = 11;
            lbltxtTemporada.Text = "Temporada:";
            // 
            // lbltxtPrecioFinal
            // 
            lbltxtPrecioFinal.AutoSize = true;
            lbltxtPrecioFinal.Location = new Point(42, 380);
            lbltxtPrecioFinal.Name = "lbltxtPrecioFinal";
            lbltxtPrecioFinal.Size = new Size(86, 20);
            lbltxtPrecioFinal.TabIndex = 12;
            lbltxtPrecioFinal.Text = "Precio final:";
            // 
            // lbltxtCheckin
            // 
            lbltxtCheckin.AutoSize = true;
            lbltxtCheckin.Location = new Point(40, 101);
            lbltxtCheckin.Name = "lbltxtCheckin";
            lbltxtCheckin.Size = new Size(60, 20);
            lbltxtCheckin.TabIndex = 13;
            lbltxtCheckin.Text = "Chek in:";
            // 
            // lbltxtNinos
            // 
            lbltxtNinos.AutoSize = true;
            lbltxtNinos.Location = new Point(458, 101);
            lbltxtNinos.Name = "lbltxtNinos";
            lbltxtNinos.Size = new Size(71, 20);
            lbltxtNinos.TabIndex = 18;
            lbltxtNinos.Text = "Nº Niños:";
            // 
            // lbltxtEquipajeAdicional
            // 
            lbltxtEquipajeAdicional.AutoSize = true;
            lbltxtEquipajeAdicional.Location = new Point(458, 245);
            lbltxtEquipajeAdicional.Name = "lbltxtEquipajeAdicional";
            lbltxtEquipajeAdicional.Size = new Size(135, 20);
            lbltxtEquipajeAdicional.TabIndex = 17;
            lbltxtEquipajeAdicional.Text = "Equipaje adicional:";
            // 
            // lbltxtCargoAdicional
            // 
            lbltxtCargoAdicional.AutoSize = true;
            lbltxtCargoAdicional.Location = new Point(458, 331);
            lbltxtCargoAdicional.Name = "lbltxtCargoAdicional";
            lbltxtCargoAdicional.Size = new Size(117, 20);
            lbltxtCargoAdicional.TabIndex = 15;
            lbltxtCargoAdicional.Text = "Cargo adicional:";
            // 
            // lbltxtAdultos
            // 
            lbltxtAdultos.AutoSize = true;
            lbltxtAdultos.Location = new Point(458, 43);
            lbltxtAdultos.Name = "lbltxtAdultos";
            lbltxtAdultos.Size = new Size(84, 20);
            lbltxtAdultos.TabIndex = 14;
            lbltxtAdultos.Text = "Nº Adultos:";
            // 
            // cbTemporada
            // 
            cbTemporada.FormattingEnabled = true;
            cbTemporada.Location = new Point(134, 243);
            cbTemporada.Name = "cbTemporada";
            cbTemporada.Size = new Size(98, 28);
            cbTemporada.TabIndex = 22;
            // 
            // lblParcela
            // 
            lblParcela.AutoSize = true;
            lblParcela.Location = new Point(105, 43);
            lblParcela.Name = "lblParcela";
            lblParcela.Size = new Size(50, 20);
            lblParcela.TabIndex = 23;
            lblParcela.Text = "label1";
            // 
            // lblAdultos
            // 
            lblAdultos.AutoSize = true;
            lblAdultos.Location = new Point(549, 43);
            lblAdultos.Name = "lblAdultos";
            lblAdultos.Size = new Size(50, 20);
            lblAdultos.TabIndex = 24;
            lblAdultos.Text = "label2";
            // 
            // lblNinos
            // 
            lblNinos.AutoSize = true;
            lblNinos.Location = new Point(535, 101);
            lblNinos.Name = "lblNinos";
            lblNinos.Size = new Size(50, 20);
            lblNinos.TabIndex = 25;
            lblNinos.Text = "label3";
            // 
            // lblPrecioFinal
            // 
            lblPrecioFinal.AutoSize = true;
            lblPrecioFinal.Location = new Point(134, 380);
            lblPrecioFinal.Name = "lblPrecioFinal";
            lblPrecioFinal.Size = new Size(0, 20);
            lblPrecioFinal.TabIndex = 27;
            // 
            // txbEquipajeAdicional
            // 
            txbEquipajeAdicional.Location = new Point(599, 243);
            txbEquipajeAdicional.Name = "txbEquipajeAdicional";
            txbEquipajeAdicional.Size = new Size(73, 27);
            txbEquipajeAdicional.TabIndex = 28;
            // 
            // txbCargoAdicional
            // 
            txbCargoAdicional.Location = new Point(581, 327);
            txbCargoAdicional.Name = "txbCargoAdicional";
            txbCargoAdicional.Size = new Size(73, 27);
            txbCargoAdicional.TabIndex = 29;
            // 
            // dtpCheckin
            // 
            dtpCheckin.Location = new Point(106, 96);
            dtpCheckin.Name = "dtpCheckin";
            dtpCheckin.Size = new Size(322, 27);
            dtpCheckin.TabIndex = 30;
            // 
            // dtpCheckout
            // 
            dtpCheckout.Location = new Point(123, 164);
            dtpCheckout.Name = "dtpCheckout";
            dtpCheckout.Size = new Size(305, 27);
            dtpCheckout.TabIndex = 31;
            // 
            // txbMascotas
            // 
            txbMascotas.Location = new Point(553, 165);
            txbMascotas.Margin = new Padding(3, 4, 3, 4);
            txbMascotas.Name = "txbMascotas";
            txbMascotas.Size = new Size(61, 27);
            txbMascotas.TabIndex = 32;
            // 
            // lblPrecioNoche
            // 
            lblPrecioNoche.AutoSize = true;
            lblPrecioNoche.Location = new Point(145, 337);
            lblPrecioNoche.Name = "lblPrecioNoche";
            lblPrecioNoche.Size = new Size(0, 20);
            lblPrecioNoche.TabIndex = 34;
            // 
            // lbltxtPrecioNoche
            // 
            lbltxtPrecioNoche.AutoSize = true;
            lbltxtPrecioNoche.Location = new Point(42, 337);
            lbltxtPrecioNoche.Name = "lbltxtPrecioNoche";
            lbltxtPrecioNoche.Size = new Size(97, 20);
            lbltxtPrecioNoche.TabIndex = 33;
            lbltxtPrecioNoche.Text = "Precio noche:";
            // 
            // FormNuevaEstancia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(699, 559);
            Controls.Add(lblPrecioNoche);
            Controls.Add(lbltxtPrecioNoche);
            Controls.Add(txbMascotas);
            Controls.Add(dtpCheckout);
            Controls.Add(dtpCheckin);
            Controls.Add(txbCargoAdicional);
            Controls.Add(txbEquipajeAdicional);
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
            Name = "FormNuevaEstancia";
            Text = "Registrar nueva estancia";
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
        private TextBox txbEquipajeAdicional;
        private TextBox txbCargoAdicional;
        private DateTimePicker dtpCheckin;
        private DateTimePicker dtpCheckout;
        private TextBox txbMascotas;
        private Label lblPrecioNoche;
        private Label lbltxtPrecioNoche;
    }
}