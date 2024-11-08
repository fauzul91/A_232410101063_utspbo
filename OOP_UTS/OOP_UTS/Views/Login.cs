using Npgsql;
using OOP_UTS.App.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OOP_UTS.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = textEmail.Text;
            string password = textPassword.Text;

            // Validasi untuk memastikan input tidak kosong
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Data salah, isi kembali!");
                return; // Menghentikan eksekusi jika input kosong
            }

            if (IsValidUser(email, password))
            {
                InventarisAdmin inventaris = new InventarisAdmin();
                inventaris.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah, isi kembali!");
            }
        }

        private bool IsValidUser(string email, string password)
        {
            string query = "SELECT COUNT(*) FROM admin WHERE email = @email AND password = @password";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@email", email),
                new NpgsqlParameter("@password", password)
            };

            try
            {
                DataTable result = DatabaseWrapper.queryExecutor(query, parameters);
                int userCount = Convert.ToInt32(result.Rows[0][0]);
                return userCount > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
