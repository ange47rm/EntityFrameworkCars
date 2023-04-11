using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCars.Models
{

    public class CarManufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearFounded { get; set; }
    }
}
