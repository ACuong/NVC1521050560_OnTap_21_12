using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NVC1521050560.Models;

namespace NVC1521050560.Controllers
{
    public class HomeController : Controller
    {
        GiaiPTBac1 gptbac1 = new GiaiPTBac1();


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

        public ActionResult GiaiPTbac1()
        {
            return View();
        }

        [HttpPost]
        
        public ActionResult GiaiPTbac1(double hesoa, double hesob)
        {
            double x = gptbac1.GiaiPTBacMot(hesoa, hesob);
            ViewBag.nghiemPT = x;
            return View();
        }


    }
}