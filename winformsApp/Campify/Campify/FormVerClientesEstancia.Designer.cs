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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerClientesEstancia));
            dgvVerClientesEstancia = new DataGridView();
            Volver = new Button();
            lblParcelaFecha = new Label();
            pnlTop = new Panel();
            btnMinimizar = new Button();
            lblTitulo = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVerClientesEstancia).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // dgvVerClientesEstancia
            // 
            dgvVerClientesEstancia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVerClientesEstancia.Location = new Point(12, 93);
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
            Volver.Location = new Point(349, 425);
            Volver.Name = "Volver";
            Volver.Size = new Size(101, 42);
            Volver.TabIndex = 1;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // lblParcelaFecha
            // 
            lblParcelaFecha.AutoSize = true;
            lblParcelaFecha.Font = new Font("Segoe UI", 12F);
            lblParcelaFecha.Location = new Point(12, 47);
            lblParcelaFecha.Name = "lblParcelaFecha";
            lblParcelaFecha.Size = new Size(407, 28);
            lblParcelaFecha.TabIndex = 3;
            lblParcelaFecha.Text = "Clientes en PARCELA del CHEKIN al CHEKOUT";
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
            pnlTop.Size = new Size(800, 36);
            pnlTop.TabIndex = 9;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(715, 1);
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
            lblTitulo.Size = new Size(225, 20);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Campify - Clientes de la estancia";
            lblTitulo.MouseDown += pnlTop_MouseDown;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(753, 1);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(44, 32);
            btnSalir.TabIndex = 7;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormVerClientesEstancia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(800, 486);
            Controls.Add(pnlTop);
            Controls.Add(lblParcelaFecha);
            Controls.Add(Volver);
            Controls.Add(dgvVerClientesEstancia);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVerClientesEstancia";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormVerClientesEstancia";
            ((System.ComponentModel.ISupportInitialize)dgvVerClientesEstancia).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVerClientesEstancia;
        private Button Volver;
        private Label lblParcelaFecha;
        private Panel pnlTop;
        private Button btnMinimizar;
        private Label lblTitulo;
        private Button btnSalir;
    }
}