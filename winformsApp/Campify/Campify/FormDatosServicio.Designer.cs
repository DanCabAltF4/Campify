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
            lblFechaHora = new Label();
            btnMinimizar = new Button();
            lblTitulo = new Label();
            btnSalir = new Button();
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
            btnVolver.Location = new Point(139, 285);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(89, 28);
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
            btnGuardar.Location = new Point(326, 285);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(89, 28);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(60, 48);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 15);
            lblId.TabIndex = 29;
            // 
            // lbltxtId
            // 
            lbltxtId.AutoSize = true;
            lbltxtId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtId.Location = new Point(29, 48);
            lbltxtId.Name = "lbltxtId";
            lbltxtId.Size = new Size(24, 15);
            lbltxtId.TabIndex = 28;
            lbltxtId.Text = "Nº:";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(96, 92);
            txbNombre.Margin = new Padding(3, 2, 3, 2);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(254, 23);
            txbNombre.TabIndex = 31;
            // 
            // lbltxtNombre
            // 
            lbltxtNombre.AutoSize = true;
            lbltxtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtNombre.Location = new Point(29, 94);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(56, 15);
            lbltxtNombre.TabIndex = 30;
            lbltxtNombre.Text = "Nombre:";
            // 
            // lbltxtPrecio
            // 
            lbltxtPrecio.AutoSize = true;
            lbltxtPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtPrecio.Location = new Point(380, 94);
            lbltxtPrecio.Name = "lbltxtPrecio";
            lbltxtPrecio.Size = new Size(45, 15);
            lbltxtPrecio.TabIndex = 32;
            lbltxtPrecio.Text = "Precio:";
            // 
            // nupPrecio
            // 
            nupPrecio.DecimalPlaces = 2;
            nupPrecio.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nupPrecio.Location = new Point(434, 92);
            nupPrecio.Margin = new Padding(3, 2, 3, 2);
            nupPrecio.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nupPrecio.Name = "nupPrecio";
            nupPrecio.Size = new Size(78, 23);
            nupPrecio.TabIndex = 33;
            // 
            // txbDescripcion
            // 
            txbDescripcion.Location = new Point(29, 170);
            txbDescripcion.Margin = new Padding(3, 2, 3, 2);
            txbDescripcion.Multiline = true;
            txbDescripcion.Name = "txbDescripcion";
            txbDescripcion.Size = new Size(484, 87);
            txbDescripcion.TabIndex = 35;
            // 
            // lbltxtDescripcion
            // 
            lbltxtDescripcion.AutoSize = true;
            lbltxtDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtDescripcion.Location = new Point(29, 140);
            lbltxtDescripcion.Name = "lbltxtDescripcion";
            lbltxtDescripcion.Size = new Size(75, 15);
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
            pnlTop.Margin = new Padding(3, 2, 3, 2);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(542, 27);
            pnlTop.TabIndex = 36;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Segoe UI", 8F);
            lblFechaHora.Location = new Point(219, 9);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(0, 13);
            lblFechaHora.TabIndex = 37;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(468, 1);
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
            lblTitulo.Size = new Size(135, 15);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Detalles sobre el servicio";
            lblTitulo.MouseDown += pnlTop_MouseDown;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(501, 1);
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
            // FormDatosServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(542, 338);
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
            Margin = new Padding(3, 2, 3, 2);
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