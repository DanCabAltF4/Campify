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
            txt = new TextBox();
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
            btnGuardarReserva.Location = new Point(380, 350);
            btnGuardarReserva.Margin = new Padding(3, 2, 3, 2);
            btnGuardarReserva.Name = "btnGuardarReserva";
            btnGuardarReserva.Size = new Size(94, 50);
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
            btnClientes.Location = new Point(71, 366);
            btnClientes.Margin = new Padding(3, 2, 3, 2);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(82, 25);
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
            btnServicios.Location = new Point(213, 366);
            btnServicios.Margin = new Padding(3, 2, 3, 2);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(82, 25);
            btnServicios.TabIndex = 2;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = false;
            btnServicios.Click += btnServicios_Click;
            // 
            // lbltxtParcela
            // 
            lbltxtParcela.AutoSize = true;
            lbltxtParcela.Location = new Point(35, 32);
            lbltxtParcela.Name = "lbltxtParcela";
            lbltxtParcela.Size = new Size(48, 15);
            lbltxtParcela.TabIndex = 3;
            lbltxtParcela.Text = "Parcela:";
            // 
            // lbltxtCheckout
            // 
            lbltxtCheckout.AutoSize = true;
            lbltxtCheckout.Location = new Point(35, 127);
            lbltxtCheckout.Name = "lbltxtCheckout";
            lbltxtCheckout.Size = new Size(64, 15);
            lbltxtCheckout.TabIndex = 7;
            lbltxtCheckout.Text = "Check out:";
            // 
            // lbltxtMascotas
            // 
            lbltxtMascotas.AutoSize = true;
            lbltxtMascotas.Location = new Point(401, 127);
            lbltxtMascotas.Name = "lbltxtMascotas";
            lbltxtMascotas.Size = new Size(77, 15);
            lbltxtMascotas.TabIndex = 10;
            lbltxtMascotas.Text = "Nº Mascotas:";
            // 
            // lbltxtTemporada
            // 
            lbltxtTemporada.AutoSize = true;
            lbltxtTemporada.Location = new Point(35, 184);
            lbltxtTemporada.Name = "lbltxtTemporada";
            lbltxtTemporada.Size = new Size(70, 15);
            lbltxtTemporada.TabIndex = 11;
            lbltxtTemporada.Text = "Temporada:";
            // 
            // lbltxtPrecioFinal
            // 
            lbltxtPrecioFinal.AutoSize = true;
            lbltxtPrecioFinal.Location = new Point(37, 285);
            lbltxtPrecioFinal.Name = "lbltxtPrecioFinal";
            lbltxtPrecioFinal.Size = new Size(69, 15);
            lbltxtPrecioFinal.TabIndex = 12;
            lbltxtPrecioFinal.Text = "Precio final:";
            // 
            // lbltxtCheckin
            // 
            lbltxtCheckin.AutoSize = true;
            lbltxtCheckin.Location = new Point(35, 76);
            lbltxtCheckin.Name = "lbltxtCheckin";
            lbltxtCheckin.Size = new Size(50, 15);
            lbltxtCheckin.TabIndex = 13;
            lbltxtCheckin.Text = "Chek in:";
            // 
            // lbltxtNinos
            // 
            lbltxtNinos.AutoSize = true;
            lbltxtNinos.Location = new Point(401, 76);
            lbltxtNinos.Name = "lbltxtNinos";
            lbltxtNinos.Size = new Size(58, 15);
            lbltxtNinos.TabIndex = 18;
            lbltxtNinos.Text = "Nº Niños:";
            // 
            // lbltxtEquipajeAdicional
            // 
            lbltxtEquipajeAdicional.AutoSize = true;
            lbltxtEquipajeAdicional.Location = new Point(401, 184);
            lbltxtEquipajeAdicional.Name = "lbltxtEquipajeAdicional";
            lbltxtEquipajeAdicional.Size = new Size(106, 15);
            lbltxtEquipajeAdicional.TabIndex = 17;
            lbltxtEquipajeAdicional.Text = "Equipaje adicional:";
            // 
            // lbltxtCargoAdicional
            // 
            lbltxtCargoAdicional.AutoSize = true;
            lbltxtCargoAdicional.Location = new Point(401, 248);
            lbltxtCargoAdicional.Name = "lbltxtCargoAdicional";
            lbltxtCargoAdicional.Size = new Size(93, 15);
            lbltxtCargoAdicional.TabIndex = 15;
            lbltxtCargoAdicional.Text = "Cargo adicional:";
            // 
            // lbltxtAdultos
            // 
            lbltxtAdultos.AutoSize = true;
            lbltxtAdultos.Location = new Point(401, 32);
            lbltxtAdultos.Name = "lbltxtAdultos";
            lbltxtAdultos.Size = new Size(68, 15);
            lbltxtAdultos.TabIndex = 14;
            lbltxtAdultos.Text = "Nº Adultos:";
            // 
            // cbTemporada
            // 
            cbTemporada.FormattingEnabled = true;
            cbTemporada.Location = new Point(117, 182);
            cbTemporada.Margin = new Padding(3, 2, 3, 2);
            cbTemporada.Name = "cbTemporada";
            cbTemporada.Size = new Size(86, 23);
            cbTemporada.TabIndex = 22;
            // 
            // lblParcela
            // 
            lblParcela.AutoSize = true;
            lblParcela.Location = new Point(92, 32);
            lblParcela.Name = "lblParcela";
            lblParcela.Size = new Size(38, 15);
            lblParcela.TabIndex = 23;
            lblParcela.Text = "label1";
            // 
            // lblAdultos
            // 
            lblAdultos.AutoSize = true;
            lblAdultos.Location = new Point(480, 32);
            lblAdultos.Name = "lblAdultos";
            lblAdultos.Size = new Size(38, 15);
            lblAdultos.TabIndex = 24;
            lblAdultos.Text = "label2";
            // 
            // lblNinos
            // 
            lblNinos.AutoSize = true;
            lblNinos.Location = new Point(468, 76);
            lblNinos.Name = "lblNinos";
            lblNinos.Size = new Size(38, 15);
            lblNinos.TabIndex = 25;
            lblNinos.Text = "label3";
            // 
            // lblPrecioFinal
            // 
            lblPrecioFinal.AutoSize = true;
            lblPrecioFinal.Location = new Point(117, 285);
            lblPrecioFinal.Name = "lblPrecioFinal";
            lblPrecioFinal.Size = new Size(38, 15);
            lblPrecioFinal.TabIndex = 27;
            lblPrecioFinal.Text = "label5";
            // 
            // txbEquipajeAdicional
            // 
            txbEquipajeAdicional.Location = new Point(524, 182);
            txbEquipajeAdicional.Margin = new Padding(3, 2, 3, 2);
            txbEquipajeAdicional.Name = "txbEquipajeAdicional";
            txbEquipajeAdicional.Size = new Size(64, 23);
            txbEquipajeAdicional.TabIndex = 28;
            // 
            // txbCargoAdicional
            // 
            txbCargoAdicional.Location = new Point(508, 245);
            txbCargoAdicional.Margin = new Padding(3, 2, 3, 2);
            txbCargoAdicional.Name = "txbCargoAdicional";
            txbCargoAdicional.Size = new Size(64, 23);
            txbCargoAdicional.TabIndex = 29;
            // 
            // dtpCheckin
            // 
            dtpCheckin.Location = new Point(93, 72);
            dtpCheckin.Margin = new Padding(3, 2, 3, 2);
            dtpCheckin.Name = "dtpCheckin";
            dtpCheckin.Size = new Size(282, 23);
            dtpCheckin.TabIndex = 30;
            // 
            // dtpCheckout
            // 
            dtpCheckout.Location = new Point(108, 123);
            dtpCheckout.Margin = new Padding(3, 2, 3, 2);
            dtpCheckout.Name = "dtpCheckout";
            dtpCheckout.Size = new Size(267, 23);
            dtpCheckout.TabIndex = 31;
            // 
            // txt
            // 
            txt.Location = new Point(484, 124);
            txt.Name = "txt";
            txt.Size = new Size(54, 23);
            txt.TabIndex = 32;
            // 
            // lblPrecioNoche
            // 
            lblPrecioNoche.AutoSize = true;
            lblPrecioNoche.Location = new Point(117, 253);
            lblPrecioNoche.Name = "lblPrecioNoche";
            lblPrecioNoche.Size = new Size(38, 15);
            lblPrecioNoche.TabIndex = 34;
            lblPrecioNoche.Text = "label5";
            // 
            // lbltxtPrecioNoche
            // 
            lbltxtPrecioNoche.AutoSize = true;
            lbltxtPrecioNoche.Location = new Point(37, 253);
            lbltxtPrecioNoche.Name = "lbltxtPrecioNoche";
            lbltxtPrecioNoche.Size = new Size(69, 15);
            lbltxtPrecioNoche.TabIndex = 33;
            lbltxtPrecioNoche.Text = "Precio final:";
            // 
            // FormNuevaEstancia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(612, 419);
            Controls.Add(lblPrecioNoche);
            Controls.Add(lbltxtPrecioNoche);
            Controls.Add(txt);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox txt;
        private Label lblPrecioNoche;
        private Label lbltxtPrecioNoche;
    }
}