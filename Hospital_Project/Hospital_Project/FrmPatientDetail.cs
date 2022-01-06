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
    public partial class FrmPatientDetail : Form
    {
        public FrmPatientDetail()
        {
            InitializeComponent();
        }

        public string Tc;
        SqlConn conn = new SqlConn();


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmPatientDetail_Load(object sender, EventArgs e)
        {
            lblTC.Text = Tc;

            // Pulling data: Name - Last Name
            {
                SqlCommand cmd = new SqlCommand("SELECT PatientName, PatientLastName FROM Patients WHERE PatientIdentityNumber=@p1", conn.connection());
                cmd.Parameters.AddWithValue("@p1", lblTC.Text);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    lblFullName.Text = sqlDataReader[0] + " " + sqlDataReader[1];
                }
                conn.connection().Close();
            }

            // Pulling data: Appointment History
            {
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Appointments WHERE PatientIdentityNumber=" + Tc, conn.connection());
                sqlDataAdapter.Fill(dataTable);
                dataGridView2.DataSource = dataTable;
            }

            // Pulling data: Branchs
            {
                SqlCommand cmd2 = new SqlCommand("SELECT BranchName FROM Branchs", conn.connection());
                SqlDataReader sqlDataReader2 = cmd2.ExecuteReader();
                while (sqlDataReader2.Read())
                {
                    cbBranch.Items.Add(sqlDataReader2[0]);
                }
                conn.connection().Close();
            }
        }

        // Pulling data: Doctors
        private void cbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDoctors.Items.Clear();

            SqlCommand cmd3 = new SqlCommand("SELECT DoctorName, DoctorLastName FROM Doctors WHERE DoctorBranch=@p1", conn.connection());
            cmd3.Parameters.AddWithValue("@p1",cbBranch.Text);
            SqlDataReader sqlDataReader3 = cmd3.ExecuteReader();
            while (sqlDataReader3.Read())
            {
                cbDoctors.Items.Add(sqlDataReader3[0] + " " + sqlDataReader3[1]);
            }
            conn.connection().Close();
        }

        private void cbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Appointments WHERE AppointmentBranch='" + cbBranch.Text + "'" + "AND AppointmentDoctorFullName='" + cbDoctors.Text + "' AND AppointmentStatus=0", conn.connection());
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void llblUpdateDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUpdatePatientDetail frmUpdatePatientDetail = new FrmUpdatePatientDetail();
            frmUpdatePatientDetail.Tc = lblTC.Text;
            frmUpdatePatientDetail.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[choosen].Cells[0].Value.ToString();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE Appointments SET AppointmentStatus=1,PatientIdentityNumber=@p1,PatientComplaint=@p2 WHERE AppointmentId=@p3",conn.connection());
            sqlCommand.Parameters.AddWithValue("@p1", lblTC.Text);
            sqlCommand.Parameters.AddWithValue("@p2", rchtxtReport.Text);
            sqlCommand.Parameters.AddWithValue("@p3", txtId.Text);
            sqlCommand.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Randevu alindi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
