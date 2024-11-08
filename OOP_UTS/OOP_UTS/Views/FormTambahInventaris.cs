using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_UTS.Views
{
    public partial class FormTambahInventaris : Form
    {
        public FormTambahInventaris()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            InventarisAdmin inventarisAdmin = new InventarisAdmin();
            inventarisAdmin.Show();
            this.Hide();
        }

    }
}

//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using winform_mvc.App.Context;
//using winform_mvc.App.Models;

//namespace winform_mvc.Views
//{
//    public partial class AddMahasiswaForm : Form
//    {
//        public bool IsEditMode { get; set; } = false;
//        public int MahasiswaId { get; set; }

//        public AddMahasiswaForm()
//        {
//            InitializeComponent();
//            UpdateButtonText();
//            LoadProdiData();
//        }

//        private void buttonAdd_Click(object sender, EventArgs e)
//        {
//            if (!ValidateInput())
//            {
//                MessageBox.Show("Inputan tidak valid");
//                return;
//            }

//            M_Mahasiswa mahasiswa = new M_Mahasiswa
//            {
//                nama = textBox1.Text,
//                nim = textBox2.Text,
//                email = textBox3.Text,
//                semester = int.Parse(textBox4.Text),
//                id_prodi = (int)comboBox1.SelectedValue,
//            };

//            if (IsEditMode)
//            {
//                mahasiswa.id = MahasiswaId;
//                MahasiswaContext.UpdateMahasiswa(mahasiswa);
//                MessageBox.Show("Mahasiswa berhasil diupdate");
//            }
//            else
//            {
//                MahasiswaContext.AddMahasiswa(mahasiswa);
//                MessageBox.Show("Mahasiswa baru berhasil ditambahkan");
//            }

//            ClearFields();

//            this.DialogResult = DialogResult.OK;
//            this.Hide();
//        }

//        private void LoadProdiData()
//        {
//            DataTable dataProdi = ProdiContext.All();
//            comboBox1.DisplayMember = "nama_prodi";
//            comboBox1.ValueMember = "id";
//            comboBox1.DataSource = dataProdi;
//        }

//        private bool ValidateInput()
//        {
//            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
//                string.IsNullOrWhiteSpace(textBox2.Text) ||
//                string.IsNullOrWhiteSpace(textBox3.Text) ||
//                !int.TryParse(textBox4.Text, out _))
//            {
//                return false;
//            }
//            return true;
//        }

//        private void ClearFields()
//        {
//            textBox1.Clear();
//            textBox2.Clear();
//            textBox3.Clear();
//            textBox4.Clear();
//            comboBox1.SelectedIndex = -1;
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            this.DialogResult = DialogResult.Cancel;
//            this.Hide();
//        }

//        public void PopulateForm(M_Mahasiswa mahasiswa)
//        {
//            LoadProdiData();

//            textBox1.Text = mahasiswa.nama;
//            textBox2.Text = mahasiswa.nim;
//            textBox3.Text = mahasiswa.email;
//            textBox4.Text = mahasiswa.semester.ToString();
//            comboBox1.SelectedValue = mahasiswa.id_prodi;
//            IsEditMode = true;
//            MahasiswaId = mahasiswa.id;
//            UpdateButtonText();
//        }

//        private void UpdateButtonText()
//        {
//            buttonAdd.Text = IsEditMode ? "Update" : "Add";
//        }
//    }
//}

