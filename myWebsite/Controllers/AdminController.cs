using myWebsite.Models.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myWebsite.Controllers
{
    public class AdminController : Controller
    {
        context c = new context();
        [Authorize]
        public ActionResult Index()
        {
            var val = c.Webs.ToList();
            return View(val);
        }

        public ActionResult bringWeb(int id)
        {
            var bw = c.Webs.Find(id);
            return View("bringWeb", bw);
        }

        public ActionResult UpdateWebsite(Web x)
        {
            var uw = c.Webs.Find(x.id);
            uw.name = x.name;
            uw.profile = x.profile;
            uw.title = x.title;
            uw.explanation = x.explanation;
            uw.contact = x.contact;
            c.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}