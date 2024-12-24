using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VT_DonemSonuProje
{
    public partial class İlacEkle : Form
    {
        public İlacEkle()
        {
            InitializeComponent();
        }

        private void btnİlacKayit_Click(object sender, EventArgs e)
        {
            NpgsqlConnection baglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=finalproject;User Id=postgres;Password=Yakamoz.21;");

            baglantı.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglantı;

            komut_ekle.Parameters.AddWithValue("@ilacno",txtBarkodNo.Text);
            komut_ekle.Parameters.AddWithValue("@ilacadi", txtİlacAdi.Text);
            komut_ekle.Parameters.AddWithValue("@tipi", cmbİlacTipi.Text);


            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into ilaclar (barkodno, adi, tip) values (@ilacno, @ilacadi, @tipi)";
            _ = komut_ekle.ExecuteReader();

            komut_ekle.Dispose();
            baglantı.Close();

            MessageBox.Show("İlaç kayıt edildi." + DateTime.Now.ToShortDateString());
            this.Close();
        }

        private void btnİlacKayitGörüntüle_Click(object sender, EventArgs e)
        {
            İlacListesi ilacListesi = new İlacListesi();
            ilacListesi.Show();
        }
    }
}
