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
using AForge.Video;
using ZXing;
using AForge.Video.DirectShow;



namespace StokTakipOtomasyonu
{
    public partial class Giris_Sayfası : Form
    {


        public Giris_Sayfası()
        {
            InitializeComponent();
        }

        FilterInfoCollection fico;
        VideoCaptureDevice vcd;

        void openForm(Form form)
        {
            this.Opacity = 0.7; 
            form.ShowDialog();
            this.Opacity = 1;
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            openForm(new Musteri_Ekleme_Sayfasi());
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            openForm(new Musteri_Listeleme_Sayfasi());
    
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            openForm(new Urun_Ekleme_Sayfasi());
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            openForm(new Urun_Marka());
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            openForm(new Urun_Kategori());
        }

        private void ButtonUrunListele_Click(object sender, EventArgs e)
        {
            openForm(new Urun_Listeleme());
        }


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1E1UBAU\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select *From Sepet", baglanti);
            sda.Fill(daset,"Sepet");
            dataGridView1.DataSource = daset.Tables["Sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            
            baglanti.Close();

        }
        private void Giriş_Sayfası_Load(object sender, EventArgs e)
        {
            sepetlistele();
            fico = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo f in fico)
            {
                comboKamera.Items.Add(f.Name);
                comboKamera.SelectedIndex = 0;
            }

        }


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
 

