using GameShop.Shared.Models;

namespace GameShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType { Id = 1, Name = "PC" },
                new ProductType { Id = 2, Name = "PlayStation" },
                new ProductType { Id = 3, Name = "Xbox" }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "MMORPG",
                    Url = "mmorpg"
                },
                new Category
                {
                    Id = 2,
                    Name = "Action",
                    Url = "action"
                },
                new Category
                {
                    Id = 3,
                    Name = "FPS",
                    Url = "fps"
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "World of Warcraft: Dragonflight",
                    Description = "Online MMORPG Game",
                    ImageUrl = "https://cdn.gracza.pl/galeria/gry13/grupy/731999812.jpg",
                    CategoryId = 1,
                    Featured = true
                },
                new Product
                {
                    Id = 2,
                    Title = "LEGO Star Wars Skywalker Saga",
                    Description = "Action Game",
                    ImageUrl = "https://cdn1.epicgames.com/offer/9c59efaabb6a48f19b3485d5d9416032/EGS_LEGOStarWarsTheSkywalkerSaga_TTGames_S2_1200x1600-fba27b1ae598e355c3ad42d04d9025ba",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 3,
                    Title = "Call of Duty World War",
                    Description = "FPS Game",
                    ImageUrl = "https://image.api.playstation.com/vulcan/img/rnd/202008/1900/lTSvbByTYMqy6R22teoybKCg.png",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 4,
                    Title = "Star Wars The Old Republic",
                    Description = "MMORPG Star Wars Game",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/3c/Star_Wars-_The_Old_Republic_cover.jpg",
                    CategoryId = 1,
                    Featured = true
                    
                },
                new Product
                {
                    Id = 5,
                    Title = "Rayman Legends",
                    Description = "Action Game",
                    ImageUrl = "https://store.ubi.com/dw/image/v2/ABBS_PRD/on/demandware.static/-/Sites-masterCatalog/default/dwa8b6d5b5/images/large/56c4948888a7e300458b47da.jpg?sw=341&sh=450&sm=fit",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 6,
                    Title = "Counter Strike",
                    Description = "FPS Online Game",
                    ImageUrl = "https://static-cdn.jtvnw.net/ttv-boxart/32399_IGDB-272x380.jpg",
                    CategoryId = 3
                }
                );

            modelBuilder.Entity<ProductVariant>().HasData(

                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 1,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },

                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 1,
                    Price = 20.00m,
                    OriginalPrice = 30.00m
                },

                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 2,
                    Price = 50.00m,
                    OriginalPrice = 60.00m
                },

                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 3,
                    Price = 40.00m,
                    OriginalPrice = 70.00m
                },

                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 1,
                    Price = 30.00m,
                    OriginalPrice = 30.00m
                },

                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 2,
                    Price = 60.00m,
                    OriginalPrice = 60.00m
                },

                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 3,
                    Price = 70.00m,
                    OriginalPrice = 80.00m
                },

                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 1,
                    Price = 15.00m,
                    OriginalPrice = 20.00m
                },

                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 1,
                    Price = 40.00m,
                    OriginalPrice = 69.99m
                },

                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 2,
                    Price = 54.35m,
                    OriginalPrice = 60.00m
                },

                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 3,
                    Price = 78.45m,
                    OriginalPrice = 99.99m
                },

                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 1,
                    Price = 29.99m,
                    OriginalPrice = 29.99m
                }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
    }
}
