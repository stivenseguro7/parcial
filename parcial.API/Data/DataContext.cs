using Microsoft.EntityFrameworkCore;
using parcial.Shared.Entities;

namespace parcial.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options): base(options) 
        {
        }

        public DbSet<Concert> concerts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
