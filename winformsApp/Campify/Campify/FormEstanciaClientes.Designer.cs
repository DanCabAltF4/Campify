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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstanciaClientes));
            btnGuardar = new Button();
            dgvListaClientes = new DataGridView();
            dgvClientesEstancia = new DataGridView();
            btnNuevoCliente = new Button();
            btnVolver = new Button();
            lblActuales = new Label();
            lblDisponibles = new Label();
            pnlTop = new Panel();
            lblFechaHora = new Label();
            btnMinimizar = new Button();
            lblTitulo = new Label();
            btnSalir = new Button();
            tmFechaHora = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvListaClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientesEstancia).BeginInit();
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
            btnGuardar.Location = new Point(657, 607);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 36);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvListaClientes
            // 
            dgvListaClientes.AllowUserToAddRows = false;
            dgvListaClientes.AllowUserToDeleteRows = false;
            dgvListaClientes.AllowUserToResizeRows = false;
            dgvListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaClientes.Location = new Point(10, 94);
            dgvListaClientes.Name = "dgvListaClientes";
            dgvListaClientes.ReadOnly = true;
            dgvListaClientes.RowHeadersWidth = 51;
            dgvListaClientes.Size = new Size(776, 219);
            dgvListaClientes.TabIndex = 1;
            dgvListaClientes.CellDoubleClick += dgvListaClientes_CellDoubleClick;
            // 
            // dgvClientesEstancia
            // 
            dgvClientesEstancia.AllowUserToAddRows = false;
            dgvClientesEstancia.AllowUserToDeleteRows = false;
            dgvClientesEstancia.AllowUserToResizeRows = false;
            dgvClientesEstancia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientesEstancia.Location = new Point(10, 390);
            dgvClientesEstancia.Name = "dgvClientesEstancia";
            dgvClientesEstancia.ReadOnly = true;
            dgvClientesEstancia.RowHeadersWidth = 51;
            dgvClientesEstancia.Size = new Size(776, 188);
            dgvClientesEstancia.TabIndex = 2;
            dgvClientesEstancia.CellDoubleClick += dgvClientesEstancia_CellDoubleClick;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.YellowGreen;
            btnNuevoCliente.FlatAppearance.BorderSize = 0;
            btnNuevoCliente.FlatStyle = FlatStyle.Flat;
            btnNuevoCliente.Font = new Font("Segoe UI", 12F);
            btnNuevoCliente.Location = new Point(290, 607);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(147, 36);
            btnNuevoCliente.TabIndex = 3;
            btnNuevoCliente.Text = "Nuevo cliente";
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Peru;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 12F);
            btnVolver.ForeColor = Color.FromArgb(255, 222, 171);
            btnVolver.Location = new Point(530, 607);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 36);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblActuales
            // 
            lblActuales.AutoSize = true;
            lblActuales.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblActuales.Location = new Point(10, 350);
            lblActuales.Name = "lblActuales";
            lblActuales.Size = new Size(147, 23);
            lblActuales.TabIndex = 5;
            lblActuales.Text = "Clientes actuales:";
            // 
            // lblDisponibles
            // 
            lblDisponibles.AutoSize = true;
            lblDisponibles.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDisponibles.Location = new Point(10, 58);
            lblDisponibles.Name = "lblDisponibles";
            lblDisponibles.Size = new Size(149, 23);
            lblDisponibles.TabIndex = 6;
            lblDisponibles.Text = "Listas de clientes:";
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
            pnlTop.TabIndex = 10;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Segoe UI", 8F);
            lblFechaHora.Location = new Point(330, 12);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(0, 19);
            lblFechaHora.TabIndex = 11;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(719, 3);
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
            lblTitulo.Size = new Size(156, 20);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Clientes de la estancia";
            lblTitulo.MouseDown += pnlTop_MouseDown;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(757, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(44, 32);
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
            // FormEstanciaClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(800, 667);
            Controls.Add(pnlTop);
            Controls.Add(lblDisponibles);
            Controls.Add(lblActuales);
            Controls.Add(btnVolver);
            Controls.Add(btnNuevoCliente);
            Controls.Add(dgvClientesEstancia);
            Controls.Add(dgvListaClientes);
            Controls.Add(btnGuardar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEstanciaClientes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormEstanciaClientes";
            Load += FormEstanciaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientesEstancia).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private DataGridView dgvListaClientes;
        private DataGridView dgvClientesEstancia;
        private Button btnNuevoCliente;
        private Button btnVolver;
        private Label lblActuales;
        private Label lblDisponibles;
        private Panel pnlTop;
        private Button btnMinimizar;
        private Label lblTitulo;
        private Button btnSalir;
        private Label lblFechaHora;
        private System.Windows.Forms.Timer tmFechaHora;
    }
}