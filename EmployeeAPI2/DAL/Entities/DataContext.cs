using Microsoft.EntityFrameworkCore;

namespace DAL.Entities
{
    public class DataContext : DbContext
    {
       

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DataContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        public DbSet<NewEmp> Employee { get; set; }
    }
}
