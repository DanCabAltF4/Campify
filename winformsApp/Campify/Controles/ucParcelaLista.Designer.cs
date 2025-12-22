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
            lblId.Location = new Point(27, 23);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            lblId.Click += lblId_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(93, 23);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 20);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo";
            lblTipo.Click += lblTipo_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(222, 23);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(54, 20);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Estado";
            lblEstado.Click += lblEstado_Click;
            // 
            // lblPrecioNoche
            // 
            lblPrecioNoche.AutoSize = true;
            lblPrecioNoche.Location = new Point(375, 23);
            lblPrecioNoche.Name = "lblPrecioNoche";
            lblPrecioNoche.Size = new Size(50, 20);
            lblPrecioNoche.TabIndex = 3;
            lblPrecioNoche.Text = "Precio";
            lblPrecioNoche.Click += lblPrecioNoche_Click;
            // 
            // ucParcela
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPrecioNoche);
            Controls.Add(lblEstado);
            Controls.Add(lblTipo);
            Controls.Add(lblId);
            Margin = new Padding(8, 5, 8, 5);
            Name = "ucParcela";
            Size = new Size(460, 67);
            Click += ucParcela_Click;
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
