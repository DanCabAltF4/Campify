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
            btnMinimizar = new Button();
            lblTitulo = new Label();
            btnSalir = new Button();
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
            btnVolver.Location = new Point(156, 379);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(102, 38);
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
            btnGuardar.Location = new Point(355, 379);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 38);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(63, 63);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 20);
            lblId.TabIndex = 27;
            // 
            // lbltxtActivo
            // 
            lbltxtActivo.AutoSize = true;
            lbltxtActivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtActivo.Location = new Point(399, 291);
            lbltxtActivo.Name = "lbltxtActivo";
            lbltxtActivo.Size = new Size(58, 20);
            lbltxtActivo.TabIndex = 20;
            lbltxtActivo.Text = "Activo:";
            // 
            // lbltxtTelefono
            // 
            lbltxtTelefono.AutoSize = true;
            lbltxtTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtTelefono.Location = new Point(399, 206);
            lbltxtTelefono.Name = "lbltxtTelefono";
            lbltxtTelefono.Size = new Size(33, 20);
            lbltxtTelefono.TabIndex = 19;
            lbltxtTelefono.Text = "Tlf:";
            // 
            // lbltxtPuesto
            // 
            lbltxtPuesto.AutoSize = true;
            lbltxtPuesto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtPuesto.Location = new Point(28, 291);
            lbltxtPuesto.Name = "lbltxtPuesto";
            lbltxtPuesto.Size = new Size(61, 20);
            lbltxtPuesto.TabIndex = 18;
            lbltxtPuesto.Text = "Puesto:";
            // 
            // lbltxtDni
            // 
            lbltxtDni.AutoSize = true;
            lbltxtDni.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtDni.Location = new Point(399, 131);
            lbltxtDni.Name = "lbltxtDni";
            lbltxtDni.Size = new Size(41, 20);
            lbltxtDni.TabIndex = 17;
            lbltxtDni.Text = "DNI:";
            // 
            // lbltxtApellidos
            // 
            lbltxtApellidos.AutoSize = true;
            lbltxtApellidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtApellidos.Location = new Point(28, 206);
            lbltxtApellidos.Name = "lbltxtApellidos";
            lbltxtApellidos.Size = new Size(78, 20);
            lbltxtApellidos.TabIndex = 16;
            lbltxtApellidos.Text = "Apellidos:";
            // 
            // lbltxtNombre
            // 
            lbltxtNombre.AutoSize = true;
            lbltxtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtNombre.Location = new Point(28, 131);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(71, 20);
            lbltxtNombre.TabIndex = 15;
            lbltxtNombre.Text = "Nombre:";
            // 
            // lbltxtId
            // 
            lbltxtId.AutoSize = true;
            lbltxtId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtId.Location = new Point(28, 63);
            lbltxtId.Name = "lbltxtId";
            lbltxtId.Size = new Size(32, 20);
            lbltxtId.TabIndex = 14;
            lbltxtId.Text = "Nº:";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(105, 128);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(228, 27);
            txbNombre.TabIndex = 28;
            // 
            // txbApellidos
            // 
            txbApellidos.Location = new Point(112, 203);
            txbApellidos.Name = "txbApellidos";
            txbApellidos.Size = new Size(221, 27);
            txbApellidos.TabIndex = 29;
            // 
            // txbDni
            // 
            txbDni.Location = new Point(446, 128);
            txbDni.Name = "txbDni";
            txbDni.Size = new Size(149, 27);
            txbDni.TabIndex = 31;
            // 
            // txbTelefono
            // 
            txbTelefono.Location = new Point(438, 203);
            txbTelefono.Name = "txbTelefono";
            txbTelefono.Size = new Size(157, 27);
            txbTelefono.TabIndex = 32;
            // 
            // cbPuesto
            // 
            cbPuesto.FormattingEnabled = true;
            cbPuesto.Location = new Point(95, 288);
            cbPuesto.Name = "cbPuesto";
            cbPuesto.Size = new Size(174, 28);
            cbPuesto.TabIndex = 34;
            // 
            // chbActivo
            // 
            chbActivo.AutoSize = true;
            chbActivo.Checked = true;
            chbActivo.CheckState = CheckState.Checked;
            chbActivo.Location = new Point(463, 294);
            chbActivo.Name = "chbActivo";
            chbActivo.Size = new Size(18, 17);
            chbActivo.TabIndex = 35;
            chbActivo.UseVisualStyleBackColor = true;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(197, 239, 100);
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
            lblTitulo.Size = new Size(229, 20);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Campify - Detalles del empleado";
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
            // FormDatosEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(620, 450);
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
    }
}
