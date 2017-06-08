using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Polly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Polly's Posies Management System";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please call Admin if you have questions";

            return View();
        }
    }
}