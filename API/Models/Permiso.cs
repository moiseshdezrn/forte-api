using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Permiso
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        [ForeignKey("TipoPermisoId")]
        public short TipoPermisoId { get; set; }
        [Required]
        public TipoPermiso TipoPermiso { get; set; }
        [Required]
        public DateTime FechaPermiso { get; set; }
    }
}
