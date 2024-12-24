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
    public partial class Muayene : Form
    {
        public Muayene()
        {
            InitializeComponent();
        }
        public static string Data;

        private void btnMuayeneKayitlariniGoruntule_Click(object sender, EventArgs e)
        {
            MuayeneListele muayeneListele = new MuayeneListele();
            muayeneListele.Show();
        }

        private void btnReceteYaz_Click(object sender, EventArgs e)
        {
            Recete recete = new Recete();
            recete.Show();
        }

        private void btnMuayeneKaydiniOlustur_Click(object sender, EventArgs e)
        {
            bool primaryKeyExists = false;
            string number = Recete.data;


            NpgsqlConnection bireyselbaglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=finalproject;User Id=postgres;Password=Yakamoz.21;");
            bireyselbaglantı.Open();


            NpgsqlCommand komut_oku = new NpgsqlCommand("SELECT * FROM muayene", bireyselbaglantı);

            using (NpgsqlDataReader reader = komut_oku.ExecuteReader())
            {
                while (reader.Read())
                {

                    long hastatc = reader.GetInt64(0);
                    if (hastatc == Convert.ToInt64(txtHastaTC.Text))
                    {
                        primaryKeyExists = true;
                        break;
                    }
                }
            }


            if (primaryKeyExists)
            {
                MessageBox.Show("Hastanın Mevcut Randevusu Görüntülendi.");
                this.Close();
            }
            else
            {


                NpgsqlCommand cmdEkle = new NpgsqlCommand();
                cmdEkle.Connection = bireyselbaglantı;

                if (number == null)
                {
                    cmdEkle.Parameters.AddWithValue("@recete", "ReceteYok");
                }
                else
                {
                    cmdEkle.Parameters.AddWithValue("@recete", number);
                }

                cmdEkle.Parameters.AddWithValue("@tc", txtHastaTC.Text);
                cmdEkle.Parameters.AddWithValue("@sikayeti", txtHastaSikayet.Text);
                cmdEkle.Parameters.AddWithValue("@tani", txtTani.Text);
                ;
                cmdEkle.Parameters.AddWithValue("@tarih", DateTime.Now.ToShortDateString());

                cmdEkle.CommandType = CommandType.Text;
                cmdEkle.CommandText = "insert into muayanedefteri (hastatc, sikayet, tanı, recetekodu, tarih) values (@tc, @sikayeti, @tani, @recete, @tarih)";
                _ = cmdEkle.ExecuteReader();
                cmdEkle.Dispose();
            }


            bireyselbaglantı.Close();
            this.Close();


        
        }

        private void Muayene_Load(object sender, EventArgs e)
        {
          
        }
    }
}
