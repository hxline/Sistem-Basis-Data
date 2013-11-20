using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace FinalAdministasiSekolah
{
    public partial class AmbilTabungan : Telerik.WinControls.UI.RadForm
    {
        Koneksi koneksi;
        public string nis { get; set; }


        public AmbilTabungan()
        {
            InitializeComponent();
        }

        private void ButtonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAmbil_Click(object sender, EventArgs e)
        {
            string jumlah = TextJumlah.Text;

            koneksi = new Koneksi();

            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string ubah = "update ttotal set total = (total - @jumlah) where nis = @id";

                MySqlCommand cmd = new MySqlCommand(ubah, koneksi.koneksiDB);

                cmd.Parameters.AddWithValue("@id", int.Parse(nis));
                cmd.Parameters.AddWithValue("@jumlah", int.Parse(jumlah));

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

        private void AmbilTabungan_Load(object sender, EventArgs e)
        {
            LabelNIS.Text = nis;
        }
    }
}
