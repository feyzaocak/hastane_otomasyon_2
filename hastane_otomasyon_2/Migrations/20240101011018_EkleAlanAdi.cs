using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hastane_otomasyon_2.Migrations
{
    public partial class EkleAlanAdi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlanAdı",
                table: "Doktors",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlanAdı",
                table: "Doktors");
        }
    }
}
