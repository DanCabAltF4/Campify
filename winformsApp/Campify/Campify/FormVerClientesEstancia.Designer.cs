namespace Forms
{
    partial class FormVerClientesEstancia
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
            dgvVerClientesEstancia = new DataGridView();
            Volver = new Button();
            lblClientes = new Label();
            lblParcelaFecha = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVerClientesEstancia).BeginInit();
            SuspendLayout();
            // 
            // dgvVerClientesEstancia
            // 
            dgvVerClientesEstancia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVerClientesEstancia.Location = new Point(12, 64);
            dgvVerClientesEstancia.Name = "dgvVerClientesEstancia";
            dgvVerClientesEstancia.RowHeadersWidth = 51;
            dgvVerClientesEstancia.Size = new Size(783, 314);
            dgvVerClientesEstancia.TabIndex = 0;
            // 
            // Volver
            // 
            Volver.BackColor = Color.Peru;
            Volver.FlatAppearance.BorderSize = 0;
            Volver.FlatStyle = FlatStyle.Flat;
            Volver.Font = new Font("Segoe UI", 12F);
            Volver.ForeColor = Color.Moccasin;
            Volver.Location = new Point(349, 396);
            Volver.Name = "Volver";
            Volver.Size = new Size(101, 42);
            Volver.TabIndex = 1;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Segoe UI", 12F);
            lblClientes.Location = new Point(12, 19);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(174, 28);
            lblClientes.TabIndex = 2;
            lblClientes.Text = "Clientes en parcela";
            // 
            // lblParcelaFecha
            // 
            lblParcelaFecha.AutoSize = true;
            lblParcelaFecha.Font = new Font("Segoe UI", 12F);
            lblParcelaFecha.Location = new Point(192, 19);
            lblParcelaFecha.Name = "lblParcelaFecha";
            lblParcelaFecha.Size = new Size(65, 28);
            lblParcelaFecha.TabIndex = 3;
            lblParcelaFecha.Text = "label1";
            // 
            // FormVerClientesEstancia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(800, 450);
            Controls.Add(lblParcelaFecha);
            Controls.Add(lblClientes);
            Controls.Add(Volver);
            Controls.Add(dgvVerClientesEstancia);
            Name = "FormVerClientesEstancia";
            Text = "FormVerClientesEstancia";
            ((System.ComponentModel.ISupportInitialize)dgvVerClientesEstancia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVerClientesEstancia;
        private Button Volver;
        private Label lblClientes;
        private Label lblParcelaFecha;
    }
}