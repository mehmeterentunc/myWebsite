using myWebsite.Models.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myWebsite.Controllers
{
    public class WebController : Controller
    {
        context c = new context();

        public ActionResult Index()
        {
            var val = c.Webs.ToList();
            return View(val);
        }

        public PartialViewResult icons()
        {
            var val = c.iconss.ToList();
            return PartialView(val);
        }
    }
}