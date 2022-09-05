using Dapper;
using RedirectLinks.Models;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace RedirectLinks.DALs
{
    public class AccountDAL : DbContext
    {
        public ResponseModel Login(string userName, string password)
        {
            using IDbConnection connection = new SqlConnection(connectionString);
            var parameters = new DynamicParameters();
            parameters.Add("@UserName", userName, DbType.String, ParameterDirection.Input);
            parameters.Add("@Password", password, DbType.String, ParameterDirection.Input);
            var response = connection.Query<ResponseModel>("[SP_Account_Login]", parameters, commandType: CommandType.StoredProcedure).SingleOrDefault();
            connection.Close();
            return response;
        }
    }
}
