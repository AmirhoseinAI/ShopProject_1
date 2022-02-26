using Microsoft.EntityFrameworkCore;
using Infrastructure.Entities;

namespace Infrastructure.Context
{
    public class ContextDB : DbContext
    {
       public DbSet<Category> Categories{ get; set; }
       public DbSet<Product> Products{ get; set; }
       public DbSet<Color> Colors{ get; set; }
       public DbSet<Size> Sizes{ get; set; }
       protected override void OnConfiguring(DbContextOptionsBuilder db)
       {
           db.UseSqlServer("Server = .; Initial Catalog = ShopProjectDB; Integrated Security = True;");
       }
    }
}