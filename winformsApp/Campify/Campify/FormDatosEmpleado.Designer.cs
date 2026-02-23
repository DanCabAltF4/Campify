namespace Campify
{
    partial class FormDatosEmpleado
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosEmpleado));
            btnVolver = new Button();
            btnGuardar = new Button();
            lblId = new Label();
            lbltxtActivo = new Label();
            lbltxtTelefono = new Label();
            lbltxtPuesto = new Label();
            lbltxtDni = new Label();
            lbltxtApellidos = new Label();
            lbltxtNombre = new Label();
            lbltxtId = new Label();
            txbNombre = new TextBox();
            txbApellidos = new TextBox();
            txbDni = new TextBox();
            txbTelefono = new TextBox();
            cbPuesto = new ComboBox();
            chbActivo = new CheckBox();
            pnlTop = new Panel();
            lblFechaHora = new Label();
            btnMinimizar = new Button();
            lblTitulo = new Label();
            btnSalir = new Button();
            tmFechaHora = new System.Windows.Forms.Timer(components);
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
            btnVolver.Location = new Point(136, 284);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(89, 28);
            btnVolver.TabIndex = 0;
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
            btnGuardar.Location = new Point(311, 284);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(89, 28);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(55, 47);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 15);
            lblId.TabIndex = 27;
            // 
            // lbltxtActivo
            // 
            lbltxtActivo.AutoSize = true;
            lbltxtActivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtActivo.Location = new Point(349, 218);
            lbltxtActivo.Name = "lbltxtActivo";
            lbltxtActivo.Size = new Size(46, 15);
            lbltxtActivo.TabIndex = 20;
            lbltxtActivo.Text = "Activo:";
            // 
            // lbltxtTelefono
            // 
            lbltxtTelefono.AutoSize = true;
            lbltxtTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtTelefono.Location = new Point(349, 154);
            lbltxtTelefono.Name = "lbltxtTelefono";
            lbltxtTelefono.Size = new Size(25, 15);
            lbltxtTelefono.TabIndex = 19;
            lbltxtTelefono.Text = "Tlf:";
            // 
            // lbltxtPuesto
            // 
            lbltxtPuesto.AutoSize = true;
            lbltxtPuesto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtPuesto.Location = new Point(24, 218);
            lbltxtPuesto.Name = "lbltxtPuesto";
            lbltxtPuesto.Size = new Size(48, 15);
            lbltxtPuesto.TabIndex = 18;
            lbltxtPuesto.Text = "Puesto:";
            // 
            // lbltxtDni
            // 
            lbltxtDni.AutoSize = true;
            lbltxtDni.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtDni.Location = new Point(349, 98);
            lbltxtDni.Name = "lbltxtDni";
            lbltxtDni.Size = new Size(32, 15);
            lbltxtDni.TabIndex = 17;
            lbltxtDni.Text = "DNI:";
            // 
            // lbltxtApellidos
            // 
            lbltxtApellidos.AutoSize = true;
            lbltxtApellidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtApellidos.Location = new Point(24, 154);
            lbltxtApellidos.Name = "lbltxtApellidos";
            lbltxtApellidos.Size = new Size(60, 15);
            lbltxtApellidos.TabIndex = 16;
            lbltxtApellidos.Text = "Apellidos:";
            // 
            // lbltxtNombre
            // 
            lbltxtNombre.AutoSize = true;
            lbltxtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtNombre.Location = new Point(24, 98);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(56, 15);
            lbltxtNombre.TabIndex = 15;
            lbltxtNombre.Text = "Nombre:";
            // 
            // lbltxtId
            // 
            lbltxtId.AutoSize = true;
            lbltxtId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtId.Location = new Point(24, 47);
            lbltxtId.Name = "lbltxtId";
            lbltxtId.Size = new Size(24, 15);
            lbltxtId.TabIndex = 14;
            lbltxtId.Text = "Nº:";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(92, 96);
            txbNombre.Margin = new Padding(3, 2, 3, 2);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(200, 23);
            txbNombre.TabIndex = 28;
            // 
            // txbApellidos
            // 
            txbApellidos.Location = new Point(98, 152);
            txbApellidos.Margin = new Padding(3, 2, 3, 2);
            txbApellidos.Name = "txbApellidos";
            txbApellidos.Size = new Size(194, 23);
            txbApellidos.TabIndex = 29;
            // 
            // txbDni
            // 
            txbDni.Location = new Point(390, 96);
            txbDni.Margin = new Padding(3, 2, 3, 2);
            txbDni.Name = "txbDni";
            txbDni.Size = new Size(131, 23);
            txbDni.TabIndex = 31;
            // 
            // txbTelefono
            // 
            txbTelefono.Location = new Point(383, 152);
            txbTelefono.Margin = new Padding(3, 2, 3, 2);
            txbTelefono.Name = "txbTelefono";
            txbTelefono.Size = new Size(138, 23);
            txbTelefono.TabIndex = 32;
            // 
            // cbPuesto
            // 
            cbPuesto.FormattingEnabled = true;
            cbPuesto.Location = new Point(83, 216);
            cbPuesto.Margin = new Padding(3, 2, 3, 2);
            cbPuesto.Name = "cbPuesto";
            cbPuesto.Size = new Size(153, 23);
            cbPuesto.TabIndex = 34;
            // 
            // chbActivo
            // 
            chbActivo.AutoSize = true;
            chbActivo.Checked = true;
            chbActivo.CheckState = CheckState.Checked;
            chbActivo.Location = new Point(405, 220);
            chbActivo.Margin = new Padding(3, 2, 3, 2);
            chbActivo.Name = "chbActivo";
            chbActivo.Size = new Size(15, 14);
            chbActivo.TabIndex = 35;
            chbActivo.UseVisualStyleBackColor = true;
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
            lblTitulo.Size = new Size(123, 15);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Detalles del empleado";
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
            // FormDatosEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(542, 338);
            Controls.Add(pnlTop);
            Controls.Add(chbActivo);
            Controls.Add(cbPuesto);
            Controls.Add(txbTelefono);
            Controls.Add(txbDni);
            Controls.Add(txbApellidos);
            Controls.Add(txbNombre);
            Controls.Add(lblId);
            Controls.Add(lbltxtActivo);
            Controls.Add(lbltxtTelefono);
            Controls.Add(lbltxtPuesto);
            Controls.Add(lbltxtDni);
            Controls.Add(lbltxtApellidos);
            Controls.Add(lbltxtNombre);
            Controls.Add(lbltxtId);
            Controls.Add(btnGuardar);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDatosEmpleado";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormDatosEmpleado";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Button btnGuardar;
        private Label lblId;
        private Label lbltxtActivo;
        private Label lbltxtTelefono;
        private Label lbltxtPuesto;
        private Label lbltxtDni;
        private Label lbltxtApellidos;
        private Label lbltxtNombre;
        private Label lbltxtId;
        private TextBox txbNombre;
        private TextBox txbApellidos;
        private TextBox txbDni;
        private TextBox txbTelefono;
        private ComboBox cbPuesto;
        private CheckBox chbActivo;
        private Panel pnlTop;
        private Button btnMinimizar;
        private Label lblTitulo;
        private Button btnSalir;
        private Label lblFechaHora;
        private System.Windows.Forms.Timer tmFechaHora;
    }
}
