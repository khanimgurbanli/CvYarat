using Microsoft.EntityFrameworkCore.Migrations;

namespace CvYarat.Migrations
{
    public partial class changetypename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "WorkExperiences");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "WorkExperiences",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "WorkExperiences");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "WorkExperiences",
                type: "int",
                nullable: true);
        }
    }
}
