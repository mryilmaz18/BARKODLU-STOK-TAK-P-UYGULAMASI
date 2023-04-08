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
    public partial class SatısListele : Form
    {
        public SatısListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1E1UBAU\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();

        private void satıslistele()
        {
            baglanti.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select *From Satıs", baglanti);
            sda.Fill(daset, "Satıs");
            dataGridView1.DataSource = daset.Tables["Satıs"];
            baglanti.Close();

        }

        private void SatısListele_Load(object sender, EventArgs e)
        {
            satıslistele();
        }

        private void ButtonSatisSil_Click(object sender, EventArgs e)
        {
            if (!(dataGridView1.SelectedRows.Count > 0))
            {
                MessageBox.Show("silmek istediğiniz Satışı Seçiniz");
                return;
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Satıs where ID='" + dataGridView1.CurrentRow.Cells["ID"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satış Silindi");
            daset.Tables["Satıs"].Clear();
            satıslistele();
        }
    }
}
