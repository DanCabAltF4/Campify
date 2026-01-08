namespace Forms
{
    partial class FormVerServiciosEstancia
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
            Volver = new Button();
            lblParcelaFecha = new Label();
            dgvVerServiciosEstancia = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVerServiciosEstancia).BeginInit();
            SuspendLayout();
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
            Volver.TabIndex = 2;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // lblParcelaFecha
            // 
            lblParcelaFecha.AutoSize = true;
            lblParcelaFecha.Font = new Font("Segoe UI", 12F);
            lblParcelaFecha.Location = new Point(12, 19);
            lblParcelaFecha.Name = "lblParcelaFecha";
            lblParcelaFecha.Size = new Size(407, 28);
            lblParcelaFecha.TabIndex = 4;
            lblParcelaFecha.Text = "Clientes en PARCELA del CHEKIN al CHEKOUT";
            // 
            // dgvVerServiciosEstancia
            // 
            dgvVerServiciosEstancia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVerServiciosEstancia.Location = new Point(12, 63);
            dgvVerServiciosEstancia.Name = "dgvVerServiciosEstancia";
            dgvVerServiciosEstancia.RowHeadersWidth = 51;
            dgvVerServiciosEstancia.Size = new Size(783, 314);
            dgvVerServiciosEstancia.TabIndex = 5;
            // 
            // FormVerServiciosEstancia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVerServiciosEstancia);
            Controls.Add(lblParcelaFecha);
            Controls.Add(Volver);
            Name = "FormVerServiciosEstancia";
            Text = "FormVerServiciosEstancia";
            ((System.ComponentModel.ISupportInitialize)dgvVerServiciosEstancia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Volver;
        private Label lblParcelaFecha;
        private DataGridView dgvVerServiciosEstancia;
    }
}