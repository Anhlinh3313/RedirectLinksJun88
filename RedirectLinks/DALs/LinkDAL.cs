using Dapper;
using RedirectLinks.Models;
using RedirectLinks.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RedirectLinks.DALs
{
    public class LinkDAL : DbContext
    {
        public async Task<ResponseModel> Insert(Link link)
        {
            var res = new ResponseModel();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@LinkGroupId", link.LinkGroupId, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@Url", link.Url, DbType.String, ParameterDirection.Input);
                parameters.Add("@LinkOrder", link.LinkOrder, DbType.Int32, ParameterDirection.Input);
                var result = await connection.QueryAsync<ResponseModel>("SP_Link_Insert", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<ResponseModel> Update(Link link)
        {
            var res = new ResponseModel();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", link.Id, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@LinkGroupId", link.LinkGroupId, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@Url", link.Url, DbType.String, ParameterDirection.Input);
                parameters.Add("@LinkOrder", link.LinkOrder, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@UpdatedTime", link.UpdatedTime, DbType.DateTime, ParameterDirection.Input);
                var result = await connection.QueryAsync<ResponseModel>("SP_Link_Update", parameters, commandType: CommandType.StoredProcedure);
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
                var result = await connection.QueryAsync<ResponseModel>("SP_Link_Delete", parameters, commandType: CommandType.StoredProcedure);
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
            var result = await connection.QueryAsync<LinkViewModel>("SP_Link_GetPaging", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<Link> GetById(long id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, DbType.Int64, ParameterDirection.Input);
            var result = await connection.QueryAsync<Link>("SP_Link_GetById", parameters, commandType: CommandType.StoredProcedure);
            var res = result.SingleOrDefault();
            return res;
        }

        public async Task<List<LinkViewModel>> GetAll(string linkGroupName)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@LinkGroupName", linkGroupName, DbType.String, ParameterDirection.Input);
            var result = await connection.QueryAsync<LinkViewModel>("SP_Link_GetAll", parameters, commandType: CommandType.StoredProcedure);
            var res = result.ToList();
            return res;
        }
    }
}
