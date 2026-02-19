namespace Forms
{
    partial class FormDatosServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosServicio));
            btnVolver = new Button();
            btnGuardar = new Button();
            lblId = new Label();
            lbltxtId = new Label();
            txbNombre = new TextBox();
            lbltxtNombre = new Label();
            lbltxtPrecio = new Label();
            nupPrecio = new NumericUpDown();
            txbDescripcion = new TextBox();
            lbltxtDescripcion = new Label();
            pnlTop = new Panel();
            btnMinimizar = new Button();
            lblTitulo = new Label();
            btnSalir = new Button();
            lblFechaHora = new Label();
            tmFechaHora = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)nupPrecio).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Peru;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 12F);
            btnVolver.ForeColor = Color.Moccasin;
            btnVolver.Location = new Point(159, 380);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(102, 38);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Peru;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.ForeColor = Color.Moccasin;
            btnGuardar.Location = new Point(372, 380);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 38);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(68, 64);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 20);
            lblId.TabIndex = 29;
            // 
            // lbltxtId
            // 
            lbltxtId.AutoSize = true;
            lbltxtId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtId.Location = new Point(33, 64);
            lbltxtId.Name = "lbltxtId";
            lbltxtId.Size = new Size(32, 20);
            lbltxtId.TabIndex = 28;
            lbltxtId.Text = "Nº:";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(110, 122);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(290, 27);
            txbNombre.TabIndex = 31;
            // 
            // lbltxtNombre
            // 
            lbltxtNombre.AutoSize = true;
            lbltxtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtNombre.Location = new Point(33, 125);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(71, 20);
            lbltxtNombre.TabIndex = 30;
            lbltxtNombre.Text = "Nombre:";
            // 
            // lbltxtPrecio
            // 
            lbltxtPrecio.AutoSize = true;
            lbltxtPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtPrecio.Location = new Point(434, 125);
            lbltxtPrecio.Name = "lbltxtPrecio";
            lbltxtPrecio.Size = new Size(56, 20);
            lbltxtPrecio.TabIndex = 32;
            lbltxtPrecio.Text = "Precio:";
            // 
            // nupPrecio
            // 
            nupPrecio.DecimalPlaces = 2;
            nupPrecio.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nupPrecio.Location = new Point(496, 122);
            nupPrecio.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nupPrecio.Name = "nupPrecio";
            nupPrecio.Size = new Size(89, 27);
            nupPrecio.TabIndex = 33;
            // 
            // txbDescripcion
            // 
            txbDescripcion.Location = new Point(33, 227);
            txbDescripcion.Multiline = true;
            txbDescripcion.Name = "txbDescripcion";
            txbDescripcion.Size = new Size(552, 115);
            txbDescripcion.TabIndex = 35;
            // 
            // lbltxtDescripcion
            // 
            lbltxtDescripcion.AutoSize = true;
            lbltxtDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtDescripcion.Location = new Point(33, 187);
            lbltxtDescripcion.Name = "lbltxtDescripcion";
            lbltxtDescripcion.Size = new Size(94, 20);
            lbltxtDescripcion.TabIndex = 34;
            lbltxtDescripcion.Text = "Descripción:";
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
            pnlTop.Size = new Size(620, 36);
            pnlTop.TabIndex = 36;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(535, 1);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(32, 32);
            btnMinimizar.TabIndex = 9;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(10, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(174, 20);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Detalles sobre el servicio";
            lblTitulo.MouseDown += pnlTop_MouseDown;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(573, 1);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(44, 32);
            btnSalir.TabIndex = 7;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Segoe UI", 8F);
            lblFechaHora.Location = new Point(250, 12);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(0, 19);
            lblFechaHora.TabIndex = 37;
            // 
            // tmFechaHora
            // 
            tmFechaHora.Enabled = true;
            tmFechaHora.Interval = 1000;
            tmFechaHora.Tick += tmFechaHora_Tick;
            // 
            // FormDatosServicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(620, 450);
            Controls.Add(pnlTop);
            Controls.Add(txbDescripcion);
            Controls.Add(lbltxtDescripcion);
            Controls.Add(nupPrecio);
            Controls.Add(lbltxtPrecio);
            Controls.Add(txbNombre);
            Controls.Add(lbltxtNombre);
            Controls.Add(lblId);
            Controls.Add(lbltxtId);
            Controls.Add(btnGuardar);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDatosServicio";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormDatosServicio";
            ((System.ComponentModel.ISupportInitialize)nupPrecio).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Button btnGuardar;
        private Label lblId;
        private Label lbltxtId;
        private TextBox txbNombre;
        private Label lbltxtNombre;
        private Label lbltxtPrecio;
        private NumericUpDown nupPrecio;
        private TextBox txbDescripcion;
        private Label lbltxtDescripcion;
        private Panel pnlTop;
        private Button btnMinimizar;
        private Label lblTitulo;
        private Button btnSalir;
        private Label lblFechaHora;
        private System.Windows.Forms.Timer tmFechaHora;
    }
}