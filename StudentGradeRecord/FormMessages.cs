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
    public partial class FormMessages : Form
    {
        public FormMessages()
        {
            InitializeComponent();
        }

        SqlConnect cnt = new SqlConnect();

        void IncomingMessages()
        {
            SqlCommand comd = new SqlCommand("Select * From TblMessages Where Receiver=@p1", cnt.connect());
            comd.Parameters.AddWithValue("@p1", number);
            SqlDataAdapter da = new SqlDataAdapter(comd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void OutgoingMessages()
        {
            SqlCommand comd = new SqlCommand("Select * From TblMessages Where Sender=@p1", cnt.connect());
            comd.Parameters.AddWithValue("@p1", number);
            SqlDataAdapter da = new SqlDataAdapter(comd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        //Messages Form
        public string number;
        private void FormMessages_Load(object sender, EventArgs e)
        {
            MskSender.Text = number;

            IncomingMessages();

            OutgoingMessages();
        }
        private void BtnSend_Click(object sender, EventArgs e)
        {
            SqlCommand comd = new SqlCommand("insert into TblMessages (Sender,Receiver,Title,Message) values (@p1,@p2,@p3,@p4)", cnt.connect());
            comd.Parameters.AddWithValue("@p1", MskSender.Text);
            comd.Parameters.AddWithValue("@p2", MskReceiver.Text);
            comd.Parameters.AddWithValue("@p3", TxtSubject.Text);
            comd.Parameters.AddWithValue("@p4", RchMessage.Text);
            comd.ExecuteNonQuery();
            MessageBox.Show("Your Message Has Been Delivered...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cnt.connect().Close();
            IncomingMessages();
            OutgoingMessages();
        }
    }
}
