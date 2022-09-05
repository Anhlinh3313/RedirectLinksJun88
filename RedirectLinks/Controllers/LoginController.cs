using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedirectLinks.DALs;
using RedirectLinks.Models;

namespace RedirectLinks.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Account admin)
        {
            if (ModelState.IsValid)
            {
                var encryptor = new Encryptor();
                var encryptedPassword = encryptor.Encrypt(admin.Password);
                admin.Password = encryptedPassword;
                var accountDAL = new AccountDAL();
                var response = accountDAL.Login(admin.UserName, admin.Password);
                if (response.Status == 1)
                {
                    HttpContext.Session.SetString("ADMIN_SESSION", admin.UserName);
                    return RedirectToAction("Index", "Admin");
                }
                else if (response.Status == 0)
                {
                    ViewBag.Notification = "Username was not exists!";
                }
                else if (response.Status == -1)
                {
                    ViewBag.Notification = "Wrong password!";
                }
            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}
