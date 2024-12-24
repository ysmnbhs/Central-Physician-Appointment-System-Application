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
    public partial class HastaKayit : Form
    {
        public HastaKayit()
        {
            InitializeComponent();
        }

        private void btnHastaKaydıOlustur_Click(object sender, EventArgs e)
        {
            NpgsqlConnection baglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=finalproject;User Id=postgres;Password=Yakamoz.21;");

            baglantı.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglantı;

            komut_ekle.Parameters.AddWithValue("@tc",txtTC);
            komut_ekle.Parameters.AddWithValue("@ad", txtNewHastaAdi.Text);
            komut_ekle.Parameters.AddWithValue("@soyad", txtNewHastaSoyadi.Text);
            komut_ekle.Parameters.AddWithValue("@dogumyeri", txtNewHastaDYeri.Text);
            komut_ekle.Parameters.AddWithValue("@dogumtarihi", txtNewHastaDTarihi.Text);
            komut_ekle.Parameters.AddWithValue("@medenidurum", cmbMedeniHali.Text);
            komut_ekle.Parameters.AddWithValue("@adres", txtNewHastaAdres.Text);
            komut_ekle.Parameters.AddWithValue("@telefon",txtNewHastaTelefon);
            komut_ekle.Parameters.AddWithValue("@kayittarihi", DateTime.Now);

            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into hasta (tc, ad, soyadı, dogumyeri, dogumtarihi, medenidurumu, adres, telefon, tarih) values (@tc, @ad, @soyad, @dogumyeri, @dogumtarihi, @medenidurum, @adres, @telefon, @kayittarihi)";
            _ = komut_ekle.ExecuteReader();

            komut_ekle.Dispose();
            baglantı.Close();

            MessageBox.Show("Hasta kayıt edildi." + DateTime.Now);
            this.Close();
        }

        private void btnHastaKaydiGörüntüle_Click(object sender, EventArgs e)
        {
            HastaListesi hastaListesi=new HastaListesi();
            hastaListesi.Show();

        }
    }
}
