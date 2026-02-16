namespace Controles
{
    partial class ucHistorial
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
            lblCheckout = new Label();
            lblCheckin = new Label();
            lblId = new Label();
            SuspendLayout();
            // 
            // lblCheckout
            // 
            lblCheckout.AutoSize = true;
            lblCheckout.Location = new Point(236, 22);
            lblCheckout.Name = "lblCheckout";
            lblCheckout.Size = new Size(70, 20);
            lblCheckout.TabIndex = 7;
            lblCheckout.Text = "Checkout";
            // 
            // lblCheckin
            // 
            lblCheckin.AutoSize = true;
            lblCheckin.Location = new Point(110, 22);
            lblCheckin.Name = "lblCheckin";
            lblCheckin.Size = new Size(64, 20);
            lblCheckin.TabIndex = 6;
            lblCheckin.Text = "Checkin ";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(18, 22);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 4;
            lblId.Text = "Id";
            // 
            // ucHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCheckout);
            Controls.Add(lblCheckin);
            Controls.Add(lblId);
            Name = "ucHistorial";
            Size = new Size(410, 65);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCheckout;
        private Label lblCheckin;
        private Label lblId;
    }
}
