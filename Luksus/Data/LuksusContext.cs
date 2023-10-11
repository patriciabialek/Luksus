using Microsoft.EntityFrameworkCore;
using Luksus.Models;

namespace Luksus.Data
{
    public class LuksusContext : DbContext
    {
        public LuksusContext(DbContextOptions<LuksusContext> options)
            : base(options)
        {
        }

        public DbSet<Perfume> Perfume { get; set; }
        /*A database context class is needed to coordinate EF Core functionality(Create, Read, Update, Delete) for the Perfume model*/
    }
}