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
    public partial class fTAICHINH : Form
    {
        public fTAICHINH()
        {
            InitializeComponent();
            load_NHANVIEN();
            load_PHANCONG();
        }

        private void load_PHANCONG()
        {
            GV_PhanCong.DataSource = AdminstratorDAO.TAICHINH_select_PHANCONG();
        }

        private void load_NHANVIEN()
        {
            GV_NhanVien.DataSource = AdminstratorDAO.TAICHINH_select_NHANVIEN();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV_NhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = GV_NhanVien.SelectedRows[0];

                // Lấy giá trị từ các cột dữ liệu
                txt_MaNV.Text = selectedRow.Cells["MANV"].Value.ToString();
                txt_Luong.Text = selectedRow.Cells["LUONG"].Value.ToString();
                txt_PhuCap.Text = selectedRow.Cells["PHUCAP"].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void fTAICHINH_Load(object sender, EventArgs e)
        {

        }

        private void txt_MaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void BT_Update_Click(object sender, EventArgs e)
        {
           
            
        }

        private void BT_Update_Click_1(object sender, EventArgs e)
        {
            if (AdminstratorDAO.updateNHANVIEN(txt_MaNV.Text, txt_Luong.Text, txt_PhuCap.Text) == 1)
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_NHANVIEN();
        }
    }
}
