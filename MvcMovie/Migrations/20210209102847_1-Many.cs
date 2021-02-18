using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class _1Many : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_MovieDetails_detailsId",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "detailsId",
                table: "Movie",
                newName: "DetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_Movie_detailsId",
                table: "Movie",
                newName: "IX_Movie_DetailsId");

            migrationBuilder.AddColumn<int>(
                name: "DirectorInfoId",
                table: "Movie",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_DirectorInfoId",
                table: "Movie",
                column: "DirectorInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Director_DirectorInfoId",
                table: "Movie",
                column: "DirectorInfoId",
                principalTable: "Director",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_MovieDetails_DetailsId",
                table: "Movie",
                column: "DetailsId",
                principalTable: "MovieDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Director_DirectorInfoId",
                table: "Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Movie_MovieDetails_DetailsId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_DirectorInfoId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "DirectorInfoId",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "DetailsId",
                table: "Movie",
                newName: "detailsId");

            migrationBuilder.RenameIndex(
                name: "IX_Movie_DetailsId",
                table: "Movie",
                newName: "IX_Movie_detailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_MovieDetails_detailsId",
                table: "Movie",
                column: "detailsId",
                principalTable: "MovieDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
