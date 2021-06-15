using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.entities;
namespace CoreEscuela.App
{
    //Sealed: Like adding final to a Java Class. The class can be instanced but not inherited.
    public class Reportator
    {

        private Dictionary<BaseSchoolEnum, IEnumerable<BaseSchoolEntity>> my_dictionary;
        public Reportator(Dictionary<BaseSchoolEnum, IEnumerable<BaseSchoolEntity>> dictionary)
        {
            if (dictionary == null)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }
            my_dictionary = dictionary;
        }

        public IEnumerable<Evaluación> getEvaluaciones()
        {
            //Safely access a dictionary using TryGetValue, similarly as the Optional approach in Java
            bool wasFound = my_dictionary.TryGetValue(BaseSchoolEnum.EVALUACION, out IEnumerable<BaseSchoolEntity> list);
            return list.Cast<Evaluación>();
        }


        public IEnumerable<string> getAsignaturas()
        {
            //Use LINQ in order to make queries over sets of information in lists or dictionaries
            var evaluaciones = getEvaluaciones();
            return (from Evaluación ev in evaluaciones
                    where ev.calificacion >= 3.0f
                    select ev.ClaseEvaluada.Nombre).Distinct();
        }

        public IEnumerable<string> GetListaAsignaturas(out IEnumerable<Evaluación> listaEvaluaciones)
        {
            listaEvaluaciones = getEvaluaciones();

            return (from Evaluación ev in listaEvaluaciones
                    select ev.ClaseEvaluada.Nombre).Distinct();
        }


        public Dictionary<string, IEnumerable<Evaluación>> getEvaluacionesDeAsignatura()
        {
            var AsigxEvaluations = new Dictionary<string, IEnumerable<Evaluación>>();
            var listaAsig = GetListaAsignaturas(out var listaEval);
            foreach (var asig in listaAsig)
            {
                var evalsAsig = from eval in listaEval
                                where eval.ClaseEvaluada.Nombre == asig
                                select eval;
                AsigxEvaluations.Add(asig, evalsAsig);
            }
            return AsigxEvaluations;

        }


        public Dictionary<string, IEnumerable<PromedioAlumno>> averagePerCourse()
        {
            var result = new Dictionary<string, IEnumerable<PromedioAlumno>>();
            var evalsPorAsig = getEvaluacionesDeAsignatura();
            foreach (var keyvalPair in evalsPorAsig)
            {

                var promedioEstudiantes = from eval in keyvalPair.Value
                                              //Results can be grouped based on a certain attribute
                                          group eval by new { eval.Evaluado.UUID, eval.Evaluado.Nombre }
                                          into grupoEvalsDeAlumno
                                            //Here can be used an anonymous type to encapuslate different elements in a type that doesn't exist
                                            // Anonymous types can be interpreted as object, however, handling the anonymous class outside the scope might be impossible
                                            //   select new
                                            //   {
                                            //       alumnoId = grupoEvalsDeAlumno.Key,
                                            //       promedio = grupoEvalsDeAlumno.Average(evaluation => evaluation.calificacion)
                                            //   };
                                        select new PromedioAlumno
                                          {
                                              AlumnoId = grupoEvalsDeAlumno.Key.UUID, 
                                              AlumnoNombre = grupoEvalsDeAlumno.Key.Nombre,
                                              CalificacionPromedio = grupoEvalsDeAlumno.Average(evaluation => evaluation.calificacion)
                                          };
                // LINQ ALWAYS returns a list, even if it is a single result.
                               result.Add(keyvalPair.Key, promedioEstudiantes);

            }
            return result;
        }
    }


}