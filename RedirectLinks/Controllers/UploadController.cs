using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedirectLinks.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace RedirectLinks.Controllers
{
    public class UploadController : Controller
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        public UploadController(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }

        [HttpPost]
        public async Task<JsonResult> UploadFile(IFormFile file)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                var wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                string extension = Path.GetExtension(file.FileName);
                fileName = fileName + "-" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + extension;
                string relativePath = "/images/uploads/" + fileName;
                string path = Path.Combine(wwwRootPath + "/images/uploads", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
                responseModel.Status = 1;
                responseModel.Message = "Upload success!";
                responseModel.Data = relativePath;
                return Json(responseModel);
            }
            catch (Exception ex)
            {
                responseModel.Status = 1;
                responseModel.Message = ex.Message;
                return Json(responseModel);
            }
        }
    }
}
