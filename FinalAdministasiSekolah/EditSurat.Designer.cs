namespace FinalAdministasiSekolah
{
    partial class EditSurat
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
            this.textBoxPengirim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPerihal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLampiran = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxJenis = new System.Windows.Forms.ComboBox();
            this.radButtonUbah = new Telerik.WinControls.UI.RadButton();
            this.textBoxNoSurat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonUbah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButtonBatal
            // 
            this.radButtonBatal.Location = new System.Drawing.Point(184, 152);
            this.radButtonBatal.Name = "radButtonBatal";
            this.radButtonBatal.Size = new System.Drawing.Size(81, 24);
            this.radButtonBatal.TabIndex = 15;
            this.radButtonBatal.Text = "Batal";
            this.radButtonBatal.Click += new System.EventHandler(this.radButtonBatal_Click);
            // 
            // textBoxPengirim
            // 
            this.textBoxPengirim.Location = new System.Drawing.Point(97, 117);
            this.textBoxPengirim.Name = "textBoxPengirim";
            this.textBoxPengirim.Size = new System.Drawing.Size(168, 20);
            this.textBoxPengirim.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Pengirim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Jenis Surat";
            // 
            // textBoxPerihal
            // 
            this.textBoxPerihal.Location = new System.Drawing.Point(97, 64);
            this.textBoxPerihal.Name = "textBoxPerihal";
            this.textBoxPerihal.Size = new System.Drawing.Size(168, 20);
            this.textBoxPerihal.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Perihal";
            // 
            // textBoxLampiran
            // 
            this.textBoxLampiran.Location = new System.Drawing.Point(97, 38);
            this.textBoxLampiran.Name = "textBoxLampiran";
            this.textBoxLampiran.Size = new System.Drawing.Size(168, 20);
            this.textBoxLampiran.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lampiran";
            // 
            // comboBoxJenis
            // 
            this.comboBoxJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJenis.FormattingEnabled = true;
            this.comboBoxJenis.Items.AddRange(new object[] {
            "Surat Masuk",
            "Surat Keluar"});
            this.comboBoxJenis.Location = new System.Drawing.Point(97, 90);
            this.comboBoxJenis.Name = "comboBoxJenis";
            this.comboBoxJenis.Size = new System.Drawing.Size(121, 21);
            this.comboBoxJenis.TabIndex = 11;
            // 
            // radButtonUbah
            // 
            this.radButtonUbah.Location = new System.Drawing.Point(97, 152);
            this.radButtonUbah.Name = "radButtonUbah";
            this.radButtonUbah.Size = new System.Drawing.Size(81, 24);
            this.radButtonUbah.TabIndex = 14;
            this.radButtonUbah.Text = "Ubah";
            this.radButtonUbah.Click += new System.EventHandler(this.radButtonUbah_Click);
            // 
            // textBoxNoSurat
            // 
            this.textBoxNoSurat.Location = new System.Drawing.Point(97, 12);
            this.textBoxNoSurat.Name = "textBoxNoSurat";
            this.textBoxNoSurat.Size = new System.Drawing.Size(168, 20);
            this.textBoxNoSurat.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nomor Surat";
            // 
            // EditSurat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 189);
            this.Controls.Add(this.radButtonBatal);
            this.Controls.Add(this.textBoxPengirim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPerihal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLampiran);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxJenis);
            this.Controls.Add(this.radButtonUbah);
            this.Controls.Add(this.textBoxNoSurat);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSurat";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditSurat";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.EditSurat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonUbah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButtonBatal;
        private System.Windows.Forms.TextBox textBoxPengirim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPerihal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLampiran;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxJenis;
        private Telerik.WinControls.UI.RadButton radButtonUbah;
        private System.Windows.Forms.TextBox textBoxNoSurat;
        private System.Windows.Forms.Label label1;
    }
}
