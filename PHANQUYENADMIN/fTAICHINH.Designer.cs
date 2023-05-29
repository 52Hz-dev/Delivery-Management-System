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
            this.GV_PhanCong = new System.Windows.Forms.DataGridView();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.GV_NhanVien = new System.Windows.Forms.DataGridView();
            this.txt_PhuCap = new System.Windows.Forms.TextBox();
            this.txt_Luong = new System.Windows.Forms.TextBox();
            this.BT_Update = new System.Windows.Forms.Button();
            this.LB_PhuCap = new System.Windows.Forms.Label();
            this.LB_Luong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.LB_Update = new System.Windows.Forms.Label();
            this.Tabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_PhanCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabcontrol
            // 
            this.Tabcontrol.Controls.Add(this.tabPage1);
            this.Tabcontrol.Controls.Add(this.tabPage2);
            this.Tabcontrol.Location = new System.Drawing.Point(0, 1);
            this.Tabcontrol.Name = "Tabcontrol";
            this.Tabcontrol.SelectedIndex = 0;
            this.Tabcontrol.Size = new System.Drawing.Size(1104, 561);
            this.Tabcontrol.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_PhuCap);
            this.tabPage1.Controls.Add(this.txt_Luong);
            this.tabPage1.Controls.Add(this.BT_Update);
            this.tabPage1.Controls.Add(this.LB_PhuCap);
            this.tabPage1.Controls.Add(this.LB_Luong);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_MaNV);
            this.tabPage1.Controls.Add(this.LB_Update);
            this.tabPage1.Controls.Add(this.GV_NhanVien);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1096, 528);
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
            this.tabPage2.Size = new System.Drawing.Size(1096, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phân công";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GV_PhanCong
            // 
            this.GV_PhanCong.AllowUserToAddRows = false;
            this.GV_PhanCong.AllowUserToDeleteRows = false;
            this.GV_PhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_PhanCong.Location = new System.Drawing.Point(3, 6);
            this.GV_PhanCong.Name = "GV_PhanCong";
            this.GV_PhanCong.ReadOnly = true;
            this.GV_PhanCong.RowHeadersWidth = 62;
            this.GV_PhanCong.RowTemplate.Height = 28;
            this.GV_PhanCong.Size = new System.Drawing.Size(555, 516);
            this.GV_PhanCong.TabIndex = 1;
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
            this.GV_NhanVien.Location = new System.Drawing.Point(-4, 0);
            this.GV_NhanVien.Name = "GV_NhanVien";
            this.GV_NhanVien.ReadOnly = true;
            this.GV_NhanVien.RowHeadersWidth = 62;
            this.GV_NhanVien.RowTemplate.Height = 28;
            this.GV_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_NhanVien.Size = new System.Drawing.Size(700, 525);
            this.GV_NhanVien.TabIndex = 0;
            this.GV_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_PhuCap
            // 
            this.txt_PhuCap.Location = new System.Drawing.Point(884, 152);
            this.txt_PhuCap.Name = "txt_PhuCap";
            this.txt_PhuCap.Size = new System.Drawing.Size(195, 26);
            this.txt_PhuCap.TabIndex = 16;
            // 
            // txt_Luong
            // 
            this.txt_Luong.Location = new System.Drawing.Point(884, 114);
            this.txt_Luong.Name = "txt_Luong";
            this.txt_Luong.Size = new System.Drawing.Size(195, 26);
            this.txt_Luong.TabIndex = 15;
            // 
            // BT_Update
            // 
            this.BT_Update.Location = new System.Drawing.Point(884, 231);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(75, 35);
            this.BT_Update.TabIndex = 14;
            this.BT_Update.Text = "Update";
            this.BT_Update.UseVisualStyleBackColor = true;
            this.BT_Update.Click += new System.EventHandler(this.BT_Update_Click_1);
            // 
            // LB_PhuCap
            // 
            this.LB_PhuCap.AutoSize = true;
            this.LB_PhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PhuCap.Location = new System.Drawing.Point(719, 152);
            this.LB_PhuCap.Name = "LB_PhuCap";
            this.LB_PhuCap.Size = new System.Drawing.Size(89, 25);
            this.LB_PhuCap.TabIndex = 13;
            this.LB_PhuCap.Text = "Phụ Cấp";
            // 
            // LB_Luong
            // 
            this.LB_Luong.AutoSize = true;
            this.LB_Luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Luong.Location = new System.Drawing.Point(718, 114);
            this.LB_Luong.Name = "LB_Luong";
            this.LB_Luong.Size = new System.Drawing.Size(67, 25);
            this.LB_Luong.TabIndex = 12;
            this.LB_Luong.Text = "Lương";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(715, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã nhân viên";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(884, 77);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.ReadOnly = true;
            this.txt_MaNV.Size = new System.Drawing.Size(195, 26);
            this.txt_MaNV.TabIndex = 10;
            // 
            // LB_Update
            // 
            this.LB_Update.AutoSize = true;
            this.LB_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Update.Location = new System.Drawing.Point(774, 17);
            this.LB_Update.Name = "LB_Update";
            this.LB_Update.Size = new System.Drawing.Size(299, 37);
            this.LB_Update.TabIndex = 9;
            this.LB_Update.Text = "Cập nhật thông tin";
            this.LB_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fTAICHINH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 558);
            this.Controls.Add(this.Tabcontrol);
            this.Name = "fTAICHINH";
            this.Text = "fTAICHINH";
            this.Load += new System.EventHandler(this.fTAICHINH_Load);
            this.Tabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV_PhanCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_NhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.DataGridView GV_PhanCong;
        private System.Windows.Forms.TextBox txt_PhuCap;
        private System.Windows.Forms.TextBox txt_Luong;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Label LB_PhuCap;
        private System.Windows.Forms.Label LB_Luong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label LB_Update;
        private System.Windows.Forms.DataGridView GV_NhanVien;
    }
}