using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class _11Relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "detailsId",
                table: "Movie",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MovieDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieDetails", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_MovieDetails_detailsId",
                table: "Movie");

            migrationBuilder.DropTable(
                name: "MovieDetails");

            migrationBuilder.DropIndex(
                name: "IX_Movie_detailsId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "detailsId",
                table: "Movie");
        }
    }
}
