using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace FinalAdministasiSekolah
{
    public partial class TambahTabungan : Telerik.WinControls.UI.RadForm
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;
        public string id { get; set; }
        public string nama { get; set; }
        public string kelas { get; set; }
        public string idTU { get; set; }

        public TambahTabungan()
        {
            InitializeComponent();
        }

        private void TambahTabungan_Load(object sender, EventArgs e)
        {
            labelNIS.Text = id;
            labelNama.Text = nama;
            labelKelas.Text = kelas;
        }

        private Boolean statusTotalTabungan(int nis)
        {
            //SqlConnection connection = new SqlConnection(strConnection);
            //connection.Open();
            //koneksi.koneksiDB.Open();
            string select = "SELECT nis FROM ttotal";
            MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetInt32(0) == nis)
                {
                    return true;
                }
            }
            //koneksi.koneksiDB.Close();
            return false;
        }

        private void Total()
        {
            if (statusTotalTabungan(int.Parse(id)) == true)
            {
                koneksi = new Koneksi();
                using (koneksi.koneksiDB)
                {
                    koneksi.koneksiDB.Open();

                    string ubah = "update ttotal set total = (select sum(jumlah) from ttabungan where nis = @nis) where nis = @nis";

                    MySqlCommand cmd = new MySqlCommand(ubah, koneksi.koneksiDB);

                    cmd.Parameters.AddWithValue("@nis", int.Parse(id));

                    int insertResult = cmd.ExecuteNonQuery();

                    koneksi.koneksiDB.Close();
                }
            }
            else
            {
                koneksi = new Koneksi();
                using (koneksi.koneksiDB)
                {
                    koneksi.koneksiDB.Open();

                    string insert = "insert into ttotal(nis,total) values (@nis,(select sum(jumlah) from ttabungan where nis = @nis))";

                    MySqlCommand cmd = new MySqlCommand(insert, koneksi.koneksiDB);

                    cmd.Parameters.AddWithValue("@nis", int.Parse(id));

                    int insertResult = cmd.ExecuteNonQuery();

                    koneksi.koneksiDB.Close();
                }
            }
        }

        private void radButtonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButtonTambah_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            string strDate = date.ToString("dd-MM-yyyy");

            string jumlah = textJumlah.Text;
            string tanggal = strDate;

            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();
            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string insert = "insert into ttabungan(nis,jumlah,tanggal,id_tu) values (@nis,@jumlah,@tanggal,@id_tu)";

                MySqlCommand cmd = new MySqlCommand(insert, koneksi.koneksiDB);

                cmd.Parameters.AddWithValue("@nis", int.Parse(id));
                cmd.Parameters.AddWithValue("@jumlah", int.Parse(jumlah));
                cmd.Parameters.AddWithValue("@tanggal", tanggal);
                cmd.Parameters.AddWithValue("@id_tu", int.Parse(idTU));

                int insertResult = cmd.ExecuteNonQuery();

                if (insertResult == 1)
                {
                    MessageBox.Show("Sukses");
                    Total();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal");
                }

                koneksi.koneksiDB.Close();
            }
        }
    }
}
