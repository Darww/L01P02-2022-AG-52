using Microsoft.EntityFrameworkCore;

namespace L01P02_2022_AG_652.Models
{
    public class blogDbContext: DbContext
    {
        public blogDbContext(DbContextOptions<blogDbContext> options) : base(options)
        {
        }

        public DbSet<roles> roles { get; set; }

        public DbSet<usuarios> usuarios { get; set; }

        public DbSet<publicaciones> publicaciones { get; set; }

        public DbSet<comentarios> comentarios { get; set; }

        public DbSet<calificaciones> calificaciones { get; set; }



    }


}
