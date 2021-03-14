using Microsoft.EntityFrameworkCore.Migrations;

namespace Cafesito.Migrations
{
    public partial class SeedOrderStatusTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO OrderStatus (Id, Name) VALUES ('1', 'In Progress')");
            migrationBuilder.Sql("INSERT INTO OrderStatus (Id, Name) VALUES ('2', 'Shipped')");
            migrationBuilder.Sql("INSERT INTO OrderStatus (Id, Name) VALUES ('3', 'Delivered')");
            migrationBuilder.Sql("INSERT INTO OrderStatus (Id, Name) VALUES ('4', 'Cancelled')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
