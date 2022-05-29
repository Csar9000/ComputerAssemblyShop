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
            AccessoryTable accessoryTable = db.AccessoryTable.Find(id);
            switch (accessoryTable.type)
            {
                case "vid":
                    {
                        Session["VideoCardName"] = accessoryTable.name;
                        break;
                    }
                case "proc":
                    {
                        Session["ProcessorName"] = accessoryTable.name;
                        break;
                    }
                case "disc":
                    {
                        Session["DiskName"] = accessoryTable.name;
                        break;
                    }
                case "ozu":
                    {
                        Session["OZUName"] = accessoryTable.name;
                        break;
                    }
                case "kuler":
                    {
                        Session["KulerName"] = accessoryTable.name;
                        break;
                    }
                case "korpus":
                    {
                        Session["KorpusName"] = accessoryTable.name;
                        break;
                    }
                case "monitor":
                    {
                        Session["MonitorName"] = accessoryTable.name;
                        break;
                    }
                case "mouse":
                    {
                        Session["MouseName"] = accessoryTable.name;
                        break;
                    }
                case "keyboard":
                    {
                        Session["KeyboardName"] = accessoryTable.name;
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
