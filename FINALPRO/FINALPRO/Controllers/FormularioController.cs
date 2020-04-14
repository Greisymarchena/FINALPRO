using FINALPRO.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FINALPRO.Controllers
{
    public class FormularioController : Controller
    {
        // GET: Formulario
        public ActionResult Form()
        { 
            return View(); 
        }
        public ActionResult Mostrar(Formulario form, HttpPostedFileBase foto, HttpPostedFileBase Curriculum)
        {
            if (Curriculum.ContentLength > 0)
            {
                var fileName = Path.GetFileName(Curriculum.FileName);
                var path = Path.Combine(Server.MapPath("~/pdf"), fileName);
                Curriculum.SaveAs(path);
                ViewBag.curriculum = fileName;
            }
            if (foto.ContentLength > 0)
            {
                var fileName = Path.GetFileName(foto.FileName);
                var path = Path.Combine(Server.MapPath("~/img"), fileName);
                foto.SaveAs(path);
                ViewBag.foto = fileName;
            }
            return View(form);
        }
        public ActionResult Acerca()
        {
            return View();
        }
    }
}