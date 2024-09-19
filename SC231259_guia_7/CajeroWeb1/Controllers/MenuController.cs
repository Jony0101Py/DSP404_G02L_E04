using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CajeroWeb1.Models;

namespace CajeroWeb1.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Menu(string sNumeroTarjeta, double sSaldo)
        {
            ViewBag.sNumeroTarjeta = sNumeroTarjeta;
            ViewBag.sSaldo = sSaldo;
            return View();
        }
    }
}