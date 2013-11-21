using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Telerik.WinControls.UI;
using MySql.Data.MySqlClient;

namespace FinalAdministasiSekolah
{
    public partial class Form1 : Form
    {
        //private string strConnection = ConfigurationManager.ConnectionStrings["AdministrasiConnectionString"].ConnectionString;
        Koneksi koneksi;
        DataTable table;
        private string idtab;
        private string id;
        private string nama;
        private string password;
        private string kelas;
        private string cathering;
        private string tombol;
        private string noSurat;
        private string lampiran;
        private string perihal;
        private string jenis;
        private string pengirim;
        private string jumlah;
        private string bulan;
        public string idTU { get; set; }
        public string user { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radGridSiswa.Dock = DockStyle.Fill;
            radGridPembayaran.Dock = DockStyle.Fill;
            radGridTu.Dock = DockStyle.Fill;
            radGridSurat.Dock = DockStyle.Fill;
            radGridPendaftaran.Dock = DockStyle.Fill;
            radGridTabungan.Dock = DockStyle.Fill;
            radGridTabunganSaldo.Dock = DockStyle.Fill;
            radGridTabunganKeluar.Dock = DockStyle.Fill;
            radLabelUser.Text = "User : " + user;
        }

        //
        //Navigasi
        //

        //
        ////Navigasi Tatausaha
        //

        private void radButtonTU_Click(object sender, EventArgs e)
        {
            tombol = "tu";
            radGridSiswa.Visible = false;
            radGridTu.Visible = true;
            radGridPembayaran.Visible = false;
            radGridPendaftaran.Visible = false;
            radGridTabungan.Visible = false;
            radGridSurat.Visible = false;
            radGridTabunganSaldo.Visible = false;
            radGridTabunganKeluar.Visible = false;
            radLabelMulai.Text = "Administrasi Sekolah [Data Tata Usaha]";
            radButtonTotal.Visible = false;
            radButtonTambah.Visible = true;
            radButtonUbah.Visible = true;
            radButtonHapus.Visible = true;
            radButtonRefresh.Visible = true;
            BindDataTU();
        }

        //
        ////Akhir Navigasi Tatausaha
        //

        //
        ////Navigasi Siswa
        //

        private void radButtonSiswa_Click(object sender, EventArgs e)
        {
            tombol = "siswa";
            radGridSiswa.Visible = true;
            radGridTu.Visible = false;
            radGridPembayaran.Visible = false;
            radGridPendaftaran.Visible = false;
            radGridTabungan.Visible = false;
            radGridSurat.Visible = false;
            radGridTabunganSaldo.Visible = false;
            radGridTabunganKeluar.Visible = false;
            radLabelMulai.Text = "Administrasi Sekolah [Data Siswa]";
            radButtonTotal.Visible = false;
            radButtonTambah.Visible = true;
            radButtonUbah.Visible = true;
            radButtonHapus.Visible = true;
            radButtonRefresh.Visible = true;
            BindDataSiswa();
        }

        //
        ////Akhir Navigasi Siswa
        //

        //
        ////Navigasi Pembayaran
        //

        private void radButtonPembayaran_Click(object sender, EventArgs e)
        {
            tombol = "pembayaran";
            radGridPembayaran.Visible = true;
            radGridSiswa.Visible = false;
            radGridTu.Visible = false;
            radGridPendaftaran.Visible = false;
            radGridTabungan.Visible = false;
            radGridSurat.Visible = false;
            radGridTabunganSaldo.Visible = false;
            radGridTabunganKeluar.Visible = false;
            radLabelMulai.Text = "Administrasi Sekolah [Data Pembayaran]";
            radButtonTotal.Visible = true;
            radButtonTambah.Visible = true;
            radButtonUbah.Visible = true;
            radButtonHapus.Visible = true;
            radButtonRefresh.Visible = true;
            BindDataPembayaran();
        }

