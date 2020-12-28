using Microsoft.EntityFrameworkCore;

namespace dnpexprep.VolumeWebService.VolumeCalculator
{
    public class Context: DbContext
    {
        public DbSet<VolumeResult> volumes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // name of database
            optionsBuilder.UseSqlite(@"Data Source = Volumes.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }
    }
}