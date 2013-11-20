namespace FinalAdministasiSekolah
{
    partial class DataSiswa
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
            this.radGridSiswa = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGridSiswa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridSiswa.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridSiswa
            // 
            this.radGridSiswa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridSiswa.Location = new System.Drawing.Point(0, 0);
            // 
            // radGridSiswa
            // 
            this.radGridSiswa.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridSiswa.Name = "radGridSiswa";
            this.radGridSiswa.ReadOnly = true;
            this.radGridSiswa.Size = new System.Drawing.Size(298, 273);
            this.radGridSiswa.TabIndex = 0;
            this.radGridSiswa.Text = "radGridView1";
            this.radGridSiswa.SelectionChanged += new System.EventHandler(this.radGridSiswa_SelectionChanged);
            this.radGridSiswa.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridSiswa_CellDoubleClick);
            // 
            // DataSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 273);
            this.Controls.Add(this.radGridSiswa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataSiswa";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DataSiswa";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.DataSiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridSiswa.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridSiswa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridSiswa;
    }
}
