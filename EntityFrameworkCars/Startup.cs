using EntityFrameworkCars.Database;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace EntityFrameworkCars
{
    public class Startup
    {
        // The Configure() method, despite being empty, is required in order for a DbContext to be instantiated.
        public static void Configure()
        {
        }

        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureDbContext(services);
        }

        private void ConfigureDbContext(IServiceCollection services)
        {
            var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");

            services.AddDbContext<CarsDbContext>(
                opt => opt
                    .UseNpgsql(connectionString)
            );
        }
    }
}