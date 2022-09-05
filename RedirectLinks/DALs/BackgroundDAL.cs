using Dapper;
using RedirectLinks.Models;
using RedirectLinks.Models.ViewModels;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RedirectLinks.DALs
{
    public class BackgroundDAL : DbContext
    {
        public async Task<ResponseModel> Insert(Background background)
        {
            var res = new ResponseModel();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@LinkgroupId", background.LinkGroupId, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@BackgroundImage", background.BackgroundImage, DbType.String, ParameterDirection.Input);
                var result = await connection.QueryAsync<ResponseModel>("SP_Background_Insert", parameters, commandType: CommandType.StoredProcedure);
                res = result.SingleOrDefault();
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                res.Status = -1;
                res.Message = ex.Message;
                res.Data = null;
            }
            return res;
        }

        public async Task<ResponseModel> Update(Background background)
        {
            var res = new ResponseModel();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", background.Id, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@LinkGroupId", background.LinkGroupId, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@BackgroundImage", background.BackgroundImage, DbType.String, ParameterDirection.Input);
                parameters.Add("@UpdatedTime", background.UpdatedTime, DbType.DateTime, ParameterDirection.Input);
                parameters.Add("@IsShow", background.IsShow, DbType.Boolean, ParameterDirection.Input);
                var result = await connection.QueryAsync<ResponseModel>("SP_Background_Update", parameters, commandType: CommandType.StoredProcedure);
                res = result.SingleOrDefault();
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                res.Status = -1;
                res.Message = ex.Message;
                res.Data = null;
            }
            return res;
        }

        public async Task<ResponseModel> Delete(long id)
        {
            var res = new ResponseModel();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", id, DbType.Int64, ParameterDirection.Input);
                var result = await connection.QueryAsync<ResponseModel>("SP_Background_Delete", parameters, commandType: CommandType.StoredProcedure);
                res = result.SingleOrDefault();
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                res.Status = -1;
                res.Message = ex.Message;
                res.Data = null;
            }
            return res;
        }

        public async Task<PagedModel> GetPaging(long? linkGroupId, int pageIndex, int pageSize)
        {
            var res = new PagedModel();
            var parameters = new DynamicParameters();
            parameters.Add("@LinkGroupId", linkGroupId, DbType.Int64, ParameterDirection.Input);
            parameters.Add("@PageIndex", pageIndex, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@PageSize", pageSize, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@TotalRecord", null, DbType.Int32, ParameterDirection.Output);
            var result = await connection.QueryAsync<BackgroundViewModel>("SP_Background_GetPaging", parameters, commandType: CommandType.StoredProcedure);
            var posts = result.ToList();
            res.PageIndex = pageIndex;
            res.PageSize = pageSize;
            res.TotalRecord = parameters.Get<int>("@TotalRecord");
            var totalPage = Math.Ceiling(Convert.ToDouble(res.TotalRecord) / pageSize);
            res.TotalPage = (int)totalPage;
            res.Data = posts;
            connection.Close();
            return res;
        }

        public async Task<Background> GetById(long id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, DbType.Int64, ParameterDirection.Input);
            var result = await connection.QueryAsync<Background>("SP_Background_GetById", parameters, commandType: CommandType.StoredProcedure);
            var res = result.SingleOrDefault();
            return res;
        }

        public async Task<Background> GetByLinkGroupName(string linkGroupName)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@LinkGroupName", linkGroupName, DbType.String, ParameterDirection.Input);
            var result = await connection.QueryAsync<Background>("SP_Background_GetByLinkGroupName", parameters, commandType: CommandType.StoredProcedure);
            var res = result.SingleOrDefault();
            return res;
        }
    }
}
