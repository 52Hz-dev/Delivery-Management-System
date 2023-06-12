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
    public partial class fTRUONGDEAN : Form
    {
        public fTRUONGDEAN()
        {
            InitializeComponent();
            load_DEAN();
        }

        private void load_DEAN()
        {
            GV_DEAN.DataSource = AdminstratorDAO.TRUONGDEAN_select_DEAN();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(GV_DEAN.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = GV_DEAN.SelectedRows[0];

                // Lấy giá trị từ các cột dữ liệu
                txt_MaDeAn.Text = selectedRow.Cells["MADA"].Value.ToString();
                txt_TenDeAn.Text = selectedRow.Cells["TENDA"].Value.ToString();
                txt_NgayBatDau.Text = ((DateTime)selectedRow.Cells["NGAYBD"].Value).ToString("yyyy-MM-dd");
                txt_Phong.Text = selectedRow.Cells["PHONG"].Value.ToString();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AdminstratorDAO.checkMaDEAN(txt_MaDeAn.Text) != 1) MessageBox.Show("Mã đề án không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (AdminstratorDAO.updateDEAN(txt_MaDeAn.Text, txt_TenDeAn.Text, txt_NgayBatDau.Text, txt_Phong.Text) == 1)
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_DEAN();
            }
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            AdminstratorDAO.TRUONGDEAN_add_DEAN(txt_MaDeAn.Text, txt_TenDeAn.Text, txt_NgayBatDau.Text, txt_Phong.Text);
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_DEAN();
        }

        private void BT_Delete_Click(object sender, EventArgs e)
        {
            AdminstratorDAO.TRUONGDEAN_remove_DEAN(txt_MaDeAn.Text, txt_TenDeAn.Text, txt_NgayBatDau.Text, txt_Phong.Text);
            MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_DEAN();
        }
    }
}
