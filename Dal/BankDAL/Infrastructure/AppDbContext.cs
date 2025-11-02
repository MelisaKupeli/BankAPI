using Microsoft.EntityFrameworkCore;
using BankAPI.Models;

namespace BankAPI.Dal.BankDAL.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            // Veritabanı ilk kez oluşturulduğunda SeedData'yı çağır
            Database.EnsureCreated();
            SeedData();
        }

        private void SeedData()
        {
            if (!Customers.Any())
            {
                var customers = new List<Customer>
                {
                    new Customer { Name = "John Doe", DateOfBirth = new DateTime(1980, 5, 10), Balance = 100.50m },
                    new Customer { Name = "Jane Smith", DateOfBirth = new DateTime(1992, 3, 15), Balance = 200.75m },
                    new Customer { Name = "Alice Johnson", DateOfBirth = new DateTime(1985, 7, 22), Balance = 150.00m },
                    new Customer { Name = "Bob Brown", DateOfBirth = new DateTime(1990, 12, 1), Balance = 300.25m }
                };

                Customers.AddRange(customers);
                SaveChanges();
            }
        }
    }
}
