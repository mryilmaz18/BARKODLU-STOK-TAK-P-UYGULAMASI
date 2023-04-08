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
    public partial class Kullanıcı_Girisi : Form
    {
        public Kullanıcı_Girisi()
        {
            InitializeComponent();
           
        }

        void girisYap()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kullanıcı where KullanıcıAd=@k1 and Sifre=@k2", baglanti);
            komut.Parameters.AddWithValue("@k1", KullanıcıAdı.Text);
            komut.Parameters.AddWithValue("@k2", Parola.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Giris_Sayfası frm = new Giris_Sayfası();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            baglanti.Close();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1E1UBAU\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");
        private void GirisYap_Click_1(object sender, EventArgs e)
        {
            girisYap();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kullanici_Kayit fr = new Kullanici_Kayit();
            fr.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region TXT
        private void KullanıcıAdı_Enter(object sender, EventArgs e)
        {
            if (KullanıcıAdı.Text == "Kullanıcı Adınızı Giriniz")
                KullanıcıAdı.Text = "";
        }

        private void KullanıcıAdı_Leave(object sender, EventArgs e)
        {
            if (KullanıcıAdı.Text == "")
                KullanıcıAdı.Text = "Kullanıcı Adınızı Giriniz";
        }

        private void Parola_Enter(object sender, EventArgs e)
        {
            if (Parola.Text == "Parolanız")
                Parola.Text = "";
        }

        private void Parola_Leave(object sender, EventArgs e)
        {
            if (Parola.Text == "")
                Parola.Text = "Parolanız";
        }
        #endregion

        private void Parola_KeyPress(object sender, KeyPressEventArgs e)
        {
           
           
        }

        private void Parola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                girisYap();
            }
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void Parola_OnValueChanged(object sender, EventArgs e)
        {
            Parola.isPassword = true;
        }

        private void Kullanıcı_Girişi_Load(object sender, EventArgs e)
        {

        }
    }
}

