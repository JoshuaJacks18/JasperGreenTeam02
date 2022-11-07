using System;
using Microsoft.EntityFrameworkCore;



namespace JasperGreenTeam02.Models
{
    public class JasperGreenContext : DbContext
    {
        public JasperGreenContext(DbContextOptions<JasperGreenContext> options)
            : base(options) 
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Property> Properties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerID = 1,
                    Name = "John",
                    BillingAddress = "123 Main St",
                    BillingCity = "College Station",
                    BillingState = "TX",
                    BillingZIP = "77480",
                    CustomerPhone = "1234567890"
                },
                new Customer
                {
                    CustomerID = 2,
                    Name = "Jain",
                    BillingAddress = "124 Main St",
                    BillingCity = "College Station",
                    BillingState = "TX",
                    BillingZIP = "77480",
                    CustomerPhone = "1234567891"
                },
                new Customer
                {
                    CustomerID = 3,
                    Name = "James",
                    BillingAddress = "122 Main St",
                    BillingCity = "College Station",
                    BillingState = "TX",
                    BillingZIP = "77480",
                    CustomerPhone = "1234567892"
                },
                new Customer
                {
                    CustomerID = 4,
                    Name = "Joe",
                    BillingAddress = "125 Main St",
                    BillingCity = "College Station",
                    BillingState = "TX",
                    BillingZIP = "77480",
                    CustomerPhone = "1234567893"
                },
                new Customer
                {
                    CustomerID = 5,
                    Name = "Jessie",
                    BillingAddress = "121 Main St",
                    BillingCity = "College Station",
                    BillingState = "TX",
                    BillingZIP = "77480",
                    CustomerPhone = "1234567899"
                }
                );
            modelBuilder.Entity<Property>().HasData(
                new Property
                {
                    PropertyID = 1,
                    CustomerID = 1,
                    PropertyAddress = "123 Main St",
                    PropertyCity ="College Station",
                    PropertyState = "TX",
                    PropertyZIP = "77480"
                },
                new Property
                {
                    PropertyID = 2,
                    CustomerID = 1,
                    PropertyAddress = "123 Main St",
                    PropertyCity = "College Station",
                    PropertyState = "TX",
                    PropertyZIP = "77480"
                },
                new Property
                {
                    PropertyID = 3,
                    CustomerID = 2,
                    PropertyAddress = "123 Main St",
                    PropertyCity = "College Station",
                    PropertyState = "TX",
                    PropertyZIP = "77480"
                },
                new Property
                {
                    PropertyID = 4,
                    CustomerID = 2,
                    PropertyAddress = "123 Main St",
                    PropertyCity = "College Station",
                    PropertyState = "TX",
                    PropertyZIP = "77480"
                },
                new Property
                {
                    PropertyID = 5,
                    CustomerID = 3,
                    PropertyAddress = "123 Main St",
                    PropertyCity = "College Station",
                    PropertyState = "TX",
                    PropertyZIP = "77480"
                },
                new Property
                {
                    PropertyID = 6,
                    CustomerID = 3,
                    PropertyAddress = "123 Main St",
                    PropertyCity = "College Station",
                    PropertyState = "TX",
                    PropertyZIP = "77480"
                },
                new Property
                {
                    PropertyID = 7,
                    CustomerID = 4,
                    PropertyAddress = "123 Main St",
                    PropertyCity = "College Station",
                    PropertyState = "TX",
                    PropertyZIP = "77480"
                },
                new Property
                {
                    PropertyID = 8,
                    CustomerID = 4,
                    PropertyAddress = "123 Main St",
                    PropertyCity = "College Station",
                    PropertyState = "TX",
                    PropertyZIP = "77480"
                },
                new Property
                {
                    PropertyID = 9,
                    CustomerID = 5,
                    PropertyAddress = "123 Main St",
                    PropertyCity = "College Station",
                    PropertyState = "TX",
                    PropertyZIP = "77480"
                },
                new Property
                {
                    PropertyID = 10,
                    CustomerID = 5,
                    PropertyAddress = "123 Main St",
                    PropertyCity = "College Station",
                    PropertyState = "TX",
                    PropertyZIP = "77480"
                }
                );
        }
    }
}
