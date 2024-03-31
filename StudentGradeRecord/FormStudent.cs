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
        public string numara;
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            LblNumara.Text = numara;

            //Numaryaa göre isim bilgisi getirme
            SqlCommand komut = new SqlCommand("Select * From TblStudents where Number=@p1", cnt.connect());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[1] + " " + dr[2];
                pictureBox1.ImageLocation = dr[5].ToString();
            }
            cnt.connect().Close();

            //Not Listesi
            SqlCommand komut2 = new SqlCommand("Select * From TblNotes where StudentID=(Select ID From TblStudents Where Number=@p1)", cnt.connect());
            komut2.Parameters.AddWithValue("@p1", LblNumara.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblSınav1.Text = dr2[1].ToString();
                LblSınav2.Text = dr2[2].ToString();
                LblSınav3.Text = dr2[3].ToString();
                LblProje.Text = dr2[4].ToString();
                LblOrtalama.Text = dr2[5].ToString();
            }
            cnt.connect().Close();

            if (Convert.ToDouble(LblOrtalama.Text) >= 50)
            {
                LblDurum.Text = "Geçti";
            }
            else
            {
                LblDurum.Text = "Kaldı";
            }
        }

        //öğrenci formu
        private void BtnMesajlar_Click(object sender, EventArgs e)
        {
            FormMessages frm = new FormMessages();
            frm.numara = LblNumara.Text;
            frm.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FormAnnouncementList frm = new FormAnnouncementList();
            frm.Show();
        }

        private void BtnHesapMakinesi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.Exe");
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Gerçekten Kaptmak İstiyor Musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();

            }
        }
    }
}
