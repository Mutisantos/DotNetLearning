using static System.Console;
using System.Collections.Generic;

namespace CoreEscuela.util
{   
    // Static classes won't create instances of themselves. All their methods work on class level and can be called without an object.
    public static class Printer {
        public static void dibujarLinea(int size = 10){
            var line = "".PadLeft(size,'=');
            WriteLine(line);
        }
        
        public static void escribirTitulo(string titulo){
            dibujarLinea(titulo.Length);
            WriteLine(titulo);
            dibujarLinea(titulo.Length);
        }
        
        public static void escribirParametros(List<string> vs){
            foreach (var param in vs){
                WriteLine("-"+param);
            }
        }
    }
}