        //
        ////Akhir Navigasi Pembayaran
        //

        //
        ////Navigasi Surat
        //
        private void radButtonSurat_Click(object sender, EventArgs e)
        {
            tombol = "surat";
            radGridPembayaran.Visible = false;
            radGridSiswa.Visible = false;
            radGridTu.Visible = false;
            radGridPendaftaran.Visible = false;
            radGridTabungan.Visible = false;
            radGridSurat.Visible = true;
            radGridTabunganSaldo.Visible = false;
            radGridTabunganKeluar.Visible = false;
            radLabelMulai.Text = "Administrasi Sekolah [Data Surat]";
            radButtonTotal.Visible = false;
            radButtonTambah.Visible = true;
            radButtonUbah.Visible = true;
            radButtonHapus.Visible = true;
            radButtonRefresh.Visible = true;
            BindDataSurat();
        }

        //
        ////Akhir Navigasi Surat
        //

        //
        ////Navigasi Pendaftaran
        //

        private void radButtonPendaftaran_Click(object sender, EventArgs e)
        {
            tombol = "pendaftaran";
            radGridPembayaran.Visible = false;
            radGridSiswa.Visible = false;
            radGridTu.Visible = false;
            radGridSurat.Visible = false;
            radGridTabungan.Visible = false;
            radGridPendaftaran.Visible = true;
            radGridTabunganSaldo.Visible = false;
            radGridTabunganKeluar.Visible = false;
            radLabelMulai.Text = "Administrasi Sekolah [Data Pendaftaran]";
            radButtonTotal.Visible = true;
            radButtonTambah.Visible = true;
            radButtonUbah.Visible = true;
            radButtonHapus.Visible = true;
            radButtonRefresh.Visible = true;
            BindDataDaftar();
        }

        //
        ////Akhir Navigasi Pendaftaran
        //

        //
        ////Navigasi Tabungan Total
        //

        private void radButtonTabungan_Click(object sender, EventArgs e)
        {
            tombol = "total";
            radGridPembayaran.Visible = false;
            radGridSiswa.Visible = false;
            radGridTu.Visible = false;
            radGridSurat.Visible = false;
            radGridTabungan.Visible = false;
            radGridPendaftaran.Visible = false;
            radGridTabunganSaldo.Visible = true;
            radGridTabunganKeluar.Visible = false;
            radLabelMulai.Text = "Administrasi Sekolah [Data Total Tabungan]";
            radButtonTotal.Visible = false;
            radButtonTambah.Visible = false;
            radButtonUbah.Visible = false;
            radButtonHapus.Visible = false;
            radButtonRefresh.Visible = false;
            BindDataTotalTabungan();
        }

        //
        //// Akhir Navigasi Tabungan Total
        //

        //
        //Akhir Navigasi
        //

        //
        //Data Tata Usaha
        //
        private void BindDataTU()
        {
            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();

            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string select = "select id_tu as 'ID Tata Usaha', nama as Nama, password as Password, tanggal as 'Tanggal Daftar' from ttu";

                MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);
                MySqlDataReader reader = cmd.ExecuteReader();

                table = new DataTable();
                table.Load(reader);

                radGridTu.DataSource = table;

