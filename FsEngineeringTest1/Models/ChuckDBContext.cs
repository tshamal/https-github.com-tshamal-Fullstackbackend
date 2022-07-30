using Microsoft.EntityFrameworkCore;


namespace FsEngineeringTest1.Models
{
    public class ChuckDBContext : DbContext
    {
        public ChuckDBContext(DbContextOptions<ChuckDBContext> options): base(options)
        {


        }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Jokes> Jokes { get; set; }
        public DbSet<People> People { get; set; }


    }
}
