using AdventureWorks.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Infrastructure.Data
{
    public class AdventureWorksContext : DbContext
    {
        public AdventureWorksContext(DbContextOptions<AdventureWorksContext> options) : base(options)
        {

        }

        public DbSet<Product> Products {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product","Production");
                entity.HasKey(e => e.ProductId);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
                entity.Property(e => e.ProductNumber).IsRequired().HasMaxLength(25);
                entity.Property(e => e.Color).HasMaxLength(15);

            });
        }
    }
}
