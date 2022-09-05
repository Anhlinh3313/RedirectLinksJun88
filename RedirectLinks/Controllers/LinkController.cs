using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using RedirectLinks.DALs;
using RedirectLinks.Models;
using System;
using System.Threading.Tasks;

namespace RedirectLinks.Controllers
{
    public class LinkController : Controller
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        public LinkController(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<JsonResult> GetLinkGroup()
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                LinkGroupDAL linkGroupDAL = new LinkGroupDAL();
                var linkGroups = await linkGroupDAL.GetAll();
                responseModel.Status = 1;
                responseModel.Message = "success";
                responseModel.Data = linkGroups;
                return Json(responseModel);
            }
            catch (Exception ex)
            {
                responseModel.Status = 0;
                responseModel.Message = ex.Message;
                return Json(responseModel);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<JsonResult> GetLink(long? linkGroupId, int pageIndex = 1, int pageSize = 10)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                LinkDAL linkDAL = new LinkDAL();
                var links = await linkDAL.GetPaging(linkGroupId, pageIndex, pageSize);
                responseModel.Status = 1;
                responseModel.Message = "success";
                responseModel.Data = links;
                return Json(responseModel);
            }
            catch (Exception ex)
            {
                responseModel.Status = 0;
                responseModel.Message = ex.Message;
                return Json(responseModel);
            }
        }
    }
}