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

namespace StokTakipOtomasyonu
{
    public partial class Kullanici_Kayit : Form
    {
        public Kullanici_Kayit()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1E1UBAU\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");
        bool durum;

        private void kullanıcıkontrol()
        {
            if (txtTC.Text.Length != 11)
            {
                MessageBox.Show("TC Numarası 11 karakter olmak zorundadır");
                return;
            }
            durum = true;
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select* from Tbl_Kullanıcı", baglanti);
            SqlDataReader read = komut2.ExecuteReader();
            while (read.Read())
            {

                if (txtTC.Text == read["KullanıcıTC"].ToString() || string.IsNullOrEmpty(txtTC.Text.Trim()) )
                {
                    durum = false;
                }
                if (txtAdSoyad.Text == "Ad Soyad Giriniz" || txtAdSoyad.Text == read["AdSoyad"].ToString() || string.IsNullOrEmpty(txtAdSoyad.Text.Trim()))
                {
                    durum = false;
                }
                if (txtKullanıcıAd.Text == "Kullanıcı Adı Giriniz" || txtKullanıcıAd.Text == read["KullanıcıAd"].ToString() || string.IsNullOrEmpty(txtKullanıcıAd.Text.Trim()))
                {
                    durum = false;
                }
                if (txtParola.Text == "Parola Giriniz" || string.IsNullOrEmpty(txtParola.Text.Trim()))
                {
                    durum = false;
                }

            }

            baglanti.Close();
        }

        void Save()
        {
            kullanıcıkontrol();
            if (durum == true)
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_Kullanıcı (AdSoyad,KullanıcıTC,KullanıcıAd,Sifre) values (@k1,@k2,@k3,@k4)", baglanti);
                komut.Parameters.AddWithValue("@k1", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@k2", txtTC.Text);
                komut.Parameters.AddWithValue("@k3", txtKullanıcıAd.Text);
                komut.Parameters.AddWithValue("@k4", txtParola.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                txtAdSoyad.Text = "";
                txtTC.Text = "";
                txtKullanıcıAd.Text = "";
                txtParola.Text = "";
                MessageBox.Show("Kaydınız gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Kullanıcı_Girisi kg = new Kullanıcı_Girisi();
                kg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Kayıtlı veya Boş Alan Bırakmayınız!");
            }

        }
        private void GirisYap_Click(object sender, EventArgs e)
        {
            Save();
            



        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAdSoyad_Leave(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == "")
            {
                txtAdSoyad.Text = "Ad Soyad Giriniz";
                txtAdSoyad.ForeColor = Color.DarkGray;

            }
            else
            {

                txtAdSoyad.ForeColor = Color.Teal;

            }

        }

        private void txtTC_Leave(object sender, EventArgs e)
        {
            if (txtTC.Text == "")
            {
                txtTC.Text = "Tc Giriniz";
                txtTC.ForeColor = Color.DarkGray;
            }
            else
            {
                txtTC.ForeColor = Color.Teal;
            } 
                
        }

        private void txtKullanıcıAd_Leave(object sender, EventArgs e)
        {
            if (txtKullanıcıAd.Text == "")
            {
                txtKullanıcıAd.Text = "Kullanıcı Adı Giriniz";
                txtKullanıcıAd.ForeColor = Color.DarkGray;
            }
            else
            {
                txtKullanıcıAd.ForeColor = Color.Teal;
            }

        }

        private void txtParola_Leave(object sender, EventArgs e)
        {
            if (txtParola.Text == "")
            {
                txtParola.Text = "Parola Giriniz";
                txtParola.ForeColor = Color.DarkGray;
            }
            else
            {
                txtParola.ForeColor = Color.Teal;
            }


        }

        private void txtAdSoyad_Enter(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text.Equals("Ad Soyad Giriniz"))
                txtAdSoyad.Text = "";
        }

        private void txtTC_Enter(object sender, EventArgs e)
        {
            if (txtTC.Text.Equals("Tc Giriniz"))
                txtTC.Text = "";
        }

        private void txtKullanıcıAd_Enter(object sender, EventArgs e)
        {
            if (txtKullanıcıAd.Text.Equals("Kullanıcı Adı Giriniz"))
                txtKullanıcıAd.Text = "";
        }

        private void txtParola_Enter(object sender, EventArgs e)
        {
            if (txtParola.Text.Equals("Parola Giriniz"))
                txtParola.Text = "";
        }

        private void txtParola_OnValueChanged(object sender, EventArgs e)
        {
            txtParola.isPassword = true;
        }

        private void Kullanıcı_Kayıt_Load(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void GirisYap_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtParola_KeyDown(object sender, KeyEventArgs e)
        {
       
            if (e.KeyCode == Keys.Enter)
            {
                // kullanıcıadı boş oldugunda kayddiyor farkettım hocam 
                Save(); // tamamödır sagolaun hocam musterı bos kaydetmeyı de yapacaktım smdı kullanıcı kayıtlı ıse ve bos alan oldugunda kaydetmıyor onu hallettım
            }
        }

        private void txtParola_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }


        // BOş bilgi kontrolü => validation (kullanıcıKayit, musteriEkleme)
        // tc 11 karakter kontrolü
        // girilen kullanıcı adaı veritabanında var ise uyarı
        // kaydettikten sonra giriş sayfasına gteri dön
        // şifre textbox'u içinde entera basınca giriş yap
    }
}
