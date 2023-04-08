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
    public partial class Müsteri_Listeleme_Sayfası : Form
    {
        public Müsteri_Listeleme_Sayfası()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1E1UBAU\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");
        private void butonKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Tbl_Musteri set Ad_Soyad=@m2,Telefon=@m3,Adres=@m4,Email=@m5 where TC_Kimlik_No=@m1",baglanti);
            komut.Parameters.AddWithValue("@m2", textAdSoyad.Text);
            komut.Parameters.AddWithValue("@m3", maskedTel.Text);
            komut.Parameters.AddWithValue("@m4", textAdres.Text);
            komut.Parameters.AddWithValue("@m1", maskedTC.Text);
            komut.Parameters.AddWithValue("@m5", textEmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Listele
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Musteri",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            maskedTC.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textAdSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            maskedTel.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textAdres.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textEmail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void Müsteri_Listeleme_Sayfası_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Musteri", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Tbl_Musteri where TC_Kimlik_No=@m1",baglanti);
            komut.Parameters.AddWithValue("@m1", maskedTC.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //Listele
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Musteri",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textTCAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select*From Tbl_Musteri where TC_Kimlik_No like'%"+textTCAra.Text+ "%' or Ad_Soyad like'%" + textTCAra.Text + "%' or Telefon like'%" + textTCAra.Text + "%' or Email like'%" + textTCAra.Text + "%'or Adres like'%" + textTCAra.Text + "%'", baglanti);
            sda.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
    }
}
