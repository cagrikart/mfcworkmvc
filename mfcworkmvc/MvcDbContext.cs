using mfcworkmvc.Models;
using Microsoft.EntityFrameworkCore;

namespace mfcworkmvc
{
    public class MvcDbContext:  DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<MainCategory> MainCategories{ get; set; }
        public DbSet<SubCategory> SubCategories{ get; set; }
        public DbSet<Student> Students{ get; set; }
        public DbSet<Grade> Grades{ get; set; }
        

    public MvcDbContext(DbContextOptions<MvcDbContext> options) : base(options)
    {

    }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.subCategory) // Product ile SubCategory arasında tek yönlü bir ilişki tanımlıyoruz.
                .WithMany() // SubCategory'nin Product'a geri dönük bir navigasyon özelliği olmadığını varsayıyoruz.
                .HasForeignKey(p => p.subCategoryId); // İlişkinin dış anahtarını belirtiyoruz.
        }

    }
}
