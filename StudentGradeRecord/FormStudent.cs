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
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        SqlConnect cnt = new SqlConnect();
        public string number;
        private void FormStudent_Load(object sender, EventArgs e)
        {
            LblNumber.Text = number;

            //Bringing name information by number
            SqlCommand comd = new SqlCommand("Select * From TblStudents where Number=@p1", cnt.connect());
            comd.Parameters.AddWithValue("@p1", number);
            SqlDataReader dr = comd.ExecuteReader();
            while (dr.Read())
            {
                LblNameSurname.Text = dr[2] + " " + dr[3];
                //pictureBox1.ImageLocation = dr[5].ToString();
            }
            cnt.connect().Close();

            //Note List
            //SqlCommand comd2 = new SqlCommand("Select * From TblNotes where StudentID=(Select ID From TblStudents Where Number=@p1)", cnt.connect());
            //comd2.Parameters.AddWithValue("@p1", LblNumber.Text);
            //SqlDataReader dr2 = comd2.ExecuteReader();
            //while (dr2.Read())
            //{
            //    LblExam1.Text = dr2[2].ToString();
            //    LblExam2.Text = dr2[3].ToString();
            //    LblExam3.Text = dr2[4].ToString();
            //    LblProject.Text = dr2[5].ToString();
            //    LblAverage.Text = dr2[6].ToString();
            //}
            //cnt.connect().Close();

            //if (Convert.ToDouble(LblAverage.Text) >= 50)
            //{
            //    LblStatus.Text = "Passed";
            //}
            //else
            //{
            //    LblStatus.Text = "Stayed";
            //}
        }

        //Student Form
        private void BtnMessages_Click(object sender, EventArgs e)
        {
            FormMessages frm = new FormMessages();
            frm.number = LblNumber.Text;
            frm.Show();
        }
        private void BtnAnnouncements_Click(object sender, EventArgs e)
        {
            FormAnnouncementList frm = new FormAnnouncementList();
            frm.Show();
        }
        private void BtnCalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.Exe");
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to quit?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
