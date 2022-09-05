using Dapper;
using RedirectLinks.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RedirectLinks.DALs
{
    public class LinkGroupDAL : DbContext
    {
        public async Task<ResponseModel> Insert(LinkGroup linkGroup)
        {
            var res = new ResponseModel();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@LinkGroupName", linkGroup.LinkGroupName, DbType.String, ParameterDirection.Input);
                var result = await connection.QueryAsync<ResponseModel>("SP_LinkGroup_Insert", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<ResponseModel> Update(LinkGroup linkGroup)
        {
            var res = new ResponseModel();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", linkGroup.Id, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@LinkGroupName", linkGroup.LinkGroupName, DbType.String, ParameterDirection.Input);
                parameters.Add("@UpdatedTime", linkGroup.UpdatedTime, DbType.DateTime, ParameterDirection.Input);
                var result = await connection.QueryAsync<ResponseModel>("SP_LinkGroup_Update", parameters, commandType: CommandType.StoredProcedure);
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
                var result = await connection.QueryAsync<ResponseModel>("SP_LinkGroup_Delete", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<PagedModel> GetPaging(string linkGroupName, int pageIndex, int pageSize)
        {
            var res = new PagedModel();
            var parameters = new DynamicParameters();
            parameters.Add("@LinkGroupName", linkGroupName, DbType.String, ParameterDirection.Input);
            parameters.Add("@PageIndex", pageIndex, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@PageSize", pageSize, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@TotalRecord", null, DbType.Int32, ParameterDirection.Output);
            var result = await connection.QueryAsync<LinkGroup>("SP_LinkGroup_GetPaging", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<LinkGroup> GetById(long id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, DbType.Int64, ParameterDirection.Input);
            var result = await connection.QueryAsync<LinkGroup>("SP_LinkGroup_GetById", parameters, commandType: CommandType.StoredProcedure);
            var res = result.SingleOrDefault();
            return res;
        }

        public async Task<List<LinkGroup>> GetAll()
        {
            var result = await connection.QueryAsync<LinkGroup>("SP_LinkGroup_GetAll", null, commandType: CommandType.StoredProcedure);
            var res = result.ToList();
            return res;
        }
    }
}
