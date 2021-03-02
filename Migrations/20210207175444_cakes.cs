using Microsoft.EntityFrameworkCore.Migrations;

namespace VeganCakeShop.Migrations
{
    public partial class cakes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Fruit cakes", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Cheese cakes", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Seasonal cakes", null });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "CakeId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsCakeOfTheWeek", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", true, true, "Baked from Somerset cider apples in the midst of cider country. A rough puff pastry surrounding juicy aples, dark molasses, spiced with cinnamon, mixed spice, and a hint of ginger. A proper treat!", "Apple Pie", null, 12.95m, "Cazz' famous Zumerset apple pie!" },
                    { 4, "", 1, "https://localhost44317/Images/NaomiChocolateBrowniessmall.jpg", "https://localhost44317/Images/NaomiChocolateBrowniessmall.jpg", true, false, "Direct from the Somerset cacao fields enjoy the richness of home grown, ethically sourced cacao in this sumptuous vegan chocolate chip squishy brownie. Topped with a light crispy volcanic eruptive crust, a perfect combination of chocolate at play.", "Naomi's velvet chocolate chip brownies", null, 15.95m, "A chocolate, squishy, crunchy brownie!" },
                    { 7, "", 1, "https://localhost44317/Images/Wellingtonsmall.jpg", "https://localhost44317/Images/Wellingtonsmall.jpg", false, false, "A warm, spicy seasonal festive Christmas treat. You can really smell those festive flavours! Crunchy rough puff surrounding a melt in the mouth textured seitan. Served with Cranberry, apricot, and vegetable gravy. Lush", "Vegan Welllington", null, 15.95m, "Festive and awesome!" },
                    { 9, "", 1, "https://localhost44317/Images/SpaghettiLuisasmall.jpg", "https://localhost44317/Images/SpaghettiLuisasmall.jpg", true, true, "A true Italian speciality of rich garlic, mushrooms, home grown zesty herbs, ripe densely flavoured tomatoes, onions, and of course the best pasta made by Chefs La Luisa & El Loz. Orla's favourite!", "Spaghetti a la Luisa", null, 15.95m, "An Italian Dream!" },
                    { 10, "", 1, "https://localhost44317/Images/Millonairessmall.jpg", "https://localhost44317/Images/Millonairessmall.jpg", true, false, "A Liverpool speciality from our uptown topranking penthouse girls. A rich chocolate, date infused caramel, a ginger crunch shortbread, and the most millonaire of millonaire toppings, Nai & Dani, we love this!", "Millonaire's Shortbread", null, 15.95m, "Only for SlumDogs!" },
                    { 2, "", 2, "https://localhost44317/Images/CarrotCakesmall.jpg", "https://localhost44317/Images/CarrotCakesmall.jpg", true, false, "Home baked from our Devon carrot patch. Moist ginger and carrot with a sticky dark molasses flavour, and a light springy icing. A Devon wonder.", "Carrot Cake", null, 18.95m, "Super carrot power!" },
                    { 3, "", 2, "https://localhost44317/Images/CreamTeasmall.jpg", "https://localhost44317/Images/CreamTeasmall.jpg", true, false, "Join us in our leafy warm banana glade for a zesty, light, fresh fruit cider and jam cream tea.", "Somerset Cream Tea", null, 18.95m, "Cazz' Somerset hot scones." },
                    { 11, "", 2, "https://localhost44317/Images/Triceratopssmall.jpg", "https://localhost44317/Images/Triceratopssmall.jpg", false, false, "Only for the brave, Happy Birthday Stephen! A chocolate Jurassic cake straight from the fossil beds of LymeRegis. Loved by pteradactyls, stegs and triceratops alike, a chocolatey, zesty, light and powerful cake, only for the best of the best.", "Triceratops Birthday Cake", null, 18.95m, "From our Jurassic coast" },
                    { 5, "", 3, "https://localhost44317/Images/Christmassmall.jpg", "https://localhost44317/Images/Christmassmall.jpg", true, false, "A Christmas marvel. Fruit lashed and matured in Somerset brandy over several weeks. Juciy raisins, cherries, almonds, brazil nuts and currants steeped in rich ginger, mixed spice, nutmeg and cinnamon, in a light and delicious sponge. Topped with vegan royal chia icing, Loved by reindeers and polars", "Christmas Worzel Cake", null, 13.95m, "Happy Christmas!" },
                    { 6, "", 3, "https://localhost44317/Images/ChocolateChicksmall.jpg", "https://localhost44317/Images/ChocolateChicksmall.jpg", true, false, "Happy Easter! Cazz chicks have prepared this chocolate cider delight. A moist fluffy chocolate avocado sponge, with a velvety rich dark chocolate and avocado topping. Indulgent and delightful.", "Chocolate Chick Cake", null, 17.95m, "An Easter delight!" },
                    { 8, "", 3, "https://localhost44317/Images/PunkyPiesmall.jpg", "https://localhost44317/Images/PunkyPiesmall.jpg", true, true, "A warm ginger spicy treat for Punky night! Rich toffee apple, molasses, cinnamon, mixed spice celebrate together with a sticky toffee glaze.", "Punky Pie", null, 12.95m, "It's Punky Night!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
