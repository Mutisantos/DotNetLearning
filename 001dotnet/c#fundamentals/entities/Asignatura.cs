using System;
namespace CoreEscuela.entities
{
    public class Asignatura : BaseSchoolEntity
    {
        public int Creditos { get; set; }


        public override string ToString()
        {
            //The $ enables to add values within the string with know values in the scope
            return $"Asignatura:{Nombre} - Creditos: {Creditos} \n Id:{UUID} ";
        }
    }

}