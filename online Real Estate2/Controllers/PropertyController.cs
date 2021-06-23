using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using online_Real_Estate2.Models;
using System.ComponentModel.DataAnnotations;

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


        public string del(int Id, string SellerId)
        {
            Database1Entities db = new Database1Entities();
            //Property em = db.Properties.Find(Id);
            //db.Properties.Remove(em);
            var em = db.Properties.Where(s => s.Id == Id && s.SellerId.Equals(SellerId));
            db.Properties.RemoveRange(em);
            db.SaveChanges();
            return "DONE";
        }
        
    }
}