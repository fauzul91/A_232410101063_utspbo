namespace OOP_UTS.Views
{
    partial class WelcomePage
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
            btnInventaris = new Button();
            btnRegister = new Button();
            btnLogin = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 145);
            label1.Name = "label1";
            label1.Size = new Size(653, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Inventory Management App";
            // 
            // btnInventaris
            // 
            btnInventaris.Location = new Point(96, 385);
            btnInventaris.Name = "btnInventaris";
            btnInventaris.Size = new Size(253, 82);
            btnInventaris.TabIndex = 1;
            btnInventaris.Text = "Inventaris";
            btnInventaris.UseVisualStyleBackColor = true;
            btnInventaris.Click += btnInventaris_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(411, 385);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(253, 82);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(720, 385);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(253, 82);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(335, 314);
            label2.Name = "label2";
            label2.Size = new Size(415, 34);
            label2.TabIndex = 4;
            label2.Text = "Silakan pilih fitur di bawah ini!";
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 709);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(btnInventaris);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "WelcomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WelcomePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnInventaris;
        private Button btnRegister;
        private Button btnLogin;
        private Label label2;
    }
}