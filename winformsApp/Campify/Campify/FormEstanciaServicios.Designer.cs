namespace Forms
{
    partial class FormEstanciaServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstanciaServicios));
            btnGuardar = new Button();
            dvgListaServicios = new DataGridView();
            dgvServiciosEstancia = new DataGridView();
            lblDisponibles = new Label();
            lblActuales = new Label();
            btnVolver = new Button();
            pnlTop = new Panel();
            lblFechaHora = new Label();
            btnMinimizar = new Button();
            lblTitulo = new Label();
            btnSalir = new Button();
            tmFechaHora = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dvgListaServicios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServiciosEstancia).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Peru;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.ForeColor = Color.FromArgb(255, 222, 171);
            btnGuardar.Location = new Point(403, 455);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 27);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dvgListaServicios
            // 
            dvgListaServicios.AllowUserToAddRows = false;
            dvgListaServicios.AllowUserToDeleteRows = false;
            dvgListaServicios.AllowUserToResizeRows = false;
            dvgListaServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgListaServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgListaServicios.Location = new Point(9, 70);
            dvgListaServicios.Margin = new Padding(3, 2, 3, 2);
            dvgListaServicios.Name = "dvgListaServicios";
            dvgListaServicios.ReadOnly = true;
            dvgListaServicios.RowHeadersWidth = 51;
            dvgListaServicios.Size = new Size(679, 164);
            dvgListaServicios.TabIndex = 1;
            dvgListaServicios.CellDoubleClick += dvgListaServicios_CellDoubleClick;
            // 
            // dgvServiciosEstancia
            // 
            dgvServiciosEstancia.AllowUserToAddRows = false;
            dgvServiciosEstancia.AllowUserToDeleteRows = false;
            dgvServiciosEstancia.AllowUserToResizeRows = false;
            dgvServiciosEstancia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServiciosEstancia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiciosEstancia.Location = new Point(9, 292);
            dgvServiciosEstancia.Margin = new Padding(3, 2, 3, 2);
            dgvServiciosEstancia.Name = "dgvServiciosEstancia";
            dgvServiciosEstancia.ReadOnly = true;
            dgvServiciosEstancia.RowHeadersWidth = 51;
            dgvServiciosEstancia.Size = new Size(679, 141);
            dgvServiciosEstancia.TabIndex = 2;
            dgvServiciosEstancia.CellDoubleClick += dgvServiciosEstancia_CellDoubleClick;
            // 
            // lblDisponibles
            // 
            lblDisponibles.AutoSize = true;
            lblDisponibles.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDisponibles.Location = new Point(9, 44);
            lblDisponibles.Name = "lblDisponibles";
            lblDisponibles.Size = new Size(154, 19);
            lblDisponibles.TabIndex = 3;
            lblDisponibles.Text = "Servicios disponibles:";
            // 
            // lblActuales
            // 
            lblActuales.AutoSize = true;
            lblActuales.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblActuales.Location = new Point(9, 262);
            lblActuales.Name = "lblActuales";
            lblActuales.Size = new Size(132, 19);
            lblActuales.TabIndex = 4;
            lblActuales.Text = "Servicios actuales:";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Peru;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 12F);
            btnVolver.ForeColor = Color.FromArgb(255, 222, 171);
            btnVolver.Location = new Point(189, 455);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 27);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
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
            lblFechaHora.Location = new Point(289, 9);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(0, 13);
            lblFechaHora.TabIndex = 10;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(629, 2);
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
            btnSalir.Location = new Point(662, 2);
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
            // FormEstanciaServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(700, 500);
            Controls.Add(pnlTop);
            Controls.Add(btnVolver);
            Controls.Add(lblActuales);
            Controls.Add(lblDisponibles);
            Controls.Add(dgvServiciosEstancia);
            Controls.Add(dvgListaServicios);
            Controls.Add(btnGuardar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormEstanciaServicios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormEstanciaServicios";
            Load += FormEstanciaServicios_Load;
            ((System.ComponentModel.ISupportInitialize)dvgListaServicios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServiciosEstancia).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private DataGridView dvgListaServicios;
        private DataGridView dgvServiciosEstancia;
        private Label lblDisponibles;
        private Label lblActuales;
        private Button btnVolver;
        private Panel pnlTop;
        private Button btnMinimizar;
        private Label lblTitulo;
        private Button btnSalir;
        private Label lblFechaHora;
        private System.Windows.Forms.Timer tmFechaHora;
    }
}