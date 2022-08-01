using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;
using WebApplication5.Data;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        private WebApplication5Context db = new WebApplication5Context();
        public ActionResult Index()
        {
            return View(db.Khoas.ToList());
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
    }
}