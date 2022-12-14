using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JasperGreenTeam02.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    BillingAddress = table.Column<string>(nullable: false),
                    BillingCity = table.Column<string>(nullable: false),
                    BillingState = table.Column<string>(nullable: false),
                    BillingZIP = table.Column<string>(nullable: false),
                    CustomerPhone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeFirstName = table.Column<string>(nullable: false),
                    EmployeeLastName = table.Column<string>(nullable: false),
                    SSN = table.Column<int>(nullable: false),
                    JobTitle = table.Column<string>(nullable: false),
                    HireDate = table.Column<DateTime>(nullable: false),
                    HourlyRate = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: false),
                    PaymentAmount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_Payments_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    PropertyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(nullable: false),
                    PropertyAddress = table.Column<string>(nullable: false),
                    PropertyCity = table.Column<string>(nullable: false),
                    PropertyState = table.Column<string>(nullable: false),
                    PropertyZIP = table.Column<string>(nullable: false),
                    ServiceFee = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.PropertyID);
                    table.ForeignKey(
                        name: "FK_Properties_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Crews",
                columns: table => new
                {
                    CrewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForemanID = table.Column<int>(nullable: false),
                    CrewMember1ID = table.Column<int>(nullable: false),
                    CrewMember2ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crews", x => x.CrewID);
                    table.ForeignKey(
                        name: "FK_Crews_Employees_CrewMember1ID",
                        column: x => x.CrewMember1ID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Crews_Employees_CrewMember2ID",
                        column: x => x.CrewMember2ID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Crews_Employees_ForemanID",
                        column: x => x.ForemanID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProvideServices",
                columns: table => new
                {
                    ServiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewID = table.Column<int>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false),
                    PropertyID = table.Column<int>(nullable: false),
                    ServiceDate = table.Column<DateTime>(nullable: false),
                    ServiceFee = table.Column<double>(nullable: false),
                    PaymentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvideServices", x => x.ServiceID);
                    table.ForeignKey(
                        name: "FK_ProvideServices_Crews_CrewID",
                        column: x => x.CrewID,
                        principalTable: "Crews",
                        principalColumn: "CrewID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProvideServices_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProvideServices_Payments_PaymentID",
                        column: x => x.PaymentID,
                        principalTable: "Payments",
                        principalColumn: "PaymentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProvideServices_Properties_PropertyID",
                        column: x => x.PropertyID,
                        principalTable: "Properties",
                        principalColumn: "PropertyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "BillingAddress", "BillingCity", "BillingState", "BillingZIP", "CustomerPhone", "Name" },
                values: new object[,]
                {
                    { 1, "123 Main St", "College Station", "TX", "77480", "1234567890", "John" },
                    { 2, "124 Main St", "College Station", "TX", "77480", "1234567891", "Jain" },
                    { 3, "122 Main St", "College Station", "TX", "77480", "1234567892", "James" },
                    { 4, "125 Main St", "College Station", "TX", "77480", "1234567893", "Joe" },
                    { 5, "121 Main St", "College Station", "TX", "77480", "1234567899", "Jessie" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "EmployeeFirstName", "EmployeeLastName", "HireDate", "HourlyRate", "JobTitle", "SSN" },
                values: new object[,]
                {
                    { 13, "Dameon", "Walker", new DateTime(2022, 12, 5, 11, 44, 46, 119, DateTimeKind.Local).AddTicks(7394), 10.5, "Worker", 123726532 },
                    { 12, "Greg", "Williams", new DateTime(2022, 12, 5, 11, 44, 46, 119, DateTimeKind.Local).AddTicks(7390), 10.5, "Worker", 123726532 },
                    { 11, "Spencer", "Simons", new DateTime(2022, 12, 5, 11, 44, 46, 119, DateTimeKind.Local).AddTicks(7387), 10.5, "Worker", 123726532 },
                    { 10, "Tyler", "Thames", new DateTime(2022, 12, 5, 11, 44, 46, 119, DateTimeKind.Local).AddTicks(7384), 10.5, "Worker", 123726532 },
                    { 9, "Sean", "Price", new DateTime(2022, 12, 5, 11, 44, 46, 119, DateTimeKind.Local).AddTicks(7381), 10.5, "Worker", 123726532 },
                    { 8, "Shawn", "Young", new DateTime(2022, 12, 5, 11, 44, 46, 119, DateTimeKind.Local).AddTicks(7377), 10.5, "Worker", 123726532 },
                    { 5, "John", "Baptist", new DateTime(2022, 12, 5, 11, 44, 46, 119, DateTimeKind.Local).AddTicks(7367), 10.5, "Worker", 123726532 },
                    { 6, "Jimmy", "Neutron", new DateTime(2022, 12, 5, 11, 44, 46, 119, DateTimeKind.Local).AddTicks(7370), 10.5, "Worker", 123726532 },
                    { 14, "James", "Thomas", new DateTime(2022, 12, 5, 11, 44, 46, 119, DateTimeKind.Local).AddTicks(7397), 10.5, "Worker", 123726532 },
                    { 4, "Josh", "Jacks", new DateTime(2022, 12, 5, 11, 44, 46, 119, DateTimeKind.Local).AddTicks(7364), 10.5, "Worker", 123726532 },
                    { 3, "Emmy", "Elders", new DateTime(2022, 12, 5, 11, 44, 46, 119, DateTimeKind.Local).AddTicks(7360), 10.5, "Worker", 123726532 },
                    { 2, "Edward", "Linus", new DateTime(2022, 12, 5, 11, 44, 46, 119, DateTimeKind.Local).AddTicks(7332), 10.5, "Worker", 123726532 },
                    { 1, "Elliot", "Matterbaby", new DateTime(2022, 12, 5, 11, 44, 46, 119, DateTimeKind.Local).AddTicks(6746), 10.5, "Worker", 123726532 },
                    { 7, "Timmy", "Turner", new DateTime(2022, 12, 5, 11, 44, 46, 119, DateTimeKind.Local).AddTicks(7374), 10.5, "Worker", 123726532 },
                    { 15, "Patrick", "Star", new DateTime(2022, 12, 5, 11, 44, 46, 119, DateTimeKind.Local).AddTicks(7400), 10.5, "Worker", 123726532 }
                });

            migrationBuilder.InsertData(
                table: "Crews",
                columns: new[] { "CrewID", "CrewMember1ID", "CrewMember2ID", "ForemanID" },
                values: new object[,]
                {
                    { 5, 14, 15, 13 },
                    { 3, 8, 9, 7 },
                    { 2, 5, 6, 4 },
                    { 1, 2, 3, 1 },
                    { 4, 11, 12, 10 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentID", "CustomerID", "PaymentAmount", "PaymentDate" },
                values: new object[,]
                {
                    { 5, 5, 200.0, new DateTime(2022, 12, 5, 11, 44, 46, 119, DateTimeKind.Local).AddTicks(4848) },
                    { 4, 4, 200.0, new DateTime(2022, 12, 5, 11, 44, 46, 119, DateTimeKind.Local).AddTicks(4845) },
                    { 2, 2, 200.0, new DateTime(2022, 12, 5, 11, 44, 46, 119, DateTimeKind.Local).AddTicks(4792) },
                    { 3, 3, 200.0, new DateTime(2022, 12, 5, 11, 44, 46, 119, DateTimeKind.Local).AddTicks(4840) },
                    { 1, 1, 200.0, new DateTime(2022, 12, 5, 11, 44, 46, 117, DateTimeKind.Local).AddTicks(100) }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyID", "CustomerID", "PropertyAddress", "PropertyCity", "PropertyState", "PropertyZIP", "ServiceFee" },
                values: new object[,]
                {
                    { 5, 3, "126 Main St", "College Station", "TX", "77480", 100.0 },
                    { 6, 3, "127 Main St", "College Station", "TX", "77480", 100.0 },
                    { 4, 2, "125 Main St", "College Station", "TX", "77480", 100.0 },
                    { 7, 4, "128 Main St", "College Station", "TX", "77480", 100.0 },
                    { 8, 4, "129 Main St", "College Station", "TX", "77480", 100.0 },
                    { 3, 2, "124 Main St", "College Station", "TX", "77480", 100.0 },
                    { 9, 5, "135 Main St", "College Station", "TX", "77480", 100.0 },
                    { 10, 5, "179 Main St", "College Station", "TX", "77480", 100.0 },
                    { 2, 1, "122 Main St", "College Station", "TX", "77480", 100.0 },
                    { 1, 1, "123 Main St", "College Station", "TX", "77480", 100.0 }
                });

            migrationBuilder.InsertData(
                table: "ProvideServices",
                columns: new[] { "ServiceID", "CrewID", "CustomerID", "PaymentID", "PropertyID", "ServiceDate", "ServiceFee" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { 2, 1, 1, 1, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { 3, 2, 2, 2, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { 4, 2, 2, 2, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { 5, 3, 3, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { 6, 3, 3, 3, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { 7, 4, 4, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { 8, 4, 4, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { 9, 5, 5, 5, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { 10, 5, 5, 5, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Crews_CrewMember1ID",
                table: "Crews",
                column: "CrewMember1ID");

            migrationBuilder.CreateIndex(
                name: "IX_Crews_CrewMember2ID",
                table: "Crews",
                column: "CrewMember2ID");

            migrationBuilder.CreateIndex(
                name: "IX_Crews_ForemanID",
                table: "Crews",
                column: "ForemanID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustomerID",
                table: "Payments",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_CustomerID",
                table: "Properties",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ProvideServices_CrewID",
                table: "ProvideServices",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_ProvideServices_CustomerID",
                table: "ProvideServices",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ProvideServices_PaymentID",
                table: "ProvideServices",
                column: "PaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_ProvideServices_PropertyID",
                table: "ProvideServices",
                column: "PropertyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProvideServices");

            migrationBuilder.DropTable(
                name: "Crews");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
