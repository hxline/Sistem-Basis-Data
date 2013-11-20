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
    public partial class EditSiswa : Telerik.WinControls.UI.RadForm
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;
        public string nis { get; set; }
        public string nama { get; set; }
        public string kelas { get; set; }

        public EditSiswa()
        {
            InitializeComponent();
        }

        private void EditSiswa_Load(object sender, EventArgs e)
        {
            labelNIS.Text = nis;
            textBoxNama.Text = nama;
            comboBoxKelas.Text = kelas;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            string nama = textBoxNama.Text;
            string kelas = comboBoxKelas.Text;

            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();
            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string ubah = "update tsiswa set nama = @nama, kelas = @kelas where nis = @nis";

                MySqlCommand cmd = new MySqlCommand(ubah, koneksi.koneksiDB);

                cmd.Parameters.AddWithValue("@nis", nis);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@kelas", kelas);

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

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
