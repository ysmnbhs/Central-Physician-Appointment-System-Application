namespace VT_DonemSonuProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSekreterGirisi_Click(object sender, EventArgs e)
        {
            HastaKayit hastaKayit = new HastaKayit();
            hastaKayit.Show();

        }

        private void btnDoktorGirisi_Click(object sender, EventArgs e)
        {
            Muayene muayene = new Muayene();
            muayene.Show();
        }

        private void btnEczac�Girisi_Click(object sender, EventArgs e)
        {
            �lacEkle ilacEkle = new �lacEkle();
            ilacEkle.Show();
        }
    }
}