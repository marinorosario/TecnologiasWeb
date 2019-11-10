using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Colegio.Data.DTOs
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Apellidos { get; set; }

        [StringLength(20)]
        public string Cedula { get; set; }

        [DisplayName("Fecha de Nacimiento")]
        public DateTime? FechaNac { get; set; }

        [StringLength(50)]
        public string Nacionalidad { get; set; }

        [StringLength(24)]
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }

        [StringLength(255)]
        [DataType(DataType.MultilineText)]
        public string Direccion { get; set; }

        public Guid Codigo { get; set; }

        public Persona(): base()
        {
            Codigo = Guid.NewGuid();
        }

        public string NombreCompleto() {
            return $"{Nombre} {Apellidos}";
        }

    }
}
