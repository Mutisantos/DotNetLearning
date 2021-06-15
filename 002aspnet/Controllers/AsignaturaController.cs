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
    public class AsignaturaController : Controller
    {   
        private EscuelaContext _context;
        [Route("Asignatura/Index")]
        public IActionResult Index(){
            var claseA = new Asignatura{
                Creditos = 5,
                Nombre = "Calculo Ultradiferencial",
            };

            ViewBag.FechaHoy = DateTime.Now;
            return View(claseA);
        }    
        
        [Route("Asignatura/Index/{id?}")]
        public IActionResult Index(string id){
            var claseA = from asig in _context.Courses
                         where asig.UUID == id
                         select asig;
            if(claseA.Any()){
                ViewBag.FechaHoy = DateTime.Now;
                return View(claseA.SingleOrDefault());
            }
            else{
                Console.WriteLine("aaa");
                return View("MultiCourse",_context.Courses.ToList());
            }
        }

        public IActionResult MultiCourse(){
            List<Asignatura> clasesLista = _context.Courses.ToList(); 
            ViewBag.FechaHoy = DateTime.Now;
            return View("MultiCourse",clasesLista);
        }


        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(Asignatura clase){
            var escuela = _context.Schools.FirstOrDefault();
            clase.EscuelaId = escuela.EscuelaId;
            if(ModelState.IsValid){
                _context.Courses.Add(clase);
                _context.SaveChanges();
                return View("MultiCourse",_context.Courses.ToList());
            }
            else{
                return View();
            }
        }


        public AsignaturaController (EscuelaContext context){
            _context = context;
        }
    }
}
