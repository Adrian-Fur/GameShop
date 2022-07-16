namespace GameShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
                    Price = 69.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "LEGO Star Wars Skywalker Saga",
                    Description = "Action Game",
                    ImageUrl = "https://cdn1.epicgames.com/offer/9c59efaabb6a48f19b3485d5d9416032/EGS_LEGOStarWarsTheSkywalkerSaga_TTGames_S2_1200x1600-fba27b1ae598e355c3ad42d04d9025ba",
                    Price = 50m,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 3,
                    Title = "Call of Duty World War",
                    Description = "FPS Game",
                    ImageUrl = "https://image.api.playstation.com/vulcan/img/rnd/202008/1900/lTSvbByTYMqy6R22teoybKCg.png",
                    Price = 90m,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 4,
                    Title = "Star Wars The Old Republic",
                    Description = "MMORPG Star Wars Game",
                    ImageUrl = "https://static.wikia.nocookie.net/swtor_gamepedia/images/5/54/BoxArt-SWTOR.png/revision/latest?cb=20190214015731",
                    Price = 30m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 5,
                    Title = "Rayman Legends",
                    Description = "Action Game",
                    ImageUrl = "https://static.wikia.nocookie.net/r__/images/6/65/250px-Rayman_Legends_Box_Art.jpg/revision/latest?cb=20190406193827&path-prefix=rayman3%2Fpl",
                    Price = 90m,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 6,
                    Title = "Counter Strike",
                    Description = "FPS Online Game",
                    ImageUrl = "https://static.wikia.nocookie.net/cswikia/images/1/1e/Csgo_steam_store_header_latest.jpg/revision/latest?cb=20211006145310",
                    Price = 10m,
                    CategoryId = 3
                }
                );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
