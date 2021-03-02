using Microsoft.EntityFrameworkCore.Migrations;

namespace VeganCakeShop.Migrations
{
    public partial class cakes4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/CarrotCakenew.jpg", "https://localhost:44319/Images/CarrotCakenew.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 4,
                column: "Name",
                value: "Naomi's brownies");

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/scandicakesmall.jpg", "https://localhost:44319/Images/scandicakesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/Chocochick.jpg", "https://localhost:44319/Images/Chocochick.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/luisa.jpg", "https://localhost:44319/Images/luisa.jpg" });

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
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "https://localhost:44319/Images/Tricera.jpg", "https://localhost:44319/Images/Tricera.jpg", "Triceratops Cake" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/CarrotCakesmall.jpg", "https://localhost:44319/Images/CarrotCakesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 4,
                column: "Name",
                value: "Naomi's chocolate brownies");

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/Christmascakesmall.jpg", "https://localhost:44319/Images/Christmascakesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/ChocolateChicksmall.jpg", "https://localhost:44319/Images/ChocolateChicksmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/ghettiLuisasmall.jpg", "https://localhost:44319/Images/ghettiLuisasmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/Millonairesmall.jpg", "https://localhost:44319/Images/Millonairesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "https://localhost:44319/Images/Triceratopsmall.jpg", "https://localhost:44319/Images/Triceratopsmall.jpg", "Triceratops Birthday Cake" });
        }
    }
}
