namespace Forms
{
    partial class FormNuevoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoCliente));
            lbltxtNombre = new Label();
            lbltxtApellidos = new Label();
            lbltxtFechaNacimiento = new Label();
            lbltxtTelefono = new Label();
            lbltxtDireccion = new Label();
            lbltxtCodigoPostal = new Label();
            lbltxtEmail = new Label();
            lbltxtDni = new Label();
            btnGuardar = new Button();
            btnVolver = new Button();
            txbNombre = new TextBox();
            txbApellidos = new TextBox();
            txbDni = new TextBox();
            txbDireccion = new TextBox();
            txbCodigoPostal = new TextBox();
            txbTelefono = new TextBox();
            txbEmail = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            pnlTop = new Panel();
            btnMinimizar = new Button();
            lblTitulo = new Label();
            btnSalir = new Button();
            lblFechaHora = new Label();
            tmFechaHora = new System.Windows.Forms.Timer(components);
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // lbltxtNombre
            // 
            lbltxtNombre.AutoSize = true;
            lbltxtNombre.Location = new Point(45, 79);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(67, 20);
            lbltxtNombre.TabIndex = 0;
            lbltxtNombre.Text = "Nombre:";
            // 
            // lbltxtApellidos
            // 
            lbltxtApellidos.AutoSize = true;
            lbltxtApellidos.Location = new Point(45, 143);
            lbltxtApellidos.Name = "lbltxtApellidos";
            lbltxtApellidos.Size = new Size(72, 20);
            lbltxtApellidos.TabIndex = 2;
            lbltxtApellidos.Text = "Apellidos";
            // 
            // lbltxtFechaNacimiento
            // 
            lbltxtFechaNacimiento.AutoSize = true;
            lbltxtFechaNacimiento.Location = new Point(45, 269);
            lbltxtFechaNacimiento.Name = "lbltxtFechaNacimiento";
            lbltxtFechaNacimiento.Size = new Size(149, 20);
            lbltxtFechaNacimiento.TabIndex = 3;
            lbltxtFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lbltxtTelefono
            // 
            lbltxtTelefono.AutoSize = true;
            lbltxtTelefono.Location = new Point(414, 279);
            lbltxtTelefono.Name = "lbltxtTelefono";
            lbltxtTelefono.Size = new Size(70, 20);
            lbltxtTelefono.TabIndex = 4;
            lbltxtTelefono.Text = "Telefono:";
            // 
            // lbltxtDireccion
            // 
            lbltxtDireccion.AutoSize = true;
            lbltxtDireccion.Location = new Point(417, 79);
            lbltxtDireccion.Name = "lbltxtDireccion";
            lbltxtDireccion.Size = new Size(72, 20);
            lbltxtDireccion.TabIndex = 5;
            lbltxtDireccion.Text = "Direccion";
            // 
            // lbltxtCodigoPostal
            // 
            lbltxtCodigoPostal.AutoSize = true;
            lbltxtCodigoPostal.Location = new Point(417, 209);
            lbltxtCodigoPostal.Name = "lbltxtCodigoPostal";
            lbltxtCodigoPostal.Size = new Size(106, 20);
            lbltxtCodigoPostal.TabIndex = 6;
            lbltxtCodigoPostal.Text = "Codigo postal:";
            // 
            // lbltxtEmail
            // 
            lbltxtEmail.AutoSize = true;
            lbltxtEmail.Location = new Point(417, 140);
            lbltxtEmail.Name = "lbltxtEmail";
            lbltxtEmail.Size = new Size(49, 20);
            lbltxtEmail.TabIndex = 7;
            lbltxtEmail.Text = "Email:";
            // 
            // lbltxtDni
            // 
            lbltxtDni.AutoSize = true;
            lbltxtDni.Location = new Point(45, 213);
            lbltxtDni.Name = "lbltxtDni";
            lbltxtDni.Size = new Size(38, 20);
            lbltxtDni.TabIndex = 8;
            lbltxtDni.Text = "DNI:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.YellowGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(495, 419);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(139, 38);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.YellowGreen;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 12F);
            btnVolver.Location = new Point(220, 419);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(139, 38);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(118, 76);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(227, 27);
            txbNombre.TabIndex = 1;
            // 
            // txbApellidos
            // 
            txbApellidos.Location = new Point(123, 140);
            txbApellidos.Name = "txbApellidos";
            txbApellidos.Size = new Size(222, 27);
            txbApellidos.TabIndex = 2;
            // 
            // txbDni
            // 
            txbDni.Location = new Point(89, 210);
            txbDni.Name = "txbDni";
            txbDni.Size = new Size(144, 27);
            txbDni.TabIndex = 3;
            // 
            // txbDireccion
            // 
            txbDireccion.Location = new Point(495, 76);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(345, 27);
            txbDireccion.TabIndex = 4;
            // 
            // txbCodigoPostal
            // 
            txbCodigoPostal.Location = new Point(529, 206);
            txbCodigoPostal.Name = "txbCodigoPostal";
            txbCodigoPostal.Size = new Size(120, 27);
            txbCodigoPostal.TabIndex = 6;
            // 
            // txbTelefono
            // 
            txbTelefono.Location = new Point(490, 279);
            txbTelefono.Name = "txbTelefono";
            txbTelefono.Size = new Size(159, 27);
            txbTelefono.TabIndex = 7;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(472, 140);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(368, 27);
            txbEmail.TabIndex = 5;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(45, 292);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(300, 27);
            dtpFechaNacimiento.TabIndex = 8;
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
            pnlTop.Size = new Size(896, 36);
            pnlTop.TabIndex = 11;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(808, 1);
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
            lblTitulo.Size = new Size(100, 20);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Nuevo cliente";
            lblTitulo.MouseDown += pnlTop_MouseDown;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(846, 1);
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
            lblFechaHora.Location = new Point(345, 9);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(0, 19);
            lblFechaHora.TabIndex = 12;
            // 
            // tmFechaHora
            // 
            tmFechaHora.Enabled = true;
            tmFechaHora.Interval = 1000;
            tmFechaHora.Tick += tmFechaHora_Tick;
            // 
            // FormNuevoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(896, 486);
            Controls.Add(pnlTop);
            Controls.Add(txbNombre);
            Controls.Add(txbApellidos);
            Controls.Add(txbDni);
            Controls.Add(txbDireccion);
            Controls.Add(txbEmail);
            Controls.Add(txbCodigoPostal);
            Controls.Add(txbTelefono);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(btnVolver);
            Controls.Add(btnGuardar);
            Controls.Add(lbltxtDni);
            Controls.Add(lbltxtEmail);
            Controls.Add(lbltxtCodigoPostal);
            Controls.Add(lbltxtDireccion);
            Controls.Add(lbltxtTelefono);
            Controls.Add(lbltxtFechaNacimiento);
            Controls.Add(lbltxtApellidos);
            Controls.Add(lbltxtNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormNuevoCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormNuevoCliente";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltxtNombre;
        private Label lbltxtApellidos;
        private Label lbltxtFechaNacimiento;
        private Label lbltxtTelefono;
        private Label lbltxtDireccion;
        private Label lbltxtCodigoPostal;
        private Label lbltxtEmail;
        private Label lbltxtDni;
        private Button btnGuardar;
        private Button btnVolver;
        private TextBox txbNombre;
        private TextBox txbApellidos;
        private TextBox txbDni;
        private TextBox txbDireccion;
        private TextBox txbCodigoPostal;
        private TextBox txbTelefono;
        private TextBox txbEmail;
        private DateTimePicker dtpFechaNacimiento;
        private Panel pnlTop;
        private Button btnMinimizar;
        private Label lblTitulo;
        private Button btnSalir;
        private Label lblFechaHora;
        private System.Windows.Forms.Timer tmFechaHora;
    }
}