namespace Campify
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbLogo = new PictureBox();
            btnEmpleados = new Button();
            btnParcelas = new Button();
            pbAjustes = new PictureBox();
            btnEstanciaActual = new Button();
            btnHistorial = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnRegistrar = new Button();
            btnServicios = new Button();
            btnDatos = new Button();
            btMapa = new Button();
            btLista = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAjustes).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(-9, -7);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(81, 85);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // btnEmpleados
            // 
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEmpleados.ForeColor = Color.FromArgb(44, 79, 29);
            btnEmpleados.Location = new Point(374, 12);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(120, 44);
            btnEmpleados.TabIndex = 1;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnParcelas
            // 
            btnParcelas.FlatAppearance.BorderSize = 0;
            btnParcelas.FlatStyle = FlatStyle.Flat;
            btnParcelas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnParcelas.ForeColor = Color.FromArgb(44, 79, 29);
            btnParcelas.Location = new Point(106, 12);
            btnParcelas.Name = "btnParcelas";
            btnParcelas.Size = new Size(120, 44);
            btnParcelas.TabIndex = 2;
            btnParcelas.Text = "Parcelas";
            btnParcelas.UseVisualStyleBackColor = true;
            // 
            // pbAjustes
            // 
            pbAjustes.Image = (Image)resources.GetObject("pbAjustes.Image");
            pbAjustes.Location = new Point(740, 12);
            pbAjustes.Name = "pbAjustes";
            pbAjustes.Size = new Size(44, 42);
            pbAjustes.SizeMode = PictureBoxSizeMode.Zoom;
            pbAjustes.TabIndex = 3;
            pbAjustes.TabStop = false;
            // 
            // btnEstanciaActual
            // 
            btnEstanciaActual.BackColor = Color.FromArgb(255, 222, 171);
            btnEstanciaActual.FlatAppearance.BorderSize = 0;
            btnEstanciaActual.FlatStyle = FlatStyle.Flat;
            btnEstanciaActual.Font = new Font("Segoe UI", 12F);
            btnEstanciaActual.ForeColor = Color.FromArgb(95, 65, 0);
            btnEstanciaActual.Location = new Point(542, 84);
            btnEstanciaActual.Margin = new Padding(0);
            btnEstanciaActual.Name = "btnEstanciaActual";
            btnEstanciaActual.Size = new Size(134, 36);
            btnEstanciaActual.TabIndex = 5;
            btnEstanciaActual.Text = "Estancia actual";
            btnEstanciaActual.UseVisualStyleBackColor = false;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.FromArgb(255, 222, 171);
            btnHistorial.FlatAppearance.BorderSize = 0;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Segoe UI", 12F);
            btnHistorial.ForeColor = Color.FromArgb(95, 65, 0);
            btnHistorial.Location = new Point(676, 84);
            btnHistorial.Margin = new Padding(0);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(119, 36);
            btnHistorial.TabIndex = 6;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(427, 121);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(368, 288);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Peru;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 12F);
            btnRegistrar.ForeColor = Color.FromArgb(255, 222, 171);
            btnRegistrar.Location = new Point(427, 411);
            btnRegistrar.Margin = new Padding(0);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(368, 34);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnServicios
            // 
            btnServicios.FlatAppearance.BorderSize = 0;
            btnServicios.FlatStyle = FlatStyle.Flat;
            btnServicios.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnServicios.ForeColor = Color.FromArgb(44, 79, 29);
            btnServicios.Location = new Point(232, 12);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(120, 44);
            btnServicios.TabIndex = 10;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = true;
            // 
            // btnDatos
            // 
            btnDatos.BackColor = Color.FromArgb(255, 222, 171);
            btnDatos.FlatAppearance.BorderSize = 0;
            btnDatos.FlatStyle = FlatStyle.Flat;
            btnDatos.Font = new Font("Segoe UI", 12F);
            btnDatos.ForeColor = Color.FromArgb(95, 65, 0);
            btnDatos.Location = new Point(427, 84);
            btnDatos.Margin = new Padding(0);
            btnDatos.Name = "btnDatos";
            btnDatos.Size = new Size(115, 36);
            btnDatos.TabIndex = 11;
            btnDatos.Text = "Datos";
            btnDatos.UseVisualStyleBackColor = false;
            // 
            // btMapa
            // 
            btMapa.BackColor = Color.Peru;
            btMapa.FlatAppearance.BorderSize = 0;
            btMapa.FlatStyle = FlatStyle.Flat;
            btMapa.Font = new Font("Segoe UI", 12F);
            btMapa.ForeColor = Color.FromArgb(255, 222, 171);
            btMapa.Location = new Point(82, 145);
            btMapa.Margin = new Padding(0);
            btMapa.Name = "btMapa";
            btMapa.Size = new Size(144, 34);
            btMapa.TabIndex = 12;
            btMapa.Text = "Mapa";
            btMapa.UseVisualStyleBackColor = false;
            // 
            // btLista
            // 
            btLista.BackColor = Color.Peru;
            btLista.FlatAppearance.BorderSize = 0;
            btLista.FlatStyle = FlatStyle.Flat;
            btLista.Font = new Font("Segoe UI", 12F);
            btLista.ForeColor = Color.FromArgb(255, 222, 171);
            btLista.Location = new Point(126, 243);
            btLista.Margin = new Padding(0);
            btLista.Name = "btLista";
            btLista.Size = new Size(163, 34);
            btLista.TabIndex = 13;
            btLista.Text = "Lista";
            btLista.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(799, 448);
            Controls.Add(btLista);
            Controls.Add(btMapa);
            Controls.Add(btnDatos);
            Controls.Add(btnRegistrar);
            Controls.Add(btnServicios);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnHistorial);
            Controls.Add(btnEstanciaActual);
            Controls.Add(pbAjustes);
            Controls.Add(btnParcelas);
            Controls.Add(btnEmpleados);
            Controls.Add(pbLogo);
            Name = "Form1";
            Text = "Daniel capullo";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAjustes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Button btnEmpleados;
        private Button btnParcelas;
        private PictureBox pbAjustes;
        private Button btnEstanciaActual;
        private Button btnHistorial;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnRegistrar;
        private Button btnServicios;
        private Button btnDatos;
        private Button btMapa;
        private Button btLista;
    }
}
