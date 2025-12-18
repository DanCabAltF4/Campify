namespace Forms
{
    partial class FormsNuevaEstancia
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
            button1 = new Button();
            btnClientes = new Button();
            btnServicios = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(176, 372);
            button1.Name = "button1";
            button1.Size = new Size(108, 66);
            button1.TabIndex = 0;
            button1.Text = "Guardar reserva";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 10F);
            btnClientes.Location = new Point(52, 313);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(94, 29);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnServicios
            // 
            btnServicios.BackColor = Color.Green;
            btnServicios.FlatAppearance.BorderSize = 0;
            btnServicios.FlatStyle = FlatStyle.Flat;
            btnServicios.Font = new Font("Segoe UI", 10F);
            btnServicios.Location = new Point(336, 313);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(94, 29);
            btnServicios.TabIndex = 2;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = false;
            // 
            // FormsNuevaEstancia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(486, 450);
            Controls.Add(btnServicios);
            Controls.Add(btnClientes);
            Controls.Add(button1);
            Name = "FormsNuevaEstancia";
            Text = "Registrar nueva estancia";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnClientes;
        private Button btnServicios;
    }
}