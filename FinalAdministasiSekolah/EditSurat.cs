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
    public partial class EditSurat : Telerik.WinControls.UI.RadForm
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;
        public string id { get; set; }
        public string noSurat { get; set; }
        public string lampiran { get; set; }
        public string perihal { get; set; }
        public string jenis { get; set; }
        public string pengirim { get; set; }

        public EditSurat()
        {
            InitializeComponent();
        }

        private void EditSurat_Load(object sender, EventArgs e)
        {
            textBoxNoSurat.Text = noSurat;
            textBoxLampiran.Text = lampiran;
            textBoxPerihal.Text = perihal;
            comboBoxJenis.Text = jenis;
            textBoxPengirim.Text = pengirim;
        }

        private void radButtonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButtonUbah_Click(object sender, EventArgs e)
        {
            string noSurat = textBoxNoSurat.Text;
            string lampiran = textBoxLampiran.Text;
            string perihal = textBoxPerihal.Text;
            string jenis = comboBoxJenis.Text;
            string pengirim = textBoxPengirim.Text;

            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();
            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string ubah = "update tsurat set no_surat = @no_surat, lampiran = @lampiran, perihal = @perihal, jenis = @jenis, pengirim = @pengirim where id_surat = @id";

                MySqlCommand cmd = new MySqlCommand(ubah, koneksi.koneksiDB);

                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                cmd.Parameters.AddWithValue("@no_surat", noSurat);
                cmd.Parameters.AddWithValue("@lampiran", lampiran);
                cmd.Parameters.AddWithValue("@perihal", perihal);
                cmd.Parameters.AddWithValue("@jenis", jenis);
                cmd.Parameters.AddWithValue("@pengirim", pengirim);

                int insertResult = cmd.ExecuteNonQuery();

                if (insertResult == 1)
                {
                    MessageBox.Show("Sukses");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed");
                }

                koneksi.koneksiDB.Close();
            }
        }

        
    }
}
