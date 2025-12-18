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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(173, 348);
            button1.Name = "button1";
            button1.Size = new Size(108, 72);
            button1.TabIndex = 0;
            button1.Text = "Guardar reserva";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormsNuevaEstancia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(486, 450);
            Controls.Add(button1);
            Name = "FormsNuevaEstancia";
            Text = "Registrar nueva estancia";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}