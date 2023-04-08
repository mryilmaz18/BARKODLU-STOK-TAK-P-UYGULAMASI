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
    public partial class Urun_Marka : Form
    {
        public Urun_Marka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1E1UBAU\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");
        bool durum;
        private void markakontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select* from Tbl_Marka", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (comboKategori.Text ==read["Kategori"].ToString() &&  textMarka.Text == read["Marka"].ToString() ||comboKategori.Text=="" || textMarka.Text == "")
                {
                    durum = false;
                }
            }

            baglanti.Close();
        }
        private void ButtonEkle_Click(object sender, EventArgs e)
        {
            markakontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_Marka(kategori,marka) values ('" + comboKategori.Text + "','" + textMarka.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Marka eklendi");
            }
            else
            {
                MessageBox.Show("Marka Kayıtlı Olabilir veya Boş Alan Bırakmayınız!");
            }

            comboKategori.Text = "";
            textMarka.Text = "";

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

        private void Ürün_Marka_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }
    }
}
