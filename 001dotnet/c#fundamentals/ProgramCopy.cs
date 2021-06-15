using System;
using CoreEscuela.entities;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace c_fundamentals
{   

    class ProgramExercise
    {
        //Predicates work as "delegates" that ensure that these functions can be passed as parameters and are safe:
        //Ensure that the parameters and return values are correct, making the function pointer correct 
        private static Predicate<Curso> isCursosDiurnos = curso => curso.TipoHorario == TipoJornada.DIURNA;

        static void MainClass(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Escuela emilioValenzuela = new Escuela();
            // C# Supports Type Inference
            var miColegio = new Escuela("Colegio Emilio Valenzuela", 1955);
            miColegio.Direccion = "Cra. 68 #180-45";
            // miColegio.Ring();
            // Optional fields can be specifically filled to avoid discrepancies of knowing which is the correct of the optional values
            var otroColegio = new Escuela("Colegio Emilio Valenzuela", 1955, ciudad: "Lima");
            otroColegio.Direccion = "Cra. 68 #180-45";
            // otroColegio.Ring();
            addAndRemoveCoursesTest(miColegio);

        }

        private static void addAndRemoveCoursesTest(Escuela miColegio)
        {
            var cursoTemporal = new Curso { Nombre = "Supletorio", TipoHorario = TipoJornada.DIURNA };
            // Latest C# Versions enable the usage of array operations in lists.
            var cursosNocturnos = new List<Curso>(){
                new Curso() {Nombre = "Once E", TipoHorario = TipoJornada.NOCTURNA},
                new Curso() {Nombre = "Decimo E", TipoHorario = TipoJornada.NOCTURNA},
                new Curso() {Nombre = "Noveno E", TipoHorario = TipoJornada.NOCTURNA},
            };
            miColegio.Cursos = new List<Curso>(){
                new Curso() {Nombre = "Septimo C"},
                new Curso() {Nombre = "Sexto B"},
                new Curso() {Nombre = "Octavo C"},
            };
            miColegio.Cursos.Add(cursoTemporal);
            miColegio.Cursos.Add(new Curso { Nombre = "Noveno D", TipoHorario = TipoJornada.TARDE });
            // Similar to addAll method in Java for Collections
            miColegio.Cursos.AddRange(cursosNocturnos);
            ImprimirCursos(miColegio);
            miColegio.Cursos.Remove(cursoTemporal);
            // Remove all the elements of the lists that comply the given Predicate (Functional Programming) calling it for each element
            // Can also provide the reference to a method that returns a bool value (function pointer)
            miColegio.Cursos.RemoveAll(isCursosDiurnos);
            ImprimirCursos(miColegio);
        }

        private static void ImprimirCursos(Escuela escuela){
            //Basic loops (while, do-while, for) structures and conditional statements (if, else if, else) remain the same as many other programming languages
            // for (int i = 0; i < cursos.Length; i++)
            // {
            //     Console.WriteLine(cursos[i]);
            // }
            Console.WriteLine("==========================================");
            if(escuela != null){
                foreach (var curso in escuela.Cursos)
                {
                    Console.WriteLine(curso.ToString());
                }
            }
            else {
                Console.WriteLine("No hay cursos!!!");
            }
            
        }


        private static void UseArraysExample(Escuela miColegio){
            //Use default constructor and then provide the specified parameters just after the creation
            var curso11A = new Curso (){
                Nombre = "Once A"
            };
            var curso10A = new Curso (){
                Nombre = "Décimo A"
            };
            var curso9A = new Curso (){
                Nombre = "Noveno A"
            };
            var cursoArreglo = new Curso[3];
            cursoArreglo[0] = curso10A;
            cursoArreglo[1] = curso11A;
            cursoArreglo[2] = curso9A;
            System.Console.WriteLine("==========================");
            ImprimirCursos(miColegio);
            //Initialize arrays can be done making the instances inside the array declaration
        }
    }
}
