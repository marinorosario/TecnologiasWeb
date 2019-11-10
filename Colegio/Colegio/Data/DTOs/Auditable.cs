using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colegio.Data.DTOs
{
    public abstract class Auditable
    {
        public DateTime? CreadoEn { get; set; }
        public DateTime? ModificadoEn { get; set; }
        public DateTime? EliminadoEn { get; set; }

        public string CreadoPor { get; set; }
        public string ModificadoPor { get; set; }
        public string EliminadoPor { get; set; }

        public bool Activo { get; set; }

        public Auditable()
        {
            CreadoEn = DateTime.UtcNow;
            ModificadoEn = DateTime.UtcNow;
        }

    }
}
