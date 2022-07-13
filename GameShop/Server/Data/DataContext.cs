namespace GameShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "World of Warcraft: Dragonflight",
                    Description = "Online MMORPG Game",
                    ImageUrl = "https://cdn.gracza.pl/galeria/gry13/grupy/731999812.jpg",
                    Price = 69.99m
                },
                 new Product
                {
                    Id = 2,
                    Title = "LEGO Star Wars Skywalker Saga",
                    Description = "Action Game",
                    ImageUrl = "https://cdn1.epicgames.com/offer/9c59efaabb6a48f19b3485d5d9416032/EGS_LEGOStarWarsTheSkywalkerSaga_TTGames_S2_1200x1600-fba27b1ae598e355c3ad42d04d9025ba",
                    Price = 50m
                },
                 new Product
                {
                    Id = 3,
                    Title = "Call of Duty World War",
                    Description = "FPS Game",
                    ImageUrl = "https://image.api.playstation.com/vulcan/img/rnd/202008/1900/lTSvbByTYMqy6R22teoybKCg.png",
                    Price = 90m
                });
        }

        public DbSet<Product> Products { get; set; }
    }
}
