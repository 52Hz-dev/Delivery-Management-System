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
    public partial class fNhanVien_TruongPhong : Form
    {
        public fNhanVien_TruongPhong()
        {
            InitializeComponent();
            LabelLoad();
            fNhanVien_TruongPhongLoad();
        }
        private void LabelLoad()
        {
            //LABEL 5
            String query1 = "Select * from ADMIN01.vw_NHANVIEN_XemThongTinCaNhan";
            DataTable dt1 = DataProvider.Instance.ExecuteQuery(query1);
            this.label5.Text = dt1.Rows[0]["MANV"].ToString();
            //LABEL 6
            String query2 = "Select * from ADMIN01.vw_NHANVIEN_XemThongTinCaNhan";
            DataTable dt2 = DataProvider.Instance.ExecuteQuery(query2);
            this.label6.Text = dt2.Rows[0]["PHG"].ToString();
            //LABEL 7
            String query3 = "Select COUNT(*) from ADMIN01.NHANVIEN";
            DataTable dt3 = DataProvider.Instance.ExecuteQuery(query3);
            this.label7.Text = dt3.Rows[0][0].ToString();
        }
        private void fNhanVien_TruongPhongLoad()
        {
            String query4 = "Select * from ADMIN01.NHANVIEN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query4);
            dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mnv = textBox1.Text.ToString();
            String query4 = "Select * from ADMIN01.NHANVIEN WHERE MANV='"+mnv+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query4);
            dataGridView1.DataSource = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fNhanVien_TruongPhongLoad();
        }
    }
}
