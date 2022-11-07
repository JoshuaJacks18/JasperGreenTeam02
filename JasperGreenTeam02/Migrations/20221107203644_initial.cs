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
                    Name = table.Column<string>(nullable: true),
                    BillingAddress = table.Column<string>(nullable: true),
                    BillingCity = table.Column<string>(nullable: true),
                    BillingState = table.Column<string>(nullable: true),
                    BillingZIP = table.Column<string>(nullable: true),
                    CustomerPhone = table.Column<string>(nullable: true)
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
                    EmployeeFirstName = table.Column<string>(nullable: true),
                    EmployeeLastName = table.Column<string>(nullable: true),
                    SSN = table.Column<int>(nullable: false),
                    JobTitle = table.Column<string>(nullable: true),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    PropertyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(nullable: false),
                    PropertyAddress = table.Column<string>(nullable: true),
                    PropertyCity = table.Column<string>(nullable: true),
                    PropertyState = table.Column<string>(nullable: true),
                    PropertyZIP = table.Column<string>(nullable: true),
                    ServiceFee = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.PropertyID);
                    table.ForeignKey(
                        name: "FK_Properties_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Crews",
                columns: table => new
                {
                    CrewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewForemanID = table.Column<int>(nullable: false),
                    CrewMember1ID = table.Column<int>(nullable: false),
                    CrewMember2ID = table.Column<int>(nullable: false),
                    ForemanEmployeeID = table.Column<int>(nullable: true)
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
                        name: "FK_Crews_Employees_ForemanEmployeeID",
                        column: x => x.ForemanEmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProvideService",
                columns: table => new
                {
                    ServiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrewID = table.Column<int>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false),
                    PropertyID = table.Column<int>(nullable: false),
                    ServiceDate = table.Column<DateTime>(nullable: false),
                    ServiceFee = table.Column<double>(nullable: false),
                    PaymentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvideService", x => x.ServiceID);
                    table.ForeignKey(
                        name: "FK_ProvideService_Crews_CrewID",
                        column: x => x.CrewID,
                        principalTable: "Crews",
                        principalColumn: "CrewID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProvideService_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProvideService_Payments_PaymentID",
                        column: x => x.PaymentID,
                        principalTable: "Payments",
                        principalColumn: "PaymentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProvideService_Properties_PropertyID",
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
                    { 1, "Elliot", "Matterbaby", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.5, "Worker", 123726532 },
                    { 2, "Edward", "Linus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.5, "Worker", 123726532 },
                    { 3, "Emmy", "Elders", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.5, "Worker", 123726532 }
                });

            migrationBuilder.InsertData(
                table: "Crews",
                columns: new[] { "CrewID", "CrewForemanID", "CrewMember1ID", "CrewMember2ID", "ForemanEmployeeID" },
                values: new object[] { 1, 1, 2, 3, null });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentID", "CustomerID", "PaymentAmount", "PaymentDate" },
                values: new object[] { 1, 1, 300.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyID", "CustomerID", "PropertyAddress", "PropertyCity", "PropertyState", "PropertyZIP", "ServiceFee" },
                values: new object[,]
                {
                    { 1, 1, "123 Main St", "College Station", "TX", "77480", null },
                    { 2, 1, "123 Main St", "College Station", "TX", "77480", null },
                    { 3, 2, "123 Main St", "College Station", "TX", "77480", null },
                    { 4, 2, "123 Main St", "College Station", "TX", "77480", null },
                    { 5, 3, "123 Main St", "College Station", "TX", "77480", null },
                    { 6, 3, "123 Main St", "College Station", "TX", "77480", null },
                    { 7, 4, "123 Main St", "College Station", "TX", "77480", null },
                    { 8, 4, "123 Main St", "College Station", "TX", "77480", null },
                    { 9, 5, "123 Main St", "College Station", "TX", "77480", null },
                    { 10, 5, "123 Main St", "College Station", "TX", "77480", null }
                });

            migrationBuilder.InsertData(
                table: "ProvideService",
                columns: new[] { "ServiceID", "CrewID", "CustomerID", "PaymentID", "PropertyID", "ServiceDate", "ServiceFee" },
                values: new object[] { 1, 1, 1, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 300.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Crews_CrewMember1ID",
                table: "Crews",
                column: "CrewMember1ID");

            migrationBuilder.CreateIndex(
                name: "IX_Crews_CrewMember2ID",
                table: "Crews",
                column: "CrewMember2ID");

            migrationBuilder.CreateIndex(
                name: "IX_Crews_ForemanEmployeeID",
                table: "Crews",
                column: "ForemanEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustomerID",
                table: "Payments",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_CustomerID",
                table: "Properties",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ProvideService_CrewID",
                table: "ProvideService",
                column: "CrewID");

            migrationBuilder.CreateIndex(
                name: "IX_ProvideService_CustomerID",
                table: "ProvideService",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ProvideService_PaymentID",
                table: "ProvideService",
                column: "PaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_ProvideService_PropertyID",
                table: "ProvideService",
                column: "PropertyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProvideService");

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
