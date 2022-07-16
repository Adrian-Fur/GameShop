using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameShop.Server.Migrations
{
    public partial class SeedMoreProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, 1, "MMORPG Star Wars Game", "https://static.wikia.nocookie.net/swtor_gamepedia/images/5/54/BoxArt-SWTOR.png/revision/latest?cb=20190214015731", 30m, "Star Wars The Old Republic" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, 2, "Action Game", "https://static.wikia.nocookie.net/r__/images/6/65/250px-Rayman_Legends_Box_Art.jpg/revision/latest?cb=20190406193827&path-prefix=rayman3%2Fpl", 90m, "Rayman Legends" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 6, 3, "FPS Online Game", "https://static.wikia.nocookie.net/cswikia/images/1/1e/Csgo_steam_store_header_latest.jpg/revision/latest?cb=20211006145310", 10m, "Counter Strike" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
