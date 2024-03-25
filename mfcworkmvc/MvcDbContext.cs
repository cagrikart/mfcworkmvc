using mfcworkmvc.Models;
using Microsoft.EntityFrameworkCore;

namespace mfcworkmvc
{
    public class MvcDbContext:  DbContext
    {
        public DbSet<Product> Products { get; set; }

    public MvcDbContext(DbContextOptions<MvcDbContext> options) : base(options)
    {

    }
    }
}
