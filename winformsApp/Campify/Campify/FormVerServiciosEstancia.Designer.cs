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
            btnMinimizar = new Button();
            lblTitulo = new Label();
            btnSalir = new Button();
            lblFechaHora = new Label();
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
            Volver.Location = new Point(349, 424);
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
            lblParcelaFecha.Location = new Point(12, 47);
            lblParcelaFecha.Name = "lblParcelaFecha";
            lblParcelaFecha.Size = new Size(416, 28);
            lblParcelaFecha.TabIndex = 4;
            lblParcelaFecha.Text = "Servicios en PARCELA del CHEKIN al CHEKOUT";
            // 
            // dgvVerServiciosEstancia
            // 
            dgvVerServiciosEstancia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVerServiciosEstancia.Location = new Point(12, 91);
            dgvVerServiciosEstancia.Name = "dgvVerServiciosEstancia";
            dgvVerServiciosEstancia.RowHeadersWidth = 51;
            dgvVerServiciosEstancia.Size = new Size(783, 314);
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
            btnMinimizar.Location = new Point(716, 1);
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
            lblTitulo.Size = new Size(162, 20);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Servicios de la estancia";
            lblTitulo.MouseDown += pnlTop_MouseDown;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(754, 1);
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
            lblFechaHora.Location = new Point(330, 9);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(0, 19);
            lblFechaHora.TabIndex = 10;
            // 
            // tmFechaHora
            // 
            tmFechaHora.Enabled = true;
            tmFechaHora.Interval = 1000;
            tmFechaHora.Tick += tmFechaHora_Tick;
            // 
            // FormVerServiciosEstancia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(800, 486);
            Controls.Add(pnlTop);
            Controls.Add(dgvVerServiciosEstancia);
            Controls.Add(lblParcelaFecha);
            Controls.Add(Volver);
            FormBorderStyle = FormBorderStyle.None;
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