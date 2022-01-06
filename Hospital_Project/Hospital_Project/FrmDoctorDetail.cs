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
    public partial class FrmDoctorDetail : Form
    {
        public FrmDoctorDetail()
        {
            InitializeComponent();
        }

        SqlConn conn = new SqlConn();
        public string Tc;

        private void FrmDoctorDetail_Load(object sender, EventArgs e)
        {
            lblTC.Text = Tc;

            // Doctor FUll Name
            SqlCommand sqlCommand = new SqlCommand("SELECT DoctorName, DoctorLastName FROM Doctors WHERE DoctorIdentityNumber=@p1", conn.connection());
            sqlCommand.Parameters.AddWithValue("@p1",lblTC.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                lblFullName.Text = reader[0] + " " + reader[1];
            }
            conn.connection().Close();


            // Appointments
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Appointments WHERE AppointmentDoctorFullName='" + lblFullName.Text + "'", conn.connection());
                sqlDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnUpdateDoctorDetail_Click(object sender, EventArgs e)
        {
            FrmUpdateDoctorDetail frmUpdateDoctorDetail = new FrmUpdateDoctorDetail();
            frmUpdateDoctorDetail.Tc = lblTC.Text;
            frmUpdateDoctorDetail.Show();
        }

        private void btnAnnouncement_Click(object sender, EventArgs e)
        {
            FrmAnnouncements frmAnnouncements = new FrmAnnouncements();
            frmAnnouncements.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;
            rchPatientComplaint.Text = dataGridView1.Rows[choosen].Cells[7].Value.ToString();
        }
    }
}
