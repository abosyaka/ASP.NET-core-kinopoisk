using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesPortal.Data.Migrations
{
    public partial class OtMFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Director_DirectorId1",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_DirectorId1",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "DirectorId1",
                table: "Movie");

            migrationBuilder.AlterColumn<int>(
                name: "DirectorId",
                table: "Movie",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                column: "DirectorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                column: "DirectorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                column: "DirectorId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_DirectorId",
                table: "Movie",
                column: "DirectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Director_DirectorId",
                table: "Movie",
                column: "DirectorId",
                principalTable: "Director",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Director_DirectorId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_DirectorId",
                table: "Movie");

            migrationBuilder.AlterColumn<long>(
                name: "DirectorId",
                table: "Movie",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DirectorId1",
                table: "Movie",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                column: "DirectorId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                column: "DirectorId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                column: "DirectorId",
                value: 3L);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_DirectorId1",
                table: "Movie",
                column: "DirectorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Director_DirectorId1",
                table: "Movie",
                column: "DirectorId1",
                principalTable: "Director",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
