namespace FinalAdministasiSekolah
{
    partial class TambahDaftar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelKelas = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelNIS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboJenis = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radButtonBatal = new Telerik.WinControls.UI.RadButton();
            this.radButtonTambah = new Telerik.WinControls.UI.RadButton();
            this.labelJumlah = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonTambah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKelas
            // 
            this.labelKelas.AutoSize = true;
            this.labelKelas.Location = new System.Drawing.Point(102, 58);
            this.labelKelas.Name = "labelKelas";
            this.labelKelas.Size = new System.Drawing.Size(33, 13);
            this.labelKelas.TabIndex = 21;
            this.labelKelas.Text = "kelas";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(102, 32);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(35, 13);
            this.labelNama.TabIndex = 20;
            this.labelNama.Text = "nama";
            // 
            // labelNIS
            // 
            this.labelNIS.AutoSize = true;
            this.labelNIS.Location = new System.Drawing.Point(102, 9);
            this.labelNIS.Name = "labelNIS";
            this.labelNIS.Size = new System.Drawing.Size(22, 13);
            this.labelNIS.TabIndex = 19;
            this.labelNIS.Text = "nis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kelas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "NIS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Jenis";
            // 
            // comboJenis
            // 
            this.comboJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboJenis.FormattingEnabled = true;
            this.comboJenis.Items.AddRange(new object[] {
            "Daftar Ulang",
            "Daftar Baru"});
            this.comboJenis.Location = new System.Drawing.Point(105, 82);
            this.comboJenis.Name = "comboJenis";
            this.comboJenis.Size = new System.Drawing.Size(121, 21);
            this.comboJenis.TabIndex = 23;
            this.comboJenis.SelectedIndexChanged += new System.EventHandler(this.comboJenis_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Jumlah";
            // 
            // radButtonBatal
            // 
            this.radButtonBatal.Location = new System.Drawing.Point(183, 139);
            this.radButtonBatal.Name = "radButtonBatal";
            this.radButtonBatal.Size = new System.Drawing.Size(80, 24);
            this.radButtonBatal.TabIndex = 27;
            this.radButtonBatal.Text = "Batal";
            this.radButtonBatal.Click += new System.EventHandler(this.radButtonBatal_Click);
            // 
            // radButtonTambah
            // 
            this.radButtonTambah.Location = new System.Drawing.Point(105, 139);
            this.radButtonTambah.Name = "radButtonTambah";
            this.radButtonTambah.Size = new System.Drawing.Size(72, 24);
            this.radButtonTambah.TabIndex = 26;
            this.radButtonTambah.Text = "Tambah";
            this.radButtonTambah.Click += new System.EventHandler(this.radButtonTambah_Click);
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Location = new System.Drawing.Point(102, 113);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(13, 13);
            this.labelJumlah.TabIndex = 25;
            this.labelJumlah.Text = "0";
            // 
            // TambahDaftar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 179);
            this.Controls.Add(this.radButtonBatal);
            this.Controls.Add(this.radButtonTambah);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboJenis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelKelas);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelNIS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TambahDaftar";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TambahDaftar";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.TambahDaftar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonTambah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKelas;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelNIS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboJenis;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadButton radButtonBatal;
        private Telerik.WinControls.UI.RadButton radButtonTambah;
        private System.Windows.Forms.Label labelJumlah;
    }
}
