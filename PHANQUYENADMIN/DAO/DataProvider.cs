using Oracle.ManagedDataAccess.Client;
using PHANQUYENADMIN.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANQUYENADMIN.DAO
{
    internal class DataProvider
    {
        public static DataProvider Instance { get; set; }
        public static DataProvider getInstance(string user,string password)
        {
            if(Instance == null)
            {
                Instance = new DataProvider(user,password);
            }
            return Instance;
        }
        private DataProvider()
        {

            string connectionString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
     + "localhost" + ")(PORT = " + "1521" + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
     + "xe" + ")));Password=" +"234" + ";User ID=" + "sys as sysdba";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Ket noi ok");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private DataProvider(String username,String passowrd)
        {

            string connectionString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
     + "localhost" + ")(PORT = " + "1521" + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
     + "xe" + ")));Password=" + passowrd + ";User ID=" + username;

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Ket noi ok");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}


