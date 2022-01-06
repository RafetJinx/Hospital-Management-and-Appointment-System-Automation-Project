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
    public partial class FrmUpdateDoctorDetail : Form
    {
        public FrmUpdateDoctorDetail()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();
        public string Tc;

        private void FrmUpdateDoctorDetail_Load(object sender, EventArgs e)
        {
            msktxtTC.Text = Tc;

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Doctors WHERE DoctorIdentityNumber=@p1", conn.connection());
            sqlCommand.Parameters.AddWithValue("@p1", msktxtTC.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                txtName.Text = reader[1].ToString();
                txtLastName.Text = reader[2].ToString();
                cbBranch.Text = reader[3].ToString();
                msktxtTC.Text = reader[4].ToString();
                txtPassword.Text = reader[5].ToString();
            }
            conn.connection().Close();
        }

        private void btnUpdateDoctorDetail_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE Doctors SET DoctorName=@p1,DoctorLastName=@p2,DoctorBranch=@p3,DoctorPassword=@p4 WHERE DoctorIdentityNumber=@p5", conn.connection());
            sqlCommand.Parameters.AddWithValue("@p1", txtName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtLastName.Text);
            sqlCommand.Parameters.AddWithValue("@p3", cbBranch.Text);
            sqlCommand.Parameters.AddWithValue("@p4", txtPassword.Text);
            sqlCommand.Parameters.AddWithValue("@p5", msktxtTC.Text);
            sqlCommand.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Doktor bilgileri güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
