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
                String query = "ALTER USER john IDENTIFIED BY " + confirmpasword;
                DataProvider.Instance.ExecuteNonQuery(query);
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
        public static void Role2User(List<GrantRoleForm> grantRoles)
        {
            foreach (GrantRoleForm item in grantRoles)
            {
                if(item.Grant == true)
                {
                    String query = "grant " + item.RoleName.ToString() + " to " + "john ";
                    if (item.AdminOption == false)
                    {
                        DataProvider.Instance.ExecuteNonQuery(query);
                    }
                    else
                    {
                        query += "with admin option";
                        DataProvider.Instance.ExecuteNonQuery(query);
                    }
                }
                else if (item.Revoke == true)
                {
                    String query = "revoke " + item.RoleName + " from " + "john"; 
                }
            }
        }
        public static void Privilege2User(List<GrantRoleForm> grantRoles)
        {
            foreach (GrantRoleForm item in grantRoles)
            {
                if (item.Grant == true)
                {
                    String query = "grant " + item.RoleName + " to " + "john ";
                    if (item.AdminOption == false)
                    {
                        DataProvider.Instance.ExecuteNonQuery(query);
                    }
                    else
                    {
                        query += "with admin option";
                        DataProvider.Instance.ExecuteNonQuery(query);
                    }
                }
                else if (item.Revoke == true)
                {
                    String query = "revoke " + item.RoleName + " from " + "john";
                }
            }
        }
        public static void Table2User(List<GrantTableForm> grantTables)
        {
            foreach(GrantTableForm item in grantTables)
            {
                String query = "grant ";
                String select = " select ";
                String update = " update ";
                String insert = " insert ";
                String delete = " delete ";
                String table = " on " + item.TableName+" to john";

                if (item.Select == true)
                {
                    DataProvider.Instance.ExecuteNonQuery(query+select+table);
                }
                if (item.Update == true)
                {
                    DataProvider.Instance.ExecuteNonQuery(query + update + table);
                }
                if (item.Insert == true)
                {
                    DataProvider.Instance.ExecuteNonQuery(query + insert + table);
                }
                if (item.Delete == true)
                {
                    DataProvider.Instance.ExecuteNonQuery(query + delete + table);
                }
            }
        }
        public static void Role2Role(List<GrantRoleForm> grantRoles)
        {
            foreach (GrantRoleForm item in grantRoles)
            {
                if (item.Grant == true)
                {
                    String query = "grant " + item.RoleName.ToString() + " to " + "john ";
                    if (item.AdminOption == false)
                    {
                        DataProvider.Instance.ExecuteNonQuery(query);
                    }
                    else
                    {
                        query += "with admin option";
                        DataProvider.Instance.ExecuteNonQuery(query);
                    }
                }
                else if (item.Revoke == true)
                {
                    String query = "revoke " + item.RoleName + " from " + "john";
                }
            }
        }
        public static void Privilege2Role(List<GrantRoleForm> grantRoles)
        {
            foreach (GrantRoleForm item in grantRoles)
            {
                if (item.Grant == true)
                {
                    String query = "grant " + item.RoleName + " to " + "john ";
                    if (item.AdminOption == false)
                    {
                        DataProvider.Instance.ExecuteNonQuery(query);
                    }
                    else
                    {
                        query += "with admin option";
                        DataProvider.Instance.ExecuteNonQuery(query);
                    }
                }
                else if (item.Revoke == true)
                {
                    String query = "revoke " + item.RoleName + " from " + "john";
                }
            }
        }
    }
}
