namespace Forms
{
    partial class FormEstanciaClientes
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
            btnGuardar = new Button();
            dgvListaClientes = new DataGridView();
            dgvClientesEstancia = new DataGridView();
            btnNuevoCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientesEstancia).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Peru;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.ForeColor = Color.FromArgb(255, 222, 171);
            btnGuardar.Location = new Point(627, 447);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 49);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvListaClientes
            // 
            dgvListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaClientes.Location = new Point(12, 12);
            dgvListaClientes.Name = "dgvListaClientes";
            dgvListaClientes.RowHeadersWidth = 51;
            dgvListaClientes.Size = new Size(776, 202);
            dgvListaClientes.TabIndex = 1;
            // 
            // dgvClientesEstancia
            // 
            dgvClientesEstancia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientesEstancia.Location = new Point(12, 237);
            dgvClientesEstancia.Name = "dgvClientesEstancia";
            dgvClientesEstancia.RowHeadersWidth = 51;
            dgvClientesEstancia.Size = new Size(776, 188);
            dgvClientesEstancia.TabIndex = 2;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.YellowGreen;
            btnNuevoCliente.FlatAppearance.BorderSize = 0;
            btnNuevoCliente.FlatStyle = FlatStyle.Flat;
            btnNuevoCliente.Font = new Font("Segoe UI", 12F);
            btnNuevoCliente.Location = new Point(93, 453);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(147, 36);
            btnNuevoCliente.TabIndex = 3;
            btnNuevoCliente.Text = "Nuevo cliente";
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // FormEstanciaClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(800, 523);
            Controls.Add(btnNuevoCliente);
            Controls.Add(dgvClientesEstancia);
            Controls.Add(dgvListaClientes);
            Controls.Add(btnGuardar);
            Name = "FormEstanciaClientes";
            Text = "FormEstanciaClientes";
            ((System.ComponentModel.ISupportInitialize)dgvListaClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientesEstancia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardar;
        private DataGridView dgvListaClientes;
        private DataGridView dgvClientesEstancia;
        private Button btnNuevoCliente;
    }
}