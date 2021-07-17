using Julio17MVC.Models;
using Julio17MVC.repo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Julio17MVC.controladores
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.mensaje = "";
            // ViewBag.usuario=new Usuario();
            // abre el formulario inicialmente
            return View(new Usuario());
        }

        [HttpPost]
        public IActionResult Index(Usuario usrDigitado)
        {
            ViewBag.mensaje=UsuarioRepo.ValidarUsuario(usrDigitado);
            
            // ViewBag.usuario=usr;
            // despues de que presione un boton.
            return View(usrDigitado);
        }
    }
}
