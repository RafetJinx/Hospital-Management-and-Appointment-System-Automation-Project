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
    public partial class FrmUpdatePatientDetail : Form
    {
        public FrmUpdatePatientDetail()
        {
            InitializeComponent();
        }
        public string Tc;
        SqlConn conn = new SqlConn();
        private void FrmUpdatePatientDetail_Load(object sender, EventArgs e)
        {
            msktxtTC.Text = Tc;

            SqlCommand cmd = new SqlCommand("SELECT * FROM Patients WHERE PatientIdentityNumber=@p1", conn.connection());
            cmd.Parameters.AddWithValue("@p1", msktxtTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtLastName.Text = dr[2].ToString();
                msktxtTelNum.Text = dr[4].ToString();
                txtPassword.Text = dr[5].ToString();
                cbGender.Text = dr[6].ToString();
            }
            conn.connection().Close();
        }

        private void btnUpdatePatientDetail_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Patients SET PatientName=@p1,PatientLastName=@p2, PatientTelNumber=@p3, PatientPassword=@p4, PatientGender=@p5 WHERE PatientIdentityNumber=@p6", conn.connection());
            cmd.Parameters.AddWithValue("@p1", txtName.Text);
            cmd.Parameters.AddWithValue("@p2", txtLastName.Text);
            cmd.Parameters.AddWithValue("@p3", msktxtTelNum.Text);
            cmd.Parameters.AddWithValue("@p4", txtPassword.Text);
            cmd.Parameters.AddWithValue("@p5", cbGender.Text);
            cmd.Parameters.AddWithValue("@p6", msktxtTC.Text);
            cmd.ExecuteNonQuery();

            conn.connection().Close();
            MessageBox.Show("Bilgileriniz güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
