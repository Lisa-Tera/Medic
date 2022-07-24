using Drug2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Drug2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Drug(string str)
        {
            if (string.IsNullOrEmpty(str))
                ViewBag.data = StaticVars.Drugs.Take(1);
            else
                ViewBag.data = StaticVars.Drugs.Where(row => row.ITEM_NAME.Contains(str));
            return View();
        }

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
        public ActionResult Login()
        {
            ViewBag.Message = "Your login page.";
            return View();
        }
    }
}