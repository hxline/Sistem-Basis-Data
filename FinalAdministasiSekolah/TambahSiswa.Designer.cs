namespace FinalAdministasiSekolah
{
    partial class TambahSiswa
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
            this.textBoxNIS = new System.Windows.Forms.TextBox();
            this.radButtonSimpan = new Telerik.WinControls.UI.RadButton();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radButtonBatal = new Telerik.WinControls.UI.RadButton();
            this.comboBoxKelas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIS";
            // 
            // textBoxNIS
            // 
            this.textBoxNIS.Location = new System.Drawing.Point(98, 12);
            this.textBoxNIS.Name = "textBoxNIS";
            this.textBoxNIS.Size = new System.Drawing.Size(144, 20);
            this.textBoxNIS.TabIndex = 1;
            // 
            // radButtonSimpan
            // 
            this.radButtonSimpan.Location = new System.Drawing.Point(98, 90);
            this.radButtonSimpan.Name = "radButtonSimpan";
            this.radButtonSimpan.Size = new System.Drawing.Size(69, 24);
            this.radButtonSimpan.TabIndex = 2;
            this.radButtonSimpan.Text = "Simpan";
            this.radButtonSimpan.Click += new System.EventHandler(this.radButtonSimpan_Click);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(98, 38);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(144, 20);
            this.textBoxNama.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kelas";
            // 
            // radButtonBatal
            // 
            this.radButtonBatal.Location = new System.Drawing.Point(173, 90);
            this.radButtonBatal.Name = "radButtonBatal";
            this.radButtonBatal.Size = new System.Drawing.Size(69, 24);
            this.radButtonBatal.TabIndex = 3;
            this.radButtonBatal.Text = "Batal";
            this.radButtonBatal.Click += new System.EventHandler(this.radButtonBatal_Click);
            // 
            // comboBoxKelas
            // 
            this.comboBoxKelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKelas.FormattingEnabled = true;
            this.comboBoxKelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxKelas.Location = new System.Drawing.Point(98, 63);
            this.comboBoxKelas.Name = "comboBoxKelas";
            this.comboBoxKelas.Size = new System.Drawing.Size(45, 21);
            this.comboBoxKelas.TabIndex = 0;
            // 
            // TambahSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 143);
            this.Controls.Add(this.comboBoxKelas);
            this.Controls.Add(this.radButtonBatal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radButtonSimpan);
            this.Controls.Add(this.textBoxNIS);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TambahSiswa";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TambahSiswa";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNIS;
        private Telerik.WinControls.UI.RadButton radButtonSimpan;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadButton radButtonBatal;
        private System.Windows.Forms.ComboBox comboBoxKelas;
    }
}
