using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FINALPRO.Controllers
{
    public class FiltroContenidoController : Controller
    {
        // GET: FiltroContenido
        public ActionResult Musica()
        {
            return View();
        }
        public ActionResult Noticias()
        {
            return View();
        }
        public ActionResult AccionAventura()
        {
            return View();
        }
        public ActionResult Drama()
        {
            return View();
        }
        public ActionResult Infantiles()
        {
            return View();
        }
        public ActionResult Documentales()
        {
            return View();
        }
    }
}