namespace Controles
{
    partial class ucParcela
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new Label();
            lblTipo = new Label();
            lblEstado = new Label();
            lblPrecioNoche = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(29, 17);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(96, 17);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(198, 17);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Estado";
            // 
            // lblPrecioNoche
            // 
            lblPrecioNoche.AutoSize = true;
            lblPrecioNoche.Location = new Point(296, 17);
            lblPrecioNoche.Name = "lblPrecioNoche";
            lblPrecioNoche.Size = new Size(78, 15);
            lblPrecioNoche.TabIndex = 3;
            lblPrecioNoche.Text = "Precio/noche";
            // 
            // ucParcela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPrecioNoche);
            Controls.Add(lblEstado);
            Controls.Add(lblTipo);
            Controls.Add(lblId);
            Margin = new Padding(7, 4, 7, 4);
            Name = "ucParcela";
            Size = new Size(415, 50);
            DoubleClick += ucParcela_DoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblTipo;
        private Label lblEstado;
        private Label lblPrecioNoche;
    }
}
