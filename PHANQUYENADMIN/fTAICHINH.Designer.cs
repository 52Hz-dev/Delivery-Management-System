namespace PHANQUYENADMIN
{
    partial class fTAICHINH
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
            this.Tabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.GV_NhanVien = new System.Windows.Forms.DataGridView();
            this.GV_PhanCong = new System.Windows.Forms.DataGridView();
            this.Tabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_PhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabcontrol
            // 
            this.Tabcontrol.Controls.Add(this.tabPage1);
            this.Tabcontrol.Controls.Add(this.tabPage2);
            this.Tabcontrol.Location = new System.Drawing.Point(0, 1);
            this.Tabcontrol.Name = "Tabcontrol";
            this.Tabcontrol.SelectedIndex = 0;
            this.Tabcontrol.Size = new System.Drawing.Size(1074, 522);
            this.Tabcontrol.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GV_NhanVien);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1066, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GV_PhanCong);
            this.tabPage2.Controls.Add(this.printPreviewControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1066, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phân công";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(673, 137);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(8, 8);
            this.printPreviewControl1.TabIndex = 0;
            // 
            // GV_NhanVien
            // 
            this.GV_NhanVien.AllowUserToAddRows = false;
            this.GV_NhanVien.AllowUserToDeleteRows = false;
            this.GV_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GV_NhanVien.Location = new System.Drawing.Point(3, 3);
            this.GV_NhanVien.Name = "GV_NhanVien";
            this.GV_NhanVien.RowHeadersWidth = 62;
            this.GV_NhanVien.RowTemplate.Height = 28;
            this.GV_NhanVien.Size = new System.Drawing.Size(1060, 483);
            this.GV_NhanVien.TabIndex = 0;
            this.GV_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GV_PhanCong
            // 
            this.GV_PhanCong.AllowUserToAddRows = false;
            this.GV_PhanCong.AllowUserToDeleteRows = false;
            this.GV_PhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_PhanCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GV_PhanCong.Location = new System.Drawing.Point(3, 3);
            this.GV_PhanCong.Name = "GV_PhanCong";
            this.GV_PhanCong.ReadOnly = true;
            this.GV_PhanCong.RowHeadersWidth = 62;
            this.GV_PhanCong.RowTemplate.Height = 28;
            this.GV_PhanCong.Size = new System.Drawing.Size(1060, 483);
            this.GV_PhanCong.TabIndex = 1;
            // 
            // fTAICHINH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 521);
            this.Controls.Add(this.Tabcontrol);
            this.Name = "fTAICHINH";
            this.Text = "fTAICHINH";
            this.Tabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_PhanCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.DataGridView GV_NhanVien;
        private System.Windows.Forms.DataGridView GV_PhanCong;
    }
}