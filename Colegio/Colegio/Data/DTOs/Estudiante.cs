using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Colegio.Data.DTOs
{
    public class Estudiante
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Matricula { get; set; }

        [StringLength(100)]
        public string Tutor { get; set; }
                
        public DateTime Fechaingreso { get; set; }

        [EnumDataType(typeof(EstadoEstudiante))]
        public EstadoEstudiante Estado { get; set; }

        [ForeignKey("Persona")]
        public int PersonaId { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
