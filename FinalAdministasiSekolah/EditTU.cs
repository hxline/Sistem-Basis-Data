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
    public partial class EditTU : Telerik.WinControls.UI.RadForm
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;
        public string id { get; set; }
        public string nama { get; set; }
        public string password { get; set; }

        public EditTU()
        {
            InitializeComponent();
        }

        private void EditTU_Load(object sender, EventArgs e)
        {
            textBoxNama.Text = nama;
            textBoxPassword.Text = password;
        }

        private void radButtonSimpan_Click(object sender, EventArgs e)
        {
            string nama = textBoxNama.Text;
            string password = textBoxPassword.Text;

            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();
            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string ubah = "update ttu set nama = @nama, password = @password where id_tu = @id";

                MySqlCommand cmd = new MySqlCommand(ubah, koneksi.koneksiDB);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@password", password);

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

        private void radButtonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
