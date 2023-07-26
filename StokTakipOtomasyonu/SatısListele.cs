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
    public partial class SatisListele : Form
    {
        public SatisListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1E1UBAU\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();

        private void satıslistele()
        {
            baglanti.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select *From Satıs1", baglanti);
            sda.Fill(daset, "Satıs1");
            dataGridView1.DataSource = daset.Tables["Satıs1"];
            baglanti.Close();

        }


        private void SatısListele_Load(object sender, EventArgs e)
        {
            satıslistele();
            satishesapla();
        }
        private void satishesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("Select Sum(ToplamAlısFiyat) from Satıs1", baglanti);
                textalıs.Text =komut1.ExecuteScalar() + "  TL";
                textalıs.Enabled = false;
                SqlCommand komut = new SqlCommand("Select Sum(ToplamSatısFiyat) from Satıs1", baglanti);
                textsatıs.Text =komut.ExecuteScalar() + "  TL";
                textsatıs.Enabled = false;
                SqlCommand komut2 = new SqlCommand("Select Sum(ToplamSatısFiyat) - Sum(ToplamAlısFiyat) from Satıs1 ", baglanti);
                textkar.Text = komut2.ExecuteScalar() + "  TL";
                textkar.Enabled = false;
                baglanti.Close();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void ButtonSatisSil_Click(object sender, EventArgs e)
        {
            if (!(dataGridView1.SelectedRows.Count > 0))
            {
                MessageBox.Show("silmek istediğiniz Satışı Seçiniz");
                return;
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Satıs1 where ID='" + dataGridView1.CurrentRow.Cells["ID"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satış Silindi");
            daset.Tables["Satıs1"].Clear();
            satıslistele();
            satishesapla();
        }

        private void textsatisAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select*From Satıs1 where BarkodNo like'%" + textsatisAra.Text + "%'or UrunAdı like'%" + textsatisAra.Text + "%'or AdSoyad like'%" + textsatisAra.Text + "%'or Tc like'%" + textsatisAra.Text + "%'or Telefon like'%" + textsatisAra.Text + "%'or Tarih like'%" + textsatisAra.Text + "%'", baglanti);
            sda.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonSatısIptal_Click(object sender, EventArgs e)
        {

        }

     
    }
}
