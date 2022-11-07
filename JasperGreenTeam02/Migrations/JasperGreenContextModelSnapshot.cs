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
                        });
                });

            modelBuilder.Entity("JasperGreenTeam02.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BillingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingZIP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("HourlyRate")
                        .HasColumnType("float");

                    b.Property<string>("JobTitle")
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
                            HireDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HourlyRate = 10.5,
                            JobTitle = "Worker",
                            SSN = 123726532
                        },
                        new
                        {
                            EmployeeID = 2,
                            EmployeeFirstName = "Edward",
                            EmployeeLastName = "Linus",
                            HireDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HourlyRate = 10.5,
                            JobTitle = "Worker",
                            SSN = 123726532
                        },
                        new
                        {
                            EmployeeID = 3,
                            EmployeeFirstName = "Emmy",
                            EmployeeLastName = "Elders",
                            HireDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
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
                            PaymentAmount = 0.0,
                            PaymentDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyZIP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceFee")
                        .HasColumnType("nvarchar(max)");

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
                            PropertyZIP = "77480"
                        },
                        new
                        {
                            PropertyID = 2,
                            CustomerID = 1,
                            PropertyAddress = "123 Main St",
                            PropertyCity = "College Station",
                            PropertyState = "TX",
                            PropertyZIP = "77480"
                        },
                        new
                        {
                            PropertyID = 3,
                            CustomerID = 2,
                            PropertyAddress = "123 Main St",
                            PropertyCity = "College Station",
                            PropertyState = "TX",
                            PropertyZIP = "77480"
                        },
                        new
                        {
                            PropertyID = 4,
                            CustomerID = 2,
                            PropertyAddress = "123 Main St",
                            PropertyCity = "College Station",
                            PropertyState = "TX",
                            PropertyZIP = "77480"
                        },
                        new
                        {
                            PropertyID = 5,
                            CustomerID = 3,
                            PropertyAddress = "123 Main St",
                            PropertyCity = "College Station",
                            PropertyState = "TX",
                            PropertyZIP = "77480"
                        },
                        new
                        {
                            PropertyID = 6,
                            CustomerID = 3,
                            PropertyAddress = "123 Main St",
                            PropertyCity = "College Station",
                            PropertyState = "TX",
                            PropertyZIP = "77480"
                        },
                        new
                        {
                            PropertyID = 7,
                            CustomerID = 4,
                            PropertyAddress = "123 Main St",
                            PropertyCity = "College Station",
                            PropertyState = "TX",
                            PropertyZIP = "77480"
                        },
                        new
                        {
                            PropertyID = 8,
                            CustomerID = 4,
                            PropertyAddress = "123 Main St",
                            PropertyCity = "College Station",
                            PropertyState = "TX",
                            PropertyZIP = "77480"
                        },
                        new
                        {
                            PropertyID = 9,
                            CustomerID = 5,
                            PropertyAddress = "123 Main St",
                            PropertyCity = "College Station",
                            PropertyState = "TX",
                            PropertyZIP = "77480"
                        },
                        new
                        {
                            PropertyID = 10,
                            CustomerID = 5,
                            PropertyAddress = "123 Main St",
                            PropertyCity = "College Station",
                            PropertyState = "TX",
                            PropertyZIP = "77480"
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
#pragma warning restore 612, 618
        }
    }
}
