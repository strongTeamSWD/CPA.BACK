using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace CPA_BackREST.DB
{
    public class DBUtil
    {
        private MySql.Data.MySqlClient.MySqlConnection connection;
        string myConnectionString = "server=127.0.0.1;port=3306;uid=root;sslmode = none;database=greetgo";

        public readonly IDataProtector protector = null;

        public DBUtil(IDataProtectionProvider provider)
        {
            protector = provider.CreateProtector(GetType().FullName);
            try
            {
                connection = new MySql.Data.MySqlClient.MySqlConnection
                {
                    ConnectionString = myConnectionString
                };
                connection.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write(ex.ToString());
                connection = null;
            }
        }

        public MySql.Data.MySqlClient.MySqlConnection GetConn()
        {
            return connection;
        }

        public MySql.Data.MySqlClient.MySqlCommand CreateCmd(string sql)
        {
            return new MySql.Data.MySqlClient.MySqlCommand(sql, this.connection);
        }

        public string ecryptPsw(string password)
        {
            return password;
        }
    }
}
