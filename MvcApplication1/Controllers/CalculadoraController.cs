using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using MvcApplication1.Services;

namespace MvcApplication1.Controllers
{
    public class CalculadoraController : Controller
    {
        private CalculadoraService calcservice = new CalculadoraService();
        //
        // GET: /Calculadora/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sumar() {
        
            return View();
        }

        public ActionResult Restar() {

            return View();
        }
        
        [HttpPost]
        public ActionResult Sumar(Operacion o)
        {
            if (!ModelState.IsValid)
            {

                return View(o);
            }
            else {

                o = calcservice.Sumar(o);
                calcservice.AgregarALista(o);

                ViewBag.operaciones = calcservice.Listar();


                return View("Resultados");
            }

        }



        [HttpPost]
        public ActionResult Restar(Operacion o)
        {
            if (!ModelState.IsValid)
            {

                return View(o);
            }
            else {


                o = calcservice.Restar(o);
                calcservice.AgregarALista(o);

                ViewBag.operaciones = calcservice.Listar();

                return View("Resultados");
            }

        }
 
    }
}
