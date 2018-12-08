using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPA_BackREST.DB
{
 



    public class DBUtil
    {
        string myConnectionString = "server=127.0.0.1;password=e12r04s97;port=1313; uid = postgres;database=CPA_DB";
        // Making connection with Npgsql provider
        NpgsqlConnection conn;



        public readonly IDataProtector protector = null;

        public DBUtil(IDataProtectionProvider provider)
        {
            protector = provider.CreateProtector(GetType().FullName);
            try
            {
                conn = new NpgsqlConnection(myConnectionString);
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write(ex.ToString());
                conn = null;
            }
        }

        public NpgsqlConnection GetConn()
        {
            return conn;
        }
    }
}
