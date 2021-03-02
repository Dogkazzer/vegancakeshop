using Microsoft.EntityFrameworkCore.Migrations;

namespace VeganCakeShop.Migrations
{
    public partial class shoppingcart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CakeId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Cakes_CakeId",
                        column: x => x.CakeId,
                        principalTable: "Cakes",
                        principalColumn: "CakeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 1,
                column: "Price",
                value: 5.75m);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 2,
                column: "Price",
                value: 3.25m);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 3,
                column: "Price",
                value: 4.95m);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "Price" },
                values: new object[] { "https://localhost:44319/Images/NaomiChocolateBrowniesmall.jpg", 2.25m });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 5,
                column: "Price",
                value: 6.75m);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 6,
                column: "Price",
                value: 5.95m);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 7,
                column: "Price",
                value: 8.95m);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 8,
                column: "Price",
                value: 2.95m);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 9,
                column: "Price",
                value: 6.85m);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Price" },
                values: new object[] { "https://localhost:44319/Images/Millonairesmall.jpg", "https://localhost:44319/Images/Millonairesmall.jpg", 2.75m });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Price" },
                values: new object[] { "https://localhost:44319/Images/Triceratopsmall.jpg", "https://localhost:44319/Images/Triceratopsmall.jpg", 6.25m });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_CakeId",
                table: "ShoppingCartItems",
                column: "CakeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 1,
                column: "Price",
                value: 12.95m);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 2,
                column: "Price",
                value: 18.95m);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 3,
                column: "Price",
                value: 18.95m);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "Price" },
                values: new object[] { "https://localhost:44319/Images/NaomiChocolateBrowniessmall.jpg", 15.95m });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 5,
                column: "Price",
                value: 13.95m);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 6,
                column: "Price",
                value: 17.95m);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 7,
                column: "Price",
                value: 15.95m);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 8,
                column: "Price",
                value: 12.95m);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 9,
                column: "Price",
                value: 15.95m);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Price" },
                values: new object[] { "https://localhost:44319/Images/Millonairessmall.jpg", "https://localhost:44319/Images/Millonairessmall.jpg", 15.95m });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Price" },
                values: new object[] { "https://localhost:44319/Images/Triceratopssmall.jpg", "https://localhost:44319/Images/Triceratopssmall.jpg", 18.95m });
        }
    }
}
