using System;
using System.Collections.Generic;
namespace CoreEscuela.entities
{

    public class Curso : BaseSchoolEntity, ILocatable
    {
        public TipoJornada TipoHorario {get; set;}
        public List<Asignatura> materias {get; set;}
        public List<Alumno> estudiantes {get; set;}
        string ILocatable.Generic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ILocatable.Direccion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //Use default constructor 
        public override string ToString()
        {
            //The $ enables to add values within the string with know values in the scope
            return $"Curso:{Nombre} - {TipoHorario} \n Id:{UUID} ";
        }

        void ILocatable.LimpiarDirección()
        {
            throw new NotImplementedException();
        }
    }
}