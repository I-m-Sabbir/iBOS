using Microsoft.EntityFrameworkCore.Migrations;

namespace AkijFood.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblColdDrinks",
                columns: table => new
                {
                    intColdDrinksId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    strColdDrinksName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    numUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblColdDrinks", x => x.intColdDrinksId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblColdDrinks");
        }
    }
}
