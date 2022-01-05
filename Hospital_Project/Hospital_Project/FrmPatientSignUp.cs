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
    public partial class FrmPatientSignUp : Form
    {
        public FrmPatientSignUp()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Patients " +
                "(PatientName,PatientLastName,PatientIdentityNumber," +
                "PatientTelNumber,PatientPassword,PatientGender) " +
                "values (@p1, @p2, @p3, @p4, @p5, @p6)", conn.connection());

            cmd.Parameters.AddWithValue("@p1", txtName.Text);
            cmd.Parameters.AddWithValue("@p2", txtLastName.Text);
            cmd.Parameters.AddWithValue("@p3", msktxtTC.Text);
            cmd.Parameters.AddWithValue("@p4",msktxtTelNum.Text);
            cmd.Parameters.AddWithValue("@p5",txtPassword.Text);
            cmd.Parameters.AddWithValue("@p6", cbGender.Text);
            cmd.ExecuteNonQuery();

            conn.connection().Close();

            MessageBox.Show("Kaydınız gerçekleştirilmiştir. Şifreniz: " + txtPassword.Text, 
                "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
