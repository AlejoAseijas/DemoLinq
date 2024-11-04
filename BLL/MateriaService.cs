using BE;
using BLL.contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MateriaService
    {
        private AlumnosDataContext context = new AlumnosDataContext();
        public List<Materia> GetAllMaterias()
        {
            return (from materia in context.materias select new Materia(materia.IdMateria, materia.Materia)).ToList();
        }
    }
}
