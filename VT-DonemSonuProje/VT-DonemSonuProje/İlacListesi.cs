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
    public partial class İlacListesi : Form
    {
        public İlacListesi()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432;Database=finalproject;User Id=postgres;Password=Yakamoz.21;");
        public void tablogoster(string txt)
        {


            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conn;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = txt;
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgİlacListesi.DataSource = dt;
            }
            cmd.Dispose();
            conn.Close();
        }

        private void btnGöster_Click(object sender, EventArgs e)
        {
            tablogoster(" SELECT * FROM ilaclar ");
        }

        private void dgİlacListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sorgu = "select * from ilaclar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgİlacListesi.DataSource = ds.Tables[0];
        }
    }
}
