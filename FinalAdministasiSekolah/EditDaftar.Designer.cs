namespace FinalAdministasiSekolah
{
    partial class EditDaftar
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
            this.radButtonBatal = new Telerik.WinControls.UI.RadButton();
            this.radButtonUbah = new Telerik.WinControls.UI.RadButton();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboJenis = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelKelas = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelNIS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonUbah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButtonBatal
            // 
            this.radButtonBatal.Location = new System.Drawing.Point(188, 143);
            this.radButtonBatal.Name = "radButtonBatal";
            this.radButtonBatal.Size = new System.Drawing.Size(80, 24);
            this.radButtonBatal.TabIndex = 40;
            this.radButtonBatal.Text = "Batal";
            this.radButtonBatal.Click += new System.EventHandler(this.radButtonBatal_Click);
            // 
            // radButtonUbah
            // 
            this.radButtonUbah.Location = new System.Drawing.Point(110, 143);
            this.radButtonUbah.Name = "radButtonUbah";
            this.radButtonUbah.Size = new System.Drawing.Size(72, 24);
            this.radButtonUbah.TabIndex = 39;
            this.radButtonUbah.Text = "Ubah";
            this.radButtonUbah.Click += new System.EventHandler(this.radButtonUbah_Click);
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Location = new System.Drawing.Point(107, 117);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(13, 13);
            this.labelJumlah.TabIndex = 38;
            this.labelJumlah.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Jumlah";
            // 
            // comboJenis
            // 
            this.comboJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboJenis.FormattingEnabled = true;
            this.comboJenis.Items.AddRange(new object[] {
            "Daftar Ulang",
            "Daftar Baru"});
            this.comboJenis.Location = new System.Drawing.Point(110, 86);
            this.comboJenis.Name = "comboJenis";
            this.comboJenis.Size = new System.Drawing.Size(121, 21);
            this.comboJenis.TabIndex = 36;
            this.comboJenis.SelectedIndexChanged += new System.EventHandler(this.comboJenis_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Jenis";
            // 
            // labelKelas
            // 
            this.labelKelas.AutoSize = true;
            this.labelKelas.Location = new System.Drawing.Point(107, 62);
            this.labelKelas.Name = "labelKelas";
            this.labelKelas.Size = new System.Drawing.Size(33, 13);
            this.labelKelas.TabIndex = 34;
            this.labelKelas.Text = "kelas";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(107, 36);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(35, 13);
            this.labelNama.TabIndex = 33;
            this.labelNama.Text = "nama";
            // 
            // labelNIS
            // 
            this.labelNIS.AutoSize = true;
            this.labelNIS.Location = new System.Drawing.Point(107, 13);
            this.labelNIS.Name = "labelNIS";
            this.labelNIS.Size = new System.Drawing.Size(22, 13);
            this.labelNIS.TabIndex = 32;
            this.labelNIS.Text = "nis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Kelas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "NIS";
            // 
            // EditDaftar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 181);
            this.Controls.Add(this.radButtonBatal);
            this.Controls.Add(this.radButtonUbah);
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
            this.Name = "EditDaftar";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditDaftar";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.EditDaftar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonUbah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButtonBatal;
        private Telerik.WinControls.UI.RadButton radButtonUbah;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboJenis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelKelas;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelNIS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
