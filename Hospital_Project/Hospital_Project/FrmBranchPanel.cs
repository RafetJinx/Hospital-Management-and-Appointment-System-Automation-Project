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
    public partial class FrmBranchPanel : Form
    {
        public FrmBranchPanel()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();

        private void ShowBranchs()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Branchs", conn.connection());
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void FrmBranchPanel_Load(object sender, EventArgs e)
        {
            ShowBranchs();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;
            txtBranchId.Text = dataGridView1.Rows[choosen].Cells[0].Value.ToString();
            txtBranchName.Text = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Branchs (BranchName) values (@p1)", conn.connection()); ;
            sqlCommand.Parameters.AddWithValue("@p1", txtBranchName.Text);
            sqlCommand.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Branş eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowBranchs();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Branchs WHERE BranchId=@p1", conn.connection());
            sqlCommand.Parameters.AddWithValue("@p1", txtBranchId.Text);
            sqlCommand.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Branş silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowBranchs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE Branchs SET BranchName=@p1 WHERE BranchId=@p2", conn.connection());
            sqlCommand.Parameters.AddWithValue("@p1", txtBranchName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtBranchId.Text);
            sqlCommand.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Branş güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowBranchs();
        }
    }
}
