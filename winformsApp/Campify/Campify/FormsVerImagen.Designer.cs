namespace Forms
{
    partial class FormsVerImagen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsVerImagen));
            pnlTop = new Panel();
            lblFechaHora = new Label();
            btnMinimizar = new Button();
            lblTitulo = new Label();
            btnSalir = new Button();
            tmFechaHora = new System.Windows.Forms.Timer(components);
            pbImagen = new PictureBox();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(197, 239, 100);
            pnlTop.Controls.Add(lblFechaHora);
            pnlTop.Controls.Add(btnMinimizar);
            pnlTop.Controls.Add(lblTitulo);
            pnlTop.Controls.Add(btnSalir);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1082, 36);
            pnlTop.TabIndex = 27;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Segoe UI", 8F);
            lblFechaHora.Location = new Point(501, 11);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(0, 19);
            lblFechaHora.TabIndex = 10;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1013, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(32, 32);
            btnMinimizar.TabIndex = 9;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(10, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(149, 20);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Imágen de la parcela";
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(1051, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(28, 32);
            btnSalir.TabIndex = 7;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // tmFechaHora
            // 
            tmFechaHora.Enabled = true;
            tmFechaHora.Interval = 1000;
            tmFechaHora.Tick += tmFechaHora_Tick;
            // 
            // pbImagen
            // 
            pbImagen.Location = new Point(10, 50);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(1060, 641);
            pbImagen.TabIndex = 28;
            pbImagen.TabStop = false;
            // 
            // FormsVerImagen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(1082, 703);
            Controls.Add(pbImagen);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormsVerImagen";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormsVerImagen";
            Load += FormsVerImagen_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Label lblFechaHora;
        private Button btnMinimizar;
        private Label lblTitulo;
        private Button btnSalir;
        private System.Windows.Forms.Timer tmFechaHora;
        private PictureBox pbImagen;
    }
}