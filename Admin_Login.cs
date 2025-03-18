using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalmanagement
{
    public partial class Admin_Login: Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void lblAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User_Login usr = new User_Login();
            usr.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminloginbtn_Click(object sender, EventArgs e)
        {
            if (usrtxt.Text == "" || passtxt.Text == "")
            {
                MessageBox.Show("Enter Username and Password!");
            }
            else if (usrtxt.Text == "admin" && passtxt.Text != "Password")
            {
                MessageBox.Show("Wrong Password!");
            }
            else if (usrtxt.Text == "admin" && passtxt.Text == "Password")
            {
                Doctors doc = new Doctors();
                doc.Show();
                this.Hide();
            }
        }
    }
}
