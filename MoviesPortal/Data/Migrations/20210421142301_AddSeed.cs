using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesPortal.Data.Migrations
{
    public partial class AddSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Steven Spielberg" },
                    { 2, "Michael Bay" },
                    { 3, "Stanley Kubrick" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Comedy" },
                    { 3, "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "DirectorId", "Poster", "Title" },
                values: new object[] { 1, 1, "https://theplaylist.net/wp-content/uploads/2012/04/as-jaws-heads-to-blu-ray-five-things-you-might-not-know-about-steven-spielberg-game-changer.jpg", "Jaw" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "DirectorId", "Poster", "Title" },
                values: new object[] { 2, 2, "https://upload.wikimedia.org/wikipedia/ru/2/28/Transformers_The_Last_Knight.jpg", "Transformers" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "DirectorId", "Poster", "Title" },
                values: new object[] { 3, 3, "https://images-na.ssl-images-amazon.com/images/S/pv-target-images/d3271cc1ecd6ad5fef1e5b06fd3ef83f4bfc384570fbda85c094857762dc4d47._RI_V_TTW_.jpg", "The Shining" });

            migrationBuilder.InsertData(
                table: "MovieDetail",
                columns: new[] { "Id", "BoxOffice", "Description", "MovieId" },
                values: new object[] { 1, 120000000, "When a killer shark unleashes chaos on a beach community, it's up to a local sheriff, a marine biologist, and an old seafarer to hunt the beast down.", 1 });

            migrationBuilder.InsertData(
                table: "MovieDetail",
                columns: new[] { "Id", "BoxOffice", "Description", "MovieId" },
                values: new object[] { 2, 400000000, "An ancient struggle between two Cybertronian races, the heroic Autobots and the evil Decepticons, comes to Earth, with a clue to the ultimate power held by a teenager.", 2 });

            migrationBuilder.InsertData(
                table: "MovieDetail",
                columns: new[] { "Id", "BoxOffice", "Description", "MovieId" },
                values: new object[] { 3, 200000000, "A family heads to an isolated hotel for the winter where a sinister presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future.", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MovieDetail",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MovieDetail",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MovieDetail",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
