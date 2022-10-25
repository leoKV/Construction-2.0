using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Construction.Models.ViewModel;
using Rotativa;

namespace Construction.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Report()
        {
            List<PersonaViewModel> lst = new List<PersonaViewModel>();
            lst.Add(new PersonaViewModel() { Nombre = "Héctor", Edad = 31, Email = "algo@gmail.com" });
            lst.Add(new PersonaViewModel() { Nombre = "Héctor 2", Edad = 31, Email = "algo@gmail.com" });
            lst.Add(new PersonaViewModel() { Nombre = "Héctor 3", Edad = 31, Email = "algo@gmail.com" });
            lst.Add(new PersonaViewModel() { Nombre = "Héctor 4", Edad = 31, Email = "algo@gmail.com" });
            lst.Add(new PersonaViewModel() { Nombre = "Héctor 5", Edad = 31, Email = "algo@gmail.com" });
            return View(lst);
        }

        public ActionResult ContratosAr()
        {
            return View();
        }
        public ActionResult Print()
        {
            return new ActionAsPdf("Report");
            //{ FileName = "Reporte.pdf" };
        }

        public ActionResult PrintHome()
        {
            return new ActionAsPdf("Index")
            { FileName = "MainPage.pdf" };
        }
    }
}