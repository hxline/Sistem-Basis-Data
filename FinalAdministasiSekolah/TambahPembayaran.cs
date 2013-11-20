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
    public partial class TambahPembayaran : Telerik.WinControls.UI.RadForm
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;
        public string id { get; set; }
        public string nama { get; set; }
        public string kelas { get; set; }
        public string idTU { get; set; }

        public TambahPembayaran()
        {
            InitializeComponent();
        }

        private void TambahPembayaran_Load(object sender, EventArgs e)
        {
            labelNIS.Text = id;
            labelNama.Text = nama;
            labelKelas.Text = kelas;
        }

        private void checkBoxCathering_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCathering.Checked == true)
            {
                checkBoxCathering.Text = "50000";
            }
            else if (checkBoxCathering.Checked == false)
            {
                checkBoxCathering.Text = "0";
            }
        }

        private void radButtonTambah_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            string strDate = date.ToString("dd-MM-yyyy");

            string nis = id;
            string spp = checkBoxSPP.Text;
            string cathering = checkBoxCathering.Text;
            string marching = checkBoxMarching.Text;
            string tanggal = strDate;
            string bulan = comboBoxBulan.Text;
            int total = int.Parse(spp) + int.Parse(cathering) + int.Parse(marching);

            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();
            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string insert = "insert into tpembayaran(id_tu,nis,spp,cathering,marching_band,bulan,tanggal,total) values (@id_tu,@nis,@spp,@cathering,@marching_band,@bulan,@tanggal,@total)";

                MySqlCommand cmd = new MySqlCommand(insert, koneksi.koneksiDB);

                cmd.Parameters.AddWithValue("@id_tu", int.Parse(idTU));
                cmd.Parameters.AddWithValue("@nis", id);
                cmd.Parameters.AddWithValue("@spp", int.Parse(spp));
                cmd.Parameters.AddWithValue("@cathering", int.Parse(cathering));
                cmd.Parameters.AddWithValue("@marching_band", int.Parse(marching));
                cmd.Parameters.AddWithValue("@bulan", bulan);
                cmd.Parameters.AddWithValue("@tanggal", tanggal);
                cmd.Parameters.AddWithValue("@total", total);

                int insertResult = cmd.ExecuteNonQuery();

                if (insertResult == 1)
                {
                    MessageBox.Show("Sukses");
                    DataSiswa siswa = new DataSiswa();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Gagal");
                }

                koneksi.koneksiDB.Close();
            }
        }

        private void radButtonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
