namespace FinalAdministasiSekolah
{
    partial class TambahTabungan
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
            this.radButtonTambah = new Telerik.WinControls.UI.RadButton();
            this.label5 = new System.Windows.Forms.Label();
            this.labelKelas = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelNIS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textJumlah = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonTambah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButtonBatal
            // 
            this.radButtonBatal.Location = new System.Drawing.Point(191, 121);
            this.radButtonBatal.Name = "radButtonBatal";
            this.radButtonBatal.Size = new System.Drawing.Size(80, 24);
            this.radButtonBatal.TabIndex = 40;
            this.radButtonBatal.Text = "Batal";
            this.radButtonBatal.Click += new System.EventHandler(this.radButtonBatal_Click);
            // 
            // radButtonTambah
            // 
            this.radButtonTambah.Location = new System.Drawing.Point(113, 121);
            this.radButtonTambah.Name = "radButtonTambah";
            this.radButtonTambah.Size = new System.Drawing.Size(72, 24);
            this.radButtonTambah.TabIndex = 39;
            this.radButtonTambah.Text = "Tambah";
            this.radButtonTambah.Click += new System.EventHandler(this.radButtonTambah_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Jumlah";
            // 
            // labelKelas
            // 
            this.labelKelas.AutoSize = true;
            this.labelKelas.Location = new System.Drawing.Point(110, 68);
            this.labelKelas.Name = "labelKelas";
            this.labelKelas.Size = new System.Drawing.Size(33, 13);
            this.labelKelas.TabIndex = 34;
            this.labelKelas.Text = "kelas";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(110, 42);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(35, 13);
            this.labelNama.TabIndex = 33;
            this.labelNama.Text = "nama";
            // 
            // labelNIS
            // 
            this.labelNIS.AutoSize = true;
            this.labelNIS.Location = new System.Drawing.Point(110, 19);
            this.labelNIS.Name = "labelNIS";
            this.labelNIS.Size = new System.Drawing.Size(22, 13);
            this.labelNIS.TabIndex = 32;
            this.labelNIS.Text = "nis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Kelas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "NIS";
            // 
            // textJumlah
            // 
            this.textJumlah.Location = new System.Drawing.Point(113, 89);
            this.textJumlah.Name = "textJumlah";
            this.textJumlah.Size = new System.Drawing.Size(100, 20);
            this.textJumlah.TabIndex = 1;
            // 
            // TambahTabungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 162);
            this.Controls.Add(this.textJumlah);
            this.Controls.Add(this.radButtonBatal);
            this.Controls.Add(this.radButtonTambah);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelKelas);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelNIS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TambahTabungan";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TambahTabungan";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.TambahTabungan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonTambah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButtonBatal;
        private Telerik.WinControls.UI.RadButton radButtonTambah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelKelas;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelNIS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textJumlah;
    }
}
