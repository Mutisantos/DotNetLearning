using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _002aspnet.Models
{
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> Schools {get; set;}
        public DbSet<Alumno> Students {get; set;}
        public DbSet<Asignatura> Courses {get; set;}
        public DbSet<Curso> Classrooms {get; set;}
        public DbSet<Evaluación> Evaluations {get; set;}


        public EscuelaContext (DbContextOptions<EscuelaContext> options): base(options){

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            var escuela = new Escuela();
            escuela.AñoFundación = 1969;
            escuela.EscuelaId = Guid.NewGuid().ToString();
            escuela.Nombre = "Colegio Emilio Valenzuela";

            var claseA = new Asignatura{
                Creditos = 3,
                Nombre = "Calculo Ultradiferencial",
                Descripcion = "Calculo IV",
                EscuelaId = escuela.EscuelaId,
                Jornada = TipoJornada.DIURNA
            };

            var claseB = new Asignatura{
                Creditos = 3,
                Nombre = "Física Horripilante",
                Descripcion = "Descripcion",
                EscuelaId = escuela.EscuelaId,
                Jornada = TipoJornada.DIURNA
            };
            var claseC = new Asignatura{
                Creditos = 4,
                Nombre = "Redes y Comunicaciones",
                Descripcion = "Descripcion",
                EscuelaId = escuela.EscuelaId,
                Jornada = TipoJornada.DIURNA
            };
            var claseD = new Asignatura{
                Creditos = 4,
                Nombre = "Ingenieria de Software",
                EscuelaId = escuela.EscuelaId,
                Descripcion = "Descripcion",
                Jornada = TipoJornada.DIURNA
            };
            var claseE = new Asignatura{
                Creditos = 2,
                Nombre = "Significacion Teológica",
                EscuelaId = escuela.EscuelaId,
                Descripcion = "Descripcion",
                Jornada = TipoJornada.DIURNA
            };
            List<Asignatura> clasesLista = new List<Asignatura>(){claseA,claseB,claseC,claseD,claseE};
            modelBuilder.Entity<Asignatura>().HasData(clasesLista.ToArray());
            modelBuilder.Entity<Escuela>().HasData(escuela);
        }


    }
}