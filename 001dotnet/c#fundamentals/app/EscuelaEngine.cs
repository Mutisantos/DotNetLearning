using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.entities;
namespace CoreEscuela
{
    //Sealed: Like adding final to a Java Class. The class can be instanced but not inherited.
    public sealed class EscuelaEngine
    {
        public Escuela escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void inicializarEscuela()
        {
            this.escuela = new Escuela("Lekh Vezé", 5738, TipoEscuela.SECUNDARIA_TECNICA, ciudad: "Nueva Shunzuru");
            cargarCursos();
            cargarAsignaturas();
            Random rng = new Random();
            foreach (var curso in this.escuela.Cursos)
            {
                int randomSize = rng.Next(3, 7);
                randomSize++;
                curso.estudiantes = cargarAlumnos(randomSize).ToList();
            }
            CargarEvaluaciones();
        }






        public Dictionary<BaseSchoolEnum, IEnumerable<BaseSchoolEntity>> classifyBaseObjects(IEnumerable<BaseSchoolEntity> listObj){
            var diccionario = new Dictionary<BaseSchoolEnum, IEnumerable<BaseSchoolEntity>>();
            var cursosList = new List<BaseSchoolEntity>();
            var alumnosList = new List<BaseSchoolEntity>();
            var asignaturasList = new List<BaseSchoolEntity>();
            var evaluacionList = new List<BaseSchoolEntity>();
            
            foreach (var item in listObj)
            {   
                switch (item.GetType().Name)
                {
                    case "Curso" : cursosList.Add(item); break;
                    case "Alumno" : alumnosList.Add(item); break;
                    case "Evaluación" : evaluacionList.Add(item); break;
                    case "Asignatura" : asignaturasList.Add(item); break;
                    default: break;
                }
            }
            diccionario.Add(BaseSchoolEnum.ASIGNATURA,asignaturasList);
            diccionario.Add(BaseSchoolEnum.CURSO,cursosList);
            diccionario.Add(BaseSchoolEnum.ALUMNO,alumnosList);
            diccionario.Add(BaseSchoolEnum.EVALUACION,evaluacionList);
            return diccionario;
        }

        //Output parameters cannot be set as default. Therefore, the parameters are mandatory to be passed from the caller.
        //Overload is recommended to handle different output possibilites and use dummy variables of output as wrappers
        //Also, there are ReadOnly Conllection interfaces to ensure that the return values are read only. No delete or updates are allowed to operate at this level
        public IReadOnlyList<BaseSchoolEntity> GetObjetosEscuela(
            out int counter,
            bool traeEvaluaciones = true,
            bool traeAlumnos = true,
            bool traeAsignaturas = true,
            bool traeCursos = true
        )
        {   
            counter = 0;
            var listObj = new List<BaseSchoolEntity>();
            if (traeCursos)
            {
                listObj.Add(escuela);
                listObj.AddRange(escuela.Cursos);
                if (traeAlumnos)
                {
                    foreach (var curso in escuela.Cursos)
                    {
                        listObj.AddRange(curso.estudiantes);
                        if (traeAsignaturas)
                        {
                            listObj.AddRange(curso.materias);
                        }
                        if (traeEvaluaciones)
                        {
                            foreach (var alumno in curso.estudiantes)
                            {
                                listObj.Add(alumno);
                                if(alumno.evaluaciones != null){
                                    listObj.AddRange(alumno.evaluaciones);
                                }
                            }
                        }
                    }
                }
            }
            return listObj;
        }

        #region Loading Methods
        private void CargarEvaluaciones()
        {

            foreach (var curso in this.escuela.Cursos)
            {
                foreach (var asignatura in curso.materias)
                {
                    foreach (var alumno in curso.estudiantes)
                    {
                        var rnd = new Random(System.Environment.TickCount);
                        if(alumno.evaluaciones == null){
                            alumno.evaluaciones = new List<Evaluación>();
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Evaluación
                            {
                                ClaseEvaluada = asignatura,
                                Nombre = $"{asignatura.Nombre} Ev#{i + 1}",
                                calificacion = (float)(5 * rnd.NextDouble()),
                                Evaluado = alumno
                            };
                            alumno.evaluaciones.Add(ev);
                        }
                    }
                }
            }

        }

        private IEnumerable<Alumno> cargarAlumnos(int tamañoCurso)
        {
            string[] alumnosN1 = { "Sabina", "Honoria", "Tránsito", "Higinio", "Ufano", "Hilario", "Gervasia", "Epifanio", "Melitón", "Régulo", "Teodora" };
            string[] alumnosN2 = { "Jacinta", "Cándido", "Teodosia", "Cástulo", "Gaudelia", "Eufemio", "Eustaquio", "Brígida", "Leonila", "Nicanor", "Martina", "Teódulo", "Tiburcio", "Celso" };
            string[] apellido1 = { "Spuckler", "Del Roy", "Gump", "Dean", "Cyrus", "Lee", "Jackson", "Stafford", "Holt", "Colton", "Sterling", "Montgomery" };
            //LINQ query language embedded in C#

            var listaAlumnos = from n1 in alumnosN1
                               from n2 in alumnosN2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1}-{n2}", Apellido = $"{a1}" };
            // Truncate the result by a lenght
            return listaAlumnos.OrderBy((alumno) => alumno.UUID).Take(tamañoCurso);

        }

        private void cargarAsignaturas()
        {
            foreach (var curso in escuela.Cursos)
            {
                List<Asignatura> asignaturasPrimaria = new List<Asignatura>(){
                    new Asignatura() {Nombre="Matemáticas", Creditos=5},
                    new Asignatura() {Nombre="Ciencias", Creditos=3},
                    new Asignatura() {Nombre="Español", Creditos=5},
                    new Asignatura() {Nombre="Inglés", Creditos=3},
                    new Asignatura() {Nombre="Sociales", Creditos=3}
                };
                curso.materias = asignaturasPrimaria;
            }

        }

        private void cargarCursos()
        {
            Curso cursoTemporal = new Curso { Nombre = "Supletorio", TipoHorario = TipoJornada.DIURNA, materias = new List<Asignatura>() };
            List<Curso> cursosNocturnos = new List<Curso>(){
                new Curso() {Nombre = "Once E", TipoHorario = TipoJornada.NOCTURNA},
                new Curso() {Nombre = "Decimo E", TipoHorario = TipoJornada.NOCTURNA},
                new Curso() {Nombre = "Noveno E", TipoHorario = TipoJornada.NOCTURNA},
                new Curso() {Nombre = "Septimo C"},
                new Curso() {Nombre = "Sexto B"},
                new Curso() {Nombre = "Octavo C"},
            };
            escuela.Cursos = cursosNocturnos;
            escuela.Cursos.Add(cursoTemporal);
            escuela.Cursos.AddRange(cursosNocturnos);
            escuela.Cursos.Add(new Curso { Nombre = "Noveno D", TipoHorario = TipoJornada.TARDE });
        }
        #endregion
    }
}