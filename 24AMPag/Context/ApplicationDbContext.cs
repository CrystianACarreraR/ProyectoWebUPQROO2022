using _24AMPag.Models;
using Microsoft.EntityFrameworkCore;

namespace _24AMPag.Context
{
    public class ApplicationDbContext : DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
       { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }
}
