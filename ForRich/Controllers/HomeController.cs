using ForRich.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForRich.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Profits()
        {
            return View();
        }
        public ActionResult Expences()
        {
            return View();
        }
        public ActionResult Plan_List()
        {
            return View();
        }
        public ActionResult Wish_List()
        {
            return View();
        }

        [HttpPost]
        public ActionResult _CreateOrdinaryUser ()
        {
            return PartialView();
        }
    }
}