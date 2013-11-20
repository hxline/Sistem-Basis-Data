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
    public partial class TambahSiswa : Telerik.WinControls.UI.RadForm
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;

        public TambahSiswa()
        {
            InitializeComponent();
        }

        private void radButtonSimpan_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string tanggal = date.ToString("dd-MM-yyyy");

            string nis = textBoxNIS.Text;
            string nama = textBoxNama.Text;
            string kelas = comboBoxKelas.Text;

            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();
            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string insert = "insert into tsiswa (nis,nama,kelas,tanggal) values (@nis, @nama, @kelas, @tanggal)";

                MySqlCommand cmd = new MySqlCommand(insert, koneksi.koneksiDB);

                cmd.Parameters.AddWithValue("@nis", nis);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@kelas", kelas);
                cmd.Parameters.AddWithValue("@tanggal", tanggal);

                int inserResult = cmd.ExecuteNonQuery();

                if (inserResult == 1)
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

        private void radButtonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
