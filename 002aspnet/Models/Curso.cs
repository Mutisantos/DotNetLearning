using System;
using System.Collections.Generic;
namespace _002aspnet.Models
{

    public class Curso : BaseSchoolEntity
    {
        public TipoJornada TipoHorario {get; set;}
        public List<Asignatura> materias {get; set;}
        public List<Alumno> estudiantes {get; set;}


        //Use default constructor 
        public override string ToString()
        {
            //The $ enables to add values within the string with know values in the scope
            return $"Curso:{Nombre} - {TipoHorario} \n Id:{UUID} ";
        }

    }
}