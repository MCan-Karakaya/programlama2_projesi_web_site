using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yemek_Tarif_Sitesi.Models;

namespace Yemek_Tarif_Sitesi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult index()
        {
            return View();
        }
        
        

        public ActionResult receipepost()
        {
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }
        public ActionResult about()
        {
            return View();
        }
        public ActionResult elements()
        {
            return View();
        }
        public ActionResult blogpost()
        {
            return View();
        }

        
        public ActionResult weirdpage()
        {
            return View();
        }
    }
}