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
    public partial class EditDaftar : Telerik.WinControls.UI.RadForm
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;
        public string idtab { get; set; }
        public string nis { get; set; }
        public string nama { get; set; }
        public string kelas { get; set; }
        public string jenis { get; set; }
        public string jumlah { get; set; }

        public EditDaftar()
        {
            InitializeComponent();
        }

        private void EditDaftar_Load(object sender, EventArgs e)
        {
            labelNIS.Text = nis;
            labelNama.Text = nama;
            labelKelas.Text = kelas;
            comboJenis.Text = jenis;
            labelJumlah.Text = jumlah;
        }

        private void radButtonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButtonUbah_Click(object sender, EventArgs e)
        {
            string jenis = comboJenis.Text;
            string jumlah = labelJumlah.Text;

            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();

            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string ubah = "update tdaftar set jenis = @jenis, jumlah = @jumlah where id_daftar = @id";

                MySqlCommand cmd = new MySqlCommand(ubah, koneksi.koneksiDB);

                cmd.Parameters.AddWithValue("@id", int.Parse(idtab));
                cmd.Parameters.AddWithValue("@jenis", jenis);
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

        
    }
}
