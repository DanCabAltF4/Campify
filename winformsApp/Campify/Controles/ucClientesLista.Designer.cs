namespace Controles
{
    partial class ucClientesLista
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
            lblApellidos = new Label();
            lblNombre = new Label();
            lblFechaNac = new Label();
            SuspendLayout();
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(118, 22);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(72, 20);
            lblApellidos.TabIndex = 6;
            lblApellidos.Text = "Apellidos";
            lblApellidos.Click += lblApellidos_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(19, 22);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            lblNombre.Click += lblNombre_Click;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(330, 22);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(47, 20);
            lblFechaNac.TabIndex = 7;
            lblFechaNac.Text = "Fecha";
            lblFechaNac.Click += lblFechaNac_Click;
            // 
            // ucClientesLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblFechaNac);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombre);
            Name = "ucClientesLista";
            Size = new Size(480, 65);
            Click += ucClientesLista_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblApellidos;
        private Label lblNombre;
        private Label lblFechaNac;
    }
}
