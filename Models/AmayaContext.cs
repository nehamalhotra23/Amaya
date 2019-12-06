using Microsoft.EntityFrameworkCore;

namespace Amaya
{
    public class AmayaContext : DbContext
    {
        public AmayaContext(DbContextOptions<AmayaContext> options) : base(options)
        {

        }
        public DbSet<Customers> Customers { get; set; }
    
    }
}