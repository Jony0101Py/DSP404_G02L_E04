using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CajeroWeb.Models;

namespace CajeroWeb.Controllers
{
    public class SaldoController : Controller
    {
        // GET: Saldo
        public ActionResult Saldo()
        {
            var tarjeta = "123456";
            var saldo = 500;


            ViewBag.Tarjeta = tarjeta;
            ViewBag.Saldo = saldo;

            return View();
        }
    }
}