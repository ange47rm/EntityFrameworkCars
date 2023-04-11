namespace EntityFrameworkCars
{
    public static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception exception)
            {
                throw new Exception("Host terminated unexpectedly. Error:", exception);
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
                        Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
                        {
                            webBuilder
                                .UseStartup<Startup>();
                        });
    }
}
