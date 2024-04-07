using ProyectoWeb_Martes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoWeb_Martes.Controllers
{
    public class InicioController : Controller
    {
        

        [HttpGet]

        public ActionResult IniciarSesion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IniciarSesionXYZ(Usuario entidad)
        {
            return RedirectToAction("PantallaPrincipal","Inicio");
        }

        [HttpGet]
        public ActionResult RegistrarUsuario()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RecuperarAcceso()
        {
            return View();
        }


        [HttpGet]
        public ActionResult PantallaPrincipal()
        {
            return View();
        }

    }
}