using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace FinalAdministasiSekolah
{
    class Koneksi
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public MySqlConnection koneksiDB;

        public Koneksi()
        {
            Initialize();
            koneksiDB = connection;
        }

        private void Initialize()
        {
            server = "localhost";
            database = "administrasi";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" +
                 "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }
    }
}
