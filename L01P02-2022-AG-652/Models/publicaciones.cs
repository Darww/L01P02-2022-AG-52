using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2022_AG_652.Models
{
    public class publicaciones
    {
        [Key]
        public int publicacionId { get; set; }

        [Required]
        [StringLength(255)]
        public string titulo { get; set; }

        [Required]
        public string descripcion { get; set; }

        [ForeignKey("Usuario")]
        public int usuarioId { get; set; }

    }
}
