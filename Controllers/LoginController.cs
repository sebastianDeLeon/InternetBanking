using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Negocio;

namespace InternetBanking.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult registro()
        {
            return View();
        }
        [HttpPost]
        public ActionResult registro(long cedula,string contraseña, string nombre,string apellido, string email, System.DateTime date)
        {
            usuario user = new usuario();
            user.Cedula = cedula;
            user.Contraseña = contraseña;
            user.Nombre = nombre;
            user.Apellido = apellido;
            user.Email = email;
            user.FechaNacimiento = date;
            FachadaNegocio userN = new FachadaNegocio();
            userN.registrar(user);
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(usuario usuarioLogin)
        {
            return View();
        }
    }
}