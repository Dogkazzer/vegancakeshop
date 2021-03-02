using Microsoft.EntityFrameworkCore.Migrations;

namespace VeganCakeShop.Migrations
{
    public partial class photoedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/scone.jpg", "https://localhost:44319/Images/scone.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/Christmascakesmall.jpg", "https://localhost:44319/Images/Christmascakesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "https://localhost:44319/Images/ginger.jpg", "https://localhost:44319/Images/ginger.jpg", "Punky Cake" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/ghettiLuisasmall.jpg", "https://localhost:44319/Images/ghettiLuisasmall.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/Christmassmall.jpg", "https://localhost:44319/Images/Christmassmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "https://localhost:44319/Images/PunkyPiesmall.jpg", "https://localhost:44319/Images/PunkyPiesmall.jpg", "Punky Pie" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:44319/Images/SpaghettiLuisasmall.jpg", "https://localhost:44319/Images/SpaghettiLuisasmall.jpg" });
        }
    }
}
