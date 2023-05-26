using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANQUYENADMIN.DAO
{
    internal class NhanVienDAO
    {
        //  NhanVien +PhanCong
        public static DataTable loadStaff()
        {
            String query = "SELECT * FROM ADMIN01.vw_NHANVIEN_XemThongTinCaNhan";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static String get_Logged_in_Role()
        {
            String query = "SELECT * FROM ADMIN01.vw_NHANVIEN_XemThongTinCaNhan";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0)
            {
                return "Admin";
            }
            return dt.Rows[0]["VaiTro"].ToString();
        }
        public static int update_Inf(string date,string addr,string sodt)
        {
            
            String query = "BEGIN ADMIN01.usp_NHANVIEN_SuaThongTin("
                + "'"+date+"'" + "," + "'"+addr+"'" + "," + "'"+sodt+"'" + "); END;";     
            return DataProvider.Instance.ExecuteNonQuery(query);
            
        }
        public static DataTable loadTasks()
        {
            String query = "SELECT * FROM ADMIN01.vw_NHANVIEN_XemThongTinPhanCong";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        // Query cua quan ly truc tiep
        public static DataTable loadTasks(string manv)
        {
            String query = "SELECT * FROM ADMIN01.vw_QLTRUCTIEP_XemThongTinPhanCong where MANV='" + manv+"'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable loadStaffInf(string manv)
        {
            String query = "SELECT * FROM ADMIN01.vw_QLTRUCTIEP_XemThongTinNhanVien where MANV='" + manv+"'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable loadDanhSachNhanVien()
        {
            String query = "SELECT * FROM ADMIN01.vw_QLTRUCTIEP_XemThongTinNhanVien";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
