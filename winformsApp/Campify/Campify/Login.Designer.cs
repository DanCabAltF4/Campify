namespace Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pbLogo = new PictureBox();
            lblPassword = new Label();
            btnLogin = new Button();
            tbUsuario = new TextBox();
            lblUsuario = new Label();
            tbPassword = new TextBox();
            btnSalir = new Button();
            pnlTop = new Panel();
            btnMinimizar = new Button();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(0, 39);
            pbLogo.Margin = new Padding(0);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(106, 116);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.Location = new Point(73, 228);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(98, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "-Contraseña:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Peru;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F);
            btnLogin.Location = new Point(130, 301);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(121, 39);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(182, 169);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(163, 27);
            tbUsuario.TabIndex = 4;
            tbUsuario.Text = "ana@campify.com";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuario.Location = new Point(73, 172);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(73, 20);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "-Usuario:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(182, 225);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(163, 27);
            tbPassword.TabIndex = 6;
            tbPassword.Text = "1234";
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(354, 1);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(44, 32);
            btnSalir.TabIndex = 7;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(197, 239, 100);
            pnlTop.Controls.Add(btnMinimizar);
            pnlTop.Controls.Add(lblTitulo);
            pnlTop.Controls.Add(btnSalir);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(398, 36);
            pnlTop.TabIndex = 8;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(316, 1);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(32, 32);
            btnMinimizar.TabIndex = 9;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(10, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(115, 20);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Campify - Login";
            lblTitulo.MouseDown += pnlTop_MouseDown;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(398, 358);
            Controls.Add(pnlTop);
            Controls.Add(tbPassword);
            Controls.Add(lblUsuario);
            Controls.Add(tbUsuario);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(pbLogo);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblPassword;
        private Button btnLogin;
        private TextBox tbUsuario;
        private Label lblUsuario;
        private TextBox tbPassword;
        private Button btnSalir;
        private Panel pnlTop;
        private Label lblTitulo;
        private Button btnMinimizar;
    }
}