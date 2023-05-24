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

        }
    }
}
