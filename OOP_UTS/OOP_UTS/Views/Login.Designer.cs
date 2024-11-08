namespace OOP_UTS.Views
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
            textPassword = new TextBox();
            label2 = new Label();
            textEmail = new TextBox();
            Email = new Label();
            label1 = new Label();
            btnBack = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // textPassword
            // 
            textPassword.Font = new Font("Century Gothic", 14F);
            textPassword.Location = new Point(378, 378);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(431, 42);
            textPassword.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F);
            label2.Location = new Point(191, 379);
            label2.Name = "label2";
            label2.Size = new Size(142, 34);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // textEmail
            // 
            textEmail.Font = new Font("Century Gothic", 14F);
            textEmail.Location = new Point(378, 289);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(431, 42);
            textEmail.TabIndex = 7;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Century Gothic", 14F);
            Email.Location = new Point(191, 290);
            Email.Name = "Email";
            Email.Size = new Size(88, 34);
            Email.TabIndex = 6;
            Email.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(387, 118);
            label1.Name = "label1";
            label1.Size = new Size(332, 56);
            label1.TabIndex = 5;
            label1.Text = "Silakan Login";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(94, 70);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(471, 517);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(175, 62);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 721);
            Controls.Add(btnLogin);
            Controls.Add(btnBack);
            Controls.Add(textPassword);
            Controls.Add(label2);
            Controls.Add(textEmail);
            Controls.Add(Email);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textPassword;
        private Label label2;
        private TextBox textEmail;
        private Label Email;
        private Label label1;
        private Button btnBack;
        private Button btnLogin;
    }
}