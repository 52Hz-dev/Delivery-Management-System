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
    public partial class fTruongPhong : Form
    {
        public fTruongPhong()
        {
            InitializeComponent();
            String query2 = "SELECT * FROM ADMIN01.vw_NHANVIEN_XemThongTinCaNhan";
            DataTable dt2 = DataProvider.Instance.ExecuteQuery(query2);
            this.label2.Text = dt2.Rows[0]["MANV"].ToString();
        }
        private void btn_TrgPhgInf_Click(object sender, EventArgs e)
        {
            fNhanVien nhanvien1 = new fNhanVien();
            this.Hide();
            nhanvien1.ShowDialog();
            this.Show();
        }

        private void btn_DsNVQL_Click(object sender, EventArgs e)
        {
            fNhanVien_TruongPhong nhanvientruongphong=new fNhanVien_TruongPhong();  
            this.Hide();
            nhanvientruongphong.ShowDialog();
            this.Show();
        }

        private void btn_PhanCongInf_Click(object sender, EventArgs e)
        {
            fPhanCong_TruongPhong phancong = new fPhanCong_TruongPhong();
            this.Hide();
            phancong.ShowDialog();
            this.Show() ;
        }
    }
}
