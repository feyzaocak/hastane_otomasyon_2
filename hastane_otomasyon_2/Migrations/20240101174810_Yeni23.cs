using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hastane_otomasyon_2.Migrations
{
    public partial class Yeni23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlanAdı",
                table: "Doktors");

            migrationBuilder.AlterColumn<int>(
                name: "DoktorId",
                table: "Alans",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlanAdı",
                table: "Doktors",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DoktorId",
                table: "Alans",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);
        }
    }
}
