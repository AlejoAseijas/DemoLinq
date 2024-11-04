using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Alumno
    {
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }

        public Alumno() { }
        public Alumno(int IdAlumno, string Nombre, string Apellido, string DNI)
        {
            this.IdAlumno = IdAlumno;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.DNI = DNI;
        }

    }
}
