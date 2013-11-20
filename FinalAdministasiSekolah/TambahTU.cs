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
    public partial class TambahTU : Telerik.WinControls.UI.RadForm
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;

        public TambahTU()
        {
            InitializeComponent();
        }

        private void radButtonTambah_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string tanggal = date.ToString("dd-MM-yyyy");

            string id = textBoxID.Text;
            string nama = textBoxNama.Text;
            string password = textBoxPassword.Text;

            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();
            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string insert = "insert into ttu (id_tu,nama,password,tanggal) values (@id, @nama, @password, @tanggal)";

                MySqlCommand cmd = new MySqlCommand(insert, koneksi.koneksiDB);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@password", password);
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
