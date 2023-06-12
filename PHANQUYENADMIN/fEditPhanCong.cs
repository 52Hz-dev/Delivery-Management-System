using PHANQUYENADMIN.DAO;
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
    public partial class fEditPhanCong : Form
    {
        public fEditPhanCong()
        {
            InitializeComponent();
            LabelLoad();
        }

        private void LabelLoad()
        {
            label8.Text = fPhanCong_TruongPhong.manv;
            label9.Text=fPhanCong_TruongPhong.mada;
        }
        private void button1_Click(object sender, EventArgs e)
        {    
            String manhanvien= label8.Text.ToString();
            String madean= label9.Text.ToString();
            String ngay = textBox1.Text.ToString();
            String thang = textBox2.Text.ToString();
            String nam=textBox3.Text.ToString();
            String check = NhanVienDAO.Execute_pr_CheckNhanVien(manhanvien).ToString();
            if (manhanvien=="" || madean=="" || ngay=="" || thang=="" || nam=="")
            {
                MessageBox.Show("Nhập thiếu thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }    
            else
            {
                
                String query = "UPDATE ADMIN01.PHANCONG SET THOIGIAN=TO_DATE('" + nam + "-" + thang + "-" + ngay + "','YYYY-MM-DD')";
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                
            }    
        }
    }
}
