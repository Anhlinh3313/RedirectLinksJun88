using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RedirectLinks.DALs;
using RedirectLinks.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RedirectLinks.Controllers
{
    public class HomeController : Controller
    {
        LinkDAL linkDAL;
        BackgroundDAL backgroundDAL;

        public async Task<IActionResult> Index(string link)
        {
            linkDAL = new LinkDAL();
            backgroundDAL = new BackgroundDAL();
            if (link == null)
            {
                link = "jun88";
            }
            var links = await linkDAL.GetAll(link);
            var background = await backgroundDAL.GetByLinkGroupName(link);
            if (background != null)
            {
                ViewBag.Background = background.BackgroundImage;
            }
            

            return View(links);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
