using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebAsp.Models;

namespace WebAsp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            MantenedorPersona ma = new MantenedorPersona();

            return View(ma.RecuperarTodos());
        }
    }
}