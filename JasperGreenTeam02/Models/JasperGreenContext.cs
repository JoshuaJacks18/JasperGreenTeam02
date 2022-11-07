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
                    ServiceFee = 100.0,
                    PropertyAddress = "123 Main St",
                    PropertyCity = "College Station",
                    PropertyState = "TX",
                    PropertyZIP = "77480"
                },
                new Property
                {
                    PropertyID = 2,
                    CustomerID = 1,
                    ServiceFee = 100.0,
                    PropertyAddress = "123 Main St",
                    PropertyCity = "College Station",
                    PropertyState = "TX",
                    PropertyZIP = "77480"
                },
                new Property
                {
                    PropertyID = 3,
                    CustomerID = 2,
                    ServiceFee = 100.0,
                    PropertyAddress = "123 Main St",
                    PropertyCity = "College Station",
                    PropertyState = "TX",
                    PropertyZIP = "77480"
                },
                new Property
                {
                    PropertyID = 4,
                    CustomerID = 2,
                    ServiceFee = 100.0,
                    PropertyAddress = "123 Main St",
                    PropertyCity = "College Station",
                    PropertyState = "TX",
                    PropertyZIP = "77480"
                },
                new Property
                {
                    PropertyID = 5,
                    CustomerID = 3,
                    ServiceFee = 100.0,
                    PropertyAddress = "123 Main St",
                    PropertyCity = "College Station",
                    PropertyState = "TX",
                    PropertyZIP = "77480"
                },
                new Property
                {
                    PropertyID = 6,
                    CustomerID = 3,
                    ServiceFee = 100.0,
                    PropertyAddress = "123 Main St",
                    PropertyCity = "College Station",
                    PropertyState = "TX",
                    PropertyZIP = "77480"
                },
                new Property
                {
                    PropertyID = 7,
                    CustomerID = 4,
                    ServiceFee = 100.0,
                    PropertyAddress = "123 Main St",
                    PropertyCity = "College Station",
                    PropertyState = "TX",
                    PropertyZIP = "77480"
                },
                new Property
                {
                    PropertyID = 8,
                    CustomerID = 4,
                    ServiceFee = 100.0,
                    PropertyAddress = "123 Main St",
                    PropertyCity = "College Station",
                    PropertyState = "TX",
                    PropertyZIP = "77480"
                },
                new Property
                {
                    PropertyID = 9,
                    CustomerID = 5,
                    ServiceFee = 100.0,
                    PropertyAddress = "123 Main St",
                    PropertyCity = "College Station",
                    PropertyState = "TX",
                    PropertyZIP = "77480"
                },
                new Property
                {
                    PropertyID = 10,
                    CustomerID = 5,
                    ServiceFee = 100.0,
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
                    PaymentDate = DateTime.Now,
                    PaymentAmount = 200.0
                },
                new Payment
                {
                    PaymentID = 2,
                    CustomerID = 2,
                    PaymentDate = DateTime.Now,
                    PaymentAmount = 200.0
                },
                new Payment
                {
                    PaymentID = 3,
                    CustomerID = 3,
                    PaymentDate = DateTime.Now,
                    PaymentAmount = 200.0
                },
                new Payment
                {
                    PaymentID = 4,
                    CustomerID = 4,
                    PaymentDate = DateTime.Now,
                    PaymentAmount = 200.0
                },
                new Payment
                {
                    PaymentID = 5,
                    CustomerID = 5,
                    PaymentDate = DateTime.Now,
                    PaymentAmount = 200.0
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
                    HireDate = DateTime.Now,
                    HourlyRate = 10.5
                },
                new Employee
                {
                    EmployeeID = 2,
                    EmployeeFirstName = "Edward",
                    EmployeeLastName = "Linus",
                    SSN = 123726532,
                    JobTitle = "Worker",
                    HireDate = DateTime.Now,
                    HourlyRate = 10.5
                },
                new Employee
                {
                    EmployeeID = 3,
                    EmployeeFirstName = "Emmy",
                    EmployeeLastName = "Elders",
                    SSN = 123726532,
                    JobTitle = "Worker",
                    HireDate = DateTime.Now,
                    HourlyRate = 10.5
                },
                new Employee
                {
                    EmployeeID = 4,
                    EmployeeFirstName = "Josh",
                    EmployeeLastName = "Jacks",
                    SSN = 123726532,
                    JobTitle = "Worker",
                    HireDate = DateTime.Now,
                    HourlyRate = 10.5
                },
                new Employee
                {
                    EmployeeID = 5,
                    EmployeeFirstName = "John",
                    EmployeeLastName = "Baptist",
                    SSN = 123726532,
                    JobTitle = "Worker",
                    HireDate = DateTime.Now,
                    HourlyRate = 10.5
                },
                new Employee
                {
                    EmployeeID = 6,
                    EmployeeFirstName = "Jimmy",
                    EmployeeLastName = "Neutron",
                    SSN = 123726532,
                    JobTitle = "Worker",
                    HireDate = DateTime.Now,
                    HourlyRate = 10.5
                },
                new Employee
                {
                    EmployeeID = 7,
                    EmployeeFirstName = "Timmy",
                    EmployeeLastName = "Turner",
                    SSN = 123726532,
                    JobTitle = "Worker",
                    HireDate = DateTime.Now,
                    HourlyRate = 10.5
                },
                new Employee
                {
                    EmployeeID = 8,
                    EmployeeFirstName = "Shawn",
                    EmployeeLastName = "Young",
                    SSN = 123726532,
                    JobTitle = "Worker",
                    HireDate = DateTime.Now,
                    HourlyRate = 10.5
                },
                new Employee
                {
                    EmployeeID = 9,
                    EmployeeFirstName = "Sean",
                    EmployeeLastName = "Price",
                    SSN = 123726532,
                    JobTitle = "Worker",
                    HireDate = DateTime.Now,
                    HourlyRate = 10.5
                },
                new Employee
                {
                    EmployeeID = 10,
                    EmployeeFirstName = "Tyler",
                    EmployeeLastName = "Thames",
                    SSN = 123726532,
                    JobTitle = "Worker",
                    HireDate = DateTime.Now,
                    HourlyRate = 10.5
                },
                new Employee
                {
                    EmployeeID = 11,
                    EmployeeFirstName = "Spencer",
                    EmployeeLastName = "Simons",
                    SSN = 123726532,
                    JobTitle = "Worker",
                    HireDate = DateTime.Now,
                    HourlyRate = 10.5
                },
                new Employee
                {
                    EmployeeID = 12,
                    EmployeeFirstName = "Greg",
                    EmployeeLastName = "Williams",
                    SSN = 123726532,
                    JobTitle = "Worker",
                    HireDate = DateTime.Now,
                    HourlyRate = 10.5
                },
                new Employee
                {
                    EmployeeID = 13,
                    EmployeeFirstName = "Dameon",
                    EmployeeLastName = "Walker",
                    SSN = 123726532,
                    JobTitle = "Worker",
                    HireDate = DateTime.Now,
                    HourlyRate = 10.5
                },
                new Employee
                {
                    EmployeeID = 14,
                    EmployeeFirstName = "James",
                    EmployeeLastName = "Thomas",
                    SSN = 123726532,
                    JobTitle = "Worker",
                    HireDate = DateTime.Now,
                    HourlyRate = 10.5
                },
                new Employee
                {
                    EmployeeID = 15,
                    EmployeeFirstName = "Patrick",
                    EmployeeLastName = "Star",
                    SSN = 123726532,
                    JobTitle = "Worker",
                    HireDate = DateTime.Now,
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
                }, 
                new Crew
                {
                    CrewID = 2,
                    CrewForemanID = 4,
                    CrewMember1ID = 5,
                    CrewMember2ID = 6
                },
                new Crew
                {
                    CrewID = 3,
                    CrewForemanID = 7,
                    CrewMember1ID = 8,
                    CrewMember2ID = 9
                },
                new Crew
                {
                    CrewID = 4,
                    CrewForemanID = 10,
                    CrewMember1ID = 11,
                    CrewMember2ID = 12
                },
                new Crew
                {
                    CrewID = 5,
                    CrewForemanID = 13,
                    CrewMember1ID = 14,
                    CrewMember2ID = 15
                }
            );
            modelBuilder.Entity<ProvideService>().HasData(
                new ProvideService
                {
                    ServiceID = 1,
                    CrewID = 1,
                    CustomerID = 1,
                    PropertyID = 1,
                    ServiceFee = 100.0,
                    PaymentID = 1
                },
                new ProvideService
                {
                    ServiceID = 2,
                    CrewID = 1,
                    CustomerID = 1,
                    PropertyID = 2,
                    ServiceFee = 100.0,
                    PaymentID = 1
                },
                new ProvideService
                {
                    ServiceID = 3,
                    CrewID = 2,
                    CustomerID = 2,
                    PropertyID = 3,
                    ServiceFee = 100.0,
                    PaymentID = 2
                },
                new ProvideService
                {
                    ServiceID = 4,
                    CrewID = 2,
                    CustomerID = 2,
                    PropertyID = 4,
                    ServiceFee = 100.0,
                    PaymentID = 2
                },
                new ProvideService
                {
                    ServiceID = 5,
                    CrewID = 3,
                    CustomerID = 3,
                    PropertyID = 5,
                    ServiceFee = 100.0,
                    PaymentID = 3
                },
                new ProvideService
                {
                    ServiceID = 6,
                    CrewID = 3,
                    CustomerID = 3,
                    PropertyID = 6,
                    ServiceFee = 100.0,
                    PaymentID = 3
                },
                new ProvideService
                {
                    ServiceID = 7,
                    CrewID = 4,
                    CustomerID = 4,
                    PropertyID = 7,
                    ServiceFee = 100.0,
                    PaymentID = 4
                },
                new ProvideService
                {
                    ServiceID = 8,
                    CrewID = 4,
                    CustomerID = 4,
                    PropertyID = 8,
                    ServiceFee = 100.0,
                    PaymentID = 4
                },
                new ProvideService
                {
                    ServiceID = 9,
                    CrewID = 5,
                    CustomerID = 5,
                    PropertyID = 9,
                    ServiceFee = 100.0,
                    PaymentID = 5
                },
                new ProvideService
                {
                    ServiceID = 10,
                    CrewID = 5,
                    CustomerID = 5,
                    PropertyID = 10,
                    ServiceFee = 100.0,
                    PaymentID = 5
                }
            );

        }
    }
}
