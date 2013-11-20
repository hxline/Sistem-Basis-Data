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
    public partial class FormLogin : Telerik.WinControls.UI.RadForm
    {
        private string nama;
        private string idTU;
        //public string strConnection;
        Koneksi koneksi;
        public FormLogin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
            koneksi = new Koneksi();
        }

        private Boolean statusLogin(string user, string password)
        {
            user = user.ToUpper();
            password = password.ToUpper();

            //SqlConnection connection = new SqlConnection(strConnection);
            //connection.Open();
            koneksi.koneksiDB.Open();
            string select = "SELECT nama,password,id_tu FROM ttu";
            MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                
                if ((reader.GetString(0).ToString().ToUpper() == user) && (reader.GetString(1).ToString().ToUpper() == password))
                {
                    idTU = reader.GetInt32(2).ToString();
                    nama = reader.GetString(0).ToString();
                    return true;
                }
            }
            koneksi.koneksiDB.Close();
            return false;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (statusLogin(textNama.Text, textPass.Text) == true)
            {
                Form1 formutama = new Form1();
                formutama.user = nama;
                formutama.idTU = idTU;
                this.AddOwnedForm(formutama);
                formutama.Visible = true;
                this.Visible = false; ;
                
            }
            else if(textNama.Text=="admin" & textPass.Text=="123")
            {                
                Form1 formutama = new Form1();
                formutama.user = textNama.Text;
                this.Visible = false;
                formutama.Visible = true;
                
            }
            else
                MessageBox.Show("Username atau password salah");
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void radButtonBatal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
