using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeRecord
{
    public partial class FormCreateAnnouncement : Form
    {
        public FormCreateAnnouncement()
        {
            InitializeComponent();
        }
        SqlConnect cnt = new SqlConnect();
        void List()
        {
            SqlCommand comd = new SqlCommand("Select * From TblAnnouncements", cnt.connect());
            SqlDataAdapter da = new SqlDataAdapter(comd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FormCreateAnnouncement_Load(object sender, EventArgs e)
        {
            List();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand comd = new SqlCommand("insert into TblAnnouncements (Description) values (@p1)", cnt.connect());
            comd.Parameters.AddWithValue("@p1", RchAnnouncement.Text);
            comd.ExecuteNonQuery();
            MessageBox.Show("Announcement Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cnt.connect().Close();
            List();
        }

        string id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[select].Cells[0].Value.ToString();
            RchAnnouncement.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            this.Text = id;
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand comd = new SqlCommand("Delete From TblAnnouncements where AnnouncementID=@p1", cnt.connect());
            comd.Parameters.AddWithValue("@p1", id);
            comd.ExecuteNonQuery();
            MessageBox.Show("Announcement Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            cnt.connect().Close();
            List();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand comd = new SqlCommand("Update TblAnnouncements set Description=@p1 where AnnouncementID=@p2", cnt.connect());
            comd.Parameters.AddWithValue("@p1", RchAnnouncement.Text);
            comd.Parameters.AddWithValue("@p2", id);
            comd.ExecuteNonQuery();
            MessageBox.Show("Announcement Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cnt.connect().Close();
            List();
        }
    }
}
