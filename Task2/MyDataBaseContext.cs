using Microsoft.EntityFrameworkCore;
using Task1;

namespace Task2;

public class MyDatabaseContext : DbContext
{
     public DbSet<Product> Products { get; set; }
     public DbSet<User> Users { get; set; }
     public DbSet<Order> Orders { get; set; }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
          optionsBuilder.UseSqlServer("Server=localhost;" +
                                      "Database=EFDataBase;" +
                                      "User Id=sa;" +
                                      "Password=MySecur3P@ssw0rd;" +
                                      "TrustServerCertificate=True;");
     }

}