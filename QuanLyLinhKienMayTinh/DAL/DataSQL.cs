using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    public class DataSQL
    {

        public SqlConnection _connectionString = new SqlConnection(DAL.Properties.Settings.Default.QLLinhKienMayTinhConnectionString);
       
        public void OpenConnection()
        {
            if (_connectionString.State == ConnectionState.Closed)
            {
                _connectionString.Open();
            }
        }
        public void CloseConnection()
        {
            if (_connectionString != null)
            {
                _connectionString.Close();
            }
        }

        public DataTable ExecQuery(string sql)
        {
            OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand command = _connectionString.CreateCommand();
            command.CommandText = sql;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            CloseConnection();
            return dt;
        }

        public bool ExecuteReader(string sql)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand(sql, _connectionString);

            SqlDataReader rd = command.ExecuteReader();

            if (rd.Read())
            {
                CloseConnection();
                return true;
            }
            CloseConnection();
            return false;
        }

        public void ExecNonQuery(string sql)
        {
            OpenConnection();
            SqlCommand command = _connectionString.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();
        }

        public object ExecuteScalar(string sql)
        {
            OpenConnection();
            SqlCommand command = _connectionString.CreateCommand();
            command.CommandText = sql;
            //command.ExecuteScalar();
            return command.ExecuteScalar();
        }
    }
}
