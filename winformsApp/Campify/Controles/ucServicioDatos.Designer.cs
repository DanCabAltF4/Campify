namespace Controles
{
    partial class ucServicioDatos
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
            lbltxtId = new Label();
            lbltxtNombre = new Label();
            lbltxtDescripcion = new Label();
            lbltxtPrecio = new Label();
            lblId = new Label();
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            SuspendLayout();
            // 
            // lbltxtId
            // 
            lbltxtId.AutoSize = true;
            lbltxtId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtId.Location = new Point(48, 47);
            lbltxtId.Name = "lbltxtId";
            lbltxtId.Size = new Size(75, 20);
            lbltxtId.TabIndex = 0;
            lbltxtId.Text = "Numero: ";
            // 
            // lbltxtNombre
            // 
            lbltxtNombre.AutoSize = true;
            lbltxtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtNombre.Location = new Point(48, 112);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(71, 20);
            lbltxtNombre.TabIndex = 1;
            lbltxtNombre.Text = "Nombre:";
            // 
            // lbltxtDescripcion
            // 
            lbltxtDescripcion.AutoSize = true;
            lbltxtDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtDescripcion.Location = new Point(48, 183);
            lbltxtDescripcion.Name = "lbltxtDescripcion";
            lbltxtDescripcion.Size = new Size(94, 20);
            lbltxtDescripcion.TabIndex = 2;
            lbltxtDescripcion.Text = "Descripcion:";
            // 
            // lbltxtPrecio
            // 
            lbltxtPrecio.AutoSize = true;
            lbltxtPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltxtPrecio.Location = new Point(213, 47);
            lbltxtPrecio.Name = "lbltxtPrecio";
            lbltxtPrecio.Size = new Size(56, 20);
            lbltxtPrecio.TabIndex = 3;
            lbltxtPrecio.Text = "Precio:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(129, 47);
            lblId.Name = "lblId";
            lblId.Size = new Size(50, 20);
            lblId.TabIndex = 4;
            lblId.Text = "label1";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(125, 112);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(50, 20);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "label2";
            // 
            // lblDescripcion
            // 
            lblDescripcion.Location = new Point(48, 225);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(320, 175);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.Text = "label3";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(275, 47);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "label4";
            // 
            // ucServicioDatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPrecio);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Controls.Add(lbltxtPrecio);
            Controls.Add(lbltxtDescripcion);
            Controls.Add(lbltxtNombre);
            Controls.Add(lbltxtId);
            Name = "ucServicioDatos";
            Size = new Size(425, 437);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltxtId;
        private Label lbltxtNombre;
        private Label lbltxtDescripcion;
        private Label lbltxtPrecio;
        private Label lblId;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblPrecio;
    }
}
