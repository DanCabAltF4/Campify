namespace Controles
{
    partial class ucServiciosLista
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
            lbId = new Label();
            lbNombre = new Label();
            lbPrecio = new Label();
            SuspendLayout();
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(29, 21);
            lbId.Name = "lbId";
            lbId.Size = new Size(22, 20);
            lbId.TabIndex = 0;
            lbId.Text = "Id";
            lbId.Click += lbId_Click;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(106, 21);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(64, 20);
            lbNombre.TabIndex = 1;
            lbNombre.Text = "Nombre";
            lbNombre.Click += lbNombre_Click;
            // 
            // lbPrecio
            // 
            lbPrecio.AutoSize = true;
            lbPrecio.Location = new Point(343, 21);
            lbPrecio.Name = "lbPrecio";
            lbPrecio.Size = new Size(50, 20);
            lbPrecio.TabIndex = 2;
            lbPrecio.Text = "Precio";
            lbPrecio.Click += lbPrecio_Click;
            // 
            // ucServiciosLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbPrecio);
            Controls.Add(lbNombre);
            Controls.Add(lbId);
            Name = "ucServiciosLista";
            Size = new Size(460, 65);
            Click += ucServiciosLista_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbId;
        private Label lbNombre;
        private Label lbPrecio;
    }
}
