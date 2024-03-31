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

        public string numara;
        SqlConnect cnt = new SqlConnect();

        //Metot olarak öğrenci listesi kodlarımızı yazıyoruz.
        void OgrenciListesi()
        {
            SqlCommand komut = new SqlCommand("Select * From TblStudents", cnt.connect());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void NotListesi()
        {
            SqlCommand komut = new SqlCommand("Execute Ogrenciler", cnt.connect());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
            //Numarayı Label aracına yazdırma.
            LblNumara.Text = numara;

            //Numaryaa göre isim bilgisi getirme
            SqlCommand komut = new SqlCommand("Select * From TblTeachers where Number=@p1", cnt.connect());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[1] + " " + dr[2];
            }
            cnt.connect().Close();

            //Form Loadda metodumuzu çağırıyoruz.
            OgrenciListesi();

            //Form Loadda 2.metodumuzu çağırıyoruz.
            NotListesi();
        }
        string Fotograf;
        private void BtnFotografSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Fotograf = openFileDialog1.FileName;
            pictureBox1.ImageLocation = Fotograf;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblStudents (Name,Surname,Number,Password,Picture) values (@p1,@p2,@p3,@p4,@p5)", cnt.connect());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskNumara.Text);
            komut.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p5", Fotograf);
            komut.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cnt.connect().Close();
            OgrenciListesi();
            NotListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskNumara.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            SqlCommand komut = new SqlCommand("Select * From TblNotes where StudentID=(Select ID From TblStudents Where Number=@p1)", cnt.connect());
            komut.Parameters.AddWithValue("@p1", MskNumara.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtSınav1.Text = dr[1].ToString();
                TxtSınav2.Text = dr[2].ToString();
                TxtSınav3.Text = dr[3].ToString();
                TxtProje.Text = dr[4].ToString();
                TxtOrtalama.Text = dr[5].ToString();
                TxtDurum.Text = dr[6].ToString();
            }
            cnt.connect().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //Öğrenci Bilgilerini Güncelleme
            SqlCommand komut = new SqlCommand("update TblStudents set Name=@p1,Surname=@p2,Password=@p3,Picture=@p4 where Number=@p5", cnt.connect());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p4", Fotograf);
            komut.Parameters.AddWithValue("@p5", MskNumara.Text);
            komut.ExecuteNonQuery();
            cnt.connect().Close();

            //Not Bilgilerini Güncelleme
            SqlCommand komut2 = new SqlCommand("update TblNotes set Exam1=@p1,Exam2=@p2,Exam3=@p3,Project=@p4,Average=@p5,Status=@p6 where StudentID=(Select ID From TblStudents Where Number=@p7)", cnt.connect());
            komut2.Parameters.AddWithValue("@p1", TxtSınav1.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSınav2.Text);
            komut2.Parameters.AddWithValue("@p3", TxtSınav3.Text);
            komut2.Parameters.AddWithValue("@p4", TxtProje.Text);
            komut2.Parameters.AddWithValue("@p5", Convert.ToDecimal(TxtOrtalama.Text));
            komut2.Parameters.AddWithValue("@p6", TxtDurum.Text);
            komut2.Parameters.AddWithValue("@p7", MskNumara.Text);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cnt.connect().Close();
            OgrenciListesi();
            NotListesi();

        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            double Exam1, Exam2, Exam3, Project, Average;
            Exam1 = Convert.ToDouble(TxtSınav1.Text);
            Exam2 = Convert.ToDouble(TxtSınav2.Text);
            Exam3 = Convert.ToDouble(TxtSınav3.Text);
            Project = Convert.ToDouble(TxtProje.Text);
            Average = (Exam1 + Exam2 + Exam3 + Project) / 4;
            TxtOrtalama.Text = Average.ToString();
            if (Average >= 50)
            {
                TxtDurum.Text = "True";
            }
            else
            {
                TxtDurum.Text = "False";
            }
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            FormCreateAnnouncement frm = new FormCreateAnnouncement();
            frm.Show();
        }

        private void BtnDuyuruListesi_Click(object sender, EventArgs e)
        {
            FormAnnouncementList frm = new FormAnnouncementList();
            frm.Show();
        }

        private void BtnMesajlar_Click(object sender, EventArgs e)
        {
            FormMessages frm = new FormMessages();
            frm.numara = LblNumara.Text;
            frm.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