                koneksi.koneksiDB.Close();
            }
        }

        private void radGridTu_SelectionChanged(object sender, EventArgs e)
        {
            foreach (GridViewRowInfo row in radGridTu.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                nama = row.Cells[1].Value.ToString();
                password = row.Cells[2].Value.ToString();
            }
        }

        private void radGridTu_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            EditTU editTU = new EditTU();
            editTU.id = id;
            editTU.nama = nama;
            editTU.password = password;
            editTU.ShowDialog();
        }
        //
        //Akhir Data Tata Usaha
        //

        //
        //Data Siswa
        //
        private void BindDataSiswa()
        {
            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();

            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string select = "select nis as NIS, nama as Nama, kelas as Kelas, tanggal as 'Tanggal Masuk' from tsiswa";

                MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);
                MySqlDataReader reader = cmd.ExecuteReader();

                table = new DataTable();
                table.Load(reader);

                radGridSiswa.DataSource = table;

                koneksi.koneksiDB.Close();
            }
        }

        private void radGridSiswa_SelectionChanged(object sender, EventArgs e)
        {
            foreach (GridViewRowInfo row in radGridSiswa.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                nama = row.Cells[1].Value.ToString();
                kelas = row.Cells[2].Value.ToString();
            }
        }

        private void radGridSiswa_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            EditSiswa editsiswa = new EditSiswa();
            editsiswa.nis = id;
            editsiswa.nama = nama;
            editsiswa.kelas = kelas;
            editsiswa.ShowDialog();
        }
        //
        //Akhir Data Siswa
        //

        //
        //Data Pembayaran
        //
        private void BindDataPembayaran()
        {
            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();

            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string select = "select pem.id_pembayaran as ID, pem.nis as NIS, sis.nama as Nama, sis.kelas as Kelas, " +
                                "pem.spp as SPP, pem.cathering as Cathering, pem.marching_band as 'Marching Band', pem.bulan as Bulan , " +
                                "pem.total as Total, pem.tanggal as 'Tanggal Bayar', tu.nama as 'Nama TU' " +
                                "from tpembayaran as pem " +
                                "join tsiswa as sis on(pem.nis = sis.nis)" +
                                "join ttu as tu on(pem.id_tu = tu.id_tu)";

                MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);
                MySqlDataReader reader = cmd.ExecuteReader();

                table = new DataTable();
                table.Load(reader);

                radGridPembayaran.DataSource = table;

                koneksi.koneksiDB.Close();
            }
        }

        private void radGridPembayaran_SelectionChanged(object sender, EventArgs e)
        {
            foreach (GridViewRowInfo row in radGridPembayaran.SelectedRows)
            {
                idtab = row.Cells[0].Value.ToString();
                id = row.Cells[1].Value.ToString();
                nama = row.Cells[2].Value.ToString();
                kelas = row.Cells[3].Value.ToString();
                cathering = row.Cells[5].Value.ToString();
                bulan = row.Cells[7].Value.ToString();
            }
        }

        private void radGridPembayaran_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            EditPembayaran pembayaran = new EditPembayaran();
            pembayaran.id = idtab;
            pembayaran.nis = id;
            pembayaran.nama = nama;
            pembayaran.kelas = kelas;
            pembayaran.cathering = cathering;
            pembayaran.bulan = bulan;
            pembayaran.ShowDialog();
        }
        //
        //Akhir Data Pembayaran
        //

        //
        //Data Surat
        //
        private void BindDataSurat()
        {
            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();

            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string select = "select surat.id_surat as ID, tu.nama as 'Nama TU', surat.no_surat as 'No Surat', surat.lampiran as Lampiran, " +
                                "surat.perihal as Perihal, surat.jenis as Jenis, surat.tanggal as Tanggal,  " +
                                "surat.pengirim as Pengirim " +
                                "from tsurat as surat " +
                                "join ttu as tu on(surat.id_tu = tu.id_tu)";

                MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);
                MySqlDataReader reader = cmd.ExecuteReader();

                table = new DataTable();
                table.Load(reader);

                radGridSurat.DataSource = table;

                koneksi.koneksiDB.Close();
            }
        }

        private void radGridSurat_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            EditSurat editSurat = new EditSurat();
            editSurat.id = id;
            editSurat.noSurat = noSurat;
            editSurat.lampiran = lampiran;
            editSurat.perihal = perihal;
            editSurat.jenis = jenis;
            editSurat.pengirim = pengirim;
            editSurat.ShowDialog();
        }

        private void radGridSurat_SelectionChanged(object sender, EventArgs e)
        {
            foreach (GridViewRowInfo row in radGridSurat.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                noSurat = row.Cells[2].Value.ToString();
                lampiran = row.Cells[3].Value.ToString();
                perihal = row.Cells[4].Value.ToString();
                jenis = row.Cells[5].Value.ToString();
                pengirim = row.Cells[7].Value.ToString();
            }
        }
        //
        //Akhir Data Surat
        //

        //
        //Data Pendaftaran
        //
        private void BindDataDaftar()
        {
            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();

            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string select = "select daf.id_daftar as ID, daf.nis as NIS, sis.nama as Nama, sis.kelas as Kelas, " +
                                "daf.jenis as Jenis, daf.jumlah as Jumlah, daf.tanggal as 'Tanggal Bayar', tu.nama as 'Nama TU' " +
                                "from tdaftar as daf " +
                                "join tsiswa as sis on(sis.nis = daf.nis) " +
                                "join ttu as tu on(tu.id_tu = daf.id_tu)";

                MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);
                MySqlDataReader reader = cmd.ExecuteReader();

                table = new DataTable();
                table.Load(reader);

                radGridPendaftaran.DataSource = table;

                koneksi.koneksiDB.Close();
            }
        }

        private void radGridPendaftaran_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            EditDaftar daftar = new EditDaftar();
            daftar.idtab = idtab;
            daftar.nis = id;
            daftar.nama = nama;
            daftar.kelas = kelas;
            daftar.jenis = jenis;
            daftar.jumlah = jumlah;
            daftar.ShowDialog();
        }

        private void radGridPendaftaran_SelectionChanged(object sender, EventArgs e)
        {
            foreach (GridViewRowInfo row in radGridPendaftaran.SelectedRows)
            {
                idtab = row.Cells[0].Value.ToString();
                id = row.Cells[1].Value.ToString();
                nama = row.Cells[2].Value.ToString();
                kelas = row.Cells[3].Value.ToString();
                jenis = row.Cells[4].Value.ToString();
                jumlah = row.Cells[5].Value.ToString();
            }
        }
        //
        //Akhir Data Pendaftaran
        //

        //
        //Data Tabungan
        //
        private void BindDataTabungan()
        {
            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();

            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string select = "select tab.id_tabung as ID, tab.nis as NIS, sis.nama as Nama, sis.kelas as Kelas, " +
                                "tab.jumlah as Jumlah, tab.tanggal as Tanggal, tu.nama as 'Nama TU' " +
                                "from ttabungan as tab " +
                                "join tsiswa as sis on(sis.nis = tab.nis) " +
                                "join ttu as tu on(tu.id_tu = tab.id_tu)";

                MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);
                MySqlDataReader reader = cmd.ExecuteReader();

                table = new DataTable();
                table.Load(reader);

                radGridTabungan.DataSource = table;

                koneksi.koneksiDB.Close();
            }
        }

        private void radGridTabungan_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            EditTabungan tabungan = new EditTabungan();
            tabungan.id = idtab;
            tabungan.nis = id;
            tabungan.nama = nama;
            tabungan.kelas = kelas;
            tabungan.jumlah = jumlah;
            tabungan.ShowDialog();
        }

        private void radGridTabungan_SelectionChanged(object sender, EventArgs e)
        {
            foreach (GridViewRowInfo row in radGridTabungan.SelectedRows)
            {
                idtab = row.Cells[0].Value.ToString();
                id = row.Cells[1].Value.ToString();
                nama = row.Cells[2].Value.ToString();
                kelas = row.Cells[3].Value.ToString();
                jumlah = row.Cells[4].Value.ToString();
            }
        }
        //
        //Akhir Data Tabungan
        //

        //
        //Data Tabungan
        //
        private void BindDataTabunganKeluar()
        {
            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();

            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string select = "select tab.id_tabung_keluar as ID, tab.nis as NIS, sis.nama as Nama, sis.kelas as Kelas, " +
                                "tab.jumlah as Jumlah, tab.tanggal as Tanggal, tu.nama as 'Nama TU' " +
                                "from ttabungankeluar as tab " +
                                "join tsiswa as sis on(sis.nis = tab.nis) " +
                                "join ttu as tu on(tu.id_tu = tab.id_tu)";

                MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);
                MySqlDataReader reader = cmd.ExecuteReader();

                table = new DataTable();
                table.Load(reader);

                radGridTabunganKeluar.DataSource = table;

                koneksi.koneksiDB.Close();
            }
        }

        
        
        //
        //Akhir Data Tabungan
        //

        //
        //Tabungan Total
        //
        private void BindDataTotalTabungan()
        {
            //SqlConnection connection = new SqlConnection(strConnection);
            koneksi = new Koneksi();

            using (koneksi.koneksiDB)
            {
                koneksi.koneksiDB.Open();

                string select = "select sis.nis as NIS, sis.nama as Nama, sis.kelas as Kelas, tab.total as Total from ttotal as tab "+
                                "join tsiswa as sis on(sis.nis = tab.nis)";

                MySqlCommand cmd = new MySqlCommand(select, koneksi.koneksiDB);
                MySqlDataReader reader = cmd.ExecuteReader();

                table = new DataTable();
                table.Load(reader);

                radGridTabunganSaldo.DataSource = table;

                koneksi.koneksiDB.Close();
            }
        }
        //
        //Akhir Tabungan Total
        //


        //
        //Tombol
        //

        //
        ////Tombol Ubah
        //
        private void radButtonUbah_Click(object sender, EventArgs e)
        {
            if (tombol == "tu")
            {
                EditTU editTU = new EditTU();
                editTU.id = id;
                editTU.nama = nama;
                editTU.password = password;
                editTU.ShowDialog();
            }
            else if (tombol == "siswa")
            {
                EditSiswa editsiswa = new EditSiswa();
                editsiswa.nis = id;
                editsiswa.nama = nama;
                editsiswa.kelas = kelas;
                editsiswa.ShowDialog();
            }
            else if (tombol == "pembayaran")
            {
                EditPembayaran pembayaran = new EditPembayaran();
                pembayaran.id = idtab;
                pembayaran.nis = id;
                pembayaran.nama = nama;
                pembayaran.kelas = kelas;
                pembayaran.cathering = cathering;
                pembayaran.bulan = bulan;
                pembayaran.ShowDialog();
            }
            else if (tombol == "surat")
            {
                EditSurat editSurat = new EditSurat();
                editSurat.id = id;
                editSurat.noSurat = noSurat;
                editSurat.lampiran = lampiran;
                editSurat.perihal = perihal;
                editSurat.jenis = jenis;
                editSurat.pengirim = pengirim;
                editSurat.ShowDialog();
            }
            else if (tombol == "pendaftaran")
            {
                EditDaftar daftar = new EditDaftar();
                daftar.idtab = idtab;
                daftar.nis = id;
                daftar.nama = nama;
                daftar.kelas = kelas;
                daftar.jenis = jenis;
                daftar.jumlah = jumlah;
                daftar.ShowDialog();
            }
            else if (tombol == "tabungan")
            {
                EditTabungan tabungan = new EditTabungan();
                tabungan.id = idtab;
                tabungan.nis = id;
                tabungan.nama = nama;
                tabungan.kelas = kelas;
                tabungan.jumlah = jumlah;
                tabungan.ShowDialog();
            }
        }

        //
        ////Akhir Tombol Ubah
        //


        //
        ////Tombol Refresh
        //
        private void radButtonRefresh_Click(object sender, EventArgs e)
        {
            BindDataTU();
            BindDataSiswa();
            BindDataPembayaran();
            BindDataSurat();
            BindDataDaftar();
            BindDataTabungan();
        }

        private void radButtonTambah_Click(object sender, EventArgs e)
        {
            if (tombol == "tu")
            {
                TambahTU tambahTU = new TambahTU();
                tambahTU.ShowDialog();
            }
            else if (tombol == "siswa")
            {
                TambahSiswa tambahSiswa = new TambahSiswa();
                tambahSiswa.ShowDialog();
            }
            else if (tombol == "pembayaran")
            {
                DataSiswa siswa = new DataSiswa();
                siswa.idTU = idTU;
                siswa.button = tombol;
                siswa.ShowDialog();

                BindDataTU();
                BindDataSiswa();
                BindDataPembayaran();
                BindDataSurat();
                BindDataDaftar();
                BindDataTabungan();
            }
            else if (tombol == "surat")
            {
                TambahSurat surat = new TambahSurat();
                surat.idTU = idTU;
                surat.ShowDialog();
            }
            else if (tombol == "pendaftaran")
            {
                DataSiswa siswa = new DataSiswa();
                siswa.idTU = idTU;
                siswa.button = tombol;
                siswa.ShowDialog();
            }
            else if (tombol == "tabungan")
            {
                DataSiswa siswa = new DataSiswa();
                siswa.idTU = idTU;
                siswa.button = tombol;
                siswa.ShowDialog();
            }
        }

        //
        ////Akhir Tombol Refresh
        //

        //
        ////Tombol Hapus
        //
        private void radButtonHapus_Click(object sender, EventArgs e)
        {
            if (tombol == "tu")
            {
                string namaHapus = nama;
                string title = "Pesan Konfirmasi";
                string messsage = "Anda yakin data dengan nama " + namaHapus.Trim() + " akan dihapus ?";
                DialogResult result = MessageBox.Show(messsage, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result != DialogResult.OK)
                {
                    return;
                }

                //SqlConnection connection = new SqlConnection(strConnection);
                koneksi = new Koneksi();
                using (koneksi.koneksiDB)
                {
                    koneksi.koneksiDB.Open();

                    string delete = "delete from ttu where id_tu = @id";

                    MySqlCommand cmd = new MySqlCommand(delete, koneksi.koneksiDB);

                    cmd.Parameters.AddWithValue("@id", id);

                    int insertResult = cmd.ExecuteNonQuery();

                    if (insertResult == 1)
                    {
                        MessageBox.Show("Sukses");
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }

                    koneksi.koneksiDB.Close();
                    BindDataTU();
                }
            }
            else if (tombol == "siswa")
            {
                string namaHapus = nama;
                string title = "Pesan Konfirmasi";
                string messsage = "Anda yakin data dengan nama " + namaHapus.Trim() + " akan dihapus ?";
                DialogResult result = MessageBox.Show(messsage, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result != DialogResult.OK)
                {
                    return;
                }

                //SqlConnection connection = new SqlConnection(strConnection);
                koneksi = new Koneksi();
                using (koneksi.koneksiDB)
                {
                    koneksi.koneksiDB.Open();

                    string delete = "delete from tsiswa where nis = @nis";

                    MySqlCommand cmd = new MySqlCommand(delete, koneksi.koneksiDB);

                    cmd.Parameters.AddWithValue("@nis", id);

                    int insertResult = cmd.ExecuteNonQuery();

                    if (insertResult == 1)
                    {
                        MessageBox.Show("Sukses");
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }

                    koneksi.koneksiDB.Close();
                    BindDataSiswa();
                }
            }
            else if (tombol == "pembayaran")
            {
                string namaHapus = nama;
                string title = "Pesan Konfirmasi";
                string messsage = "Anda yakin data dengan nama " + namaHapus.Trim() + " akan dihapus ?";
                DialogResult result = MessageBox.Show(messsage, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result != DialogResult.OK)
                {
                    return;
                }

                //SqlConnection connection = new SqlConnection(strConnection);
                koneksi = new Koneksi();
                using (koneksi.koneksiDB)
                {
                    koneksi.koneksiDB.Open();

                    string delete = "delete from tpembayaran where id_pembayaran = @id";

                    MySqlCommand cmd = new MySqlCommand(delete, koneksi.koneksiDB);

                    cmd.Parameters.AddWithValue("@id", idtab);

                    int insertResult = cmd.ExecuteNonQuery();

                    if (insertResult == 1)
                    {
                        MessageBox.Show("Sukses");
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }

                    koneksi.koneksiDB.Close();
                    BindDataPembayaran();
                }
            }
            else if (tombol == "surat")
            {
                string surat = noSurat;
                string title = "Pesan Konfirmasi";
                string messsage = "Anda yakin data dengan No Surat " + surat.Trim() + " akan dihapus ?";
                DialogResult result = MessageBox.Show(messsage, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result != DialogResult.OK)
                {
                    return;
                }

                //SqlConnection connection = new SqlConnection(strConnection);
                koneksi = new Koneksi();
                using (koneksi.koneksiDB)
                {
                    koneksi.koneksiDB.Open();

                    string delete = "delete from tsurat where id_surat = @id";

                    MySqlCommand cmd = new MySqlCommand(delete, koneksi.koneksiDB);

                    cmd.Parameters.AddWithValue("@id", id);

                    int insertResult = cmd.ExecuteNonQuery();

                    if (insertResult == 1)
                    {
                        MessageBox.Show("Sukses");
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }

                    koneksi.koneksiDB.Close();
                    BindDataSurat();
                }
            }
            else if (tombol == "pendaftaran")
            {
                string namaHapus = nama;
                string title = "Pesan Konfirmasi";
                string messsage = "Anda yakin data dengan nama " + namaHapus.Trim() + " akan dihapus ?";
                DialogResult result = MessageBox.Show(messsage, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result != DialogResult.OK)
                {
                    return;
                }

                //SqlConnection connection = new SqlConnection(strConnection);
                koneksi = new Koneksi();
                using (koneksi.koneksiDB)
                {
                    koneksi.koneksiDB.Open();

                    string delete = "delete from tdaftar where id_daftar = @id";

                    MySqlCommand cmd = new MySqlCommand(delete, koneksi.koneksiDB);

                    cmd.Parameters.AddWithValue("@id", idtab);

                    int insertResult = cmd.ExecuteNonQuery();

                    if (insertResult == 1)
                    {
                        MessageBox.Show("Sukses");
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }

                    koneksi.koneksiDB.Close();
                    BindDataDaftar();
                }
            }
            else if (tombol == "tabungan")
            {
                string namaHapus = nama;
                string title = "Pesan Konfirmasi";
                string messsage = "Anda yakin data dengan nama " + namaHapus.Trim() + " akan dihapus ?";
                DialogResult result = MessageBox.Show(messsage, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result != DialogResult.OK)
                {
                    return;
                }

                //SqlConnection connection = new SqlConnection(strConnection);
                koneksi = new Koneksi();
                using (koneksi.koneksiDB)
                {
                    koneksi.koneksiDB.Open();

                    string delete = "delete from ttabungan where id_tabung = @id";

                    MySqlCommand cmd = new MySqlCommand(delete, koneksi.koneksiDB);

                    cmd.Parameters.AddWithValue("@id", idtab);

                    int insertResult = cmd.ExecuteNonQuery();

                    if (insertResult == 1)
                    {
                        MessageBox.Show("Sukses");
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }

                    koneksi.koneksiDB.Close();
                    BindDataTabungan();
                }
            }
        }

        //
        ////Akhir Tombol Hapus
        //

        //
        ////Tombol Logout
        //

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Visible = true;
            this.Visible = false;
        }

        //
        ////Akhir Tombol Logout
        //

        //
        ////Tombol Exit
        //

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //
        ////Akhir Tombol Exit
        //

        //
        ////Tombol Tabungan Masuk
        //

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            tombol = "tabungan";
            radGridPembayaran.Visible = false;
            radGridSiswa.Visible = false;
            radGridTu.Visible = false;
            radGridSurat.Visible = false;
            radGridPendaftaran.Visible = false;
            radGridTabungan.Visible = true;
            radGridTabunganSaldo.Visible = false;
            radGridTabunganKeluar.Visible = false;
            radLabelMulai.Text = "Administrasi Sekolah [Data Tabungan Masuk]";
            radButtonTotal.Visible = true;
            radButtonTambah.Visible = true;
            radButtonUbah.Visible = true;
            radButtonHapus.Visible = true;
            radButtonRefresh.Visible = true;
            BindDataTabungan();
        }

        //
        ////Akhir Tombol Tabungan Masuk
        //

        //
        ////Tombol Tabungan Keluar
        //

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            tombol = "tabungankeluar";
            radGridPembayaran.Visible = false;
            radGridSiswa.Visible = false;
            radGridTu.Visible = false;
            radGridSurat.Visible = false;
            radGridPendaftaran.Visible = false;
            radGridTabungan.Visible = false;
            radGridTabunganSaldo.Visible = false;
            radGridTabunganKeluar.Visible = true;
            radLabelMulai.Text = "Administrasi Sekolah [Data Tabungan Keluar]";
            radButtonTotal.Visible = true;
            radButtonTambah.Visible = true;
            radButtonUbah.Visible = true;
            radButtonHapus.Visible = true;
            radButtonRefresh.Visible = true;
            BindDataTabunganKeluar();
        }

        //
        ////Akhir Tombol Tabungan Keluar
        //

        //
        ////Tombol Cari
        //

        private void radCari_Click(object sender, EventArgs e)
        {
            if (tombol == "tu")
            {
                DataView cari = new DataView(table);
                cari.RowFilter = string.Format("nama like '%{0}%'", textCari.Text);
                radGridTu.DataSource = cari;
            }
            else if (tombol == "siswa")
            {
                DataView cari = new DataView(table);
                cari.RowFilter = string.Format("nama like '%{0}%'", textCari.Text);
                radGridSiswa.DataSource = cari;
            }
            else if (tombol == "pembayaran")
            {
                DataView cari = new DataView(table);
                cari.RowFilter = string.Format("nama like '%{0}%'", textCari.Text);
                radGridPembayaran.DataSource = cari;
            }
            else if (tombol == "pendaftaran")
            {
                DataView cari = new DataView(table);
                cari.RowFilter = string.Format("nama like '%{0}%'", textCari.Text);
                radGridPendaftaran.DataSource = cari;
            }
            else if (tombol == "surat")
            {
                DataView cari = new DataView(table);
                cari.RowFilter = string.Format("nama like '%{0}%'", textCari.Text);
                radGridSurat.DataSource = cari;
            }
            else if (tombol == "tabungan")
            {
                DataView cari = new DataView(table);
                cari.RowFilter = string.Format("nama like '%{0}%'", textCari.Text);
                radGridTabungan.DataSource = cari;
            }
            else if (tombol == "total")
            {
                DataView cari = new DataView(table);
                cari.RowFilter = string.Format("nama like '%{0}%'", textCari.Text);
                radGridTabunganSaldo.DataSource = cari;
            }
        }

        //
        ////Akhir Tombol Cari
        //

        //
        ////Tombol Total
        //

        private void radButtonTotal_Click(object sender, EventArgs e)
        {
            FormTotal total = new FormTotal();
            total.button = tombol;
            total.nis = id;
            total.ShowDialog();
        }

        //
        ////Akhir Tombol Total
        //

        //
        ////Tombol About
        //

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        //
        ////Akhir Tombol About
        //
        
       //
        //Akhir Tombol
        //
    }
}
