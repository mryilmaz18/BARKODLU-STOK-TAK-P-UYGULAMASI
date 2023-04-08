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
    public partial class Urun_Kategori : Form
    {
        public Urun_Kategori()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1E1UBAU\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");
        bool durum;
        private void kategorikontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select* from Tbl_Kategori", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textKategori.Text == read["Kategori"].ToString() || textKategori.Text == "")
                {
                    durum = false;
                }
            }
            
            baglanti.Close();
        }
        private void Ürün_Kategori_Load(object sender, EventArgs e)
        {

        }

        private void ButtonEkle_Click(object sender, EventArgs e)
        {
            kategorikontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_Kategori(kategori) values ('" + textKategori.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                textKategori.Text = "";
                MessageBox.Show("Kategori eklendi");

            }
            else
            {
                MessageBox.Show("Kategori Kayıtlı Olabilir veya Boş Alan Bırakmayınız!");
            }
            
        }
    }
}