        private void textBarkod_TextChanged(object sender, EventArgs e)
        {
            textID.Text = "";
            textmarka.Text = "";
            textUrunAd.Text = "";
            textSatıs.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Urunler  where BarkodNo Like '" + textBarkod.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textmarka.Text = read["Marka"].ToString();
                textUrunAd.Text = read["UrunAdı"].ToString();
                textSatıs.Text = read["SatısFiyat"].ToString();
            }
            baglanti.Close();
        }

        private void Temizle()
        {
            if (textBarkod.Text == "")
            {
                foreach (Control item in groupUrun.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != textMiktar)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }

        private void textTc_TextChanged(object sender, EventArgs e)
        {
           
            textAdSoyad.Text = "";
            textKAD.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Musteri  Where TC_Kimlik_No Like '" + textTc.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textAdSoyad.Text = read["Ad_Soyad"].ToString();
                textKAD.Text = read["Telefon"].ToString();
            }
            baglanti.Close();
        }

        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Sepet", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBarkod.Text == read["BarkodNo"].ToString())
                {
                    durum = false;
                }
              

                


            }
            baglanti.Close();

        }
        private void ButtonEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textUrunAd.Text))
            {
                MessageBox.Show("Ürün seçiniz");
                return;
            }
            SqlCommand komut;
            bool varmi = false;
            baglanti.Open();
            komut = new SqlCommand("Select * From Tbl_Musteri  Where TC_Kimlik_No Like '" + textTc.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                varmi = true;
            }
            baglanti.Close();

            if (!varmi)
            {
                MessageBox.Show("Müşteri Bulunamadı");
                return;
            }


            barkodkontrol();
            

            if (durum ==true)
            {
                baglanti.Open();
                komut = new SqlCommand("insert into Sepet(Tc,AdSoyad,Telefon,BarkodNo,Marka,UrunAdı,Miktar,SatısFiyat,ToplamFiyat,Tarih) values (@u1,@u2,@u3,@u4,@u10,@u5,@u6,@u7,@u8,@u9)", baglanti);
                komut.Parameters.AddWithValue("@u1", textTc.Text);
                komut.Parameters.AddWithValue("@u2", textAdSoyad.Text);
                komut.Parameters.AddWithValue("@u3", textKAD.Text);
                komut.Parameters.AddWithValue("@u4", textBarkod.Text);
                komut.Parameters.AddWithValue("@u10", textmarka.Text);
                komut.Parameters.AddWithValue("@u5", textUrunAd.Text);
                komut.Parameters.AddWithValue("@u6", int.Parse(textMiktar.Text));
                komut.Parameters.AddWithValue("@u7", double.Parse(textSatıs.Text));
                komut.Parameters.AddWithValue("@u8", double.Parse(textToplam.Text));
                komut.Parameters.AddWithValue("@u9", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close(); 
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("Update Sepet set Miktar=Miktar+'" + int.Parse(textMiktar.Text) + "'Where BarkodNo='" + textBarkod.Text + "'", baglanti);
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("Update Sepet set ToplamFiyat=Miktar*SatısFiyat Where BarkodNo='" + textBarkod.Text + "'", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            
            textMiktar.Text = "1";
            daset.Tables["Sepet"].Clear();
            sepetlistele();
            hesapla();
            foreach (Control item in groupUrun.Controls)
            {
                if (item is TextBox)
                {
                    if (item != textMiktar)
                    {
                        item.Text = "";
                    }
                }
            }

            button1.PerformClick();
        }

        private void textMiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textToplam.Text = (double.Parse(textMiktar.Text) * double.Parse(textSatıs.Text)).ToString();
            }
            catch(Exception)
            {
                ;
            }
        }

        private void textSatıs_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textToplam.Text = (double.Parse(textMiktar.Text) * double.Parse(textSatıs.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void ButtonSıl_Click(object sender, EventArgs e)
        {
            if (!(dataGridView1.SelectedRows.Count > 0))
            {
                MessageBox.Show("silmek istediğiniz Sipariş Seçiniz");
                return;
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Sepet where BarkodNo='"+dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString()+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sepetteki Ürün Silindi");
            daset.Tables["Sepet"].Clear();
            sepetlistele();
            hesapla();

        }

        private void ButtonSatısIptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Sepet", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sepetteki Ürünler Silindi");
            daset.Tables["Sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void ButtonSatıslarıLıstele_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.7;
            SatisListele listele = new SatisListele();
            listele.ShowDialog();
            this.Opacity = 1;
        }

        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select Sum(ToplamFiyat) from sepet", baglanti);
                LabelGenelToplam.Text = "GENEL TOPLAM    "+komut.ExecuteScalar() + "  TL";
                baglanti.Close();
            }
            catch(Exception)
            {
                ;
            }
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelGenelToplam_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSatısYap_Click(object sender, EventArgs e)
        {
            for(int i= 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                baglanti.Open();
                SqlCommand komut= new SqlCommand("insert into Satıs(Tc,AdSoyad,Telefon,BarkodNo,UrunAdı,Miktar,SatısFiyat,ToplamFiyat,Tarih) values (@u1,@u2,@u3,@u4,@u5,@u6,@u7,@u8,@u9)", baglanti);
                komut.Parameters.AddWithValue("@u1", textTc.Text);
                komut.Parameters.AddWithValue("@u2", textAdSoyad.Text);
                komut.Parameters.AddWithValue("@u3", textKAD.Text);
                komut.Parameters.AddWithValue("@u4", dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString());
                komut.Parameters.AddWithValue("@u5", dataGridView1.Rows[i].Cells["UrunAdı"].Value.ToString());
                komut.Parameters.AddWithValue("@u6", int.Parse(dataGridView1.Rows[i].Cells["Miktar"].Value.ToString()));
                komut.Parameters.AddWithValue("@u7", double.Parse(dataGridView1.Rows[i].Cells["SatısFiyat"].Value.ToString()));
                komut.Parameters.AddWithValue("@u8", double.Parse(dataGridView1.Rows[i].Cells["ToplamFiyat"].Value.ToString()));
                komut.Parameters.AddWithValue("@u9", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("Update Tbl_Urunler set Miktar=Miktar-'" + int.Parse(dataGridView1.Rows[i].Cells["Miktar"].Value.ToString()) + "' where BarkodNo='" + dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Delete From Sepet",baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fico[comboKamera.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer1.Start();
            
            
            
            
            textBarkod.Text = "";
            textBarkod.Focus();

            
        }

        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader brd = new BarcodeReader();
                Result sonuc = brd.Decode((Bitmap)pictureBox1.Image);
                if (sonuc != null)
                {
                    textBarkod.Text = sonuc.ToString();
                    timer1.Stop();

                }
                return;
            }
        }

        private void textTc_DoubleClick(object sender, EventArgs e)
        {
            openForm(new Musteri_Listeleme_Sayfasi());
        }
    }
}
