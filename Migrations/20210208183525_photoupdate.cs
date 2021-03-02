using Microsoft.EntityFrameworkCore.Migrations;

namespace VeganCakeShop.Migrations
{
    public partial class photoupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/CazzCreamTeasmall.jpg", "https://localhost:44319/Images/CazzCreamTeasmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://localhost:44319/Images/NaomiChocolateBrowniesmall.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/CreamTeasmall.jpg", "https://localhost:44319/Images/CreamTeasmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://localhost:44319/Images/NaomiChocolateBrowniessmall.jpg");
        }
    }
}
