namespace Forms
{
    partial class FormNuevaEstancia
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
            btnGuardarReserva = new Button();
            btnClientes = new Button();
            btnServicios = new Button();
            SuspendLayout();
            // 
            // btnGuardarReserva
            // 
            btnGuardarReserva.BackColor = Color.Peru;
            btnGuardarReserva.FlatAppearance.BorderSize = 0;
            btnGuardarReserva.FlatStyle = FlatStyle.Flat;
            btnGuardarReserva.Font = new Font("Segoe UI", 12F);
            btnGuardarReserva.ForeColor = Color.FromArgb(255, 222, 171);
            btnGuardarReserva.Location = new Point(176, 372);
            btnGuardarReserva.Name = "btnGuardarReserva";
            btnGuardarReserva.Size = new Size(108, 66);
            btnGuardarReserva.TabIndex = 0;
            btnGuardarReserva.Text = "Guardar reserva";
            btnGuardarReserva.UseVisualStyleBackColor = false;
            btnGuardarReserva.Click += btnGuardarReserva_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.YellowGreen;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 10F);
            btnClientes.Location = new Point(52, 313);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(94, 29);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnServicios
            // 
            btnServicios.BackColor = Color.YellowGreen;
            btnServicios.FlatAppearance.BorderSize = 0;
            btnServicios.FlatStyle = FlatStyle.Flat;
            btnServicios.Font = new Font("Segoe UI", 10F);
            btnServicios.Location = new Point(325, 313);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(94, 29);
            btnServicios.TabIndex = 2;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = false;
            btnServicios.Click += btnServicios_Click;
            // 
            // FormNuevaEstancia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(486, 450);
            Controls.Add(btnServicios);
            Controls.Add(btnClientes);
            Controls.Add(btnGuardarReserva);
            Name = "FormNuevaEstancia";
            Text = "Registrar nueva estancia";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardarReserva;
        private Button btnClientes;
        private Button btnServicios;
    }
}