using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutWebDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Default()
        {
            return View();
        }
        public ActionResult Index()
        {
            return PartialView();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return PartialView();
        }

        [ActionName("OurContact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return PartialView("Contact");
        }

        [ChildActionOnly]
        public ActionResult SayHi()
        {
            return PartialView();
        }
    }
}