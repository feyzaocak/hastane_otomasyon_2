using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hastane_otomasyon_2.Migrations
{
    public partial class AddDoktorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "IX_Doktors_AlanId",
                table: "Doktors");

            migrationBuilder.AlterColumn<int>(
                name: "KullaniciId",
                table: "Randevus",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "DoktorId",
                table: "Randevus",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "AlanId",
                table: "Randevus",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "AlanId",
                table: "Doktors",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "UzmanlikId",
                table: "Doktors",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Doktors_UzmanlikId",
                table: "Doktors",
                column: "UzmanlikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doktors_Alans_UzmanlikId",
                table: "Doktors",
                column: "UzmanlikId",
                principalTable: "Alans",
                principalColumn: "AlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevus_Alans_AlanId",
                table: "Randevus",
                column: "AlanId",
                principalTable: "Alans",
                principalColumn: "AlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevus_Doktors_DoktorId",
                table: "Randevus",
                column: "DoktorId",
                principalTable: "Doktors",
                principalColumn: "DoktorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevus_Kullanicis_KullaniciId",
                table: "Randevus",
                column: "KullaniciId",
                principalTable: "Kullanicis",
                principalColumn: "KullaniciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doktors_Alans_UzmanlikId",
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
                name: "IX_Doktors_UzmanlikId",
                table: "Doktors");

            migrationBuilder.DropColumn(
                name: "UzmanlikId",
                table: "Doktors");

            migrationBuilder.AlterColumn<int>(
                name: "KullaniciId",
                table: "Randevus",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DoktorId",
                table: "Randevus",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AlanId",
                table: "Randevus",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AlanId",
                table: "Doktors",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

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
    }
}
