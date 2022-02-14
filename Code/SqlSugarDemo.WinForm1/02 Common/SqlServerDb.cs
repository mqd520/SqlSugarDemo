using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;

namespace SqlSugarDemo.WinForm1._02_Common
{
    public static class SqlServerDb
    {
        static SqlServerDb()
        {

        }

        private static void CloseConnection(SqlConnection conn)
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

        private static void OpenConnection(SqlConnection conn)
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

        async private static Task OpenConnectionAsync(SqlConnection conn)
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

        private static SqlConnection CreateConnection()
        {
            string str = ConfigurationManager.ConnectionStrings["northwind2"].ConnectionString;
            return CreateConnection(str);
        }

        private static SqlConnection CreateConnection(string strConnection)
        {
            var conn = new SqlConnection(strConnection);
            return conn;
        }

        private static SqlCommand CreateCmd(string sql, SqlConnection conn, DbParameter[] paras)
        {
            var cmd = new SqlCommand(sql, conn);

            if (paras != null && paras.Length > 0)
            {
                foreach (var item in paras)
                {
                    cmd.Parameters.Add(item as SqlParameter);
                }
            }

            return cmd;
        }

        private static SqlDataAdapter CreateDataAdapter()
        {
            return new SqlDataAdapter();
        }

        public static DataTable GetTable(string sql, DbParameter[] paras)
        {
            DataTable dt = new DataTable();

            var conn = CreateConnection();
            var cmd = CreateCmd(sql, conn, paras);
            try
            {
                OpenConnection(conn);
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
                SqlDataReader dr = await cmd.ExecuteReaderAsync() as SqlDataReader;

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
