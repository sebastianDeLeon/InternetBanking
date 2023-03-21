using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternetBanking.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult consultarProductor()
        {
            return View();

        }

        public ActionResult transaccion()
        {
            return View();
        }
    }
}