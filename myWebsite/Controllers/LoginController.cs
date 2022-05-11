using myWebsite.Models.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace myWebsite.Controllers
{
    public class LoginController : Controller
    {
        context c = new context(); 
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(admin ad)
        {
            var info = c.Admins.FirstOrDefault(x => x.username == ad.username && x.password == ad.password);
            if (info !=null)
            {
                FormsAuthentication.SetAuthCookie(info.username, false);
                Session["username"] = info.username.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }

    }
}