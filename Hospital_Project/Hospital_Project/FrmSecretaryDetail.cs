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
    public partial class FrmSecretaryDetail : Form
    {
        public FrmSecretaryDetail()
        {
            InitializeComponent();
        }

        public string Tc;
        SqlConn conn = new SqlConn();

        private void FrmSecretaryDetail_Load(object sender, EventArgs e)
        {
            lblTC.Text = Tc;

            // Secretary Full Name
            {
                SqlCommand cmd = new SqlCommand("SELECT SecretaryName, SecretaryLastName FROM Secretarys WHERE SecretaryIdentityNumber=@p1", conn.connection()); ;
                cmd.Parameters.AddWithValue("@p1", lblTC.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblFullName.Text = dr[0] + " " + dr[1];
                }
                conn.connection().Close();
            }

            // Branchs
            {
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Branchs", conn.connection());
                sqlDataAdapter.Fill(dataTable);
                dataGridView2.DataSource = dataTable;
            }

            // Branch Combobox
            {
                SqlCommand sql = new SqlCommand("SELECT BranchName FROM Branchs", conn.connection());
                SqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    cmbBranch.Items.Add(dr[0]);
                }
                conn.connection().Close ();
            }

            // Doctors
            {
                DataTable dataTable2 = new DataTable();
                SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("SELECT (DoctorName + ' ' + DoctorLastName) as [Doktor Adi], DoctorBranch  FROM Doctors", conn.connection());
                sqlDataAdapter2.Fill(dataTable2);
                dataGridView1.DataSource = dataTable2;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Appointments (AppointmentDate,AppointmentHour,AppointmentBranch,AppointmentDoctorFullName) values (@p1,@p2,@p3,@p4)", conn.connection());
            sqlCommand.Parameters.AddWithValue("@p1", mskDate.Text);
            sqlCommand.Parameters.AddWithValue("@p2", mskHour.Text);
            sqlCommand.Parameters.AddWithValue("@p3", cmbBranch.Text);
            sqlCommand.Parameters.AddWithValue("@p4", cmbDoctor.Text);
            sqlCommand.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Randevu Olusturuldu","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();

            SqlCommand sqlcomm = new SqlCommand("SELECT DoctorName, DoctorLastName FROM Doctors WHERE DoctorBranch=@p1", conn.connection());
            sqlcomm.Parameters.AddWithValue("@p1", cmbBranch.Text);
            SqlDataReader sqlDataReader = sqlcomm.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cmbDoctor.Items.Add(sqlDataReader[0] + " " + sqlDataReader[1]);
            }
            conn.connection().Close();
        }

        private void btnCreateAnnouncement_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Announcements (AnnouncementName) values (@p1)", conn.connection());
            sqlCommand.Parameters.AddWithValue("@p1", rchAnnouncement.Text);
            sqlCommand.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Duyuru oluşturuldu", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDoctorPanel_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel frmDoctorPanel = new FrmDoctorPanel();
            frmDoctorPanel.Show();
        }

        private void btnBranchPanel_Click(object sender, EventArgs e)
        {
            FrmBranchPanel frmBranchPanel = new FrmBranchPanel();
            frmBranchPanel.Show();
        }

        private void btnListAppointments_Click(object sender, EventArgs e)
        {
            FrmAppointmentList frmAppointmentList = new FrmAppointmentList();
            frmAppointmentList.Show();
        }

        private void btnAnnouncement_Click(object sender, EventArgs e)
        {
            FrmAnnouncements frmAnnouncements = new FrmAnnouncements();
            frmAnnouncements.Show();
        }
    }
}
