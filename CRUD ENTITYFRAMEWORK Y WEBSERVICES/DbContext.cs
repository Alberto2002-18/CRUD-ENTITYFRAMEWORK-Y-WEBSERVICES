using Microsoft.EntityFrameworkCore;

namespace CRUD_ENTITYFRAMEWORK_Y_WEBSERVICES
{
    public class AppDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().ToTable("PRODUCTOS");
            modelBuilder.Entity<Producto>().HasKey(p => p.Id_Producto);
        }
    }
}
