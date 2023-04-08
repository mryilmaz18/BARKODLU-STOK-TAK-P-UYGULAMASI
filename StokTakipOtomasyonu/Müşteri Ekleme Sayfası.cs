using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokTakipOtomasyonu
{
    public partial class Müşteri_Ekleme_Sayfası : Form
    {
        public Müşteri_Ekleme_Sayfası()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1E1UBAU\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");
        bool durum;
        void temizle()
        {
            maskedTC.Text = "";
            textAdSoyad.Text = "";
            maskedTel.Text = "";
            textAdres.Text = "";
            textEmail.Text = "";
            maskedTC.Focus();
        }
        private void Müşteri_Ekleme_Sayfası_Load(object sender, EventArgs e)
        {

        }

        private void musterikontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select* from Tbl_Musteri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (maskedTC.Text == read["TC_Kimlik_No"].ToString() || string.IsNullOrEmpty(maskedTC.Text.Trim()))
                {
                    durum = false;
                }
                if (string.IsNullOrEmpty(textAdSoyad.Text.Trim()))
                {
                    durum = false;
                }
                if (maskedTel.Text == read["Telefon"].ToString() || string.IsNullOrEmpty(maskedTel.Text.Trim()))
                {
                    durum = false;
                }
                if (string.IsNullOrEmpty(textAdres.Text.Trim()))
                {
                    durum = false;
                }

                if (textEmail.Text == read["Email"].ToString() || string.IsNullOrEmpty(textEmail.Text.Trim()))
                {
                    durum = false;
                }


            }
            baglanti.Close();
        }
        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            musterikontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_Musteri (TC_Kimlik_No,Ad_Soyad,Telefon,Adres,Email) values (@m1,@m2,@m3,@m4,@m5)", baglanti);
                komut.Parameters.AddWithValue("@m1", maskedTC.Text);
                komut.Parameters.AddWithValue("@m2", textAdSoyad.Text);
                komut.Parameters.AddWithValue("@m3", maskedTel.Text);
                komut.Parameters.AddWithValue("@m4", textAdres.Text);
                komut.Parameters.AddWithValue("@m5", textEmail.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri Kaydı Gerçekleşti");
                temizle();
            }
            else
            {
                MessageBox.Show("Müşteri Kayıtlı veya Boş Alan Bırakmayınız!");
            }




        }
    }
}
