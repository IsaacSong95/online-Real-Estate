using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using online_Real_Estate2.Models;
using System.Data.Entity.Validation;

namespace online_Real_Estate2.Controllers
{
    public class SellerController : Controller
    {
        private object ema;

        // GET: Seller
        public ActionResult Index()
        {
            return View();

        }
        [HttpPost]
        public string reg(Seller model)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    Database1Entities db = new Database1Entities();
                    db.Sellers.Add(model);
                    db.SaveChanges();
                    return "Done";
                } 
                else
                {
                    return "invaild";
                }
                
            }
            catch
            { 
                return "error"; 
            }
        }
        public string upd(int ID, string address, string Email_address)
        {
            Database1Entities db = new Database1Entities();
            var se = db.Sellers.First(a => a.Id == ID);
            se.Address = address;
            se.Email_address = Email_address;

            return "Done";

        }

    }
    
}