using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutWebDemo.Controllers
{
   
    public class HomeController : Controller
    {
        [OutputCache(CacheProfile = "IndexProfile")]
        public ActionResult Default()
        {
            Response.Cache.SetOmitVaryStar(true);
            return View();
        }
        [OutputCache(CacheProfile = "IndexProfile")]
        public ActionResult Index()
        {
            Response.Cache.SetOmitVaryStar(true);
            return PartialView();
        }
        [OutputCache(CacheProfile = "IndexProfile")]
        public ActionResult About()
        {
            Response.Cache.SetOmitVaryStar(true);
            ViewBag.Message = "Your application description page.";

            return PartialView();
        }

        [ActionName("OurContact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            //当使用ActionName特性时，就需要设置PartialView返回的存在视图名称
            return PartialView("Contact");
        }

        [ChildActionOnly]
        public ActionResult SayHi()
        {
            return PartialView();
        }
    }
}