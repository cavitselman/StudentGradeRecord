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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        SqlConnect cnt = new SqlConnect();
        private void BtnTeacherLogin_Click(object sender, EventArgs e)
        {
            SqlCommand comd = new SqlCommand("Select * From TblTeachers where Number=@p1 and Password=@p2", cnt.connect());
            comd.Parameters.AddWithValue("@p1", MskTeacherNumber.Text);
            comd.Parameters.AddWithValue("@p2", TxtTeacherPassword.Text);
            SqlDataReader dr = comd.ExecuteReader();
            if (dr.Read())
            {
                FormTeacher frm = new FormTeacher();
                frm.number = MskTeacherNumber.Text;
                frm.Show();
                MessageBox.Show("Welcome to the System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Number or Password", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cnt.connect().Close();
        }
        private void BtnStudentLogin_Click(object sender, EventArgs e)
        {
            SqlCommand comd = new SqlCommand("Select * From TblStudents where Number=@p1 and Password=@p2", cnt.connect());
            comd.Parameters.AddWithValue("@p1", MskStudentNumber.Text);
            comd.Parameters.AddWithValue("@p2", TxtStudentPassword.Text);
            SqlDataReader dr = comd.ExecuteReader();
            if (dr.Read())
            {
                FormStudent frm = new FormStudent();
                frm.number = MskStudentNumber.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Number or Password", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cnt.connect().Close();
        }                
    }
}
