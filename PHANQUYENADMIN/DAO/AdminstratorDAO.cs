using PHANQUYENADMIN.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANQUYENADMIN.DAO
{
    internal class AdminstratorDAO
    {
        public static bool changeUserPassword(String password, String confirmpasword)
        {
            if(password == null || confirmpasword == null)
            {
                MessageBox.Show("Empty");
                return false;
                
            }
            if (password.Equals(confirmpasword))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Fail to confirm password");
                return false;
            }
        }
        public static void changeRole(List<GrantRoleForm> grantRoles)
        {
            foreach(GrantRoleForm item in grantRoles)
            {
                if(item.Grant==true)
                {
                    if (item.AdminOption == true)
                    {
                        // add role with admin option
                    }
                    else
                    {
                        // add role without admin option
                    }
                }
                if (item.Revoke == true)
                {
                    // revoke role from user
                }
            }
        }
        public static void changeTablePermission(List<GrantTableForm> grantTables)
        {
            foreach(GrantTableForm item in grantTables)
            {
                if (item.Select == true)
                {
                    // add select permission
                }
                if (item.Update == true)
                {
                    // add select permission
                }
                if (item.Insert == true)
                {
                    // add select permission
                }
                if (item.Delete == true)
                {
                    // add select permission
                }
            }
        }
        public static DataTable loadUserRole()
        {
            String query = "select ROLE R from DBA_ROLES";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable loadUserPrivilege()
        {
            String query = "SELECT distinct(PRIVILEGE) FROM DBA_SYS_PRIVS";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable loadTable()
        {
            String query = "SELECT TABLE_NAME FROM DBA_TABLES WHERE TABLESPACE_NAME='USERS'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
