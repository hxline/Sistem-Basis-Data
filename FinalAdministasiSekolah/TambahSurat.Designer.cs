namespace FinalAdministasiSekolah
{
    partial class TambahSurat
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNoSurat = new System.Windows.Forms.TextBox();
            this.radButtonSimpan = new Telerik.WinControls.UI.RadButton();
            this.comboBoxJenis = new System.Windows.Forms.ComboBox();
            this.textBoxLampiran = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPerihal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPengirim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radButtonBatal = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nomor Surat";
            // 
            // textBoxNoSurat
            // 
            this.textBoxNoSurat.Location = new System.Drawing.Point(94, 15);
            this.textBoxNoSurat.Name = "textBoxNoSurat";
            this.textBoxNoSurat.Size = new System.Drawing.Size(168, 20);
            this.textBoxNoSurat.TabIndex = 1;
            // 
            // radButtonSimpan
            // 
            this.radButtonSimpan.Location = new System.Drawing.Point(94, 155);
            this.radButtonSimpan.Name = "radButtonSimpan";
            this.radButtonSimpan.Size = new System.Drawing.Size(81, 24);
            this.radButtonSimpan.TabIndex = 2;
            this.radButtonSimpan.Text = "Simpan";
            this.radButtonSimpan.Click += new System.EventHandler(this.radButtonSimpan_Click);
            // 
            // comboBoxJenis
            // 
            this.comboBoxJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJenis.FormattingEnabled = true;
            this.comboBoxJenis.Items.AddRange(new object[] {
            "Surat Masuk",
            "Surat Keluar"});
            this.comboBoxJenis.Location = new System.Drawing.Point(94, 93);
            this.comboBoxJenis.Name = "comboBoxJenis";
            this.comboBoxJenis.Size = new System.Drawing.Size(121, 21);
            this.comboBoxJenis.TabIndex = 0;
            // 
            // textBoxLampiran
            // 
            this.textBoxLampiran.Location = new System.Drawing.Point(94, 41);
            this.textBoxLampiran.Name = "textBoxLampiran";
            this.textBoxLampiran.Size = new System.Drawing.Size(168, 20);
            this.textBoxLampiran.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lampiran";
            // 
            // textBoxPerihal
            // 
            this.textBoxPerihal.Location = new System.Drawing.Point(94, 67);
            this.textBoxPerihal.Name = "textBoxPerihal";
            this.textBoxPerihal.Size = new System.Drawing.Size(168, 20);
            this.textBoxPerihal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Perihal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jenis Surat";
            // 
            // textBoxPengirim
            // 
            this.textBoxPengirim.Location = new System.Drawing.Point(94, 120);
            this.textBoxPengirim.Name = "textBoxPengirim";
            this.textBoxPengirim.Size = new System.Drawing.Size(168, 20);
            this.textBoxPengirim.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pengirim";
            // 
            // radButtonBatal
            // 
            this.radButtonBatal.Location = new System.Drawing.Point(181, 155);
            this.radButtonBatal.Name = "radButtonBatal";
            this.radButtonBatal.Size = new System.Drawing.Size(81, 24);
            this.radButtonBatal.TabIndex = 3;
            this.radButtonBatal.Text = "Batal";
            this.radButtonBatal.Click += new System.EventHandler(this.radButtonBatal_Click);
            // 
            // TambahSurat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 204);
            this.Controls.Add(this.radButtonBatal);
            this.Controls.Add(this.textBoxPengirim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPerihal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLampiran);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxJenis);
            this.Controls.Add(this.radButtonSimpan);
            this.Controls.Add(this.textBoxNoSurat);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TambahSurat";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TambahSurat";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.TambahSurat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNoSurat;
        private Telerik.WinControls.UI.RadButton radButtonSimpan;
        private System.Windows.Forms.ComboBox comboBoxJenis;
        private System.Windows.Forms.TextBox textBoxLampiran;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPerihal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPengirim;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadButton radButtonBatal;
    }
}
