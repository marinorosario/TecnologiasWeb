using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Colegio.Data.DTOs
{
    public class Profesor
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [DisplayName("Nivel Académico")]
        public string NivelAcademico { get; set; }

        [DataType(DataType.Currency)]
        public decimal Sueldo { get; set; }

        [ForeignKey("Persona")]
        public int PersonaId { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
