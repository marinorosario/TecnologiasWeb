using Colegio.Data.DTOs;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Colegio.Data.DTOs
{
    public class Curso : Auditable
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }

        [StringLength(255)]
        public string Detalle { get; set; }

        [StringLength(50)]
        public string Lugar { get; set; }
        
        public Guid Codigo { get; set; }

        public Curso()
        {
            Codigo = Guid.NewGuid();
        }
    }
}
