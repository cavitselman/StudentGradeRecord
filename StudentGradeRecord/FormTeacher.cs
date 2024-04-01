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
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
        }

        public string number;
        SqlConnect cnt = new SqlConnect();

        //As a method, we write our student list codes.
        void StudentList()
        {
            SqlCommand comd = new SqlCommand("Select * From TblStudents", cnt.connect());
            SqlDataAdapter da = new SqlDataAdapter(comd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void NoteList()
        {
            //SqlCommand comd = new SqlCommand("Execute StudentID", cnt.connect());
            //SqlDataAdapter da = new SqlDataAdapter(comd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView2.DataSource = dt;
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            //Printing the number in the Label tool.
            LblNumber.Text = number;

            //Bringing name information by number.
            SqlCommand comd = new SqlCommand("Select * From TblTeachers where Number=@p1", cnt.connect());
            comd.Parameters.AddWithValue("@p1", number);
            SqlDataReader dr = comd.ExecuteReader();
            while (dr.Read())
            {
                LblNameSurname.Text = dr[3] + " " + dr[4];
            }
            cnt.connect().Close();

            //We call our method on Form Load.
            StudentList();

            //We call our second method on Form Load.
            NoteList();
        }

        string Fotograf;

        private void BtnPictureSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Fotograf = openFileDialog1.FileName;
            pictureBox1.ImageLocation = Fotograf;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand comd = new SqlCommand("insert into TblStudents (Name,Surname,Number,Password,Picture) values (@p1,@p2,@p3,@p4,@p5)", cnt.connect());
            comd.Parameters.AddWithValue("@p1", TxtName.Text);
            comd.Parameters.AddWithValue("@p2", TxtSurname.Text);
            comd.Parameters.AddWithValue("@p3", MskNumber.Text);
            comd.Parameters.AddWithValue("@p4", TxtPassword.Text);
            comd.Parameters.AddWithValue("@p5", pictureBox1);
            comd.ExecuteNonQuery();
            MessageBox.Show("Student Registered in the System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cnt.connect().Close();
            StudentList();
            NoteList();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            TxtName.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            MskNumber.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            TxtPassword.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[chosen].Cells[5].Value.ToString();

            SqlCommand comd = new SqlCommand("Select * From TblNotes where StudentID=(Select ID From TblStudents Where Number=@p1)", cnt.connect());
            comd.Parameters.AddWithValue("@p1", MskNumber.Text);
            SqlDataReader dr = comd.ExecuteReader();
            while (dr.Read())
            {
                TxtExam1.Text = dr[1].ToString();
                TxtExam2.Text = dr[2].ToString();
                TxtExam3.Text = dr[3].ToString();
                TxtProject.Text = dr[4].ToString();
                TxtAverage.Text = dr[5].ToString();
                TxtStatus.Text = dr[6].ToString();
            }
            cnt.connect().Close();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //Updating Student Information
            SqlCommand comd = new SqlCommand("update TblStudents set Name=@p1,Surname=@p2,Password=@p3,Picture=@p4 where Number=@p5", cnt.connect());
            comd.Parameters.AddWithValue("@p1", TxtName.Text);
            comd.Parameters.AddWithValue("@p2", TxtSurname.Text);
            comd.Parameters.AddWithValue("@p3", TxtPassword.Text);
            comd.Parameters.AddWithValue("@p4", Fotograf);
            comd.Parameters.AddWithValue("@p5", MskNumber.Text);
            comd.ExecuteNonQuery();
            cnt.connect().Close();

            //Update Grade Information
            SqlCommand comd2 = new SqlCommand("update TblNotes set Exam1=@p1,Exam2=@p2,Exam3=@p3,Project=@p4,Average=@p5,Status=@p6 where StudentID=(Select ID From TblStudents Where Number=@p7)", cnt.connect());
            comd2.Parameters.AddWithValue("@p1", TxtExam1.Text);
            comd2.Parameters.AddWithValue("@p2", TxtExam2.Text);
            comd2.Parameters.AddWithValue("@p3", TxtExam3.Text);
            comd2.Parameters.AddWithValue("@p4", TxtProject.Text);
            comd2.Parameters.AddWithValue("@p5", Convert.ToDecimal(TxtAverage.Text));
            comd2.Parameters.AddWithValue("@p6", TxtStatus.Text);
            comd2.Parameters.AddWithValue("@p7", MskNumber.Text);
            comd2.ExecuteNonQuery();
            MessageBox.Show("Student Information Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cnt.connect().Close();
            StudentList();
            NoteList();
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double Exam1, Exam2, Exam3, Project, Average;
            Exam1 = Convert.ToDouble(TxtExam1.Text);
            Exam2 = Convert.ToDouble(TxtExam2.Text);
            Exam3 = Convert.ToDouble(TxtExam3.Text);
            Project = Convert.ToDouble(TxtProject.Text);
            Average = (Exam1 + Exam2 + Exam3 + Project) / 4;
            TxtAverage.Text = Average.ToString();
            if (Average >= 50)
            {
                TxtStatus.Text = "True";
            }
            else
            {
                TxtStatus.Text = "False";
            }
        }
        private void BtnCreateAnnouncement_Click(object sender, EventArgs e)
        {
            FormCreateAnnouncement frm = new FormCreateAnnouncement();
            frm.Show();
        }
        private void BtnAnnouncementList_Click(object sender, EventArgs e)
        {
            FormAnnouncementList frm = new FormAnnouncementList();
            frm.Show();
        }
        private void BtnMessages_Click(object sender, EventArgs e)
        {
            FormMessages frm = new FormMessages();
            frm.number = LblNumber.Text;
            frm.Show();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
