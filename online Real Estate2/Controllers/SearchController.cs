using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using online_Real_Estate2.Models;

namespace online_Real_Estate2.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult se(string Suburb, string Property_Type)
        {

            Database1Entities db = new Database1Entities();
            var s = from x in db.Properties
                    where true
                    && (string.IsNullOrEmpty(Suburb) ? true : x.Suburb == Suburb)
                    && (string.IsNullOrEmpty(Property_Type) ? true : x.Property_Type == Property_Type)
                    //&& x.Location == Location 
                    //&& x.Property_Type == Property_Type
                    select x;
          
            return View(s);


        }

    }
}