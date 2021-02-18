using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class _11Relation1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_MovieDetails_detailsId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_detailsId",
                table: "Movie");

            migrationBuilder.AlterColumn<int>(
                name: "detailsId",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_detailsId",
                table: "Movie",
                column: "detailsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_MovieDetails_detailsId",
                table: "Movie",
                column: "detailsId",
                principalTable: "MovieDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_MovieDetails_detailsId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_detailsId",
                table: "Movie");

            migrationBuilder.AlterColumn<int>(
                name: "detailsId",
                table: "Movie",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_detailsId",
                table: "Movie",
                column: "detailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_MovieDetails_detailsId",
                table: "Movie",
                column: "detailsId",
                principalTable: "MovieDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
