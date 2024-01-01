using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hastane_otomasyon_2.Migrations
{
    public partial class EkleAlanVeDoktorAdi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlanAdı",
                table: "Randevus",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DoktorAdi",
                table: "Randevus",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlanAdı",
                table: "Randevus");

            migrationBuilder.DropColumn(
                name: "DoktorAdi",
                table: "Randevus");
        }
    }
}
