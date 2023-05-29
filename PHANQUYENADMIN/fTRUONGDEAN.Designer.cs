namespace PHANQUYENADMIN
{
    partial class fTRUONGDEAN
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
            this.GV_DEAN = new System.Windows.Forms.DataGridView();
            this.LB_CTDA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaDeAn = new System.Windows.Forms.TextBox();
            this.txt_TenDeAn = new System.Windows.Forms.TextBox();
            this.txt_NgayBatDau = new System.Windows.Forms.TextBox();
            this.txt_Phong = new System.Windows.Forms.TextBox();
            this.BT_Add = new System.Windows.Forms.Button();
            this.BT_Update = new System.Windows.Forms.Button();
            this.BT_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GV_DEAN)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_DEAN
            // 
            this.GV_DEAN.AllowUserToAddRows = false;
            this.GV_DEAN.AllowUserToDeleteRows = false;
            this.GV_DEAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_DEAN.Location = new System.Drawing.Point(0, -1);
            this.GV_DEAN.Name = "GV_DEAN";
            this.GV_DEAN.ReadOnly = true;
            this.GV_DEAN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_DEAN.Size = new System.Drawing.Size(445, 450);
            this.GV_DEAN.TabIndex = 0;
            this.GV_DEAN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LB_CTDA
            // 
            this.LB_CTDA.AutoSize = true;
            this.LB_CTDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CTDA.Location = new System.Drawing.Point(559, 47);
            this.LB_CTDA.Name = "LB_CTDA";
            this.LB_CTDA.Size = new System.Drawing.Size(153, 25);
            this.LB_CTDA.TabIndex = 1;
            this.LB_CTDA.Text = "Chi tiết đề án";
            this.LB_CTDA.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã đề án";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đề án";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(518, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(518, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phòng";
            // 
            // txt_MaDeAn
            // 
            this.txt_MaDeAn.Location = new System.Drawing.Point(628, 101);
            this.txt_MaDeAn.Name = "txt_MaDeAn";
            this.txt_MaDeAn.Size = new System.Drawing.Size(127, 20);
            this.txt_MaDeAn.TabIndex = 6;
            // 
            // txt_TenDeAn
            // 
            this.txt_TenDeAn.Location = new System.Drawing.Point(628, 128);
            this.txt_TenDeAn.Name = "txt_TenDeAn";
            this.txt_TenDeAn.Size = new System.Drawing.Size(127, 20);
            this.txt_TenDeAn.TabIndex = 7;
            // 
            // txt_NgayBatDau
            // 
            this.txt_NgayBatDau.Location = new System.Drawing.Point(628, 154);
            this.txt_NgayBatDau.Name = "txt_NgayBatDau";
            this.txt_NgayBatDau.Size = new System.Drawing.Size(127, 20);
            this.txt_NgayBatDau.TabIndex = 8;
            // 
            // txt_Phong
            // 
            this.txt_Phong.Location = new System.Drawing.Point(628, 180);
            this.txt_Phong.Name = "txt_Phong";
            this.txt_Phong.Size = new System.Drawing.Size(127, 20);
            this.txt_Phong.TabIndex = 9;
            // 
            // BT_Add
            // 
            this.BT_Add.Location = new System.Drawing.Point(521, 226);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(75, 23);
            this.BT_Add.TabIndex = 10;
            this.BT_Add.Text = "Thêm";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // BT_Update
            // 
            this.BT_Update.Location = new System.Drawing.Point(628, 226);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(75, 23);
            this.BT_Update.TabIndex = 11;
            this.BT_Update.Text = "Cập nhật";
            this.BT_Update.UseVisualStyleBackColor = true;
            this.BT_Update.Click += new System.EventHandler(this.button2_Click);
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(724, 226);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(75, 23);
            this.BT_Delete.TabIndex = 12;
            this.BT_Delete.Text = "Xoá";
            this.BT_Delete.UseVisualStyleBackColor = true;
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            // 
            // fTRUONGDEAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.BT_Update);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.txt_Phong);
            this.Controls.Add(this.txt_NgayBatDau);
            this.Controls.Add(this.txt_TenDeAn);
            this.Controls.Add(this.txt_MaDeAn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_CTDA);
            this.Controls.Add(this.GV_DEAN);
            this.Name = "fTRUONGDEAN";
            this.Text = "fTRUONGDEAN";
            ((System.ComponentModel.ISupportInitialize)(this.GV_DEAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_DEAN;
        private System.Windows.Forms.Label LB_CTDA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MaDeAn;
        private System.Windows.Forms.TextBox txt_TenDeAn;
        private System.Windows.Forms.TextBox txt_NgayBatDau;
        private System.Windows.Forms.TextBox txt_Phong;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Button BT_Delete;
    }
}