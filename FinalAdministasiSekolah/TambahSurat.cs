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
    public partial class TambahSurat : Telerik.WinControls.UI.RadForm
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;
        public string idTU { get; set; }

        public TambahSurat()
        {
            InitializeComponent();
        }

        private void TambahSurat_Load(object sender, EventArgs e)
        {
        }

        private void radButtonSimpan_Click(object sender, EventArgs e)
        {

            DateTime date = DateTime.Now;

            string strDate = date.ToString("dd-MM-yyyy");

            string noSurat = textBoxNoSurat.Text;
            string lampiran = textBoxLampiran.Text;
            string perihal = textBoxPerihal.Text;
            string jenis = comboBoxJenis.Text;
            string pengirim = textBoxPengirim.Text;
            string tanggal = strDate;

            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();
            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string insert = "insert into tsurat(id_tu,no_surat,lampiran,perihal,jenis,pengirim,tanggal) values (@id,@no_surat,@lampiran,@perihal,@jenis,@pengirim,@tanggal)";

                MySqlCommand cmd = new MySqlCommand(insert, koneksi.koneksiDB);

                cmd.Parameters.AddWithValue("@id", int.Parse(idTU));
                cmd.Parameters.AddWithValue("@no_surat", noSurat);
                cmd.Parameters.AddWithValue("@lampiran", lampiran);
                cmd.Parameters.AddWithValue("@perihal", perihal);
                cmd.Parameters.AddWithValue("@jenis", jenis);
                cmd.Parameters.AddWithValue("@pengirim", pengirim);
                cmd.Parameters.AddWithValue("@tanggal", tanggal);

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

        private void radButtonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
