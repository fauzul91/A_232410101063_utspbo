namespace OOP_UTS.Views
{
    partial class InventarisAdmin
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
            btnBack = new Button();
            label1 = new Label();
            dataGridInventarisAdmin = new DataGridView();
            btnTambah = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridInventarisAdmin).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(153, 91);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(441, 92);
            label1.Name = "label1";
            label1.Size = new Size(236, 38);
            label1.TabIndex = 4;
            label1.Text = "Fitur Inventaris";
            // 
            // dataGridInventarisAdmin
            // 
            dataGridInventarisAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInventarisAdmin.Location = new Point(153, 178);
            dataGridInventarisAdmin.Name = "dataGridInventarisAdmin";
            dataGridInventarisAdmin.RowHeadersWidth = 62;
            dataGridInventarisAdmin.Size = new Size(793, 451);
            dataGridInventarisAdmin.TabIndex = 3;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(834, 99);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(112, 34);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // InventarisAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 721);
            Controls.Add(btnTambah);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(dataGridInventarisAdmin);
            Name = "InventarisAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventarisAdmin";
            Load += InventarisAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridInventarisAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label1;
        private DataGridView dataGridInventarisAdmin;
        private Button btnTambah;
    }
}