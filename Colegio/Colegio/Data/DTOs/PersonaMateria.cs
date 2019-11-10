using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Colegio.Data.DTOs
{
    public class PersonaMateria : Auditable
    {
        public int Id { get; set; }

        [ForeignKey("Persona")]
        public int PersonaId { get; set; }

        [ForeignKey("Materia")]
        public int MateriaId { get; set; }

        [ForeignKey("Curso")]
        public int CursoId { get; set; }

        public virtual Persona Persona { get; set; }
        public virtual Materia Materia { get; set; }
        public virtual Curso Curso { get; set; }

    }
}
