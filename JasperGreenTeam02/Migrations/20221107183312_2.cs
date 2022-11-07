using Microsoft.EntityFrameworkCore.Migrations;

namespace JasperGreenTeam02.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BillingZip",
                table: "Customers",
                newName: "BillingZIP");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customers",
                newName: "CustomerID");

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

            migrationBuilder.CreateIndex(
                name: "IX_Properties_CustomerID",
                table: "Properties",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.RenameColumn(
                name: "BillingZIP",
                table: "Customers",
                newName: "BillingZip");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Customers",
                newName: "CustomerId");
        }
    }
}
