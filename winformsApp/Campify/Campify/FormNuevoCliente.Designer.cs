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
            SuspendLayout();
            // 
            // lbltxtNombre
            // 
            lbltxtNombre.AutoSize = true;
            lbltxtNombre.Location = new Point(47, 51);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(67, 20);
            lbltxtNombre.TabIndex = 0;
            lbltxtNombre.Text = "Nombre:";
            // 
            // lbltxtApellidos
            // 
            lbltxtApellidos.AutoSize = true;
            lbltxtApellidos.Location = new Point(47, 115);
            lbltxtApellidos.Name = "lbltxtApellidos";
            lbltxtApellidos.Size = new Size(72, 20);
            lbltxtApellidos.TabIndex = 2;
            lbltxtApellidos.Text = "Apellidos";
            // 
            // lbltxtFechaNacimiento
            // 
            lbltxtFechaNacimiento.AutoSize = true;
            lbltxtFechaNacimiento.Location = new Point(47, 241);
            lbltxtFechaNacimiento.Name = "lbltxtFechaNacimiento";
            lbltxtFechaNacimiento.Size = new Size(149, 20);
            lbltxtFechaNacimiento.TabIndex = 3;
            lbltxtFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lbltxtTelefono
            // 
            lbltxtTelefono.AutoSize = true;
            lbltxtTelefono.Location = new Point(416, 251);
            lbltxtTelefono.Name = "lbltxtTelefono";
            lbltxtTelefono.Size = new Size(70, 20);
            lbltxtTelefono.TabIndex = 4;
            lbltxtTelefono.Text = "Telefono:";
            // 
            // lbltxtDireccion
            // 
            lbltxtDireccion.AutoSize = true;
            lbltxtDireccion.Location = new Point(419, 51);
            lbltxtDireccion.Name = "lbltxtDireccion";
            lbltxtDireccion.Size = new Size(72, 20);
            lbltxtDireccion.TabIndex = 5;
            lbltxtDireccion.Text = "Direccion";
            // 
            // lbltxtCodigoPostal
            // 
            lbltxtCodigoPostal.AutoSize = true;
            lbltxtCodigoPostal.Location = new Point(419, 181);
            lbltxtCodigoPostal.Name = "lbltxtCodigoPostal";
            lbltxtCodigoPostal.Size = new Size(106, 20);
            lbltxtCodigoPostal.TabIndex = 6;
            lbltxtCodigoPostal.Text = "Codigo postal:";
            // 
            // lbltxtEmail
            // 
            lbltxtEmail.AutoSize = true;
            lbltxtEmail.Location = new Point(419, 112);
            lbltxtEmail.Name = "lbltxtEmail";
            lbltxtEmail.Size = new Size(49, 20);
            lbltxtEmail.TabIndex = 7;
            lbltxtEmail.Text = "Email:";
            // 
            // lbltxtDni
            // 
            lbltxtDni.AutoSize = true;
            lbltxtDni.Location = new Point(47, 185);
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
            btnGuardar.Location = new Point(481, 391);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 38);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.YellowGreen;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 12F);
            btnVolver.Location = new Point(253, 391);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 38);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(120, 48);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(227, 27);
            txbNombre.TabIndex = 11;
            // 
            // txbApellidos
            // 
            txbApellidos.Location = new Point(125, 112);
            txbApellidos.Name = "txbApellidos";
            txbApellidos.Size = new Size(222, 27);
            txbApellidos.TabIndex = 12;
            // 
            // txbDni
            // 
            txbDni.Location = new Point(91, 182);
            txbDni.Name = "txbDni";
            txbDni.Size = new Size(144, 27);
            txbDni.TabIndex = 13;
            // 
            // txbDireccion
            // 
            txbDireccion.Location = new Point(497, 48);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(345, 27);
            txbDireccion.TabIndex = 14;
            // 
            // txbCodigoPostal
            // 
            txbCodigoPostal.Location = new Point(531, 178);
            txbCodigoPostal.Name = "txbCodigoPostal";
            txbCodigoPostal.Size = new Size(120, 27);
            txbCodigoPostal.TabIndex = 15;
            // 
            // txbTelefono
            // 
            txbTelefono.Location = new Point(492, 251);
            txbTelefono.Name = "txbTelefono";
            txbTelefono.Size = new Size(159, 27);
            txbTelefono.TabIndex = 16;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(474, 112);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(368, 27);
            txbEmail.TabIndex = 17;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(47, 264);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(300, 27);
            dtpFechaNacimiento.TabIndex = 18;
            // 
            // FormNuevoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(896, 450);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txbEmail);
            Controls.Add(txbTelefono);
            Controls.Add(txbCodigoPostal);
            Controls.Add(txbDireccion);
            Controls.Add(txbDni);
            Controls.Add(txbApellidos);
            Controls.Add(txbNombre);
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
            Name = "FormNuevoCliente";
            Text = "FormNuevoCliente";
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
    }
}