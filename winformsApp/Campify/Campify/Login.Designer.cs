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
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(-7, -12);
            pbLogo.Margin = new Padding(3, 4, 3, 4);
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
            lblPassword.Location = new Point(66, 176);
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
            btnLogin.Location = new Point(123, 249);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(121, 39);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(175, 117);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(163, 27);
            tbUsuario.TabIndex = 4;
            tbUsuario.Text = "ana@campify.com";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuario.Location = new Point(66, 120);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(73, 20);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "-Usuario:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(175, 173);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(163, 27);
            tbPassword.TabIndex = 6;
            tbPassword.Text = "1234";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(398, 322);
            Controls.Add(tbPassword);
            Controls.Add(lblUsuario);
            Controls.Add(tbUsuario);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(pbLogo);
            Font = new Font("Segoe UI", 9F);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
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
    }
}