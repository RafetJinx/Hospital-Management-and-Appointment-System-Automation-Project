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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();

        private void ShowDoctors()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Doctors", conn.connection());
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }


        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            ShowDoctors();
            // Branch Combobox
            {
                SqlCommand sql = new SqlCommand("SELECT BranchName FROM Branchs", conn.connection());
                SqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    cbBranch.Items.Add(dr[0]);
                }
                conn.connection().Close();
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Doctors (DoctorName,DoctorLastName,DoctorBranch,DoctorIdentityNumber,DoctorPassword) values (@p1,@p2,@p3,@p4,@p5)", conn.connection());
            sqlCommand.Parameters.AddWithValue("@p1", txtName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtLastName.Text);
            sqlCommand.Parameters.AddWithValue("@p3", cbBranch.Text);
            sqlCommand.Parameters.AddWithValue("@p4", msktxtTC.Text);
            sqlCommand.Parameters.AddWithValue("@p5",txtPassword.Text);
            sqlCommand.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Doktor Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowDoctors();
        }

        private void cbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;
            txtName.Text = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            txtLastName.Text = dataGridView1.Rows[choosen].Cells[2].Value.ToString();
            cbBranch.Text = dataGridView1.Rows[choosen].Cells[3].Value.ToString();
            msktxtTC.Text = dataGridView1.Rows[choosen].Cells[4].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[choosen].Cells[5].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Doctors WHERE DoctorIdentityNumber=@p1", conn.connection()); ;
            sqlCommand.Parameters.AddWithValue("@p1", msktxtTC.Text);
            sqlCommand.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Doktor kaydı silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowDoctors();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE Doctors SET DoctorName=@p1,DoctorLastName@p2,DoctorBranch=@p4,DoctorPassword=@p5 WHERE DoctorIdentityNumber=@p3", conn.connection());
            sqlCommand.Parameters.AddWithValue("@p1", txtName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtLastName.Text);
            sqlCommand.Parameters.AddWithValue("@p3", msktxtTC.Text);
            sqlCommand.Parameters.AddWithValue("@p4", cbBranch.Text);
            sqlCommand.Parameters.AddWithValue("@p5", txtPassword.Text);
            sqlCommand.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Doktor bilgisi güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowDoctors();
        }
    }
}
