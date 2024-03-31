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

        void GelenMesajlar()
        {
            SqlCommand komut = new SqlCommand("Select * From TblMessages Where Receiver=@p1", cnt.connect());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void GidenMesajlar()
        {
            SqlCommand komut = new SqlCommand("Select * From TblMessages Where Sender=@p1", cnt.connect());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        //Mesajlar Formu
        public string numara;

        private void FrmMesjalar_Load(object sender, EventArgs e)
        {
            MskGonderen.Text = numara;

            GelenMesajlar();

            GidenMesajlar();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblMessages (Sender,Receiver,Title,Message) values (@p1,@p2,@p3,@p4)", cnt.connect());
            komut.Parameters.AddWithValue("@p1", MskGonderen.Text);
            komut.Parameters.AddWithValue("@p2", MskAlıcı.Text);
            komut.Parameters.AddWithValue("@p3", TxtKonu.Text);
            komut.Parameters.AddWithValue("@p4", RchMesaj.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Mesajınız İletildi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cnt.connect().Close();
            GelenMesajlar();
            GidenMesajlar();
        }
    }
}
