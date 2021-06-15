using System;

namespace CoreEscuela.entities
{   
    //Uses the same concept of Abstraction of other OOP languages, as declaring this class won't be instanced. Instead, other classes will be able to inherit it
    public abstract class BaseSchoolEntity
    {
        public string UUID {get; private set;}
        public string Nombre {get;  set;}

        public BaseSchoolEntity()=> UUID = Guid.NewGuid().ToString();
    }
}