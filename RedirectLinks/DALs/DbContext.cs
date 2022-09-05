using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace RedirectLinks.DALs
{
    public class DbContext
    {
        public static string path = @".\appsettings.json";
        public static string fullPath = Path.GetFullPath(path);
        public static IConfiguration config = new ConfigurationBuilder().AddJsonFile(fullPath, true, true).Build();
        public static string connectionString = config["ConnectionString"];
        public static IDbConnection connection = new SqlConnection(connectionString);
    }
}
