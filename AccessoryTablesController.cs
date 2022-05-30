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

        // GET: AccessoryTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccessoryTables/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,type,price,description")] AccessoryTable accessoryTable)
        {
            if (ModelState.IsValid)
            {
                db.AccessoryTable.Add(accessoryTable);
                db.SaveChanges();
                return RedirectToAction("Complectation");
            }

            return View(accessoryTable);
        }

        // GET: AccessoryTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccessoryTable accessoryTable = db.AccessoryTable.Find(id);
            if (accessoryTable == null)
            {
                return HttpNotFound();
            }
            return View(accessoryTable);
        }

        // POST: AccessoryTables/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,type,price,description")] AccessoryTable accessoryTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessoryTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Complectation");
            }
            return View(accessoryTable);
        }

        // GET: AccessoryTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccessoryTable accessoryTable = db.AccessoryTable.Find(id);
            if (accessoryTable == null)
            {
                return HttpNotFound();
            }
            return View(accessoryTable);
        }

        // POST: AccessoryTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AccessoryTable accessoryTable = db.AccessoryTable.Find(id);
            db.AccessoryTable.Remove(accessoryTable);
            db.SaveChanges();
            return RedirectToAction("Complectation");
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
