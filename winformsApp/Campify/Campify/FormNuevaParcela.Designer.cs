namespace Forms
{
    partial class FormNuevaParcela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevaParcela));
            pnlTop = new Panel();
            lblFechaHora = new Label();
            btnMinimizar = new Button();
            lblTitulo = new Label();
            btnSalir = new Button();
            tmFechaHora = new System.Windows.Forms.Timer(components);
            lblId = new Label();
            lblTipoParcela = new Label();
            lblPrecioNoche = new Label();
            lbltxtId = new Label();
            ckCercaBaño = new CheckBox();
            ckCercaEntrada = new CheckBox();
            ckTieneVistas = new CheckBox();
            ckZonaSombra = new CheckBox();
            ckZonaTranquila = new CheckBox();
            cbTipoParcela = new ComboBox();
            nudPrecioNoche = new NumericUpDown();
            pbImagen = new PictureBox();
            btnVolver = new Button();
            btnGuardar = new Button();
            btnSubirImagen = new Button();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecioNoche).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
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
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(810, 36);
            pnlTop.TabIndex = 27;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Segoe UI", 8F);
            lblFechaHora.Location = new Point(405, 9);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(0, 19);
            lblFechaHora.TabIndex = 10;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(729, 1);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(32, 32);
            btnMinimizar.TabIndex = 9;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(10, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(175, 20);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Campify - Panel principal";
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(767, 1);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(30, 32);
            btnSalir.TabIndex = 7;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // tmFechaHora
            // 
            tmFechaHora.Enabled = true;
            tmFechaHora.Interval = 10;
            tmFechaHora.Tick += tmFechaHora_Tick;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.Location = new Point(36, 74);
            lblId.Name = "lblId";
            lblId.Size = new Size(38, 20);
            lblId.TabIndex = 28;
            lblId.Text = "-Nº:";
            // 
            // lblTipoParcela
            // 
            lblTipoParcela.AutoSize = true;
            lblTipoParcela.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTipoParcela.Location = new Point(41, 241);
            lblTipoParcela.Name = "lblTipoParcela";
            lblTipoParcela.Size = new Size(125, 20);
            lblTipoParcela.TabIndex = 30;
            lblTipoParcela.Text = "-Tipo de parcela:";
            // 
            // lblPrecioNoche
            // 
            lblPrecioNoche.AutoSize = true;
            lblPrecioNoche.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrecioNoche.Location = new Point(36, 341);
            lblPrecioNoche.Name = "lblPrecioNoche";
            lblPrecioNoche.Size = new Size(108, 20);
            lblPrecioNoche.TabIndex = 34;
            lblPrecioNoche.Text = "-Precio noche:";
            // 
            // lbltxtId
            // 
            lbltxtId.AutoSize = true;
            lbltxtId.Location = new Point(77, 74);
            lbltxtId.Name = "lbltxtId";
            lbltxtId.Size = new Size(0, 20);
            lbltxtId.TabIndex = 38;
            // 
            // ckCercaBaño
            // 
            ckCercaBaño.AutoSize = true;
            ckCercaBaño.CheckAlign = ContentAlignment.BottomCenter;
            ckCercaBaño.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckCercaBaño.Location = new Point(36, 145);
            ckCercaBaño.Name = "ckCercaBaño";
            ckCercaBaño.Size = new Size(99, 41);
            ckCercaBaño.TabIndex = 39;
            ckCercaBaño.Text = "-Baño cerca:";
            ckCercaBaño.UseVisualStyleBackColor = true;
            // 
            // ckCercaEntrada
            // 
            ckCercaEntrada.AutoSize = true;
            ckCercaEntrada.CheckAlign = ContentAlignment.BottomCenter;
            ckCercaEntrada.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckCercaEntrada.Location = new Point(173, 145);
            ckCercaEntrada.Name = "ckCercaEntrada";
            ckCercaEntrada.Size = new Size(117, 41);
            ckCercaEntrada.TabIndex = 40;
            ckCercaEntrada.Text = "-Entrada cerca:";
            ckCercaEntrada.UseVisualStyleBackColor = true;
            // 
            // ckTieneVistas
            // 
            ckTieneVistas.AutoSize = true;
            ckTieneVistas.CheckAlign = ContentAlignment.BottomCenter;
            ckTieneVistas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckTieneVistas.Location = new Point(337, 145);
            ckTieneVistas.Name = "ckTieneVistas";
            ckTieneVistas.Size = new Size(105, 41);
            ckTieneVistas.TabIndex = 41;
            ckTieneVistas.Text = "-Tiene vistas:";
            ckTieneVistas.UseVisualStyleBackColor = true;
            // 
            // ckZonaSombra
            // 
            ckZonaSombra.AutoSize = true;
            ckZonaSombra.CheckAlign = ContentAlignment.BottomCenter;
            ckZonaSombra.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckZonaSombra.Location = new Point(475, 145);
            ckZonaSombra.Name = "ckZonaSombra";
            ckZonaSombra.Size = new Size(136, 41);
            ckZonaSombra.TabIndex = 42;
            ckZonaSombra.Text = "-Zona de sombra:";
            ckZonaSombra.UseVisualStyleBackColor = true;
            // 
            // ckZonaTranquila
            // 
            ckZonaTranquila.AutoSize = true;
            ckZonaTranquila.CheckAlign = ContentAlignment.BottomCenter;
            ckZonaTranquila.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckZonaTranquila.Location = new Point(650, 145);
            ckZonaTranquila.Name = "ckZonaTranquila";
            ckZonaTranquila.Size = new Size(125, 41);
            ckZonaTranquila.TabIndex = 43;
            ckZonaTranquila.Text = "-Zona tranquila:";
            ckZonaTranquila.UseVisualStyleBackColor = true;
            // 
            // cbTipoParcela
            // 
            cbTipoParcela.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoParcela.FormattingEnabled = true;
            cbTipoParcela.Location = new Point(172, 238);
            cbTipoParcela.Name = "cbTipoParcela";
            cbTipoParcela.Size = new Size(192, 28);
            cbTipoParcela.TabIndex = 44;
            // 
            // nudPrecioNoche
            // 
            nudPrecioNoche.DecimalPlaces = 2;
            nudPrecioNoche.Location = new Point(150, 339);
            nudPrecioNoche.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudPrecioNoche.Name = "nudPrecioNoche";
            nudPrecioNoche.Size = new Size(96, 27);
            nudPrecioNoche.TabIndex = 45;
            nudPrecioNoche.TextAlign = HorizontalAlignment.Right;
            // 
            // pbImagen
            // 
            pbImagen.Location = new Point(468, 219);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(300, 225);
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagen.TabIndex = 46;
            pbImagen.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(190, 130, 65);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 12F);
            btnVolver.ForeColor = Color.FromArgb(255, 222, 171);
            btnVolver.Location = new Point(36, 450);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(130, 35);
            btnVolver.TabIndex = 47;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(190, 130, 65);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.ForeColor = Color.FromArgb(255, 222, 171);
            btnGuardar.Location = new Point(275, 450);
            btnGuardar.Margin = new Padding(0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 35);
            btnGuardar.TabIndex = 48;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSubirImagen
            // 
            btnSubirImagen.BackColor = Color.FromArgb(190, 130, 65);
            btnSubirImagen.FlatAppearance.BorderSize = 0;
            btnSubirImagen.FlatStyle = FlatStyle.Flat;
            btnSubirImagen.Location = new Point(468, 456);
            btnSubirImagen.Name = "btnSubirImagen";
            btnSubirImagen.Size = new Size(300, 29);
            btnSubirImagen.TabIndex = 49;
            btnSubirImagen.Text = "Subir imágen";
            btnSubirImagen.UseVisualStyleBackColor = false;
            btnSubirImagen.Click += btnSubirImagen_Click;
            // 
            // FormNuevaParcela
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(810, 518);
            Controls.Add(btnSubirImagen);
            Controls.Add(btnGuardar);
            Controls.Add(btnVolver);
            Controls.Add(pbImagen);
            Controls.Add(nudPrecioNoche);
            Controls.Add(cbTipoParcela);
            Controls.Add(ckZonaTranquila);
            Controls.Add(ckZonaSombra);
            Controls.Add(ckTieneVistas);
            Controls.Add(ckCercaEntrada);
            Controls.Add(ckCercaBaño);
            Controls.Add(lbltxtId);
            Controls.Add(lblPrecioNoche);
            Controls.Add(lblTipoParcela);
            Controls.Add(lblId);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormNuevaParcela";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormNuevaParcela";
            Load += FormNuevaParcela_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecioNoche).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTop;
        private Label lblFechaHora;
        private Button btnMinimizar;
        private Label lblTitulo;
        private Button btnSalir;
        private System.Windows.Forms.Timer tmFechaHora;
        private Label lblId;
        private Label lblTipoParcela;
        private Label lblPrecioNoche;
        private Label lbltxtId;
        private CheckBox ckCercaBaño;
        private CheckBox ckCercaEntrada;
        private CheckBox ckTieneVistas;
        private CheckBox ckZonaSombra;
        private CheckBox ckZonaTranquila;
        private ComboBox cbTipoParcela;
        private NumericUpDown nudPrecioNoche;
        private PictureBox pbImagen;
        private Button btnVolver;
        private Button btnGuardar;
        private Button btnSubirImagen;
    }
}