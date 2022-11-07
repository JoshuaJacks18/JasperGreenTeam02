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
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    BillingAddress = table.Column<string>(nullable: true),
                    BillingCity = table.Column<string>(nullable: true),
                    BillingState = table.Column<string>(nullable: true),
                    BillingZip = table.Column<string>(nullable: true),
                    CustomerPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "BillingAddress", "BillingCity", "BillingState", "BillingZip", "CustomerPhone", "Name" },
                values: new object[,]
                {
                    { 1, "123 Main St", "College Station", "TX", "77480", "1234567890", "John" },
                    { 2, "124 Main St", "College Station", "TX", "77480", "1234567891", "Jain" },
                    { 3, "122 Main St", "College Station", "TX", "77480", "1234567892", "James" },
                    { 4, "125 Main St", "College Station", "TX", "77480", "1234567893", "Joe" },
                    { 5, "121 Main St", "College Station", "TX", "77480", "1234567899", "Jessie" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
