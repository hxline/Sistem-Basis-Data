namespace FinalAdministasiSekolah
{
    partial class EditPembayaran
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
            this.checkBoxCathering = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radButtonBatal = new Telerik.WinControls.UI.RadButton();
            this.radButtonUbah = new Telerik.WinControls.UI.RadButton();
            this.comboBoxBulan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonUbah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKelas
            // 
            this.labelKelas.AutoSize = true;
            this.labelKelas.Location = new System.Drawing.Point(107, 69);
            this.labelKelas.Name = "labelKelas";
            this.labelKelas.Size = new System.Drawing.Size(33, 13);
            this.labelKelas.TabIndex = 21;
            this.labelKelas.Text = "kelas";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(107, 43);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(35, 13);
            this.labelNama.TabIndex = 20;
            this.labelNama.Text = "nama";
            // 
            // labelNIS
            // 
            this.labelNIS.AutoSize = true;
            this.labelNIS.Location = new System.Drawing.Point(107, 20);
            this.labelNIS.Name = "labelNIS";
            this.labelNIS.Size = new System.Drawing.Size(22, 13);
            this.labelNIS.TabIndex = 19;
            this.labelNIS.Text = "nis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kelas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "NIS";
            // 
            // checkBoxCathering
            // 
            this.checkBoxCathering.AutoSize = true;
            this.checkBoxCathering.Location = new System.Drawing.Point(108, 95);
            this.checkBoxCathering.Name = "checkBoxCathering";
            this.checkBoxCathering.Size = new System.Drawing.Size(32, 17);
            this.checkBoxCathering.TabIndex = 23;
            this.checkBoxCathering.Text = "0";
            this.checkBoxCathering.UseVisualStyleBackColor = true;
            this.checkBoxCathering.CheckedChanged += new System.EventHandler(this.checkBoxCathering_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cathering";
            // 
            // radButtonBatal
            // 
            this.radButtonBatal.Location = new System.Drawing.Point(186, 153);
            this.radButtonBatal.Name = "radButtonBatal";
            this.radButtonBatal.Size = new System.Drawing.Size(80, 24);
            this.radButtonBatal.TabIndex = 25;
            this.radButtonBatal.Text = "Batal";
            this.radButtonBatal.Click += new System.EventHandler(this.radButtonBatal_Click);
            // 
            // radButtonUbah
            // 
            this.radButtonUbah.Location = new System.Drawing.Point(108, 153);
            this.radButtonUbah.Name = "radButtonUbah";
            this.radButtonUbah.Size = new System.Drawing.Size(72, 24);
            this.radButtonUbah.TabIndex = 24;
            this.radButtonUbah.Text = "Ubah";
            this.radButtonUbah.Click += new System.EventHandler(this.radButtonUbah_Click);
            // 
            // comboBoxBulan
            // 
            this.comboBoxBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBulan.FormattingEnabled = true;
            this.comboBoxBulan.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.comboBoxBulan.Location = new System.Drawing.Point(108, 118);
            this.comboBoxBulan.Name = "comboBoxBulan";
            this.comboBoxBulan.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBulan.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Bulan";
            // 
            // EditPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 189);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxBulan);
            this.Controls.Add(this.radButtonBatal);
            this.Controls.Add(this.radButtonUbah);
            this.Controls.Add(this.checkBoxCathering);
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
            this.Name = "EditPembayaran";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditPembayaran";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.EditPembayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonUbah)).EndInit();
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
        private System.Windows.Forms.CheckBox checkBoxCathering;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadButton radButtonBatal;
        private Telerik.WinControls.UI.RadButton radButtonUbah;
        private System.Windows.Forms.ComboBox comboBoxBulan;
        private System.Windows.Forms.Label label4;
    }
}
