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
    public partial class FormTotal : Telerik.WinControls.UI.RadForm
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;
        DataTable table;
        public string nis { get; set; }
        public string button { get; set; }


        public FormTotal()
        {
            InitializeComponent();
        }

        private void BindDataTotalTabungan()
        {
            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();

            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string select = "select total as Total from ttotal where nis = @nis";

                MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);
                cmd.Parameters.AddWithValue("@nis", nis);

                MySqlDataReader reader = cmd.ExecuteReader();

                table = new DataTable();
                table.Load(reader);

                radGridView1.DataSource = table;

                koneksi.koneksiDB.Close();
            }
        }

        private void BindDataTotalTabunganKeluar()
        {
            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();

            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string select = "select sum(jumlah) as Total from ttabungankeluar where nis = @nis";

                MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);
                cmd.Parameters.AddWithValue("@nis", nis);

                MySqlDataReader reader = cmd.ExecuteReader();

                table = new DataTable();
                table.Load(reader);

                radGridView1.DataSource = table;

                koneksi.koneksiDB.Close();
            }
        }

        private void BindDataTotalPembayaran()
        {
            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();

            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string select = "select sum(total) as 'Total Pembayaran' from tpembayaran";

                MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);

                MySqlDataReader reader = cmd.ExecuteReader();

                table = new DataTable();
                table.Load(reader);

                radGridView1.DataSource = table;

                koneksi.koneksiDB.Close();
            }
        }

        private void BindDataTotalPendaftaran()
        {
            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();

            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string select = "select sum(jumlah) as 'Total Uang Pendaftaran' from tdaftar";

                MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);

                MySqlDataReader reader = cmd.ExecuteReader();

                table = new DataTable();
                table.Load(reader);

                radGridView1.DataSource = table;

                koneksi.koneksiDB.Close();
            }
        }

        private void FormTotal_Load(object sender, EventArgs e)
        {
            if (button == "pembayaran")
            {
                radButtonAmbil.Visible = false;
                BindDataTotalPembayaran();
            }
            else if (button == "tabungan")
            {
                radButtonAmbil.Visible = true;
                BindDataTotalTabungan();
            }
            else if (button == "pendaftaran")
            {
                radButtonAmbil.Visible = false;
                BindDataTotalPendaftaran();
            }
            else if (button == "tabungankeluar")
            {
                radButtonAmbil.Visible = false;
                BindDataTotalTabunganKeluar();
            }
        }

        private void radButtonOk_Click(object sender, EventArgs e)
        {
            AmbilTabungan tabungan = new AmbilTabungan();
            tabungan.nis = nis;
            tabungan.ShowDialog();
            this.Close();
        }

        private void radButtonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
