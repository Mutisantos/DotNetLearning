using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _002aspnet.Models;

namespace _002aspnet.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;
        public IActionResult Index(){
            // var escuela = new Escuela();
            // escuela.AñoFundación = 1969;
            // escuela.UUID = Guid.NewGuid().ToString();
            // escuela.Nombre = "Colegio Emilio Valenzuela";

            ViewBag.miCosaCustom = "Elementos Custom de View Bag pls";
            Escuela escuela1 = _context.Schools.FirstOrDefault(); 
            return View(escuela1);
        }

        public EscuelaController (EscuelaContext context){
            _context = context;
        }
    }
}
