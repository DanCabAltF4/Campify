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
            btnVolver = new Button();
            btnGuardar = new Button();
            lblId = new Label();
            lbltxtId = new Label();
            txbNombre = new TextBox();
            lbltxtNombre = new Label();
            lbltxtPrecio = new Label();
            nupPrecio = new NumericUpDown();
            txbApellidos = new TextBox();
            lbltxtDescripcion = new Label();
            ((System.ComponentModel.ISupportInitialize)nupPrecio).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Peru;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 12F);
            btnVolver.ForeColor = Color.Moccasin;
            btnVolver.Location = new Point(198, 365);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(102, 38);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Peru;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.ForeColor = Color.Moccasin;
            btnGuardar.Location = new Point(411, 365);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 38);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(107, 49);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 20);
            lblId.TabIndex = 29;
            // 
            // lbltxtId
            // 
            lbltxtId.AutoSize = true;
            lbltxtId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtId.Location = new Point(72, 49);
            lbltxtId.Name = "lbltxtId";
            lbltxtId.Size = new Size(32, 20);
            lbltxtId.TabIndex = 28;
            lbltxtId.Text = "Nº:";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(149, 107);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(290, 27);
            txbNombre.TabIndex = 31;
            // 
            // lbltxtNombre
            // 
            lbltxtNombre.AutoSize = true;
            lbltxtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtNombre.Location = new Point(72, 110);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(71, 20);
            lbltxtNombre.TabIndex = 30;
            lbltxtNombre.Text = "Nombre:";
            // 
            // lbltxtPrecio
            // 
            lbltxtPrecio.AutoSize = true;
            lbltxtPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtPrecio.Location = new Point(473, 110);
            lbltxtPrecio.Name = "lbltxtPrecio";
            lbltxtPrecio.Size = new Size(56, 20);
            lbltxtPrecio.TabIndex = 32;
            lbltxtPrecio.Text = "Precio:";
            // 
            // nupPrecio
            // 
            nupPrecio.DecimalPlaces = 2;
            nupPrecio.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nupPrecio.Location = new Point(535, 107);
            nupPrecio.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nupPrecio.Name = "nupPrecio";
            nupPrecio.Size = new Size(89, 27);
            nupPrecio.TabIndex = 33;
            // 
            // txbApellidos
            // 
            txbApellidos.Location = new Point(72, 212);
            txbApellidos.Multiline = true;
            txbApellidos.Name = "txbApellidos";
            txbApellidos.Size = new Size(552, 115);
            txbApellidos.TabIndex = 35;
            // 
            // lbltxtDescripcion
            // 
            lbltxtDescripcion.AutoSize = true;
            lbltxtDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtDescripcion.Location = new Point(72, 172);
            lbltxtDescripcion.Name = "lbltxtDescripcion";
            lbltxtDescripcion.Size = new Size(94, 20);
            lbltxtDescripcion.TabIndex = 34;
            lbltxtDescripcion.Text = "Descripción:";
            // 
            // FormDatosServicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(720, 440);
            Controls.Add(txbApellidos);
            Controls.Add(lbltxtDescripcion);
            Controls.Add(nupPrecio);
            Controls.Add(lbltxtPrecio);
            Controls.Add(txbNombre);
            Controls.Add(lbltxtNombre);
            Controls.Add(lblId);
            Controls.Add(lbltxtId);
            Controls.Add(btnGuardar);
            Controls.Add(btnVolver);
            Name = "FormDatosServicio";
            Text = "FormDatosServicio";
            ((System.ComponentModel.ISupportInitialize)nupPrecio).EndInit();
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
        private TextBox txbApellidos;
        private Label lbltxtDescripcion;
    }
}