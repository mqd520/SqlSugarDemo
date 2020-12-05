using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using SqlSugar;

namespace SqlSugarDemo.DAL
{
    /// <summary>
    /// SqlSugar Helper
    /// </summary>
    public static class SqlSugarHelper
    {
        public static SqlSugarClient GetClient()
        {
            return GetClient("northwind");
        }

        public static SqlSugarClient GetClient(string name)
        {
            var css = ConfigurationManager.ConnectionStrings[name];
            if (css == null)
            {
                throw new Exception(string.Format("Not Found ConnectionStrings: {0}", name));
            }

            var cfg = new ConnectionConfig
            {
                ConnectionString = css.ConnectionString,
                DbType = GetDbType(css),
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            };

            return new SqlSugarClient(cfg);
        }

        /// <summary>
        /// Get Db Type
        /// </summary>
        /// <param name="css"></param>
        /// <returns></returns>
        public static DbType GetDbType(ConnectionStringSettings css)
        {
            if (css.ProviderName.Equals("MySql.Data.MySqlClient", StringComparison.OrdinalIgnoreCase))
            {
                return DbType.MySql;
            }

            else if (css.ProviderName.Equals("System.Data.SqlClient", StringComparison.OrdinalIgnoreCase))
            {
                return DbType.SqlServer;
            }

            throw new NotImplementedException(string.Format("Invalid ConnectionStrings Provider: {0}", css.ProviderName));
        }
    }
}
