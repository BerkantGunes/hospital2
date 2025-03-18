using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hospitalmanagement
{
    public partial class Doctors: Form
    {
        public Doctors()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gunes\Desktop\DEV\FULL-STACK\My Projects\Form Projects\5) Hospital Management Project\Hospital Management System\Hospital Management System\HMSDatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            Patients ptn = new Patients();
            ptn.Show();
            this.Hide();
        }

        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            Diagnosis dgn = new Diagnosis();
            dgn.Show();
            this.Hide();
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            Medicine mdc = new Medicine();
            mdc.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Admin_Login adm = new Admin_Login();
            adm.Show();
            this.Hide();
        }

        void populate()
        {
            Con.Open();
            string query = "select * from DoctorsTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DoctorsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Reset()
        {
            txtDoctorId.Text = "";
            txtDoctorName.Text = "";
            txtDoctorExperience.Text = "";
            txtPassword.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDoctorId.Text == "" && txtDoctorName.Text == "" && txtDoctorExperience.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Missing Information! Fill all details");
            }
            else
            {
                Con.Open();
                string query = "insert into DoctorsTbl values(" + txtDoctorId.Text + ",'" + txtDoctorName.Text + "'," + txtDoctorExperience.Text + ",'" + txtPassword.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Added Successfully!");
                Con.Close();
                populate();
                Reset();
            }
        }

        private void DoctorsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDoctorId.Text = DoctorsDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtDoctorName.Text = DoctorsDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtDoctorExperience.Text = DoctorsDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtPassword.Text = DoctorsDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DoctorsTbl set DoctorName = '"+txtDoctorName.Text+"', DoctorExperience = "+txtDoctorExperience.Text+", DoctorPassword = '"+txtPassword.Text+"' where DoctorId = "+txtDoctorId+"";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Informations Updated Successfully!");
            Con.Close();
            populate();
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtDoctorId.Text == "")
            {
                MessageBox.Show("Enter the Doctor Id");
            }
            else
            {
                Con.Open();
                string query = "delete from DoctorsTbl where DoctorId = " + txtDoctorId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Deleted Successfully!");
                Con.Close();
                populate();
                Reset();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
