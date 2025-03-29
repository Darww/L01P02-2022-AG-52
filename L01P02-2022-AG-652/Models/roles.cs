using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace L01P02_2022_AG_652.Models
{
    public class roles
    {
        [Key]
        public int rolId { get; set; }
        public string rolNombre { get; set; }

    }
}
