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

namespace Hospital_Project
{
    public partial class FrmPatientLogin : Form
    {
        public FrmPatientLogin()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();

        private void llblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientSignUp frm = new FrmPatientSignUp();
            frm.Show();
        }

        private void FrmPatientLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Patients WHERE PatientIdentityNumber=@p1 AND PatientPassword=@p2",conn.connection());
            cmd.Parameters.AddWithValue("@p1", msktxtTC.Text);
            cmd.Parameters.AddWithValue("@p2",txtPassword.Text);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
                FrmPatientDetail frm = new FrmPatientDetail();
                frm.Tc = msktxtTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya şifre","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            conn.connection().Close();
        }
    }
}
