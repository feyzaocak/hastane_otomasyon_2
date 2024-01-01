using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hastane_otomasyon_2.Migrations
{
    public partial class Yeni2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlanAdı",
                table: "Randevus");

            migrationBuilder.DropColumn(
                name: "DoktorAdi",
                table: "Randevus");

            migrationBuilder.AddColumn<int>(
                name: "AlanId",
                table: "Doktors",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_AlanId",
                table: "Randevus",
                column: "AlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_DoktorId",
                table: "Randevus",
                column: "DoktorId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_KullaniciId",
                table: "Randevus",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Doktors_AlanId",
                table: "Doktors",
                column: "AlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doktors_Alans_AlanId",
                table: "Doktors",
                column: "AlanId",
                principalTable: "Alans",
                principalColumn: "AlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevus_Alans_AlanId",
                table: "Randevus",
                column: "AlanId",
                principalTable: "Alans",
                principalColumn: "AlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevus_Doktors_DoktorId",
                table: "Randevus",
                column: "DoktorId",
                principalTable: "Doktors",
                principalColumn: "DoktorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevus_Kullanicis_KullaniciId",
                table: "Randevus",
                column: "KullaniciId",
                principalTable: "Kullanicis",
                principalColumn: "KullaniciId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doktors_Alans_AlanId",
                table: "Doktors");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevus_Alans_AlanId",
                table: "Randevus");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevus_Doktors_DoktorId",
                table: "Randevus");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevus_Kullanicis_KullaniciId",
                table: "Randevus");

            migrationBuilder.DropIndex(
                name: "IX_Randevus_AlanId",
                table: "Randevus");

            migrationBuilder.DropIndex(
                name: "IX_Randevus_DoktorId",
                table: "Randevus");

            migrationBuilder.DropIndex(
                name: "IX_Randevus_KullaniciId",
                table: "Randevus");

            migrationBuilder.DropIndex(
                name: "IX_Doktors_AlanId",
                table: "Doktors");

            migrationBuilder.DropColumn(
                name: "AlanId",
                table: "Doktors");

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
    }
}
