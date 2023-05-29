using PHANQUYENADMIN.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
        private void fNhanVien_Load(object sender, EventArgs e)
        {

            DataTable dt=NhanVienDAO.loadStaff();

            lbTen.Text= dt.Rows[0]["TENNV"].ToString();
            lbGioiTinh.Text= dt.Rows[0]["PHAI"].ToString();
            DateTime myDateTimeValue = Convert.ToDateTime
                (dt.Rows[0]["NGAYSINH"].ToString());
            lbNgaySinh.Text = myDateTimeValue.ToString("dd/MM/yyyy");
            lbDiaChi.Text= dt.Rows[0]["DIACHI"].ToString();
            lbVaiTro.Text= dt.Rows[0]["VAITRO"].ToString();
            lbMaNQL.Text= dt.Rows[0]["MANQL"].ToString();
            lbLuong.Text= dt.Rows[0]["LUONG"].ToString();
            lbPhuCap.Text= dt.Rows[0]["PHUCAP"].ToString();
            lbSDT.Text = dt.Rows[0]["SODT"].ToString();
            lbMaNV.Text = dt.Rows[0]["MANV"].ToString();
            //
            txtNgaySinh.Text = lbNgaySinh.Text;
            txtDiaChi.Text= dt.Rows[0]["DIACHI"].ToString();
            txtSDT.Text= dt.Rows[0]["SODT"].ToString();
            if(lbVaiTro.Text=="QL truc tiep")
            {
                loadDanhSachNhanVien();
            }
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
        private void loadDanhSachNhanVien()
        {
            DataTable dt = NhanVienDAO.loadDanhSachNhanVien();
            if (dt.Rows.Count != 0)
            {
                dgvDanhSachNhanVien.DataSource = dt;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            control = (control + 3) % 2;
            if (control == 0)
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
                try
                {
                    DateTime date = Convert.ToDateTime
                    (txtNgaySinh.Text);
                    String ngaysinh=date.ToString("yyyy-MM-dd");
                    NhanVienDAO.update_Inf(ngaysinh, txtDiaChi.Text, txtSDT.Text);
                    MessageBox.Show("Cập nhật thông tin thành công");
                }
                catch (Exception d)
                {
                    MessageBox.Show("Có lỗi xảy ra vui lòng thử lại sau");
                    return;
                }
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
                DateTime myDateTimeValue = Convert.ToDateTime
                (dt.Rows[0]["NGAYSINH"].ToString());
                lbNgaySinh.Text = myDateTimeValue.ToString("dd/MM/yyyy");
                lbDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
                lbVaiTro.Text = dt.Rows[0]["VAITRO"].ToString();
                lbMaNQL.Text = dt.Rows[0]["MANQL"].ToString();
                lbLuong.Text = dt.Rows[0]["LUONG"].ToString();
                lbPhuCap.Text = dt.Rows[0]["PHUCAP"].ToString();
                lbSDT.Text = dt.Rows[0]["SODT"].ToString();
                lbMaNV.Text = dt.Rows[0]["MANV"].ToString();
                //
                txtNgaySinh.Text = txtNgaySinh.Text = lbNgaySinh.Text;
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
            int selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dgvDanhSachNhanVien.Rows[selectedRowIndex];
            string manv = row.Cells["MANV"].Value.ToString();
            fThongTinNhanVien_QL fThongTinNhanVien_QL = new fThongTinNhanVien_QL(manv);
            this.Hide();
            fThongTinNhanVien_QL.ShowDialog();
            this.Show();
        }
    }
}
