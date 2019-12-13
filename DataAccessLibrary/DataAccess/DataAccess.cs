using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataAccessLibrary.DataAccess
{
    public class DataAccess
    {
        private static string GetConnectionString()
        {
            return $@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CollectorSQLDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }

        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                var response = cnn.Query<int>(sql, data).Single();
                return response;
                throw new Exception("Unexpected error while writing data");
            }
        }

        public static void ExecuteQuery(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                cnn.Query(sql);
            }
        }

        public static T GetSingleData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList()[0];
            }
        }
    }
}
