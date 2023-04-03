using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Net;
using System.Xml.Linq;

namespace EntityFrameworkCars
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new CarsDbContext();

            var manufacturerTest = new CarManufacturer { Name = "Test", YearFounded = 1991 };

            context.CarManufacturers.Add(manufacturerTest);

            context.SaveChanges();
        }

        public class CarManufacturer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int YearFounded { get; set; }
        }

        public class CarModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime DateLaunched { get; set; }
        }

        public class CarsDbContext : DbContext
        {
            public DbSet<CarManufacturer> CarManufacturers { get; set; }
            public DbSet<CarModel> CarModels { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");

                optionsBuilder.UseNpgsql(connectionString);
            }
        }
    }
}
