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
            btnGuardar = new Button();
            dvgListaServicios = new DataGridView();
            dgvServiciosEstancia = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgListaServicios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServiciosEstancia).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Peru;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.ForeColor = Color.FromArgb(255, 222, 171);
            btnGuardar.Location = new Point(346, 474);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(98, 48);
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
            dvgListaServicios.Location = new Point(12, 12);
            dvgListaServicios.Name = "dvgListaServicios";
            dvgListaServicios.ReadOnly = true;
            dvgListaServicios.RowHeadersWidth = 51;
            dvgListaServicios.Size = new Size(776, 219);
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
            dgvServiciosEstancia.Location = new Point(12, 255);
            dgvServiciosEstancia.Name = "dgvServiciosEstancia";
            dgvServiciosEstancia.ReadOnly = true;
            dgvServiciosEstancia.RowHeadersWidth = 51;
            dgvServiciosEstancia.Size = new Size(776, 188);
            dgvServiciosEstancia.TabIndex = 2;
            dgvServiciosEstancia.CellDoubleClick += dgvServiciosEstancia_CellDoubleClick;
            // 
            // FormEstanciaServicios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(800, 554);
            Controls.Add(dgvServiciosEstancia);
            Controls.Add(dvgListaServicios);
            Controls.Add(btnGuardar);
            Name = "FormEstanciaServicios";
            Text = "FormEstanciaServicios";
            Load += FormEstanciaServicios_Load;
            ((System.ComponentModel.ISupportInitialize)dvgListaServicios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServiciosEstancia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardar;
        private DataGridView dvgListaServicios;
        private DataGridView dgvServiciosEstancia;
    }
}