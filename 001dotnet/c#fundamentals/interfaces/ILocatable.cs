namespace CoreEscuela.entities
{

    // Interfaces are only meant to define a certain specification and behavior based on contract (methods)
    public interface ILocatable
    {
        string Generic {get; set;}
         public string Direccion {get; set;}

         void LimpiarDirección();
    }
}