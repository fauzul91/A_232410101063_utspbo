namespace OOP_UTS.Views
{
    partial class FormTambahInventaris
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
            btnLogin = new Button();
            textCategory = new TextBox();
            category = new Label();
            textNama = new TextBox();
            namaInventaris = new Label();
            label1 = new Label();
            textHarga = new TextBox();
            harga = new Label();
            textJumlah = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(458, 563);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(175, 62);
            btnLogin.TabIndex = 18;
            btnLogin.Text = "Tambah";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // textCategory
            // 
            textCategory.Font = new Font("Century Gothic", 14F);
            textCategory.Location = new Point(432, 307);
            textCategory.Name = "textCategory";
            textCategory.Size = new Size(431, 42);
            textCategory.TabIndex = 16;
            // 
            // category
            // 
            category.AutoSize = true;
            category.Font = new Font("Century Gothic", 14F);
            category.Location = new Point(245, 308);
            category.Name = "category";
            category.Size = new Size(131, 34);
            category.TabIndex = 15;
            category.Text = "Kategori";
            // 
            // textNama
            // 
            textNama.Font = new Font("Century Gothic", 14F);
            textNama.Location = new Point(432, 218);
            textNama.Name = "textNama";
            textNama.Size = new Size(431, 42);
            textNama.TabIndex = 14;
            // 
            // namaInventaris
            // 
            namaInventaris.AutoSize = true;
            namaInventaris.Font = new Font("Century Gothic", 14F);
            namaInventaris.Location = new Point(245, 219);
            namaInventaris.Name = "namaInventaris";
            namaInventaris.Size = new Size(100, 34);
            namaInventaris.TabIndex = 13;
            namaInventaris.Text = "Nama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 103);
            label1.Name = "label1";
            label1.Size = new Size(577, 56);
            label1.TabIndex = 12;
            label1.Text = "Form Tambah Inventaris";
            // 
            // textHarga
            // 
            textHarga.Font = new Font("Century Gothic", 14F);
            textHarga.Location = new Point(432, 463);
            textHarga.Name = "textHarga";
            textHarga.Size = new Size(431, 42);
            textHarga.TabIndex = 22;
            // 
            // harga
            // 
            harga.AutoSize = true;
            harga.Font = new Font("Century Gothic", 14F);
            harga.Location = new Point(245, 464);
            harga.Name = "harga";
            harga.Size = new Size(99, 34);
            harga.TabIndex = 21;
            harga.Text = "Harga";
            // 
            // textJumlah
            // 
            textJumlah.Font = new Font("Century Gothic", 14F);
            textJumlah.Location = new Point(432, 382);
            textJumlah.Name = "textJumlah";
            textJumlah.Size = new Size(431, 42);
            textJumlah.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F);
            label4.Location = new Point(245, 383);
            label4.Name = "label4";
            label4.Size = new Size(113, 34);
            label4.TabIndex = 19;
            label4.Text = "Jumlah";
            // 
            // FormTambahInventaris
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 721);
            Controls.Add(textHarga);
            Controls.Add(harga);
            Controls.Add(textJumlah);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(textCategory);
            Controls.Add(category);
            Controls.Add(textNama);
            Controls.Add(namaInventaris);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormTambahInventaris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTambahInventaris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnBack;
        private TextBox textCategory;
        private Label category;
        private TextBox textNama;
        private Label namaInventaris;
        private Label label1;
        private TextBox textHarga;
        private Label harga;
        private TextBox textJumlah;
        private Label label4;
    }
}