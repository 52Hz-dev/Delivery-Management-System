﻿using PHANQUYENADMIN.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANQUYENADMIN
{
    public partial class fNhanVien : Form
    {
        private int control = 1;
        public fNhanVien()
        {
            InitializeComponent();
            loadTasks();
        }

        private void NhanVien_Click(object sender, EventArgs e)
        {

        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {

            DataTable dt=NhanVienDAO.loadStaff();

            lbTen.Text= dt.Rows[0]["TENNV"].ToString();
            lbGioiTinh.Text= dt.Rows[0]["PHAI"].ToString();
            lbNgaySinh.Text= dt.Rows[0]["NGAYSINH"].ToString(); 
            lbDiaChi.Text= dt.Rows[0]["DIACHI"].ToString();
            lbVaiTro.Text= dt.Rows[0]["VAITRO"].ToString();
            lbMaNQL.Text= dt.Rows[0]["MANQL"].ToString();
            lbLuong.Text= dt.Rows[0]["LUONG"].ToString();
            lbPhuCap.Text= dt.Rows[0]["PHUCAP"].ToString();
            lbSDT.Text = dt.Rows[0]["SODT"].ToString();
            lbMaNV.Text = dt.Rows[0]["MANV"].ToString();
            //
            txtNgaySinh.Text= dt.Rows[0]["NGAYSINH"].ToString();
            txtDiaChi.Text= dt.Rows[0]["DIACHI"].ToString();
            txtSDT.Text= dt.Rows[0]["SODT"].ToString();
            
        }
        private void loadTasks()
        {
            DataTable dt = NhanVienDAO.loadTasks();
            if (dt.Rows.Count != 0)
            {
                lbNoti.Visible = false;
                dvgPhanCong.DataSource = dt;
            }
        }
        private void dvgNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            control = (control + 1) / 2;
            if (control == 1)
            {
                btnCancel.Visible = true;
                btnChange.Text = "Lưu";
                lbNgaySinh.Visible = false;
                lbDiaChi.Visible = false;
                lbSDT.Visible = false;
                txtNgaySinh.Visible = true;
                txtDiaChi.Visible = true;
                txtSDT.Visible = true;
            }
            else
            {
                btnCancel.Visible = false;
                btnChange.Text = "Thay Đổi";
                lbNgaySinh.Visible = true;
                lbDiaChi.Visible = true;
                lbSDT.Visible = true;
                txtNgaySinh.Visible = false;
                txtDiaChi.Visible = false;
                txtSDT.Visible = false;
                DataTable dt = NhanVienDAO.loadStaff();
                lbTen.Text = dt.Rows[0]["TENNV"].ToString();
                lbGioiTinh.Text = dt.Rows[0]["PHAI"].ToString();
                lbNgaySinh.Text = dt.Rows[0]["NGAYSINH"].ToString();
                lbDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
                lbVaiTro.Text = dt.Rows[0]["VAITRO"].ToString();
                lbMaNQL.Text = dt.Rows[0]["MANQL"].ToString();
                lbLuong.Text = dt.Rows[0]["LUONG"].ToString();
                lbPhuCap.Text = dt.Rows[0]["PHUCAP"].ToString();
                lbSDT.Text = dt.Rows[0]["SODT"].ToString();
                lbMaNV.Text = dt.Rows[0]["MANV"].ToString();
                //
                txtNgaySinh.Text = dt.Rows[0]["NGAYSINH"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
                txtSDT.Text = dt.Rows[0]["SODT"].ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnChange.Text = "Thay Đổi";
            lbNgaySinh.Visible = true;
            lbDiaChi.Visible = true;
            lbSDT.Visible = true;
            txtNgaySinh.Visible = false;
            txtDiaChi.Visible = false;
            txtSDT.Visible = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
