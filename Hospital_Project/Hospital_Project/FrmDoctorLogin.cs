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
    public partial class FrmDoctorLogin : Form
    {
        public FrmDoctorLogin()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();

        private void FrmDoctorLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Doctors WHERE DoctorIdentityNumber=@p1 AND DoctorPassword=@p2", conn.connection());
            sqlCommand.Parameters.AddWithValue("@p1", msktxtTC.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                FrmDoctorDetail frm = new FrmDoctorDetail();
                frm.Tc = msktxtTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali TC veya şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.connection().Close();
        }
    }
}
