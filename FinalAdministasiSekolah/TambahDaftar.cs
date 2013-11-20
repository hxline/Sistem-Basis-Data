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
    public partial class TambahDaftar : Telerik.WinControls.UI.RadForm
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;
        public string id { get; set; }
        public string nama { get; set; }
        public string kelas { get; set; }
        public string idTU { get; set; }

        public TambahDaftar()
        {
            InitializeComponent();
        }

        private void TambahDaftar_Load(object sender, EventArgs e)
        {
            labelNIS.Text = id;
            labelNama.Text = nama;
            labelKelas.Text = kelas;
        }

        private void radButtonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboJenis.Text == "Daftar Ulang")
            {
                labelJumlah.Text = "500000";
            }
            else if (comboJenis.Text == "Daftar Baru")
            {
                labelJumlah.Text = "1000000";
            }
        }

        private void radButtonTambah_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            string strDate = date.ToString("dd-MM-yyyy");

            string jenis = comboJenis.Text;
            string jumlah = labelJumlah.Text;
            string tanggal = strDate;

            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();
            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string insert = "insert into tdaftar(nis,jenis,jumlah,tanggal,id_tu) values (@nis,@jenis,@jumlah,@tanggal,@id_tu)";

                MySqlCommand cmd = new MySqlCommand(insert, koneksi.koneksiDB);

                cmd.Parameters.AddWithValue("@nis", int.Parse(id));
                cmd.Parameters.AddWithValue("@jenis", jenis);
                cmd.Parameters.AddWithValue("@jumlah", int.Parse(jumlah));
                cmd.Parameters.AddWithValue("@tanggal", tanggal);
                cmd.Parameters.AddWithValue("@id_tu", int.Parse(idTU));

                int insertResult = cmd.ExecuteNonQuery();

                if (insertResult == 1)
                {
                    MessageBox.Show("Sukses");
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
