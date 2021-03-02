using Microsoft.EntityFrameworkCore.Migrations;

namespace VeganCakeShop.Migrations
{
    public partial class photochange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44317/Images/CarrotCakesmall.jpg", "https://localhost:44317/Images/CarrotCakesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44317/Images/CreamTeasmall.jpg", "https://localhost:44317/Images/CreamTeasmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44317/Images/NaomiChocolateBrowniessmall.jpg", "https://localhost:44317/Images/NaomiChocolateBrowniessmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44317/Images/Christmassmall.jpg", "https://localhost:44317/Images/Christmassmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44317/Images/ChocolateChicksmall.jpg", "https://localhost:44317/Images/ChocolateChicksmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44317/Images/Wellingtonsmall.jpg", "https://localhost:44317/Images/Wellingtonsmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44317/Images/PunkyPiesmall.jpg", "https://localhost:44317/Images/PunkyPiesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44317/Images/SpaghettiLuisasmall.jpg", "https://localhost:44317/Images/SpaghettiLuisasmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44317/Images/Millonairessmall.jpg", "https://localhost:44317/Images/Millonairessmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44317/Images/Triceratopssmall.jpg", "https://localhost:44317/Images/Triceratopssmall.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost44317/Images/CarrotCakesmall.jpg", "https://localhost44317/Images/CarrotCakesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost44317/Images/CreamTeasmall.jpg", "https://localhost44317/Images/CreamTeasmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost44317/Images/NaomiChocolateBrowniessmall.jpg", "https://localhost44317/Images/NaomiChocolateBrowniessmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost44317/Images/Christmassmall.jpg", "https://localhost44317/Images/Christmassmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost44317/Images/ChocolateChicksmall.jpg", "https://localhost44317/Images/ChocolateChicksmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost44317/Images/Wellingtonsmall.jpg", "https://localhost44317/Images/Wellingtonsmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost44317/Images/PunkyPiesmall.jpg", "https://localhost44317/Images/PunkyPiesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost44317/Images/SpaghettiLuisasmall.jpg", "https://localhost44317/Images/SpaghettiLuisasmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost44317/Images/Millonairessmall.jpg", "https://localhost44317/Images/Millonairessmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost44317/Images/Triceratopssmall.jpg", "https://localhost44317/Images/Triceratopssmall.jpg" });
        }
    }
}
