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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerServiciosEstancia));
            Volver = new Button();
            lblParcelaFecha = new Label();
            dgvVerServiciosEstancia = new DataGridView();
            pnlTop = new Panel();
            lblFechaHora = new Label();
            btnMinimizar = new Button();
            lblTitulo = new Label();
            btnSalir = new Button();
            tmFechaHora = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvVerServiciosEstancia).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // Volver
            // 
            Volver.BackColor = Color.Peru;
            Volver.FlatAppearance.BorderSize = 0;
            Volver.FlatStyle = FlatStyle.Flat;
            Volver.Font = new Font("Segoe UI", 12F);
            Volver.ForeColor = Color.Moccasin;
            Volver.Location = new Point(305, 318);
            Volver.Margin = new Padding(3, 2, 3, 2);
            Volver.Name = "Volver";
            Volver.Size = new Size(88, 32);
            Volver.TabIndex = 2;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // lblParcelaFecha
            // 
            lblParcelaFecha.AutoSize = true;
            lblParcelaFecha.Font = new Font("Segoe UI", 12F);
            lblParcelaFecha.Location = new Point(10, 35);
            lblParcelaFecha.Name = "lblParcelaFecha";
            lblParcelaFecha.Size = new Size(332, 21);
            lblParcelaFecha.TabIndex = 4;
            lblParcelaFecha.Text = "Servicios en PARCELA del CHEKIN al CHEKOUT";
            // 
            // dgvVerServiciosEstancia
            // 
            dgvVerServiciosEstancia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVerServiciosEstancia.Location = new Point(10, 68);
            dgvVerServiciosEstancia.Margin = new Padding(3, 2, 3, 2);
            dgvVerServiciosEstancia.Name = "dgvVerServiciosEstancia";
            dgvVerServiciosEstancia.RowHeadersWidth = 51;
            dgvVerServiciosEstancia.Size = new Size(685, 236);
            dgvVerServiciosEstancia.TabIndex = 5;
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
            pnlTop.Size = new Size(700, 27);
            pnlTop.TabIndex = 9;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Segoe UI", 8F);
            lblFechaHora.Location = new Point(289, 7);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(0, 13);
            lblFechaHora.TabIndex = 10;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(626, 1);
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
            lblTitulo.Size = new Size(127, 15);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Servicios de la estancia";
            lblTitulo.MouseDown += pnlTop_MouseDown;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(660, 1);
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
            // FormVerServiciosEstancia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(700, 364);
            Controls.Add(pnlTop);
            Controls.Add(dgvVerServiciosEstancia);
            Controls.Add(lblParcelaFecha);
            Controls.Add(Volver);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormVerServiciosEstancia";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormVerServiciosEstancia";
            ((System.ComponentModel.ISupportInitialize)dgvVerServiciosEstancia).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Volver;
        private Label lblParcelaFecha;
        private DataGridView dgvVerServiciosEstancia;
        private Panel pnlTop;
        private Button btnMinimizar;
        private Label lblTitulo;
        private Button btnSalir;
        private Label lblFechaHora;
        private System.Windows.Forms.Timer tmFechaHora;
    }
}