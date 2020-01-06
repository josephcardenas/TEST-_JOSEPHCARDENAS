using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB.Controllers;
using WEB.Models;

namespace WEB.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Details/5
        public ActionResult Details(string nombre)
        {
            MantenimientoPersona ma = new MantenimientoPersona();
            Persona per = ma.Recuperar(nombre);
            return View(per);
        }
    }
}