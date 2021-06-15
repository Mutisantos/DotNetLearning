using System;
namespace CoreEscuela.entities
{

    public class Evaluación: BaseSchoolEntity
    {
        public Alumno Evaluado {get; set;}
        public Asignatura ClaseEvaluada {get; set;}
        public Double calificacion {get; set;}

    }
}