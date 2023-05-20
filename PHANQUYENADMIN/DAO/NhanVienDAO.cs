using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHANQUYENADMIN.DAO
{
    internal class NhanVienDAO
    {
        //  NhanVien +PhanCong
        public static DataTable loadStaff()
        {
            String query = "SELECT * FROM sys.vw_NHANVIEN_XemThongTinCaNhan";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static String get_Logged_in_Role()
        {
            String query = "SELECT * FROM sys.vw_NHANVIEN_XemThongTinCaNhan";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0)
            {
                return "Admin";
            }
            return dt.Rows[0]["VaiTro"].ToString();
        }
        public static DataTable loadTasks()
        {
            String query = "SELECT * FROM sys.vw_NHANVIEN_XemThongTinPhanCong";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
