using System;
using System.Collections.Generic;

namespace _002aspnet.Models
{
    public class Alumno : BaseSchoolEntity
    {
        public string Apellido {get;  set;}
        public string Edad {get;  set;}
        public List<Evaluación> evaluaciones {get; set;}

        // Inheriting the BaseSchoolEntity 
        // public Alumno()=> UUID = Guid.NewGuid().ToString();

        public override string ToString()
        {
            //The $ enables to add values within the string with know values in the scope
            return $"{UUID}|:{Nombre}.{Apellido}";
        } 
    }
}