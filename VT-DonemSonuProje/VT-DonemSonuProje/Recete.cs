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
    public partial class Recete : Form
    {
        string number = Muayene.Data;
        public Recete()
        {
            InitializeComponent();
        }
        public static string data;
        private void btnReceteOlustur_Click(object sender, EventArgs e)
        {
            string textBox1Value = txtilac1.Text;
            string textBox2Value = txtilac2.Text;
            string textBox3Value = txtilac3.Text;
            string textBox4Value = txtilac4.Text;
            string textBox5Value = txtilac5.Text;

            NpgsqlConnection bireyselbaglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=finalproject;User Id=postgres;Password=Yakamoz.21;");

            List<int> nolar = new List<int>();
            Random rst = new Random();
            int rstsayi = rst.Next();
            if (!nolar.Contains(rstsayi))
                nolar.Add(rstsayi);


            string recetekod = rstsayi.ToString();

            data = recetekod;
           Muayene muayene=new Muayene();   

            bireyselbaglantı.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = bireyselbaglantı;


            if (textBox1Value != textBox2Value && textBox1Value != textBox3Value && textBox1Value != textBox4Value && textBox1Value != textBox5Value
                 && textBox2Value != textBox3Value && textBox2Value != textBox4Value && textBox2Value != textBox5Value
                 && textBox3Value != textBox4Value && textBox3Value != textBox5Value
                 && textBox4Value != textBox5Value)
            {
                komut_ekle.Parameters.AddWithValue("@recetekodu", Convert.ToInt64(recetekod));
                komut_ekle.Parameters.AddWithValue("@tcno", Convert.ToInt64(number));
                komut_ekle.Parameters.AddWithValue("@ilac1", txtilac1.Text);
                komut_ekle.Parameters.AddWithValue("@ilac2", txtilac2.Text);
                komut_ekle.Parameters.AddWithValue("@ilac3", txtilac3.Text);
                komut_ekle.Parameters.AddWithValue("@ilac4", txtilac4.Text);
                komut_ekle.Parameters.AddWithValue("@ilac5", txtilac5.Text);
                komut_ekle.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut_ekle.Parameters.AddWithValue("@adet1", cmb1.Text);
                komut_ekle.Parameters.AddWithValue("@adet2", cmb2.Text);
                komut_ekle.Parameters.AddWithValue("@adet3", cmb3.Text);
                komut_ekle.Parameters.AddWithValue("@adet4", cmb4.Text);
                komut_ekle.Parameters.AddWithValue("@adet5", cmb5.Text);
                Recete recete = new Recete();



                komut_ekle.CommandType = CommandType.Text;
                komut_ekle.CommandText = "insert into recete (recetekodu, tc, ilac1, ilac1sayisi, ilac2, ilac2sayisi, ilac3, ilac3sayisi, ilac4, ilac4sayisi, ilac5, ilac5sayisi,tarih) values (@recetekodu, @tcno, @ilac1, @adet1, @ilac2, @adet2, @ilac3, @adet3, @ilac4, @adet4, @ilac5, @adet5, @TARIH)";
                _ = komut_ekle.ExecuteReader();
            }
            else
                MessageBox.Show("Bir ilacı sadace bir kez ve aynı ilaçtan maksimum 3 kutu yazabilirsiniz!Lütfen düzenleyiniz ");



            komut_ekle.Dispose();
            bireyselbaglantı.Close();

            this.Close();



        }

        private void Recete_Load(object sender, EventArgs e)
        {
            cmb1.SelectedIndex = 0;
            cmb2.SelectedIndex = 0;
            cmb3.SelectedIndex = 0;
            cmb4.SelectedIndex = 0;
            cmb5.SelectedIndex = 0;
        }
    }
}
