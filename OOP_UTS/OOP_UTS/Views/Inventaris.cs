using OOP_UTS.App.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_UTS.Views
{
    public partial class Inventaris : Form
    {
        public Inventaris()
        {
            InitializeComponent();
        }
        public void LoadDataInventaris()
        {
            try
            {
                dataGridInventaris.AllowUserToAddRows = false;

                DataTable inventarisData = InventarisContext.All();
                if (inventarisData == null)
                {
                    MessageBox.Show("Error: Gagal mengambil data inventaris");
                    return;
                }

                dataGridInventaris.Columns.Clear();

                dataGridInventaris.DataSource = inventarisData;

                if (dataGridInventaris.Columns["nama_inventaris"] != null) dataGridInventaris.Columns["nama_inventaris"].HeaderText = "Nama Inventaris";
                if (dataGridInventaris.Columns["id_category"] != null) dataGridInventaris.Columns["id_category"].Visible = false;
                if (dataGridInventaris.Columns["nama_category"] != null) dataGridInventaris.Columns["nama_category"].HeaderText = "Nama Kategori";
                if (dataGridInventaris.Columns["jumlah"] != null) dataGridInventaris.Columns["jumlah"].HeaderText = "Jumlah";
                if (dataGridInventaris.Columns["harga"] != null) dataGridInventaris.Columns["harga"].HeaderText = "Harga";

                // Tambahkan kolom nomor secara manual
                //DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn
                //{
                //    //HeaderText = "No",
                //    Name = "nomor"
                //};
                //dataGridInventaris.Columns.Insert(0, nomorColumn);

                // Tambahkan nomor urut di kolom nomor
                //for (int i = 0; i < dataGridInventaris.Rows.Count; i++)
                //{
                //    dataGridInventaris.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
                //}

                // Tambahkan kolom update hanya jika belum ada
                if (dataGridInventaris.Columns["Update"] == null)
                {
                    DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "Update",
                        HeaderText = "Update",
                        Text = "Edit",
                        UseColumnTextForButtonValue = true
                    };
                    dataGridInventaris.Columns.Add(updateButtonColumn);
                }

                // Tambahkan kolom delete hanya jika belum ada
                if (dataGridInventaris.Columns["Delete"] == null)
                {
                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "Delete",
                        HeaderText = "Delete",
                        Text = "Delete",
                        UseColumnTextForButtonValue = true
                    };
                    dataGridInventaris.Columns.Add(deleteButtonColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam LoadDataMahasiswa: {ex.Message}\n{ex.StackTrace}");
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.Show();
            this.Hide();
        }

        private void Inventaris_Load(object sender, EventArgs e)
        {
            LoadDataInventaris();
        }
    }
}
