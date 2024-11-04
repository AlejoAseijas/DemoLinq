using BE;
using BLL.contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AlumnoService
    {
        private AlumnosDataContext context = new AlumnosDataContext();

        public List<Alumno> GetAllAlumnos() 
        {

            List<Alumno> alumnosFromDB = (from alumno in context.alumnos 
                                          select new Alumno(alumno.IdAlumno, alumno.Nombre, alumno.Apellido, alumno.DNI))
                                          .ToList();
            return alumnosFromDB;
        }

        public List<Nota> GetNotasByIdAlumno(int IdAlumno) 
        {
            List<Nota> notas = (from nota in context.notas
                                join materia in context.materias on nota.IdMateria equals materia.IdMateria
                                where nota.IdAlumno == IdAlumno
                                select new Nota(new Materia(materia.IdMateria, materia.Materia), float.Parse(nota.Nota.ToString())))
                                .ToList();

            return notas;
        }

        public void CreateAlumno(Alumno alumno) 
        {
            alumnos alumno1 = GetAlumno(alumno);

            context.alumnos.InsertOnSubmit(alumno1);

            context.SubmitChanges();
        }

        public void deleteById(Alumno alumno) 
        {
            alumnos alumno1 = GetAlumno(alumno);
            context.alumnos.DeleteOnSubmit(alumno1);
            context.SubmitChanges();
        }

        private alumnos GetAlumno(Alumno alumno) 
        {
            alumnos alumno1 = new alumnos();

            alumno1.Nombre = alumno.Nombre;
            alumno1.Apellido = alumno.Apellido;
            alumno1.DNI = alumno.DNI;
            alumno1.IdAlumno = alumno.IdAlumno;

            return alumno1;
        }

        public void LoadNewNota(Alumno alumno, Materia materia, float calificacion) 
        {
            notas nota = new notas();

            nota.IdMateria = materia.IdMateria;
            nota.IdAlumno = alumno.IdAlumno;
            nota.Nota = calificacion;

            context.notas.InsertOnSubmit(nota);
            context.SubmitChanges();
        }
        
    }
}
