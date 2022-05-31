using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ComputerAssemblyShop
{
    public class AccessoryTablesController : Controller
    {

        private ComputerAssemblyEntities db = new ComputerAssemblyEntities();

        // GET: AccessoryTables
        public ActionResult Index()
        {
            return View(db.AccessoryTable.ToList());
        }

        public ActionResult Complectation()
        {
            return View(db.AccessoryTable.ToList());
        }

        public ActionResult Create()
        {
            return PartialView();
        }

        public ActionResult CreateOrder([Bind(Include = "id,processor,videoCard,disc,korpus,mouse,ozu,keyboard,kuler,date,FIO,Address,PhoneNumber,price")] Orders orders,string Person,string PhoneNumber,string Address)
        {
            orders.processor = Session["ProcessorName"].ToString();
            orders.videoCard = Session["VideoCardName"].ToString();
            orders.disc = Session["DiskName"].ToString();
            orders.korpus = Session["KorpusName"].ToString();
            orders.mouse = Session["MouseName"].ToString();
            orders.ozu = Session["OZUName"].ToString();
            orders.keyboard = Session["KeyboardName"].ToString();
            orders.kuler = Session["KulerName"].ToString();
            orders.date = System.DateTime.Now.ToString();
            orders.price = int.Parse(Session["ResultSum"].ToString());
            orders.Address = "Ya";
            orders.FIO = "Ya";
            orders.PhoneNumber = "890567835334";



            if (ModelState.IsValid)
            {
                db.Orders.Add(orders);
                db.SaveChanges();
            }

            return RedirectToAction("Complectation");
        }



        public ActionResult addComplect(int? id)
        {
            if (Session["ResultSum"] == null)
            {
                Session["ResultSum"] = 0;
            }

            AccessoryTable accessoryTable = db.AccessoryTable.Find(id);
            switch (accessoryTable.type)
            {
                case "vid":
                    {
                        Session["vidId"] = accessoryTable.id;
                        Session["VideoCardName"] = accessoryTable.name;
                        Session["VideoCardPrice"] = accessoryTable.price;
                        Session["ResultSum"] = int.Parse(Session["ResultSum"].ToString()) + accessoryTable.price;
                        break;
                    }
                case "proc":
                    {
                        Session["procId"] = accessoryTable.id;
                        Session["ProcessorName"] = accessoryTable.name;
                        Session["ProcPrice"] = accessoryTable.price;
                        Session["ResultSum"] = int.Parse(Session["ResultSum"].ToString()) + accessoryTable.price;
                        break;
                    }
                case "disc":
                    {
                        Session["discId"] = accessoryTable.id;
                        Session["DiskName"] = accessoryTable.name;
                        Session["DiskPrice"] = accessoryTable.price;
                        Session["ResultSum"] = int.Parse(Session["ResultSum"].ToString()) + accessoryTable.price;
                        break;
                    }
                case "ozu":
                    {
                        Session["ozuId"] = accessoryTable.id;
                        Session["OZUName"] = accessoryTable.name;
                        Session["OZUPrice"] = accessoryTable.price;
                        Session["ResultSum"] = int.Parse(Session["ResultSum"].ToString()) + accessoryTable.price;
                        break;
                    }
                case "kuler":
                    {
                        Session["kulerId"] = accessoryTable.id;
                        Session["KulerName"] = accessoryTable.name;
                        Session["KulerPrice"] = accessoryTable.price;
                        Session["ResultSum"] = int.Parse(Session["ResultSum"].ToString()) + accessoryTable.price;
                        break;
                    }
                case "korpus":
                    {
                        Session["korpusId"] = accessoryTable.id;
                        Session["KorpusName"] = accessoryTable.name;
                        Session["KorpusPrice"] = accessoryTable.price;
                        Session["ResultSum"] = int.Parse(Session["ResultSum"].ToString()) + accessoryTable.price;
                        break;
                    }
                case "monitor":
                    {
                        Session["monitorId"] = accessoryTable.id;
                        Session["MonitorName"] = accessoryTable.name;
                        Session["MonitorPrice"] = accessoryTable.price;
                        Session["ResultSum"] = int.Parse(Session["ResultSum"].ToString()) + accessoryTable.price;
                        break;
                    }
                case "mouse":
                    {
                        Session["mouseId"] = accessoryTable.id;
                        Session["MouseName"] = accessoryTable.name;
                        Session["MousePrice"] = accessoryTable.price;
                        Session["ResultSum"] = int.Parse(Session["ResultSum"].ToString()) + accessoryTable.price;
                        break;
                    }
                case "keyboard":
                    {
                        Session["keyboardId"] = accessoryTable.id;
                        Session["KeyboardName"] = accessoryTable.name;
                        Session["KeyboardPrice"] = accessoryTable.price;
                        Session["ResultSum"] = int.Parse(Session["ResultSum"].ToString()) + accessoryTable.price;
                        break;
                    }
            }

            return RedirectToAction("Complectation");
        }


        public ActionResult deleteComplect(int? id)
        {
            AccessoryTable accessoryTable = db.AccessoryTable.Find(id);
            switch (accessoryTable.type)
            {
                case "vid":
                    {
                        Session["vidId"] = "";
                        Session["VideoCardName"] = "";
                        Session["VideoCardPrice"] = "";
                        Session["ResultSum"] = int.Parse(Session["ResultSum"].ToString()) - accessoryTable.price;
                        break;
                    }
                case "proc":
                    {
                        Session["procId"] = "";
                        Session["ProcessorName"] = "";
                        Session["ProcPrice"] = "";
                        Session["ResultSum"] = int.Parse(Session["ResultSum"].ToString()) - accessoryTable.price;
                        break;
                    }
                case "disc":
                    {
                        Session["discId"] = "";
                        Session["DiskName"] = "";
                        Session["DiskPrice"] = "";
                        Session["ResultSum"] = int.Parse(Session["ResultSum"].ToString()) - accessoryTable.price;
                        break;
                    }
                case "ozu":
                    {
                        Session["ozuId"] = "";
                        Session["OZUName"] = "";
                        Session["OZUPrice"] = "";
                        Session["ResultSum"] = int.Parse(Session["ResultSum"].ToString()) - accessoryTable.price;
                        break;
                    }
                case "kuler":
                    {
                        Session["kulerId"] = "";
                        Session["KulerName"] = "";
                        Session["KulerPrice"] = "";
                        Session["ResultSum"] = int.Parse(Session["ResultSum"].ToString()) - accessoryTable.price;
                        break;
                    }
                case "korpus":
                    {
                        Session["korpusId"] = "";
                        Session["KorpusName"] = "";
                        Session["KorpusPrice"] = "";
                        Session["ResultSum"] = int.Parse(Session["ResultSum"].ToString()) - accessoryTable.price;
                        break;
                    }
                case "monitor":
                    {
                        Session["monitorId"] = "";
                        Session["MonitorName"] = "";
                        Session["MonitorPrice"] = "";
                        Session["ResultSum"] = int.Parse(Session["ResultSum"].ToString()) - accessoryTable.price;
                        break;
                    }
                case "mouse":
                    {
                        Session["mouseId"] = "";
                        Session["MouseName"] = "";
                        Session["MousePrice"] = "";
                        Session["ResultSum"] = int.Parse(Session["ResultSum"].ToString()) - accessoryTable.price;
                        break;
                    }
                case "keyboard":
                    {
                        Session["keyboardId"] = "";
                        Session["KeyboardName"] = "";
                        Session["KeyboardPrice"] = "";
                        Session["ResultSum"] = int.Parse(Session["ResultSum"].ToString()) - accessoryTable.price;
                        break;
                    }
            }

            return RedirectToAction("Complectation");
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

        // GET: AccessoryTables/Details/5
        public ActionResult Details(int? id)
        {
            AccessoryTable accessoryTable = db.AccessoryTable.Find(id);
            if (accessoryTable != null)
                return PartialView(accessoryTable);
            return HttpNotFound();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
