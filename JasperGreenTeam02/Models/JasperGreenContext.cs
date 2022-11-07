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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    Name = "John",
                    BillingAddress = "123 Main St",
                    BillingCity = "College Station",
                    BillingState = "TX",
                    BillingZip = "77480",
                    CustomerPhone = "1234567890"
                },
                new Customer
                {
                    CustomerId = 2,
                    Name = "Jain",
                    BillingAddress = "124 Main St",
                    BillingCity = "College Station",
                    BillingState = "TX",
                    BillingZip = "77480",
                    CustomerPhone = "1234567891"
                },
                new Customer
                {
                    CustomerId = 3,
                    Name = "James",
                    BillingAddress = "122 Main St",
                    BillingCity = "College Station",
                    BillingState = "TX",
                    BillingZip = "77480",
                    CustomerPhone = "1234567892"
                },
                new Customer
                {
                    CustomerId = 4,
                    Name = "Joe",
                    BillingAddress = "125 Main St",
                    BillingCity = "College Station",
                    BillingState = "TX",
                    BillingZip = "77480",
                    CustomerPhone = "1234567893"
                },
                new Customer
                {
                    CustomerId = 5,
                    Name = "Jessie",
                    BillingAddress = "121 Main St",
                    BillingCity = "College Station",
                    BillingState = "TX",
                    BillingZip = "77480",
                    CustomerPhone = "1234567899"
                }
                );
        }
    }
}
