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
    public partial class EditPembayaran : Telerik.WinControls.UI.RadForm
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;
        public string id { get; set; }
        public string nis { get; set; }
        public string nama { get; set; }
        public string kelas { get; set; }
        public string cathering { get; set; }
        public string bulan { get; set; }

        public EditPembayaran()
        {
            InitializeComponent();
        }

        private void radButtonUbah_Click(object sender, EventArgs e)
        {
            string cathering = checkBoxCathering.Text;

            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();
            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string ubah = "update tpembayaran set cathering = @cathering, bulan = @bulan where id_pembayaran = @id";

                MySqlCommand cmd = new MySqlCommand(ubah, koneksi.koneksiDB);

                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                cmd.Parameters.AddWithValue("@cathering", cathering);

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

        private void EditPembayaran_Load(object sender, EventArgs e)
        {
            labelNIS.Text = nis;
            labelNama.Text = nama;
            labelKelas.Text = kelas;
            comboBoxBulan.Text = bulan;
            if (cathering == "50000")
            {
                checkBoxCathering.Checked = true;
            }
            else if (cathering == "0")
            {
                checkBoxCathering.Checked = false;
            }
        }

        private void checkBoxCathering_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCathering.Checked == true)
            {
                checkBoxCathering.Text = "50000";
            }
            else if (checkBoxCathering.Checked == false)
            {
                checkBoxCathering.Text = "0";
            }
        }
    }
}
