using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalmanagement
{
    public partial class Patients: Form
    {
        public Patients()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\gunes\Desktop\DEV\FULL-STACK\My Projects\Form Projects\5) Hospital Management Project\Hospital Management System\Hospital Management System\HMSDatabase.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            Diagnosis dgn = new Diagnosis();
            dgn.Show();
            this.Hide();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            Doctors doc = new Doctors();
            doc.Show();
            this.Hide();
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            Medicine med = new Medicine();
            med.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Admin_Login adm = new Admin_Login();
            adm.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            Con.Open(); 
            string query = "select * from PatientTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PatientsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Reset()
        {
            txtPatientId.Text = "";
            txtPatientName.Text = "";
            txtaddress.Text = "";
            txtphone.Text = "";
            txtage.Text = "";
            diseasetxt.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtPatientId.Text == "" || txtPatientName.Text == "" || txtaddress.Text == "" || txtphone.Text == "" || txtage.Text == "" || diseasetxt.Text == "")
            {
                MessageBox.Show("Missing Information. Fill in the blank fields!");
            }
            else
            {
                Con.Open();
                string query = "insert into PatientTbl values(" + txtPatientId.Text + ",'" + txtPatientName.Text + "', '" + txtaddress.Text + "', '" + txtphone.Text + "', " + txtage.Text + ", '" + cbPatientGender.SelectedItem.ToString() + "', '" + cbPatientBG.SelectedItem.ToString() + "', '" + diseasetxt.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Informations Added Successfully!");
                Con.Close();
                populate();
                Reset();
            }
        }

        private void PatientsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPatientId.Text = PatientsDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtPatientName.Text = PatientsDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtaddress.Text = PatientsDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtphone.Text = PatientsDGV.SelectedRows[0].Cells[3].Value.ToString();
            txtage.Text = PatientsDGV.SelectedRows[0].Cells[4].Value.ToString();
            diseasetxt.Text = PatientsDGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
