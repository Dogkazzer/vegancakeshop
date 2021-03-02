using Microsoft.EntityFrameworkCore.Migrations;

namespace VeganCakeShop.Migrations
{
    public partial class cake4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/Wellingtonnew.jpg", "https://localhost:44319/Images/Wellingtonnew.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/Millonairesnew.jpg", "https://localhost:44319/Images/Millonairesnew.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/choc.jpg", "https://localhost:44319/Images/choc.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/Wellingtonsmall.jpg", "https://localhost:44319/Images/Wellingtonsmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/Millon.jpg", "https://localhost:44319/Images/Millon.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/Tricera.jpg", "https://localhost:44319/Images/Tricera.jpg" });
        }
    }
}
