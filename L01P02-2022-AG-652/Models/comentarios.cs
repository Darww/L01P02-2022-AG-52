using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2022_AG_652.Models
{
    public class comentarios
    {
        [Key]
        public int comentarioId { get; set; }

        [ForeignKey("Publicacion")]
        public int publicacionId { get; set; }

        public string comentacio { get; set; }

        [ForeignKey("Usuario")]
        public int usuarioId { get; set; }
    }
}
