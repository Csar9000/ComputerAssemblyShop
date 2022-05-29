using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ComputerAssemblyShop;

namespace ComputerAssemblyShop.Controllers
{
    public class HomeController : Controller
    {
        private ComputerAssemblyEntities db = new ComputerAssemblyEntities();
        public ActionResult Complectation()
        {
            ViewBag.Accessory = new SelectList(db.AccessoryTable.ToList(), "Id", "Name");

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
    }
}