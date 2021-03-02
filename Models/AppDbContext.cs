using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeganCakeShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Cake> Cakes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruit cakes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Cheese cakes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Seasonal cakes" });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 1,
                Name = "Apple Pie",
                Price = 5.75M,
                ShortDescription = "Cazz' famous Zumerset apple pie!",
                LongDescription =
                  "Baked from Somerset cider apples in the midst of cider country. A rough puff pastry surrounding juicy aples, dark molasses, spiced with cinnamon, mixed spice, and a hint of ginger. A proper treat!",
                CategoryId = 1,
                ImageUrl = "https://localhost:44319/Images/apple.jpg",
                InStock = true,
                IsCakeOfTheWeek = true,
                ImageThumbnailUrl = "https://localhost:44319/Images/apple.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 2,
                Name = "Carrot Cake",
                Price = 3.25M,
                ShortDescription = "Super carrot power!",
                LongDescription =
                    "Home baked from our Devon carrot patch. Moist ginger and carrot with a sticky dark molasses flavour, and a light springy icing. A Devon wonder.",
                CategoryId = 2,
                ImageUrl = "https://localhost:44319/Images/CarrotCakenew.jpg",
                InStock = true,
                IsCakeOfTheWeek = false,
                ImageThumbnailUrl = "https://localhost:44319/Images/CarrotCakenew.jpg",

                AllergyInformation = ""
            });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 3,
                Name = "Somerset Cream Tea",
                Price = 4.95M,
                ShortDescription = "Cazz' Somerset hot scones.",
                LongDescription =
                   "Join us in our leafy warm banana glade for a zesty, light, fresh fruit cider and jam cream tea.",
                CategoryId = 2,
                ImageUrl = "https://localhost:44319/Images/scone.jpg",
                InStock = true,
                IsCakeOfTheWeek = false,
                ImageThumbnailUrl = "https://localhost:44319/Images/scone.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 4,
                Name = "Naomi's brownies",
                Price = 2.25M,
                ShortDescription = "A chocolate, crunchy brownie!",
                LongDescription =
                    "Direct from the Somerset cacao fields enjoy the richness of home grown, ethically sourced cacao in this sumptuous vegan chocolate chip squishy brownie. Topped with a light crispy volcanic eruptive crust, a perfect combination of chocolate at play.",
                CategoryId = 1,
                ImageUrl = "https://localhost:44319/Images/brownies.jpg",
                InStock = true,
                IsCakeOfTheWeek = false,
                ImageThumbnailUrl = "https://localhost:44319/Images/brownies.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 5,
                Name = "Christmas Worzel Cake",
                Price = 6.75M,
                ShortDescription = "Happy Christmas!",
                LongDescription =
                   "A Christmas marvel. Fruit lashed and matured in Somerset brandy over several weeks. Juciy raisins, cherries, almonds, brazil nuts and currants steeped in rich ginger, mixed spice, nutmeg and cinnamon, in a light and delicious sponge. Topped with vegan royal chia icing, Loved by reindeers and polars",
                CategoryId = 3,
                ImageUrl = "https://localhost:44319/Images/scandicakesmall.jpg",
                InStock = true,
                IsCakeOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://localhost:44319/Images/scandicakesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 6,
                Name = "Chocolate Chick Cake",
                Price = 5.95M,
                ShortDescription = "An Easter delight!",
                LongDescription =
                    "Happy Easter! Cazz chicks have prepared this chocolate cider delight. A moist fluffy chocolate avocado sponge, with a velvety rich dark chocolate and avocado topping. Indulgent and delightful.",
                CategoryId = 3,
                ImageUrl = "https://localhost:44319/Images/Chocochick.jpg",
                InStock = true,
                IsCakeOfTheWeek = false,
                ImageThumbnailUrl = "https://localhost:44319/Images/Chocochick.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 7,
                Name = "Welllington",
                Price = 8.95M,
                ShortDescription = "Festive and awesome!",
                LongDescription =
                    "A warm, spicy seasonal festive Christmas treat. You can really smell those festive flavours! Crunchy rough puff surrounding a melt in the mouth textured seitan. Served with Cranberry, apricot, and vegetable gravy. Lush",
                CategoryId = 1,
                ImageUrl = "https://localhost:44319/Images/Wellingtonnew.jpg",
                InStock = false,
                IsCakeOfTheWeek = false,
                ImageThumbnailUrl = "https://localhost:44319/Images/wellingtonnew.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 8,
                Name = "Punky Cake",
                Price = 2.95M,
                ShortDescription = "It's Punky Night!",
                LongDescription =
                    "A warm ginger spicy treat for Punky night! Rich toffee apple, molasses, cinnamon, mixed spice celebrate together with a sticky toffee glaze.",
                CategoryId = 3,
                ImageUrl = "https://localhost:44319/Images/ginger.jpg",
                InStock = true,
                IsCakeOfTheWeek = true,
                ImageThumbnailUrl = "https://localhost:44319/Images/ginger.jpg",
                AllergyInformation = ""
            });


            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 9,
                Name = "Spaghetti a la Luisa",
                Price = 6.85M,
                ShortDescription = "An Italian Dream!",
                LongDescription =
                   "A true Italian speciality of rich garlic, mushrooms, home grown zesty herbs, ripe densely flavoured tomatoes, onions, and of course the best pasta made by Chefs La Luisa & El Loz. Orla's favourite!",
                CategoryId = 1,
                ImageUrl = "https://localhost:44319/Images/luisa.jpg",
                InStock = true,
                IsCakeOfTheWeek = true,
                ImageThumbnailUrl = "https://localhost:44319/Images/luisa.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 10,
                Name = "Millonaire's Shortbread",
                Price = 2.75M,
                ShortDescription = "Only for SlumDogs!",
                LongDescription =
                   "A Liverpool speciality from our uptown topranking penthouse girls. A rich chocolate, date infused caramel, a ginger crunch shortbread, and the most millonaire of millonaire toppings, Nai & Dani, we love this!",
                CategoryId = 1,
                ImageUrl = "https://localhost:44319/Images/millonairesnew.jpg",
                InStock = true,
                IsCakeOfTheWeek = false,
                ImageThumbnailUrl = "https://localhost:44319/Images/millonairesnew.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 11,
                Name = "Triceratops Cake",
                Price = 6.25M,
                ShortDescription = "From our Jurassic coast",
                LongDescription =
                     "Only for the brave, Happy Birthday Stephen! A chocolate Jurassic cake straight from the fossil beds of LymeRegis. Loved by pteradactyls, stegs and triceratops alike, a chocolatey, zesty, light and powerful cake, only for the best of the best.",
                CategoryId = 2,
                ImageUrl = "https://localhost:44319/Images/choc.jpg",
                InStock = false,
                IsCakeOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://localhost:44319/Images/choc.jpg",
                AllergyInformation = ""
            });
        }

    }
}
