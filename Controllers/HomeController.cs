using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Agua.Models;

namespace Agua.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Calcular(DateTime ProximoCumple, int minutos)
        {
            /// Aquí tienen que hacer todo
            /// La fecha que y los minutos vienen del formulario 
            /// Investigar Model Binding 
            int r;
            int bote=12;
            int m;
        DateTime hoy = DateTime.Today;
        TimeSpan resta = ProximoCumple-hoy;
        r = resta.Days;
        m = minutos*bote*resta.Days;

            ViewBag.Dias = r;
            ViewBag.Botellas = m;

            return View();
        }

    }
}

