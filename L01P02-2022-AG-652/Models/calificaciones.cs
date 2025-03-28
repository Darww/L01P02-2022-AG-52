using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2022_AG_652.Models
{
    public class calificaciones
    {
        [Key]
        public int calificacionId { get; set; }

        [ForeignKey("Publicacion")]
        public int publicacionId { get; set; }

        [ForeignKey("Usuario")]
        public int usuarioId { get; set; }
        public int calificacion { get; set; }
    }
}
