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
    public partial class Urun_Listeleme : Form
    {
        public Urun_Listeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1E1UBAU\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
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
        private void Urun_Listeleme_Load(object sender, EventArgs e)
        {
            Urun_Liste();
            kategorigetir();
        }
        private void Urun_Liste()
        {
            baglanti.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select* from Tbl_Urunler", baglanti);
            sda.Fill(daset, "Tbl_Urunler");
            dataGridView1.DataSource = daset.Tables["Tbl_Urunler"];
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBarkod.Text = dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString();
            textKategori.Text = dataGridView1.CurrentRow.Cells["Kategori"].Value.ToString();
            textMarka.Text = dataGridView1.CurrentRow.Cells["Marka"].Value.ToString();
            textUrunAd.Text = dataGridView1.CurrentRow.Cells["UrunAdı"].Value.ToString();
            textUrunMıktar.Text = dataGridView1.CurrentRow.Cells["Miktar"].Value.ToString();
            textAlıs.Text = dataGridView1.CurrentRow.Cells["AlısFiyat"].Value.ToString();
            textSatıs.Text = dataGridView1.CurrentRow.Cells["SatısFiyat"].Value.ToString();

        }

        private void butonGuncelle_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Tbl_Urunler set UrunAdı=@u2,Miktar=@u3,AlısFiyat=@u4,SatısFiyat=@u5 where BarkodNo=@u1", baglanti);
            komut.Parameters.AddWithValue("@u1", textBarkod.Text);
            komut.Parameters.AddWithValue("@u2", textUrunAd.Text);
            komut.Parameters.AddWithValue("@u3", int.Parse(textUrunMıktar.Text));
            komut.Parameters.AddWithValue("@u4", double.Parse(textAlıs.Text));
            komut.Parameters.AddWithValue("@u5", double.Parse(textSatıs.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Tbl_Urunler"].Clear();
            Urun_Liste();
            MessageBox.Show("Ürün Kaydı Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach(Control item in this.bunifuGradientPanel1.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void butonGuncelle2_Click(object sender, EventArgs e)
        {
            if (textBarkod.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Tbl_Urunler set Kategori=@u2,Marka=@u3 where BarkodNo=@u1", baglanti);
                komut.Parameters.AddWithValue("@u1", textBarkod.Text);
                komut.Parameters.AddWithValue("@u2", comboKategori.Text);
                komut.Parameters.AddWithValue("@u3", comboMarka.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün Kategori&Marka Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                daset.Tables["Tbl_Urunler"].Clear();
                Urun_Liste();
            }
            else
            {
                MessageBox.Show("BarkodNo Yazınız");
            }
            
            foreach (Control item in this.bunifuGradientPanel1.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }

            }
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Marka where Kategori='" + comboKategori.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["Marka"].ToString());
            }
            baglanti.Close();
        }

        private void butonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Tbl_Urunler where BarkodNo='"+dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Tbl_Urunler"].Clear();
            Urun_Liste();
            MessageBox.Show("Ürün Kaydı Silindi");
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textTCAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select*From Tbl_Urunler where BarkodNo like'%" + textBarkodAra.Text + "%'or Kategori like'%" + textBarkodAra.Text + "%'or Marka like'%" + textBarkodAra.Text + "%'or UrunAdı like'%" + textBarkodAra.Text + "%'or Tarih like'%" + textBarkodAra.Text + "%'", baglanti);
            sda.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
