using Microsoft.EntityFrameworkCore.Migrations;

namespace VeganCakeShop.Migrations
{
    public partial class cake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 4,
                columns: new[] { "Name", "ShortDescription" },
                values: new object[] { "Naomi's chocolate chip brownies", "A chocolate, crunchy brownie!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 4,
                columns: new[] { "Name", "ShortDescription" },
                values: new object[] { "Naomi's velvet chocolate chip brownies", "A chocolate, squishy, crunchy brownie!" });
        }
    }
}
