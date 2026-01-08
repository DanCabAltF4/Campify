namespace Controles
{
    partial class ucEstanciasLista
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
            lblParcela = new Label();
            lblCheckin = new Label();
            lblCheckout = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(31, 23);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            lblId.Click += lblId_Click;
            // 
            // lblParcela
            // 
            lblParcela.AutoSize = true;
            lblParcela.Location = new Point(108, 23);
            lblParcela.Name = "lblParcela";
            lblParcela.Size = new Size(56, 20);
            lblParcela.TabIndex = 1;
            lblParcela.Text = "Parcela";
            lblParcela.Click += lblParcela_Click;
            // 
            // lblCheckin
            // 
            lblCheckin.AutoSize = true;
            lblCheckin.Location = new Point(235, 23);
            lblCheckin.Name = "lblCheckin";
            lblCheckin.Size = new Size(64, 20);
            lblCheckin.TabIndex = 2;
            lblCheckin.Text = "Checkin ";
            lblCheckin.Click += lblCheckin_Click;
            // 
            // lblCheckout
            // 
            lblCheckout.AutoSize = true;
            lblCheckout.Location = new Point(361, 23);
            lblCheckout.Name = "lblCheckout";
            lblCheckout.Size = new Size(70, 20);
            lblCheckout.TabIndex = 3;
            lblCheckout.Text = "Checkout";
            lblCheckout.Click += lblCheckout_Click;
            // 
            // ucEstanciasLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCheckout);
            Controls.Add(lblCheckin);
            Controls.Add(lblParcela);
            Controls.Add(lblId);
            Name = "ucEstanciasLista";
            Size = new Size(460, 65);
            Click += ucEstanciasLista_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblParcela;
        private Label lblCheckin;
        private Label lblCheckout;
    }
}
