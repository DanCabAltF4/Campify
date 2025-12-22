namespace Controles
{
    partial class ucEmpleadosLista
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new Label();
            lblNombre = new Label();
            lblApellidos = new Label();
            lblPuesto = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 22);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            lblId.Click += lblId_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(203, 22);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            lblNombre.Click += lblNombre_Click;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(302, 22);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(72, 20);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos";
            lblApellidos.Click += lblApellidos_Click;
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.Location = new Point(59, 22);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(53, 20);
            lblPuesto.TabIndex = 3;
            lblPuesto.Text = "Puesto";
            lblPuesto.Click += lblPuesto_Click;
            // 
            // ucEmpleadosLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPuesto);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Name = "ucEmpleadosLista";
            Size = new Size(460, 65);
            Click += ucEmpleadosLista_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNombre;
        private Label lblApellidos;
        private Label lblPuesto;
    }
}
