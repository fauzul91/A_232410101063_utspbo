namespace OOP_UTS.Views
{
    partial class Registrasi
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
            label1 = new Label();
            Email = new Label();
            textEmail = new TextBox();
            textPassword = new TextBox();
            label2 = new Label();
            btnBack = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(336, 136);
            label1.Name = "label1";
            label1.Size = new Size(425, 56);
            label1.TabIndex = 0;
            label1.Text = "Silakan Registrasi";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Century Gothic", 14F);
            Email.Location = new Point(193, 290);
            Email.Name = "Email";
            Email.Size = new Size(88, 34);
            Email.TabIndex = 1;
            Email.Text = "Email";
            // 
            // textEmail
            // 
            textEmail.Font = new Font("Century Gothic", 14F);
            textEmail.Location = new Point(380, 289);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(431, 42);
            textEmail.TabIndex = 2;
            // 
            // textPassword
            // 
            textPassword.Font = new Font("Century Gothic", 14F);
            textPassword.Location = new Point(380, 378);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(431, 42);
            textPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F);
            label2.Location = new Point(193, 379);
            label2.Name = "label2";
            label2.Size = new Size(142, 34);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(90, 69);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(445, 521);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(175, 62);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Registrasi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 717);
            Controls.Add(btnRegister);
            Controls.Add(btnBack);
            Controls.Add(textPassword);
            Controls.Add(label2);
            Controls.Add(textEmail);
            Controls.Add(Email);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Registrasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrasi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Email;
        private TextBox textEmail;
        private TextBox textPassword;
        private Label label2;
        private Button btnBack;
        private Button btnRegister;
    }
}