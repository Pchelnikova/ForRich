using ForRich.Models;
using ForRich.Models.DBModels;
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
        [HttpPost]
        public ActionResult _ShowAll()
        {
            AppDbContext ctx = new AppDbContext();
            var data = ctx.Profits.ToList();
                
            return PartialView(data);
        }
        [HttpGet]
        public ActionResult _AddProfit()
        {
            return PartialView("_modalAddProfit");

            //AppDbContext ctx = new AppDbContext();
            //var data = ctx.Profits.ToList();
            //return PartialView(data);
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
        public ActionResult _CreateNewGroup()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult _Surname()
        {
            return PartialView();
        }
      
        [HttpPost]
        public ActionResult _EmailsForGroup(string surname)
        {
            AppDbContext ctx = new AppDbContext();
            ctx.Family.Add(new Models.DBModels.Family() { Name = surname });
            ctx.SaveChanges();
            return PartialView();
        }

        public ActionResult AfterRegistration ()
        {
            return View();
        }
      
      



    }
}