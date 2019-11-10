using Colegio.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colegio.Data.DTOs
{
    public class Materia : Auditable
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Detalles { get; set; }
        public Guid Codigo { get; set; }

        public Materia()
        {
            Codigo = Guid.NewGuid();
        }
    }
}
