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
    public partial class FrmSecretaryLogin : Form
    {
        public FrmSecretaryLogin()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Secretarys WHERE SecretaryIdentityNumber=@p1 AND SecretaryPassword=@p2", conn.connection());
            cmd.Parameters.AddWithValue("@p1",msktxtTC.Text);
            cmd.Parameters.AddWithValue("@p2",txtPassword.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                FrmSecretaryDetail frmSecretaryDetail = new FrmSecretaryDetail();
                frmSecretaryDetail.Tc = msktxtTC.Text;
                frmSecretaryDetail.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali TC veya şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.connection().Close();
        }
    }
}
