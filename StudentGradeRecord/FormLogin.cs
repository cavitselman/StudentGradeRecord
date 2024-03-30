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
        private void BtnOgretmenGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From TblOgretmen where Numara=@p1 and Sıfre=@p2", cnt.connect());
            komut.Parameters.AddWithValue("@p1", MskOgretmenNumara.Text);
            komut.Parameters.AddWithValue("@p2", TxtOgretmenSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FormTeacher frm = new FormTeacher();
                frm.numara = MskOgretmenNumara.Text;
                frm.Show();
                MessageBox.Show("Sisteme Hoş Geldiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Numara ya da Şifre", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cnt.connect().Close();
        }

        private void BtnOgrenciGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From TblOgrenci where Numara=@p1 and Sıfre=@p2", cnt.connect());
            komut.Parameters.AddWithValue("@p1", MskOgrenciNumara.Text);
            komut.Parameters.AddWithValue("@p2", TxtOGrenciSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FormStudent frm = new FormStudent();
                frm.numara = MskOgrenciNumara.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Numara ya da Şifre", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cnt.connect().Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtOgretmenSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void MskOgretmenNumara_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TxtOGrenciSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void MskOgrenciNumara_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

    }
}
