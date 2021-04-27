using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsHeadlines_API_.Migrations
{
    public partial class firstmigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "title",
                table: "News",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "content",
                table: "News",
                newName: "Content");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "News",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "News",
                newName: "content");
        }
    }
}
