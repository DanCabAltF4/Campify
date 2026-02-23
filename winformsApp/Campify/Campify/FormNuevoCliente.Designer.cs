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
            lblFechaHora = new Label();
            btnMinimizar = new Button();
            lblTitulo = new Label();
            btnSalir = new Button();
            tmFechaHora = new System.Windows.Forms.Timer(components);
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // lbltxtNombre
            // 
            lbltxtNombre.AutoSize = true;
            lbltxtNombre.Location = new Point(39, 59);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(54, 15);
            lbltxtNombre.TabIndex = 0;
            lbltxtNombre.Text = "Nombre:";
            // 
            // lbltxtApellidos
            // 
            lbltxtApellidos.AutoSize = true;
            lbltxtApellidos.Location = new Point(39, 107);
            lbltxtApellidos.Name = "lbltxtApellidos";
            lbltxtApellidos.Size = new Size(56, 15);
            lbltxtApellidos.TabIndex = 2;
            lbltxtApellidos.Text = "Apellidos";
            // 
            // lbltxtFechaNacimiento
            // 
            lbltxtFechaNacimiento.AutoSize = true;
            lbltxtFechaNacimiento.Location = new Point(39, 202);
            lbltxtFechaNacimiento.Name = "lbltxtFechaNacimiento";
            lbltxtFechaNacimiento.Size = new Size(120, 15);
            lbltxtFechaNacimiento.TabIndex = 3;
            lbltxtFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lbltxtTelefono
            // 
            lbltxtTelefono.AutoSize = true;
            lbltxtTelefono.Location = new Point(362, 209);
            lbltxtTelefono.Name = "lbltxtTelefono";
            lbltxtTelefono.Size = new Size(56, 15);
            lbltxtTelefono.TabIndex = 4;
            lbltxtTelefono.Text = "Telefono:";
            // 
            // lbltxtDireccion
            // 
            lbltxtDireccion.AutoSize = true;
            lbltxtDireccion.Location = new Point(365, 59);
            lbltxtDireccion.Name = "lbltxtDireccion";
            lbltxtDireccion.Size = new Size(57, 15);
            lbltxtDireccion.TabIndex = 5;
            lbltxtDireccion.Text = "Direccion";
            // 
            // lbltxtCodigoPostal
            // 
            lbltxtCodigoPostal.AutoSize = true;
            lbltxtCodigoPostal.Location = new Point(365, 157);
            lbltxtCodigoPostal.Name = "lbltxtCodigoPostal";
            lbltxtCodigoPostal.Size = new Size(84, 15);
            lbltxtCodigoPostal.TabIndex = 6;
            lbltxtCodigoPostal.Text = "Codigo postal:";
            // 
            // lbltxtEmail
            // 
            lbltxtEmail.AutoSize = true;
            lbltxtEmail.Location = new Point(365, 105);
            lbltxtEmail.Name = "lbltxtEmail";
            lbltxtEmail.Size = new Size(39, 15);
            lbltxtEmail.TabIndex = 7;
            lbltxtEmail.Text = "Email:";
            // 
            // lbltxtDni
            // 
            lbltxtDni.AutoSize = true;
            lbltxtDni.Location = new Point(39, 160);
            lbltxtDni.Name = "lbltxtDni";
            lbltxtDni.Size = new Size(30, 15);
            lbltxtDni.TabIndex = 8;
            lbltxtDni.Text = "DNI:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.YellowGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(433, 314);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(122, 28);
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
            btnVolver.Location = new Point(192, 314);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(122, 28);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(103, 57);
            txbNombre.Margin = new Padding(3, 2, 3, 2);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(199, 23);
            txbNombre.TabIndex = 1;
            // 
            // txbApellidos
            // 
            txbApellidos.Location = new Point(108, 105);
            txbApellidos.Margin = new Padding(3, 2, 3, 2);
            txbApellidos.Name = "txbApellidos";
            txbApellidos.Size = new Size(195, 23);
            txbApellidos.TabIndex = 2;
            // 
            // txbDni
            // 
            txbDni.Location = new Point(78, 158);
            txbDni.Margin = new Padding(3, 2, 3, 2);
            txbDni.Name = "txbDni";
            txbDni.Size = new Size(126, 23);
            txbDni.TabIndex = 3;
            // 
            // txbDireccion
            // 
            txbDireccion.Location = new Point(433, 57);
            txbDireccion.Margin = new Padding(3, 2, 3, 2);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(302, 23);
            txbDireccion.TabIndex = 4;
            // 
            // txbCodigoPostal
            // 
            txbCodigoPostal.Location = new Point(463, 154);
            txbCodigoPostal.Margin = new Padding(3, 2, 3, 2);
            txbCodigoPostal.Name = "txbCodigoPostal";
            txbCodigoPostal.Size = new Size(106, 23);
            txbCodigoPostal.TabIndex = 6;
            // 
            // txbTelefono
            // 
            txbTelefono.Location = new Point(429, 209);
            txbTelefono.Margin = new Padding(3, 2, 3, 2);
            txbTelefono.Name = "txbTelefono";
            txbTelefono.Size = new Size(140, 23);
            txbTelefono.TabIndex = 7;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(413, 105);
            txbEmail.Margin = new Padding(3, 2, 3, 2);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(322, 23);
            txbEmail.TabIndex = 5;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(39, 219);
            dtpFechaNacimiento.Margin = new Padding(3, 2, 3, 2);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(263, 23);
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
            pnlTop.Margin = new Padding(3, 2, 3, 2);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(784, 27);
            pnlTop.TabIndex = 11;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Segoe UI", 8F);
            lblFechaHora.Location = new Point(302, 7);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(0, 13);
            lblFechaHora.TabIndex = 12;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(707, 1);
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
            lblTitulo.Size = new Size(80, 15);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Nuevo cliente";
            lblTitulo.MouseDown += pnlTop_MouseDown;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(740, 1);
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
            // FormNuevoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(784, 364);
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
            Margin = new Padding(3, 2, 3, 2);
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