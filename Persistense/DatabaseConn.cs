using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Persistense.Interface;

namespace Persistense
{
    public class DatabaseConn : IDatabaseConn
    {
        private static IConfiguration _configuration { get; set; }

        public DatabaseConn(IConfiguration conn)
        {
            _configuration = conn;
        }

        private static DbConnection GetConnection()
        {
            var conn = new MySqlConnection(_configuration.GetConnectionString("MysqlConnection"));
            conn.Open();
            return conn;
        }

        public IEnumerable<T> Query<T>(string query, object parameters = null)
        {
            using (var conn = GetConnection())
            {
                return conn.Query<T>(query, parameters);
            }
        }
        public void Query(string query, object parameters = null)
        {
            using (var conn = GetConnection())
            {
                conn.Execute(query, parameters);
            }
        }
    }
}
