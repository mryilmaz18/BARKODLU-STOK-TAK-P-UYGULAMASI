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
    public partial class Urun_Ekleme_Sayfasi : Form
    {
        public Urun_Ekleme_Sayfasi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1E1UBAU\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select* from Tbl_Urunler", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBarkod.Text == read["BarkodNo"].ToString() || textBarkod.Text =="")
                {
                    durum = false;
                }
            }

            baglanti.Close();
        }
        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Kategori", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["Kategori"].ToString());
            }
            baglanti.Close();
        }
        private void Ürün_Ekleme_Sayfası_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Marka where Kategori='"+comboKategori.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["Marka"].ToString());
            }
            baglanti.Close();
        }

        private void ButtonEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if(durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_Urunler(BarkodNo,Kategori,Marka,UrunAdı,Miktar,AlısFiyat,SatısFiyat,Tarih) values (@u1,@u2,@u3,@u4,@u5,@u6,@u7,@u8)", baglanti);
                komut.Parameters.AddWithValue("@u1", textBarkod.Text);
                komut.Parameters.AddWithValue("@u2", comboKategori.Text);
                komut.Parameters.AddWithValue("@u3", comboMarka.Text);
                komut.Parameters.AddWithValue("@u4", textUrunAd.Text);
                komut.Parameters.AddWithValue("@u5", int.Parse(textUrunMıktar.Text));
                komut.Parameters.AddWithValue("@u6", double.Parse(textAlıs.Text));
                komut.Parameters.AddWithValue("@u7", double.Parse(textSatıs.Text));
                komut.Parameters.AddWithValue("@u8", DateTime.Now.ToString());

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yeni Ürün Kaydedildi");
            }
            else
            {
                MessageBox.Show("Ürün Kayıtlı Olabilir veya Boş Alan Bırakmayınız!");
            }
            
            
            comboMarka.Items.Clear();
            foreach (Control item in groupUrun.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void textBarkod2_TextChanged(object sender, EventArgs e)
        {
            if (textBarkod2.Text=="")
            {
                labelMiktar.Text = "";
                foreach(Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tbl_Urunler where BarkodNo like'"+textBarkod2.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                
                textKategori.Text = read["Kategori"].ToString();
                textMarka.Text = read["Marka"].ToString();
                textUrunAd2.Text = read["UrunAdı"].ToString();
                labelMiktar.Text = read["Miktar"].ToString();
                textAlıs2.Text = read["AlısFiyat"].ToString();
                textSatıs2.Text = read["SatısFiyat"].ToString();
            }
           
            baglanti.Close();
        }

        private void ButtonEkle2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Tbl_Urunler set Miktar=Miktar+'"+int.Parse(textUrunMıktar2.Text)+"' where BarkodNo='"+textBarkod2.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Var Olan Ürüne Ekleme Yapıldı");
        }
    }
}
