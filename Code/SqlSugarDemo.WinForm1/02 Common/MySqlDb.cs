using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Configuration;

using MySql.Data.MySqlClient;

namespace SqlSugarDemo.WinForm1._02_Common
{
    /// <summary>
    /// MySqlDb
    /// </summary>
    public static class MySqlDb
    {
        static MySqlDb()
        {

        }

        private static void CloseConnection(MySqlConnection conn)
        {
            if (conn != null)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        private static void OpenConnection(MySqlConnection conn)
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async private static Task OpenConnectionAsync(MySqlConnection conn)
        {
            try
            {
                await conn.OpenAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static MySqlConnection CreateConnection()
        {
            string str = ConfigurationManager.ConnectionStrings["northwind"].ConnectionString;
            return CreateConnection(str);
        }

        private static MySqlConnection CreateConnection(string strConnection)
        {
            var conn = new MySqlConnection(strConnection);
            return conn;
        }

        private static MySqlCommand CreateCmd(string sql, MySqlConnection conn, DbParameter[] paras)
        {
            var cmd = new MySqlCommand(sql, conn);

            if (paras != null && paras.Length > 0)
            {
                foreach (var item in paras)
                {
                    cmd.Parameters.Add(item as MySqlParameter);
                }
            }

            return cmd;
        }

        private static MySqlDataAdapter CreateDataAdapter()
        {
            return new MySqlDataAdapter();
        }

        public static DataTable GetTable(string sql, DbParameter[] paras)
        {
            DataTable dt = new DataTable();

            var conn = CreateConnection();
            var cmd = CreateCmd(sql, conn, paras);
            OpenConnection(conn);
            try
            {
                var da = CreateDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);

                CloseConnection(conn);
            }
            catch (Exception ex)
            {
                CloseConnection(conn);
                throw ex;
            }

            return dt;
        }

        async public static Task<DataTable> GetTableAsync(string sql, DbParameter[] paras)
        {
            DataTable dt = new DataTable();

            var conn = CreateConnection();
            var cmd = CreateCmd(sql, conn, paras);
            await OpenConnectionAsync(conn);
            try
            {
                MySqlDataReader dr = await cmd.ExecuteReaderAsync() as MySqlDataReader;

                for (int i = 0; i < dr.FieldCount; i++)
                {
                    string columnName = dr.GetName(i);
                    dt.Columns.Add(new DataColumn(columnName));
                }

                while (await dr.ReadAsync())
                {
                    var row = dt.NewRow();
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        row[i] = dr.GetFieldValue<object>(i);
                    }

                    dt.Rows.Add(row);
                }

                CloseConnection(conn);
            }
            catch (Exception ex)
            {
                CloseConnection(conn);
                throw ex;
            }

            return dt;
        }
    }
}
