namespace FinalAdministasiSekolah
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textNama = new System.Windows.Forms.TextBox();
            this.radButtonBatal = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radButton1.Location = new System.Drawing.Point(271, 331);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(73, 30);
            this.radButton1.TabIndex = 9;
            this.radButton1.Text = "Masuk";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(174, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password";
            // 
            // Nama
            // 
            this.Nama.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Nama.AutoSize = true;
            this.Nama.BackColor = System.Drawing.Color.Transparent;
            this.Nama.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama.ForeColor = System.Drawing.Color.Transparent;
            this.Nama.Location = new System.Drawing.Point(174, 274);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(53, 19);
            this.Nama.TabIndex = 7;
            this.Nama.Text = "Nama";
            // 
            // textPass
            // 
            this.textPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textPass.Location = new System.Drawing.Point(271, 305);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(152, 20);
            this.textPass.TabIndex = 6;
            // 
            // textNama
            // 
            this.textNama.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textNama.Location = new System.Drawing.Point(271, 273);
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(152, 20);
            this.textNama.TabIndex = 5;
            // 
            // radButtonBatal
            // 
            this.radButtonBatal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radButtonBatal.Location = new System.Drawing.Point(350, 331);
            this.radButtonBatal.Name = "radButtonBatal";
            this.radButtonBatal.Size = new System.Drawing.Size(73, 30);
            this.radButtonBatal.TabIndex = 10;
            this.radButtonBatal.Text = "Keluar";
            this.radButtonBatal.Click += new System.EventHandler(this.radButtonBatal_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalAdministasiSekolah.Properties.Resources.cat21280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 396);
            this.Controls.Add(this.radButtonBatal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.textNama);
            this.Controls.Add(this.textPass);
            this.EnableKeyMap = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.ThemeName = "ControlDefault";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textNama;
        private Telerik.WinControls.UI.RadButton radButtonBatal;
    }
}
