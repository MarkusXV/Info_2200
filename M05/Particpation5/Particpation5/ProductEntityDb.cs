using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Particpation5
{
  public partial class ProductEntityDb : DbContext
  {
    public ProductEntityDb()
        : base("name=ProductEntityDb")
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Product>()
          .Property(e => e.Product_Number)
          .IsFixedLength();

      modelBuilder.Entity<Product>()
          .Property(e => e.Price)
          .HasPrecision(19, 4);
    }
  }
}
