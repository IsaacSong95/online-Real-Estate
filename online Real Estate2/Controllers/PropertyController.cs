using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using online_Real_Estate2.Models;

namespace online_Real_Estate2.Controllers
{
    public class PropertyController : Controller
    {
        // GET: Property
        public ActionResult Index()
        {
            Database1Entities db = new Database1Entities();
            var pro = from p in db.Properties
                      orderby p.Id
                      select p;
            return View(pro);
            //return View();
        }
        
        public string reg2(Property model)
        {
            try
            {
                Database1Entities db = new Database1Entities();
                db.Properties.Add(model);
                db.SaveChanges();
                return "Done";
            }
            catch { return "invalid"; }
        }

        public string del(int ID)
        {
            Database1Entities db = new Database1Entities();
            Property em = db.Properties.Find(ID);
            db.Properties.Remove(em);
            db.SaveChanges();
            return "DONE";
        }
        
    }
}