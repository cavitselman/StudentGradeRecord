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
    public partial class FormAnnouncementList : Form
    {
        public FormAnnouncementList()
        {
            InitializeComponent();
        }
        SqlConnect cnt = new SqlConnect();
        private void FormAnnouncementList_Load(object sender, EventArgs e)
        {
            ListBox lst = new ListBox();
            Point lstlocation = new Point(10, 10);
            lst.Name = "Listbox1";
            lst.Height = 250;
            lst.Width = 450;
            lst.Font = new Font("Georgia", 14, FontStyle.Regular);
            lst.Location = lstlocation;
            this.Controls.Add(lst);

            //Announcements Listing Codes
            SqlCommand comd = new SqlCommand("Select * From TblAnnouncements", cnt.connect());
            SqlDataReader dr = comd.ExecuteReader();
            while (dr.Read())
            {
                lst.Items.Add(dr[0] + " " + dr[1]);
            }
            cnt.connect().Close();
        }
    }
}
