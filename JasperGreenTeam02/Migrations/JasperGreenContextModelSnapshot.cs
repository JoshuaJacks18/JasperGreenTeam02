﻿// <auto-generated />
using System;
using JasperGreenTeam02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JasperGreenTeam02.Migrations
{
    [DbContext(typeof(JasperGreenContext))]
    partial class JasperGreenContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JasperGreenTeam02.Models.Crew", b =>
                {
                    b.Property<int>("CrewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CrewForemanID")
                        .HasColumnType("int");

                    b.Property<int>("CrewMember1ID")
                        .HasColumnType("int");

                    b.Property<int>("CrewMember2ID")
                        .HasColumnType("int");

                    b.Property<int?>("ForemanEmployeeID")
                        .HasColumnType("int");

                    b.HasKey("CrewID");

                    b.HasIndex("CrewMember1ID");

                    b.HasIndex("CrewMember2ID");

                    b.HasIndex("ForemanEmployeeID");

                    b.ToTable("Crews");

                    b.HasData(
                        new
                        {
                            CrewID = 1,
                            CrewForemanID = 1,
                            CrewMember1ID = 2,
                            CrewMember2ID = 3
                        },
                        new
                        {
                            CrewID = 2,
                            CrewForemanID = 4,
                            CrewMember1ID = 5,
                            CrewMember2ID = 6
                        },
                        new
                        {
                            CrewID = 3,
                            CrewForemanID = 7,
                            CrewMember1ID = 8,
                            CrewMember2ID = 9
                        },
                        new
                        {
                            CrewID = 4,
                            CrewForemanID = 10,
                            CrewMember1ID = 11,
                            CrewMember2ID = 12
                        },
                        new
                        {
                            CrewID = 5,
                            CrewForemanID = 13,
                            CrewMember1ID = 14,
                            CrewMember2ID = 15
                        });
                });

            modelBuilder.Entity("JasperGreenTeam02.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BillingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingZIP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = 1,
                            BillingAddress = "123 Main St",
                            BillingCity = "College Station",
                            BillingState = "TX",
                            BillingZIP = "77480",
                            CustomerPhone = "1234567890",
                            Name = "John"
                        },
                        new
                        {
                            CustomerID = 2,
                            BillingAddress = "124 Main St",
                            BillingCity = "College Station",
                            BillingState = "TX",
                            BillingZIP = "77480",
                            CustomerPhone = "1234567891",
                            Name = "Jain"
                        },
                        new
                        {
                            CustomerID = 3,
                            BillingAddress = "122 Main St",
                            BillingCity = "College Station",
                            BillingState = "TX",
                            BillingZIP = "77480",
                            CustomerPhone = "1234567892",
                            Name = "James"
                        },
                        new
                        {
                            CustomerID = 4,
                            BillingAddress = "125 Main St",
                            BillingCity = "College Station",
                            BillingState = "TX",
                            BillingZIP = "77480",
                            CustomerPhone = "1234567893",
                            Name = "Joe"
                        },
                        new
                        {
                            CustomerID = 5,
                            BillingAddress = "121 Main St",
                            BillingCity = "College Station",
                            BillingState = "TX",
                            BillingZIP = "77480",
                            CustomerPhone = "1234567899",
                            Name = "Jessie"
                        });
                });

            modelBuilder.Entity("JasperGreenTeam02.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("HourlyRate")
                        .HasColumnType("float");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SSN")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            EmployeeFirstName = "Elliot",
                            EmployeeLastName = "Matterbaby",
                            HireDate = new DateTime(2022, 11, 9, 11, 45, 16, 568, DateTimeKind.Local).AddTicks(7293),
                            HourlyRate = 10.5,
                            JobTitle = "Worker",
                            SSN = 123726532
                        },
                        new
                        {
                            EmployeeID = 2,
                            EmployeeFirstName = "Edward",
                            EmployeeLastName = "Linus",
                            HireDate = new DateTime(2022, 11, 9, 11, 45, 16, 568, DateTimeKind.Local).AddTicks(7926),
                            HourlyRate = 10.5,
                            JobTitle = "Worker",
                            SSN = 123726532
                        },
                        new
                        {
                            EmployeeID = 3,
                            EmployeeFirstName = "Emmy",
                            EmployeeLastName = "Elders",
                            HireDate = new DateTime(2022, 11, 9, 11, 45, 16, 568, DateTimeKind.Local).AddTicks(7955),
                            HourlyRate = 10.5,
                            JobTitle = "Worker",
                            SSN = 123726532
                        },
                        new
                        {
                            EmployeeID = 4,
                            EmployeeFirstName = "Josh",
                            EmployeeLastName = "Jacks",
                            HireDate = new DateTime(2022, 11, 9, 11, 45, 16, 568, DateTimeKind.Local).AddTicks(7959),
                            HourlyRate = 10.5,
                            JobTitle = "Worker",
                            SSN = 123726532
                        },
                        new
                        {
                            EmployeeID = 5,
                            EmployeeFirstName = "John",
                            EmployeeLastName = "Baptist",
                            HireDate = new DateTime(2022, 11, 9, 11, 45, 16, 568, DateTimeKind.Local).AddTicks(7963),
                            HourlyRate = 10.5,
                            JobTitle = "Worker",
                            SSN = 123726532
                        },
                        new
                        {
                            EmployeeID = 6,
                            EmployeeFirstName = "Jimmy",
                            EmployeeLastName = "Neutron",
                            HireDate = new DateTime(2022, 11, 9, 11, 45, 16, 568, DateTimeKind.Local).AddTicks(7966),
                            HourlyRate = 10.5,
                            JobTitle = "Worker",
                            SSN = 123726532
                        },
                        new
                        {
                            EmployeeID = 7,
                            EmployeeFirstName = "Timmy",
                            EmployeeLastName = "Turner",
                            HireDate = new DateTime(2022, 11, 9, 11, 45, 16, 568, DateTimeKind.Local).AddTicks(7969),
                            HourlyRate = 10.5,
                            JobTitle = "Worker",
                            SSN = 123726532
                        },
                        new
                        {
                            EmployeeID = 8,
                            EmployeeFirstName = "Shawn",
                            EmployeeLastName = "Young",
                            HireDate = new DateTime(2022, 11, 9, 11, 45, 16, 568, DateTimeKind.Local).AddTicks(7973),
                            HourlyRate = 10.5,
                            JobTitle = "Worker",
                            SSN = 123726532
                        },
                        new
                        {
                            EmployeeID = 9,
                            EmployeeFirstName = "Sean",
                            EmployeeLastName = "Price",
                            HireDate = new DateTime(2022, 11, 9, 11, 45, 16, 568, DateTimeKind.Local).AddTicks(7976),
                            HourlyRate = 10.5,
                            JobTitle = "Worker",
                            SSN = 123726532
                        },
                        new
                        {
                            EmployeeID = 10,
                            EmployeeFirstName = "Tyler",
                            EmployeeLastName = "Thames",
                            HireDate = new DateTime(2022, 11, 9, 11, 45, 16, 568, DateTimeKind.Local).AddTicks(7980),
                            HourlyRate = 10.5,
                            JobTitle = "Worker",
                            SSN = 123726532
                        },
                        new
                        {
                            EmployeeID = 11,
                            EmployeeFirstName = "Spencer",
                            EmployeeLastName = "Simons",
                            HireDate = new DateTime(2022, 11, 9, 11, 45, 16, 568, DateTimeKind.Local).AddTicks(7983),
                            HourlyRate = 10.5,
                            JobTitle = "Worker",
                            SSN = 123726532
                        },
                        new
                        {
                            EmployeeID = 12,
                            EmployeeFirstName = "Greg",
                            EmployeeLastName = "Williams",
                            HireDate = new DateTime(2022, 11, 9, 11, 45, 16, 568, DateTimeKind.Local).AddTicks(7986),
                            HourlyRate = 10.5,
                            JobTitle = "Worker",
                            SSN = 123726532
                        },
                        new
                        {
                            EmployeeID = 13,
                            EmployeeFirstName = "Dameon",
                            EmployeeLastName = "Walker",
                            HireDate = new DateTime(2022, 11, 9, 11, 45, 16, 568, DateTimeKind.Local).AddTicks(7990),
                            HourlyRate = 10.5,
                            JobTitle = "Worker",
                            SSN = 123726532
                        },
                        new
                        {
                            EmployeeID = 14,
                            EmployeeFirstName = "James",
                            EmployeeLastName = "Thomas",
                            HireDate = new DateTime(2022, 11, 9, 11, 45, 16, 568, DateTimeKind.Local).AddTicks(7993),
                            HourlyRate = 10.5,
                            JobTitle = "Worker",
                            SSN = 123726532
                        },
                        new
                        {
                            EmployeeID = 15,
                            EmployeeFirstName = "Patrick",
                            EmployeeLastName = "Star",
                            HireDate = new DateTime(2022, 11, 9, 11, 45, 16, 568, DateTimeKind.Local).AddTicks(7997),
                            HourlyRate = 10.5,
                            JobTitle = "Worker",
                            SSN = 123726532
                        });
                });

            modelBuilder.Entity("JasperGreenTeam02.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<double>("PaymentAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PaymentID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            PaymentID = 1,
                            CustomerID = 1,
                            PaymentAmount = 200.0,
                            PaymentDate = new DateTime(2022, 11, 9, 11, 45, 16, 565, DateTimeKind.Local).AddTicks(7829)
                        },
                        new
                        {
                            PaymentID = 2,
                            CustomerID = 2,
                            PaymentAmount = 200.0,
                            PaymentDate = new DateTime(2022, 11, 9, 11, 45, 16, 568, DateTimeKind.Local).AddTicks(5155)
                        },
                        new
                        {
                            PaymentID = 3,
                            CustomerID = 3,
                            PaymentAmount = 200.0,
                            PaymentDate = new DateTime(2022, 11, 9, 11, 45, 16, 568, DateTimeKind.Local).AddTicks(5208)
                        },
                        new
                        {
                            PaymentID = 4,
                            CustomerID = 4,
                            PaymentAmount = 200.0,
                            PaymentDate = new DateTime(2022, 11, 9, 11, 45, 16, 568, DateTimeKind.Local).AddTicks(5214)
                        },
                        new
                        {
                            PaymentID = 5,
                            CustomerID = 5,
                            PaymentAmount = 200.0,
                            PaymentDate = new DateTime(2022, 11, 9, 11, 45, 16, 568, DateTimeKind.Local).AddTicks(5217)
                        });
                });

            modelBuilder.Entity("JasperGreenTeam02.Models.Property", b =>
                {
                    b.Property<int>("PropertyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("PropertyAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyZIP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ServiceFee")
                        .HasColumnType("float");

                    b.HasKey("PropertyID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            PropertyID = 1,
                            CustomerID = 1,
                            PropertyAddress = "123 Main St",
                            PropertyCity = "College Station",
                            PropertyState = "TX",
                            PropertyZIP = "77480",
                            ServiceFee = 100.0
                        },
                        new
                        {
                            PropertyID = 2,
                            CustomerID = 1,
                            PropertyAddress = "122 Main St",
                            PropertyCity = "College Station",
                            PropertyState = "TX",
                            PropertyZIP = "77480",
                            ServiceFee = 100.0
                        },
                        new
                        {
                            PropertyID = 3,
                            CustomerID = 2,
                            PropertyAddress = "124 Main St",
                            PropertyCity = "College Station",
                            PropertyState = "TX",
                            PropertyZIP = "77480",
                            ServiceFee = 100.0
                        },
                        new
                        {
                            PropertyID = 4,
                            CustomerID = 2,
                            PropertyAddress = "125 Main St",
                            PropertyCity = "College Station",
                            PropertyState = "TX",
                            PropertyZIP = "77480",
                            ServiceFee = 100.0
                        },
                        new
                        {
                            PropertyID = 5,
                            CustomerID = 3,
                            PropertyAddress = "126 Main St",
                            PropertyCity = "College Station",
                            PropertyState = "TX",
                            PropertyZIP = "77480",
                            ServiceFee = 100.0
                        },
                        new
                        {
                            PropertyID = 6,
                            CustomerID = 3,
                            PropertyAddress = "127 Main St",
                            PropertyCity = "College Station",
                            PropertyState = "TX",
                            PropertyZIP = "77480",
                            ServiceFee = 100.0
                        },
                        new
                        {
                            PropertyID = 7,
                            CustomerID = 4,
                            PropertyAddress = "128 Main St",
                            PropertyCity = "College Station",
                            PropertyState = "TX",
                            PropertyZIP = "77480",
                            ServiceFee = 100.0
                        },
                        new
                        {
                            PropertyID = 8,
                            CustomerID = 4,
                            PropertyAddress = "129 Main St",
                            PropertyCity = "College Station",
                            PropertyState = "TX",
                            PropertyZIP = "77480",
                            ServiceFee = 100.0
                        },
                        new
                        {
                            PropertyID = 9,
                            CustomerID = 5,
                            PropertyAddress = "135 Main St",
                            PropertyCity = "College Station",
                            PropertyState = "TX",
                            PropertyZIP = "77480",
                            ServiceFee = 100.0
                        },
                        new
                        {
                            PropertyID = 10,
                            CustomerID = 5,
                            PropertyAddress = "179 Main St",
                            PropertyCity = "College Station",
                            PropertyState = "TX",
                            PropertyZIP = "77480",
                            ServiceFee = 100.0
                        });
                });

            modelBuilder.Entity("JasperGreenTeam02.Models.ProvideService", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CrewID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("PaymentID")
                        .HasColumnType("int");

                    b.Property<int>("PropertyID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ServiceDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("ServiceFee")
                        .HasColumnType("float");

                    b.HasKey("ServiceID");

                    b.HasIndex("CrewID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("PaymentID");

                    b.HasIndex("PropertyID");

                    b.ToTable("ProvideServices");

                    b.HasData(
                        new
                        {
                            ServiceID = 1,
                            CrewID = 1,
                            CustomerID = 1,
                            PaymentID = 1,
                            PropertyID = 1,
                            ServiceDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ServiceFee = 100.0
                        },
                        new
                        {
                            ServiceID = 2,
                            CrewID = 1,
                            CustomerID = 1,
                            PaymentID = 1,
                            PropertyID = 2,
                            ServiceDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ServiceFee = 100.0
                        },
                        new
                        {
                            ServiceID = 3,
                            CrewID = 2,
                            CustomerID = 2,
                            PaymentID = 2,
                            PropertyID = 3,
                            ServiceDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ServiceFee = 100.0
                        },
                        new
                        {
                            ServiceID = 4,
                            CrewID = 2,
                            CustomerID = 2,
                            PaymentID = 2,
                            PropertyID = 4,
                            ServiceDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ServiceFee = 100.0
                        },
                        new
                        {
                            ServiceID = 5,
                            CrewID = 3,
                            CustomerID = 3,
                            PaymentID = 3,
                            PropertyID = 5,
                            ServiceDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ServiceFee = 100.0
                        },
                        new
                        {
                            ServiceID = 6,
                            CrewID = 3,
                            CustomerID = 3,
                            PaymentID = 3,
                            PropertyID = 6,
                            ServiceDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ServiceFee = 100.0
                        },
                        new
                        {
                            ServiceID = 7,
                            CrewID = 4,
                            CustomerID = 4,
                            PaymentID = 4,
                            PropertyID = 7,
                            ServiceDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ServiceFee = 100.0
                        },
                        new
                        {
                            ServiceID = 8,
                            CrewID = 4,
                            CustomerID = 4,
                            PaymentID = 4,
                            PropertyID = 8,
                            ServiceDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ServiceFee = 100.0
                        },
                        new
                        {
                            ServiceID = 9,
                            CrewID = 5,
                            CustomerID = 5,
                            PaymentID = 5,
                            PropertyID = 9,
                            ServiceDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ServiceFee = 100.0
                        },
                        new
                        {
                            ServiceID = 10,
                            CrewID = 5,
                            CustomerID = 5,
                            PaymentID = 5,
                            PropertyID = 10,
                            ServiceDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ServiceFee = 100.0
                        });
                });

            modelBuilder.Entity("JasperGreenTeam02.Models.Crew", b =>
                {
                    b.HasOne("JasperGreenTeam02.Models.Employee", "CrewMember1")
                        .WithMany("Member1")
                        .HasForeignKey("CrewMember1ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("JasperGreenTeam02.Models.Employee", "CrewMember2")
                        .WithMany("Member2")
                        .HasForeignKey("CrewMember2ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("JasperGreenTeam02.Models.Employee", "Foreman")
                        .WithMany("Crews")
                        .HasForeignKey("ForemanEmployeeID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("JasperGreenTeam02.Models.Payment", b =>
                {
                    b.HasOne("JasperGreenTeam02.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JasperGreenTeam02.Models.Property", b =>
                {
                    b.HasOne("JasperGreenTeam02.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JasperGreenTeam02.Models.ProvideService", b =>
                {
                    b.HasOne("JasperGreenTeam02.Models.Crew", "Crew")
                        .WithMany("ProvidedServices")
                        .HasForeignKey("CrewID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("JasperGreenTeam02.Models.Customer", "Customer")
                        .WithMany("ProvidedServices")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("JasperGreenTeam02.Models.Payment", "Payment")
                        .WithMany("ProvidedServices")
                        .HasForeignKey("PaymentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("JasperGreenTeam02.Models.Property", "Property")
                        .WithMany("ProvidedServices")
                        .HasForeignKey("PropertyID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
