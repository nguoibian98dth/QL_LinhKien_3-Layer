using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;


namespace DAL
{
    public class config
    {
        DataSQL dtsql = new DataSQL();
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
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            return table;
        }

        public string GetNameDatabase()
        {
            SqlConnection temp = new SqlConnection(Properties.Settings.Default.connectionString);
            string nameDatabase = temp.Database.ToString();
            return nameDatabase;
        }

        public DataTable GetDBName(string pServer)
        {
            int loi = 1;
            foreach (DataRow row in GetServerName().Rows)
            {
                foreach (var item in row.ItemArray) // Duyệt từng cột của dòng hiện tại
                {
                    if (item.ToString() == pServer)
                    {
                        loi = 0;
                        break;
                    }
                }
            }
            if (loi == 0)
                return LayDBnames(pServer);

            return null;
            
        }

        public DataTable LayDBnames(string serverName)
        {
            string sql_ncc = "select name from sys.databases where @@SERVERNAME='"+serverName+"' ";
            return dtsql.ExecQuery(sql_ncc);
        }


        public List<string> GetDatabaseName(string pServerName, string pUser, string pPass)
        {
            List<string> _list = new List<string>();
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM sys.databases tabases", "Data Source=" + pServerName + ";Initial Catalog=" + "master" + ";User ID=" + pUser + ";pwd = " + pPass + "");
                da.Fill(dt);
                foreach (System.Data.DataRow row in dt.Rows)
                {
                    foreach (System.Data.DataColumn col in dt.Columns)
                    {
                        _list.Add(row[col].ToString());
                    }
                }
            }
            catch
            {
                return null;
            }
            return _list;
        }

        public void ChangeConnectionString(string pServerName, string pDataBase, string pUser, string pPass)
        {
            Properties.Settings.Default["QLLinhKienMayTinhConnectionString"] = "Data Source=" + pServerName + ";Initial Catalog=" + pDataBase + ";User ID=" + pUser + ";pwd = " + pPass + "";
            //DAL.Properties.Settings.Default["QLLinhKienMayTinhConnectionString1"] = "Data Source=" + pServerName + ";Initial Catalog=" + pDataBase + ";User ID=" + pUser + ";pwd = " + pPass + "";
            Properties.Settings.Default.Save();
        }

        public int Check_Config()
        {
            if (Properties.Settings.Default.QLLinhKienMayTinhConnectionString == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            SqlConnection _Sqlconn = new
            SqlConnection(Properties.Settings.Default.QLLinhKienMayTinhConnectionString);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;// Chuỗi cấu hình không phù hợp.
            }
        }
    }
}
