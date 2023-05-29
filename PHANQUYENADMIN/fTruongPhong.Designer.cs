using PHANQUYENADMIN.DAO;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PHANQUYENADMIN
{
    partial class fTruongPhong
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_DsNVQL = new System.Windows.Forms.Button();
            this.btn_TrgPhgInf = new System.Windows.Forms.Button();
            this.btn_PhanCongInf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PHANQUYENADMIN.Properties.Resources.Multimedia__253_;
            this.pictureBox1.Location = new System.Drawing.Point(467, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "MÃ TRƯỞNG PHÒNG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(506, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_DsNVQL);
            this.panel1.Controls.Add(this.btn_TrgPhgInf);
            this.panel1.Controls.Add(this.btn_PhanCongInf);
            this.panel1.Location = new System.Drawing.Point(33, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 198);
            this.panel1.TabIndex = 3;
            // 
            // btn_DsNVQL
            // 
            this.btn_DsNVQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_DsNVQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DsNVQL.Location = new System.Drawing.Point(41, 115);
            this.btn_DsNVQL.Name = "btn_DsNVQL";
            this.btn_DsNVQL.Size = new System.Drawing.Size(356, 50);
            this.btn_DsNVQL.TabIndex = 4;
            this.btn_DsNVQL.Text = "Danh sách nhân viên quản lý";
            this.btn_DsNVQL.UseVisualStyleBackColor = false;
            this.btn_DsNVQL.Click += new System.EventHandler(this.btn_DsNVQL_Click);
            // 
            // btn_TrgPhgInf
            // 
            this.btn_TrgPhgInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_TrgPhgInf.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_TrgPhgInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrgPhgInf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_TrgPhgInf.Location = new System.Drawing.Point(384, 28);
            this.btn_TrgPhgInf.Name = "btn_TrgPhgInf";
            this.btn_TrgPhgInf.Size = new System.Drawing.Size(226, 49);
            this.btn_TrgPhgInf.TabIndex = 3;
            this.btn_TrgPhgInf.Text = "Thông tin cá nhân";
            this.btn_TrgPhgInf.UseVisualStyleBackColor = false;
            this.btn_TrgPhgInf.Click += new System.EventHandler(this.btn_TrgPhgInf_Click);
            // 
            // btn_PhanCongInf
            // 
            this.btn_PhanCongInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_PhanCongInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PhanCongInf.Location = new System.Drawing.Point(621, 115);
            this.btn_PhanCongInf.Name = "btn_PhanCongInf";
            this.btn_PhanCongInf.Size = new System.Drawing.Size(308, 50);
            this.btn_PhanCongInf.TabIndex = 2;
            this.btn_PhanCongInf.Text = "Thông tin phân công";
            this.btn_PhanCongInf.UseVisualStyleBackColor = false;
            this.btn_PhanCongInf.Click += new System.EventHandler(this.btn_PhanCongInf_Click);
            // 
            // fTruongPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fTruongPhong";
            this.Text = "fTruongPhong";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_PhanCongInf;
        private System.Windows.Forms.Button btn_TrgPhgInf;
        private System.Windows.Forms.Button btn_DsNVQL;
    }
}