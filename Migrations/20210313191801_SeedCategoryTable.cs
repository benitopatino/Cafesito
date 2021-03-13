using Microsoft.EntityFrameworkCore.Migrations;

namespace Cafesito.Migrations
{
    public partial class SeedCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Category (Id, Name) VALUES ('1', 'Coffee')");
            migrationBuilder.Sql("INSERT INTO Category (Id, Name) VALUES ('2', 'Tea')");
            migrationBuilder.Sql("INSERT INTO Category (Id, Name) VALUES ('3', 'Merchandise')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
