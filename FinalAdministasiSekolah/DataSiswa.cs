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
using Telerik.WinControls.UI;
using MySql.Data.MySqlClient;

namespace FinalAdministasiSekolah
{
    public partial class DataSiswa : Telerik.WinControls.UI.RadForm
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;
        DataTable table;
        private string id;
        private string nama;
        private string kelas;
        public string button { get; set; }
        public string idTU { get; set; }

        public DataSiswa()
        {
            InitializeComponent();
        }

        private void BindDataSiswa()
        {
            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();
            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string select = "select nis as NIS, nama as Nama, kelas as Kelas from tsiswa";

                MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);
                MySqlDataReader reader = cmd.ExecuteReader();

                table = new DataTable();
                table.Load(reader);

                radGridSiswa.DataSource = table;

                koneksi.koneksiDB.Close();
            }
        }

        private void DataSiswa_Load(object sender, EventArgs e)
        {
            BindDataSiswa();
        }

        private void radGridSiswa_SelectionChanged(object sender, EventArgs e)
        {
            foreach (GridViewRowInfo row in radGridSiswa.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                nama = row.Cells[1].Value.ToString();
                kelas = row.Cells[2].Value.ToString();
            }
        }

        private void radGridSiswa_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if (button == "pembayaran")
            {
                TambahPembayaran pembayaran = new TambahPembayaran();
                pembayaran.id = id;
                pembayaran.nama = nama;
                pembayaran.kelas = kelas;
                pembayaran.idTU=idTU;
                pembayaran.ShowDialog();
            }
            else if (button == "pendaftaran")
            {
                TambahDaftar daftar = new TambahDaftar();
                daftar.id = id;
                daftar.nama = nama;
                daftar.kelas = kelas;
                daftar.idTU = idTU;
                daftar.ShowDialog();
            }
            else if (button == "tabungan")
            {
                TambahTabungan tabungan = new TambahTabungan();
                tabungan.id = id;
                tabungan.nama = nama;
                tabungan.kelas = kelas;
                tabungan.idTU = idTU;
                tabungan.ShowDialog();
            }
        }

    }
}
