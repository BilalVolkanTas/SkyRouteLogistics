using Microsoft.EntityFrameworkCore;

namespace SkyRouteLogistics.Models
{
    // DbContext sınıfından miras alarak bu sınıfı bir veri tabanı yöneticisi yapıyoruz
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Bu property'ler PostgreSQL'de tablolara dönüşecek olan yapılardır.
        // Okulda gördüğün "Tables" mantığı.
        public DbSet<Flight> Flights { get; set; }
        public DbSet<CargoContainer> CargoContainers { get; set; }
    }
}