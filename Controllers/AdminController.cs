using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternetBanking.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult clientes()
        {
            return View();
        }
        public ActionResult cuenta()
        {
            return View();
        }
        public ActionResult tarjeta()
        {
            return View();
        }
        public ActionResult prestamo()
        {
            return View();
        }
    }
}