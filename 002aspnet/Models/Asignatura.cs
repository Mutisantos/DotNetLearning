using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _002aspnet.Models
{
    public class Asignatura : BaseSchoolEntity
    {   

        // [Range(1,10, ErrorMessage = "No podemos ofrecer clases de más de 10 créditos")]
        public int Creditos { get; set; }
        // [Display(Prompt="Descripcion del curso",Name="Description")]
        // [MinLength(10, ErrorMessage = "Provea una descripcion de al menos 10 letras")]
        public string Descripcion { get; set; }
        public string EscuelaId {get; set;}
        public Escuela Escuela {get; set;}
        public TipoJornada Jornada {get; set;}

        // [Required(ErrorMessage = "El nombre del curso es obligatorio")]
        // [MaxLength(20, ErrorMessage = "El maximo del nombre es de 20 caracteres")]
        public override string Nombre { get => base.Nombre; set => base.Nombre = value; }

        public override string ToString()
        {
            //The $ enables to add values within the string with know values in the scope
            return $"Asignatura:{Nombre}: {Descripcion} - Creditos: {Creditos} \n Id:{UUID} ";
        }
    }

}