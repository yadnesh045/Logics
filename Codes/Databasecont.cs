using Microsoft.EntityFrameworkCore;
using Middleware.Models;

namespace Middleware
{
    public class Databasecont : DbContext
    {

        public Databasecont(DbContextOptions<Databasecont> options) : base(options)
        {

        }

        public DbSet<Testmiddle> Testmiddles { get; set; }

    }
}
