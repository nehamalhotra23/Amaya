using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Amaya
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string  City { get; set; }
        public string State { get; set; }
        public int  Zip { get; set; }
    
    }
}