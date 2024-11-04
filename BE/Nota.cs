using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Nota
    {
        public Materia Materia { get; set; }
        public float Calificacion { get; set; }

        public Nota(Materia Materia, float Calificacion) 
        {
            this.Materia = Materia;
            this.Calificacion = Calificacion;
        }

    }
}
