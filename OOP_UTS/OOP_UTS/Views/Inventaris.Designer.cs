namespace OOP_UTS.Views
{
    partial class Inventaris
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
            dataGridInventaris = new DataGridView();
            label1 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridInventaris).BeginInit();
            SuspendLayout();
            // 
            // dataGridInventaris
            // 
            dataGridInventaris.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInventaris.Location = new Point(138, 156);
            dataGridInventaris.Name = "dataGridInventaris";
            dataGridInventaris.RowHeadersWidth = 62;
            dataGridInventaris.Size = new Size(793, 451);
            dataGridInventaris.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(426, 70);
            label1.Name = "label1";
            label1.Size = new Size(236, 38);
            label1.TabIndex = 1;
            label1.Text = "Fitur Inventaris";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(138, 69);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Inventaris
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 713);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(dataGridInventaris);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Inventaris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventaris";
            Load += Inventaris_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridInventaris).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridInventaris;
        private Label label1;
        private Button btnBack;
    }
}