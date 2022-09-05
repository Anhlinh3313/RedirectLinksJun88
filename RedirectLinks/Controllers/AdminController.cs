using Microsoft.AspNetCore.Mvc;
using RedirectLinks.DALs;
using RedirectLinks.Models;
using System;
using System.Threading.Tasks;

namespace RedirectLinks.Controllers
{
    public class AdminController : BaseController
    {
        LinkGroupDAL linkGroupDAL;
        LinkDAL linkDAL;
        BackgroundDAL backgroundDAL;
        
        public async Task<IActionResult> Index(long? linkGroupId, int pageIndex = 1, int pageSize = 10)
        {
            linkDAL = new LinkDAL();
            linkGroupDAL = new LinkGroupDAL();
            var links = await linkDAL.GetPaging(linkGroupId, pageIndex, pageSize);

            ViewBag.LinkGroups = await linkGroupDAL.GetAll();

            ViewBag.LinkGroupId = linkGroupId;
            ViewBag.PageIndex = pageIndex;
            ViewBag.PageSize = pageSize;

            return View(links);
        }

        public async Task<IActionResult> LinkGroup(string linkGroupName, int pageIndex = 1, int pageSize = 10)
        {
            linkGroupDAL = new LinkGroupDAL();
            var linkGroups = await linkGroupDAL.GetPaging(linkGroupName, pageIndex, pageSize);

            ViewBag.LinkGroupName = linkGroupName;
            ViewBag.PageIndex = pageIndex;
            ViewBag.PageSize = pageSize;
            return View(linkGroups);
        }

        public async Task<IActionResult> Background(long? linkGroupId, int pageIndex = 1, int pageSize = 10)
        {
            backgroundDAL = new BackgroundDAL();
            linkGroupDAL = new LinkGroupDAL();
            var backgrounds = await backgroundDAL.GetPaging(linkGroupId, pageIndex, pageSize);

            ViewBag.LinkGroups = await linkGroupDAL.GetAll();

            ViewBag.LinkGroupId = linkGroupId;
            ViewBag.PageIndex = pageIndex;
            ViewBag.PageSize = pageSize;

            return View(backgrounds);
        }

        [HttpPost]
        public async Task<JsonResult> InsertLinkGroup(LinkGroup linkGroup)
        {
            linkGroupDAL = new LinkGroupDAL();
            var response = await linkGroupDAL.Insert(linkGroup);
            return Json(response);
        }

        [HttpGet]
        public async Task<PartialViewResult> UpdateLinkGroup(long id)
        {
            linkGroupDAL = new LinkGroupDAL();
            var linkGroup = await linkGroupDAL.GetById(id);
            return PartialView(linkGroup);
        }

        [HttpPut]
        public async Task<JsonResult> UpdateLinkGroup(LinkGroup linkGroup)
        {
            linkGroupDAL = new LinkGroupDAL();
            linkGroup.UpdatedTime = DateTime.Now;
            var response = await linkGroupDAL.Update(linkGroup);
            return Json(response);
        }

        [HttpDelete]
        public async Task<JsonResult> DeleteLinkGroup(long id)
        {
            linkGroupDAL = new LinkGroupDAL();
            var response = await linkGroupDAL.Delete(id);
            return Json(response);
        }

        //Link CRUD
        [HttpPost]
        public async Task<JsonResult> InsertLink(Link link)
        {
            linkDAL = new LinkDAL();
            var response = await linkDAL.Insert(link);
            return Json(response);
        }

        [HttpGet]
        public async Task<PartialViewResult> UpdateLink(long id)
        {
            linkDAL = new LinkDAL();
            linkGroupDAL = new LinkGroupDAL();
            var link = await linkDAL.GetById(id);

            ViewBag.LinkGroups = await linkGroupDAL.GetAll();

            return PartialView(link);
        }

        [HttpPut]
        public async Task<JsonResult> UpdateLink(Link link)
        {
            linkDAL = new LinkDAL();
            link.UpdatedTime = DateTime.Now;
            var response = await linkDAL.Update(link);
            return Json(response);
        }

        [HttpDelete]
        public async Task<JsonResult> DeleteLink(long id)
        {
            linkDAL = new LinkDAL();
            var response = await linkDAL.Delete(id);
            return Json(response);
        }

        //Background CRUD
        [HttpPost]
        public async Task<JsonResult> InsertBackground(Background background)
        {
            backgroundDAL = new BackgroundDAL();
            var response = await backgroundDAL.Insert(background);
            return Json(response);
        }

        [HttpGet]
        public async Task<PartialViewResult> UpdateBackground(long id)
        {
            backgroundDAL = new BackgroundDAL();
            linkGroupDAL = new LinkGroupDAL();
            var background = await backgroundDAL.GetById(id);
            ViewBag.LinkGroups = await linkGroupDAL.GetAll();
            return PartialView(background);
        }

        [HttpPut]
        public async Task<JsonResult> UpdateBackground(Background background)
        {
            backgroundDAL = new BackgroundDAL();
            background.UpdatedTime = DateTime.Now;
            var response = await backgroundDAL.Update(background);
            return Json(response);
        }

        [HttpDelete]
        public async Task<JsonResult> DeleteBackground(long id)
        {
            backgroundDAL = new BackgroundDAL();
            var response = await backgroundDAL.Delete(id);
            return Json(response);
        }
    }
}
