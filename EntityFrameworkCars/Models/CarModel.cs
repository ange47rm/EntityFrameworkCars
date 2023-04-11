namespace EntityFrameworkCars.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateLaunched { get; set; }
        public int CarManufacturerId { get; set; }
        public virtual CarManufacturer CarManufacturer { get; set; }
    }
}
