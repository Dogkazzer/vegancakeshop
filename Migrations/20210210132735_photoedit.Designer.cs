﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VeganCakeShop.Models;

namespace VeganCakeShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210210132735_photoedit")]
    partial class photoedit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("VeganCakeShop.Models.Cake", b =>
                {
                    b.Property<int>("CakeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AllergyInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCakeOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CakeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Cakes");

                    b.HasData(
                        new
                        {
                            CakeId = 1,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                            InStock = true,
                            IsCakeOfTheWeek = true,
                            LongDescription = "Baked from Somerset cider apples in the midst of cider country. A rough puff pastry surrounding juicy aples, dark molasses, spiced with cinnamon, mixed spice, and a hint of ginger. A proper treat!",
                            Name = "Apple Pie",
                            Price = 5.75m,
                            ShortDescription = "Cazz' famous Zumerset apple pie!"
                        },
                        new
                        {
                            CakeId = 2,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://localhost:44319/Images/CarrotCakesmall.jpg",
                            ImageUrl = "https://localhost:44319/Images/CarrotCakesmall.jpg",
                            InStock = true,
                            IsCakeOfTheWeek = false,
                            LongDescription = "Home baked from our Devon carrot patch. Moist ginger and carrot with a sticky dark molasses flavour, and a light springy icing. A Devon wonder.",
                            Name = "Carrot Cake",
                            Price = 3.25m,
                            ShortDescription = "Super carrot power!"
                        },
                        new
                        {
                            CakeId = 3,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://localhost:44319/Images/scone.jpg",
                            ImageUrl = "https://localhost:44319/Images/scone.jpg",
                            InStock = true,
                            IsCakeOfTheWeek = false,
                            LongDescription = "Join us in our leafy warm banana glade for a zesty, light, fresh fruit cider and jam cream tea.",
                            Name = "Somerset Cream Tea",
                            Price = 4.95m,
                            ShortDescription = "Cazz' Somerset hot scones."
                        },
                        new
                        {
                            CakeId = 4,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://localhost:44319/Images/NaomiChocolateBrowniesmall.jpg",
                            ImageUrl = "https://localhost:44319/Images/NaomiChocolateBrowniesmall.jpg",
                            InStock = true,
                            IsCakeOfTheWeek = false,
                            LongDescription = "Direct from the Somerset cacao fields enjoy the richness of home grown, ethically sourced cacao in this sumptuous vegan chocolate chip squishy brownie. Topped with a light crispy volcanic eruptive crust, a perfect combination of chocolate at play.",
                            Name = "Naomi's velvet chocolate chip brownies",
                            Price = 2.25m,
                            ShortDescription = "A chocolate, squishy, crunchy brownie!"
                        },
                        new
                        {
                            CakeId = 5,
                            AllergyInformation = "",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://localhost:44319/Images/Christmascakesmall.jpg",
                            ImageUrl = "https://localhost:44319/Images/Christmascakesmall.jpg",
                            InStock = true,
                            IsCakeOfTheWeek = false,
                            LongDescription = "A Christmas marvel. Fruit lashed and matured in Somerset brandy over several weeks. Juciy raisins, cherries, almonds, brazil nuts and currants steeped in rich ginger, mixed spice, nutmeg and cinnamon, in a light and delicious sponge. Topped with vegan royal chia icing, Loved by reindeers and polars",
                            Name = "Christmas Worzel Cake",
                            Price = 6.75m,
                            ShortDescription = "Happy Christmas!"
                        },
                        new
                        {
                            CakeId = 6,
                            AllergyInformation = "",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://localhost:44319/Images/ChocolateChicksmall.jpg",
                            ImageUrl = "https://localhost:44319/Images/ChocolateChicksmall.jpg",
                            InStock = true,
                            IsCakeOfTheWeek = false,
                            LongDescription = "Happy Easter! Cazz chicks have prepared this chocolate cider delight. A moist fluffy chocolate avocado sponge, with a velvety rich dark chocolate and avocado topping. Indulgent and delightful.",
                            Name = "Chocolate Chick Cake",
                            Price = 5.95m,
                            ShortDescription = "An Easter delight!"
                        },
                        new
                        {
                            CakeId = 7,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://localhost:44319/Images/Wellingtonsmall.jpg",
                            ImageUrl = "https://localhost:44319/Images/Wellingtonsmall.jpg",
                            InStock = false,
                            IsCakeOfTheWeek = false,
                            LongDescription = "A warm, spicy seasonal festive Christmas treat. You can really smell those festive flavours! Crunchy rough puff surrounding a melt in the mouth textured seitan. Served with Cranberry, apricot, and vegetable gravy. Lush",
                            Name = "Vegan Welllington",
                            Price = 8.95m,
                            ShortDescription = "Festive and awesome!"
                        },
                        new
                        {
                            CakeId = 8,
                            AllergyInformation = "",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://localhost:44319/Images/ginger.jpg",
                            ImageUrl = "https://localhost:44319/Images/ginger.jpg",
                            InStock = true,
                            IsCakeOfTheWeek = true,
                            LongDescription = "A warm ginger spicy treat for Punky night! Rich toffee apple, molasses, cinnamon, mixed spice celebrate together with a sticky toffee glaze.",
                            Name = "Punky Cake",
                            Price = 2.95m,
                            ShortDescription = "It's Punky Night!"
                        },
                        new
                        {
                            CakeId = 9,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://localhost:44319/Images/ghettiLuisasmall.jpg",
                            ImageUrl = "https://localhost:44319/Images/ghettiLuisasmall.jpg",
                            InStock = true,
                            IsCakeOfTheWeek = true,
                            LongDescription = "A true Italian speciality of rich garlic, mushrooms, home grown zesty herbs, ripe densely flavoured tomatoes, onions, and of course the best pasta made by Chefs La Luisa & El Loz. Orla's favourite!",
                            Name = "Spaghetti a la Luisa",
                            Price = 6.85m,
                            ShortDescription = "An Italian Dream!"
                        },
                        new
                        {
                            CakeId = 10,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://localhost:44319/Images/Millonairesmall.jpg",
                            ImageUrl = "https://localhost:44319/Images/Millonairesmall.jpg",
                            InStock = true,
                            IsCakeOfTheWeek = false,
                            LongDescription = "A Liverpool speciality from our uptown topranking penthouse girls. A rich chocolate, date infused caramel, a ginger crunch shortbread, and the most millonaire of millonaire toppings, Nai & Dani, we love this!",
                            Name = "Millonaire's Shortbread",
                            Price = 2.75m,
                            ShortDescription = "Only for SlumDogs!"
                        },
                        new
                        {
                            CakeId = 11,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://localhost:44319/Images/Triceratopsmall.jpg",
                            ImageUrl = "https://localhost:44319/Images/Triceratopsmall.jpg",
                            InStock = false,
                            IsCakeOfTheWeek = false,
                            LongDescription = "Only for the brave, Happy Birthday Stephen! A chocolate Jurassic cake straight from the fossil beds of LymeRegis. Loved by pteradactyls, stegs and triceratops alike, a chocolatey, zesty, light and powerful cake, only for the best of the best.",
                            Name = "Triceratops Birthday Cake",
                            Price = 6.25m,
                            ShortDescription = "From our Jurassic coast"
                        });
                });

            modelBuilder.Entity("VeganCakeShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Fruit cakes"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Cheese cakes"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Seasonal cakes"
                        });
                });

            modelBuilder.Entity("VeganCakeShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("CakeId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("CakeId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("VeganCakeShop.Models.Cake", b =>
                {
                    b.HasOne("VeganCakeShop.Models.Category", "Category")
                        .WithMany("Cakes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("VeganCakeShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("VeganCakeShop.Models.Cake", "Cake")
                        .WithMany()
                        .HasForeignKey("CakeId");

                    b.Navigation("Cake");
                });

            modelBuilder.Entity("VeganCakeShop.Models.Category", b =>
                {
                    b.Navigation("Cakes");
                });
#pragma warning restore 612, 618
        }
    }
}
