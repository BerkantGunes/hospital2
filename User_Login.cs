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
    public partial class User_Login: Form
    {
        public User_Login()
        {
            InitializeComponent();
        }

        private void usrloginbtn_Click(object sender, EventArgs e)
        {

        }

        private void lblAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_Login adm = new Admin_Login();
            adm.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
