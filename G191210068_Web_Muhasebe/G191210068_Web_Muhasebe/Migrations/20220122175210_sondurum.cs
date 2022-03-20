using Microsoft.EntityFrameworkCore.Migrations;

namespace G191210068_Web_Muhasebe.Migrations
{
    public partial class sondurum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "SonDurum",
                table: "CariIslemler",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SonDurum",
                table: "CariIslemler");
        }
    }
}
