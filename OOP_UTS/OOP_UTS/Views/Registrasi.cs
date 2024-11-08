using OOP_UTS.App.Context;
using OOP_UTS.App.Models;
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
    public partial class Registrasi : Form
    {
        public bool IsEditMode { get; set; } = false;
        public Registrasi()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            M_Pengguna pengguna = new M_Pengguna()
            {
                email = textEmail.Text,
                password = textPassword.Text
            };

            InventarisContext context = new InventarisContext();

            //if (IsAccessible
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textEmail.Text) ||
                string.IsNullOrWhiteSpace(textPassword.Text))
            {
                return false;
            }
            return true;
        }
    }
}


