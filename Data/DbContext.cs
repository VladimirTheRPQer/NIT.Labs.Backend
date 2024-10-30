using Microsoft.EntityFrameworkCore;

namespace StudentService
{


    public class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=NewInformationTechnologies;Username=postgres;Password=1234");
        }
    }
}
