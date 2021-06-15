using System;
using System.ComponentModel.DataAnnotations;

namespace _002aspnet.Models
{   
    //Uses the same concept of Abstraction of other OOP languages, as declaring this class won't be instanced. Instead, other classes will be able to inherit it
    public abstract class BaseSchoolEntity
    {   
        [Key]
        public string UUID {get; private set;}
        public virtual string Nombre {get;  set;}

        public BaseSchoolEntity()=> UUID = Guid.NewGuid().ToString();
    }
}