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
        public static DataTable readUsersys()
        {
            String query = "SELECT * FROM dba_users";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable readSYSprivs(string name)
        {
            String query = "SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE = '" +name+"'" ;
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable readTABprivs(string name)
        {
            String query = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '" + name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable readROLEprivs(string name)
        {
            String query = "SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = '" + name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static void dropUser(string username)
        {
            String query = "alter session set \"_ORACLE_SCRIPT\" = TRUE";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            query = "drop user " + username;
            result = DataProvider.Instance.ExecuteNonQuery(query);
        }
        public static void dropRole(string rolename)
        {
            String query = "alter session set \"_ORACLE_SCRIPT\" = TRUE";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            query = "drop role " + rolename;
            result = DataProvider.Instance.ExecuteNonQuery(query);
            
        }
        public static int checkUserName(string username)
        {
            String query = "SELECT count(username) FROM all_users where username = '" + username + "'";
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result;
        }
        public static void createUser(string username, string pw)
        {
            String query = "alter session set \"_ORACLE_SCRIPT\" = TRUE";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            query = " create user " + username + " IDENTIFIED BY " + pw;
            result = DataProvider.Instance.ExecuteNonQuery(query);
        }
        public static int checkRoleName(string rolename)
        {
            String query = "select count(ROLE) from DBA_ROLES where ROLE = '" + rolename + "'";
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result;
        }
        public static void createRole(string rolename)
        {
            String query = "alter session set \"_ORACLE_SCRIPT\" = TRUE";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            query = " create role " + rolename;
            result = DataProvider.Instance.ExecuteNonQuery(query);
        }
        public static DataTable loadUserRole()
        {
            String query = "select ROLE R from DBA_ROLES";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable loadUser()
        {
            String query = "SELECT username U FROM all_users";
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
