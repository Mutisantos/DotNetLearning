using System;
using System.Collections.Generic;
namespace CoreEscuela.entities
{
    //Multiple inheritance can be achieved through Interface implementations
    //Since only 1 class can be inherited per children class
    public class Escuela : BaseSchoolEntity, ILocatable
    {
        //Wrapped private attributes and getters and setters.
        // //The private attribute is hidden, while a property element exposes the methods for the attribute.
        // string nombre;
        // public string Nombre
        // {
        //     get { return "Nombre:" + nombre; }
        //     set { nombre = value.ToUpper(); }
        // }
        // C# supports multiple languages, so it enables code with multiple codecs
        // A shortcut can be done to create a lower-cased variable with a get-set wrapper
        public int AñoFundacion { get; set; }

        // Default privacy is Protected/Packaged
        // Default values can also be done
        string ciudad = "Bogotá";
        public string Ciudad
        {
            get { return "Ciudad:" + ciudad; }
            set { ciudad = value.ToUpper(); }
        }
        public TipoEscuela TipoDeEscuela { get; set; }

        public List<Curso> Cursos {get; set; }
        public string Direccion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }




        //Constructor Method
        public Escuela(string name, int año, string direccion)
        {
            Nombre = name;
            AñoFundacion = año;
            Direccion = direccion;
        }

        // Tuples assignment for constructors based on Functional Programmin
        public Escuela(int año, string nombre) => (AñoFundacion, Nombre) = (año, nombre);

        //tipoescuela parameter has a default value if the attribute is not passed on the method call. Optional Params
        public Escuela(string nombre, int año, TipoEscuela tipoescuela = TipoEscuela.PRIMARIA, string ciudad = "") =>
         (Nombre, AñoFundacion, TipoDeEscuela, Ciudad) = (nombre, año, tipoescuela,ciudad);

        public void Ring()
        {
            //Use the static method of Console to write on console
            Console.WriteLine(this.ToString());
            //The console will beep with a system sound
            Console.Beep(1000, 500);
        }

        public override string ToString()
        {
            //The $ enables to add values within the string with know values in the scope
            return $"Nombre:{Nombre} - {TipoDeEscuela} \n Direccion:{Direccion}  \n Fundado en {AñoFundacion} en la ciudad de {Ciudad}";
        }


        // The interface method is implemented as expected
        public void LimpiarDirección()
        {
           Console.WriteLine("COSA LIMPIA");
        }
    }
}