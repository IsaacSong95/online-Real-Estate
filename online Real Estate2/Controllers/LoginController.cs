using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using online_Real_Estate2;
using online_Real_Estate2.Models;

namespace online_Real_Estate2.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
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
    }

}