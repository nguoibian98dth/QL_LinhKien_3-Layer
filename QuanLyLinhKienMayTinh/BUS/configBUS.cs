using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using DAL;

namespace BUS
{
    public class configBUS
    {
        config co = new config();
        public static SqlConnection GetDBConnection(string datasource, string database, string username, string password)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }

        public static SqlConnection GetDBConnection()
        {
            string datasource = @"ADMIN";
            string database = "QLLinhKienMayTinh";
            string username = "sa";
            string password = "sa2012";

            return GetDBConnection(datasource, database, username, password);
        }

        public DataTable GetServerName()
        {
            return co.GetServerName();
        }

        public string GetNameDatabase()
        {
            return co.GetNameDatabase();
        }

        public DataTable GetDBName(string pServer)
        {
            return co.GetDBName(pServer);
        }

        public DataTable LayDBnames(string serverName)
        {
            return co.LayDBnames(serverName);
        }


        public List<string> GetDatabaseName(string pServerName, string pUser, string pPass)
        {
            return co.GetDatabaseName(pServerName, pUser, pPass);
        }

        public void ChangeConnectionString(string pServerName, string pDataBase, string pUser, string pPass)
        {
            co.ChangeConnectionString(pServerName, pDataBase, pUser, pPass);
        }

        public int Check_Config()
        {
            return co.Check_Config();
        }
    }
}

