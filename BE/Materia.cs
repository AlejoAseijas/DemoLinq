﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Materia
    {
        public int IdMateria {  get; set; }
        public string Nombre { get; set; }

        public Materia(int idMateria, string nombre)
        {
            IdMateria = idMateria;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
