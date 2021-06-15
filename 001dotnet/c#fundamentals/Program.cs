using System;
using CoreEscuela.entities;
using CoreEscuela.util;
using System.Collections.Generic;
using System.Collections.Concurrent;
using CoreEscuela.App;

namespace CoreEscuela
{

    class Program
    {
        //Predicates work as "delegates" that ensure that these functions can be passed as parameters and are safe:
        //Ensure that the parameters and return values are correct, making the function pointer correct 
        private static Predicate<Curso> isCursosDiurnos = curso => curso.TipoHorario == TipoJornada.DIURNA;

        static void Main(string[] args)
        {
            // For events, the trigger is binded to a method that will be executed once the action occurs.
            // Process exit, for example, will only be executed at the end of the run if the execution was succesful (no exceptions)
            AppDomain.CurrentDomain.ProcessExit += EventAction; 
            // Mutliple events can be stacked in the current domain
            AppDomain.CurrentDomain.ProcessExit += (o,s) => Console.Beep(4000,500); 
            
            var engine = new EscuelaEngine();
            engine.inicializarEscuela();
            // Printer.dibujarLinea(20);
            // ImprimirCursos(engine.escuela);
            // Printer.dibujarLinea(40);
            pruebaPolimorfica();
            // engine.escuela.LimpiarDirección();

            IReadOnlyList<BaseSchoolEntity> lists = engine.GetObjetosEscuela(out int counter);
            Dictionary<BaseSchoolEnum, IEnumerable<BaseSchoolEntity>> map = engine.classifyBaseObjects(lists);
            // ImprimirDiccionario(map);

            var reportr = new Reportator(map);
            Printer.escribirTitulo("Evaluadas");
            Printer.escribirParametros(new List<string>(reportr.getAsignaturas()));

            var listaPromXAsignatura = reportr.averagePerCourse();
            foreach(var item in listaPromXAsignatura){
                foreach (var alum in item.Value)
                {   
                    PromedioAlumno avg = alum as PromedioAlumno;
                    Printer.escribirParametros(new List<string>{avg.AlumnoNombre, avg.AlumnoId, "Promedio:" + avg.CalificacionPromedio});
                }

            }


        }

        private static void EventAction(Object sender, EventArgs e)
        {
            Printer.escribirTitulo("SALIENDO");
            Console.Beep(2000,500);
            Console.Beep(2000,500);
            Console.Beep(2000,500);
            Printer.escribirTitulo("salido");
        }

        private static void pruebaPolimorfica(){
            Printer.dibujarLinea(40);
            Printer.dibujarLinea(40);
            Printer.dibujarLinea(40);
            Printer.dibujarLinea(40);
            Printer.dibujarLinea(40);
            var alumnoTest = new Alumno{Nombre="Hadiza",Apellido="Okaterme"};
            // A "Alumno" is a "BaseSchoolEntity" since it inherits that class. Alumno can take parent Class properties and Methods but not backwards. Polymorphism. 
            // Unless a cast is made and forced.
            BaseSchoolEntity ob = alumnoTest;
            Printer.escribirParametros(new List<string>(){"BaseObject:",ob.UUID, ob.Nombre, ob.GetType().ToString()});
            Printer.escribirParametros(new List<string>(){"Alumno:",alumnoTest.UUID, alumnoTest.Nombre, alumnoTest.GetType().ToString()});
            //Validate the instance type of the object. So the cast can be made safely.
            if(ob is Alumno){
                Alumno estudiante = (Alumno)ob;
            }
            // Or check if the object can be interpreted AS other class and assign it as the expected class or assign it as null
            Alumno otroEstudiante = ob as Alumno;
        }


        private static void ImprimirDiccionario(Dictionary<BaseSchoolEnum, IEnumerable<BaseSchoolEntity>> dictionary){
            foreach (var obj in dictionary){
                Printer.escribirTitulo(obj.Key.ToString());
                List<BaseSchoolEntity> list = obj.Value as List<BaseSchoolEntity>;
                int limit = list.Count > 5 ? 5 : list.Count; 
                for (int i = 0; i < limit; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }

        private static void ImprimirCursos(Escuela escuela)
        {
            if (escuela != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    Printer.escribirTitulo(curso.Nombre.ToString());
                    Printer.escribirParametros(new List<string>(){curso.UUID, curso.TipoHorario.ToString(), curso.Nombre});
                    foreach (var alumno in curso.estudiantes)
                    {
                     Printer.escribirParametros(new List<string>(){alumno.ToString()});
                    }
                }
            }
            else
            {
                Console.WriteLine("No hay cursos!!!");
            }

        }
    }
}
