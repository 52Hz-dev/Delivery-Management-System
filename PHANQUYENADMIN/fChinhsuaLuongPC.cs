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
    public partial class fChinhsuaLuongPC : Form
    {
        public fChinhsuaLuongPC()
        {
            InitializeComponent();
        }

        private void fChinhsuaLuongPC_Load(object sender, EventArgs e)
        {
            txtMANV.Text = fTableNhanVien.MANV;
            txtLuong.Text = fTableNhanVien.LUONG;
            txtPhuCap.Text = fTableNhanVien.PHUCAP;
        }
    }
}
