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
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Crew> Crews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relationship and Deletion Rules


            modelBuilder.Entity<Crew>()
                .HasOne(e => e.Foreman)
                .WithMany(c => c.Crews)
                .OnDelete(DeleteBehavior.Restrict)
            ;

            modelBuilder.Entity<Crew>()
                .HasOne(e => e.CrewMember1)
                .WithMany(c => c.Member1)
                .OnDelete(DeleteBehavior.Restrict)
            ;

            modelBuilder.Entity<Crew>()
                .HasOne(e => e.CrewMember2)
                .WithMany(c => c.Member2)
                .OnDelete(DeleteBehavior.Restrict)
            ;

            modelBuilder.Entity<ProvideService>()
                .HasKey(p => p.ServiceID)
            ;

            modelBuilder.Entity<ProvideService>()
                .HasOne(c => c.Customer)
                .WithMany(p => p.ProvidedServices)
                .OnDelete(DeleteBehavior.Restrict)
            ;

            modelBuilder.Entity<ProvideService>()
                .HasOne(c => c.Crew)
                .WithMany(p => p.ProvidedServices)
                .OnDelete(DeleteBehavior.Restrict)
            ;
            
            modelBuilder.Entity<ProvideService>()
                .HasOne(c => c.Property)
                .WithMany(p => p.ProvidedServices)
                .OnDelete(DeleteBehavior.Restrict)
            ;

            modelBuilder.Entity<ProvideService>()
                .HasOne(c => c.Payment)
                .WithMany(p => p.ProvidedServices)
                .OnDelete(DeleteBehavior.Restrict)
            ;


            //Seed Data
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
                    PropertyCity = "College Station",
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
            modelBuilder.Entity<Payment>().HasData(
                new Payment
                {
                    PaymentID = 1,
                    CustomerID = 1,
                    PaymentAmount = 300.0
                },
                new Payment
                {
                    PaymentID = 2,
                    CustomerID = 2,
                    PaymentAmount = 300.0
                },
                new Payment
                {
                    PaymentID = 3,
                    CustomerID = 3,
                    PaymentAmount = 300.0
                },
                new Payment
                {
                    PaymentID = 4,
                    CustomerID = 4,
                    PaymentAmount = 300.0
                },
                new Payment
                {
                    PaymentID = 5,
                    CustomerID = 5,
                    PaymentAmount = 300.0
                }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeID = 1,
                    EmployeeFirstName = "Elliot",
                    EmployeeLastName = "Matterbaby",
                    SSN = 123726532,
                    JobTitle = "Worker",
                    HourlyRate = 10.5
                },
                new Employee
                {
                    EmployeeID = 2,
                    EmployeeFirstName = "Edward",
                    EmployeeLastName = "Linus",
                    SSN = 123726532,
                    JobTitle = "Worker",
                    HourlyRate = 10.5
                },
                new Employee
                {
                    EmployeeID = 3,
                    EmployeeFirstName = "Emmy",
                    EmployeeLastName = "Elders",
                    SSN = 123726532,
                    JobTitle = "Worker",
                    HourlyRate = 10.5
                }
            );
            modelBuilder.Entity<Crew>().HasData(
                new Crew
                { 
                    CrewID = 1,
                    CrewForemanID = 1,
                    CrewMember1ID = 2,
                    CrewMember2ID = 3
                }
            );
            modelBuilder.Entity<ProvideService>().HasData(
                new ProvideService
                {
                    ServiceID = 1,
                    CrewID = 1,
                    CustomerID = 1,
                    PropertyID = 1,
                    ServiceFee = 300.0,
                    PaymentID = 1
                }
            );

        }
    }
}
