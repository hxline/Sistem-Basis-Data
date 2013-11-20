namespace FinalAdministasiSekolah
{
    partial class AmbilTabungan
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
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.LabelNIS = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.TextJumlah = new Telerik.WinControls.UI.RadTextBox();
            this.ButtonAmbil = new Telerik.WinControls.UI.RadButton();
            this.ButtonBatal = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelNIS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextJumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAmbil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBatal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 17);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(24, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "NIS";
            // 
            // LabelNIS
            // 
            this.LabelNIS.Location = new System.Drawing.Point(70, 17);
            this.LabelNIS.Name = "LabelNIS";
            this.LabelNIS.Size = new System.Drawing.Size(24, 18);
            this.LabelNIS.TabIndex = 2;
            this.LabelNIS.Text = "NIS";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(12, 54);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(41, 18);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "Jumlah";
            // 
            // TextJumlah
            // 
            this.TextJumlah.Location = new System.Drawing.Point(70, 52);
            this.TextJumlah.Name = "TextJumlah";
            this.TextJumlah.Size = new System.Drawing.Size(100, 20);
            this.TextJumlah.TabIndex = 4;
            this.TextJumlah.TabStop = false;
            // 
            // ButtonAmbil
            // 
            this.ButtonAmbil.Location = new System.Drawing.Point(39, 97);
            this.ButtonAmbil.Name = "ButtonAmbil";
            this.ButtonAmbil.Size = new System.Drawing.Size(68, 24);
            this.ButtonAmbil.TabIndex = 5;
            this.ButtonAmbil.Text = "Ambil";
            this.ButtonAmbil.Click += new System.EventHandler(this.ButtonAmbil_Click);
            // 
            // ButtonBatal
            // 
            this.ButtonBatal.Location = new System.Drawing.Point(113, 97);
            this.ButtonBatal.Name = "ButtonBatal";
            this.ButtonBatal.Size = new System.Drawing.Size(68, 24);
            this.ButtonBatal.TabIndex = 6;
            this.ButtonBatal.Text = "Batal";
            this.ButtonBatal.Click += new System.EventHandler(this.ButtonBatal_Click);
            // 
            // AmbilTabungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 139);
            this.Controls.Add(this.ButtonBatal);
            this.Controls.Add(this.ButtonAmbil);
            this.Controls.Add(this.TextJumlah);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.LabelNIS);
            this.Controls.Add(this.radLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AmbilTabungan";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AmbilTabungan";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.AmbilTabungan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelNIS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextJumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAmbil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBatal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel LabelNIS;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox TextJumlah;
        private Telerik.WinControls.UI.RadButton ButtonAmbil;
        private Telerik.WinControls.UI.RadButton ButtonBatal;
    }
}
