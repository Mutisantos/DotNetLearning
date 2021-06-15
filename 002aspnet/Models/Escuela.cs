using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _002aspnet.Models
{
    public class Escuela
    {   
        [Key]
        public string EscuelaId {get; set;}
        public string Nombre {get; set;}
        [Required]
        public int AñoFundación {get; set;}
        public List<Asignatura> Asignaturas {get;set;}

                public override string ToString()
        {
            //The $ enables to add values within the string with know values in the scope
            return $"{Nombre}: {EscuelaId}";
        }
    }
}