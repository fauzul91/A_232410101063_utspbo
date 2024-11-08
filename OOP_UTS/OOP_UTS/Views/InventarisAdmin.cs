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
    public partial class InventarisAdmin : Form
    {
        public InventarisAdmin()
        {
            InitializeComponent();
        }

        public void LoadDataInventaris()
        {
            try
            {
                dataGridInventarisAdmin.AllowUserToAddRows = false;

                DataTable inventarisDataAdmin = InventarisContext.All();
                if (inventarisDataAdmin == null)
                {
                    MessageBox.Show("Error: Gagal mengambil data inventaris");
                    return;
                }

                dataGridInventarisAdmin.Columns.Clear();

                dataGridInventarisAdmin.DataSource = inventarisDataAdmin;

                if (dataGridInventarisAdmin.Columns["nama_inventaris"] != null) dataGridInventarisAdmin.Columns["nama_inventaris"].HeaderText = "Nama Inventaris";
                if (dataGridInventarisAdmin.Columns["id_category"] != null) dataGridInventarisAdmin.Columns["id_category"].Visible = false;
                if (dataGridInventarisAdmin.Columns["nama_category"] != null) dataGridInventarisAdmin.Columns["nama_category"].HeaderText = "Nama Kategori";
                if (dataGridInventarisAdmin.Columns["jumlah"] != null) dataGridInventarisAdmin.Columns["jumlah"].HeaderText = "Jumlah";
                if (dataGridInventarisAdmin.Columns["harga"] != null) dataGridInventarisAdmin.Columns["harga"].HeaderText = "Harga";

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
                if (dataGridInventarisAdmin.Columns["Update"] == null)
                {
                    DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "Update",
                        HeaderText = "Update",
                        Text = "Edit",
                        UseColumnTextForButtonValue = true
                    };
                    dataGridInventarisAdmin.Columns.Add(updateButtonColumn);
                }

                // Tambahkan kolom delete hanya jika belum ada
                if (dataGridInventarisAdmin.Columns["Delete"] == null)
                {
                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "Delete",
                        HeaderText = "Delete",
                        Text = "Delete",
                        UseColumnTextForButtonValue = true
                    };
                    dataGridInventarisAdmin.Columns.Add(deleteButtonColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam LoadDataMahasiswa: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormTambahInventaris formTambahInventaris = new FormTambahInventaris();
            formTambahInventaris.Show();
            this.Hide();
        }

        private void InventarisAdmin_Load(object sender, EventArgs e)
        {
            LoadDataInventaris();
        }
    }
}
