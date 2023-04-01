using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using System.Xml.Linq;

namespace EntityFrameworkCars
{
    class Program
    {
        static void Main(string[] args)
        {
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
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Data Source=angelosdb.cd8qygawtti7.eu-west-2.rds.amazonaws.com;Database=postgres;User ID=postgres;Password=angelosdb;MultipleActiveResultSets=True");
                }
            }
        }
    }
}
