using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TESTMultiUserApp.Controllers
{
    public class HomeController : Controller
    {
    /// this is index controller
        public ActionResult Index()
        {
            return View();

        }
        // comment on about view of home controller to check commit
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
