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
    public partial class fThongTinNhanVien_QL : Form
    {
        private string MaNV;
        public fThongTinNhanVien_QL()
        {
            InitializeComponent();
        }
        public fThongTinNhanVien_QL(String manv)
        {
            MaNV = manv;
            InitializeComponent();
            loadTasks(manv);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            DataTable dt = NhanVienDAO.loadStaffInf(MaNV);

            lbTen.Text = dt.Rows[0]["TENNV"].ToString();
            lbGioiTinh.Text = dt.Rows[0]["PHAI"].ToString();
            DateTime myDateTimeValue = Convert.ToDateTime
                (dt.Rows[0]["NGAYSINH"].ToString());
            lbNgaySinh.Text = myDateTimeValue.ToString("dd/MM/yyyy");
            lbDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
            lbVaiTro.Text = dt.Rows[0]["VAITRO"].ToString();
            lbMaNQL.Text = dt.Rows[0]["MANQL"].ToString();
            lbSDT.Text = dt.Rows[0]["SODT"].ToString();
            lbMaNV.Text = dt.Rows[0]["MANV"].ToString();

            ///
        }
        void loadTasks( string manv)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void fThongTinNhanVien_QL_Load(object sender, EventArgs e)
        {

        }
    }
}
