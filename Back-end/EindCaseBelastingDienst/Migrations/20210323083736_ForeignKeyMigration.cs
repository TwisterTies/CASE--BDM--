using Microsoft.EntityFrameworkCore.Migrations;

namespace EindCaseBelastingDienst.Migrations
{
    public partial class ForeignKeyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursussen_CursusInstanties_CursusInstantieId",
                table: "Cursussen");

            migrationBuilder.DropIndex(
                name: "IX_Cursussen_CursusInstantieId",
                table: "Cursussen");

            migrationBuilder.DropColumn(
                name: "CursusInstantieId",
                table: "Cursussen");

            migrationBuilder.AddColumn<int>(
                name: "CursussenCursusId",
                table: "CursusInstanties",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CursusInstanties_CursussenCursusId",
                table: "CursusInstanties",
                column: "CursussenCursusId");

            migrationBuilder.AddForeignKey(
                name: "FK_CursusInstanties_Cursussen_CursussenCursusId",
                table: "CursusInstanties",
                column: "CursussenCursusId",
                principalTable: "Cursussen",
                principalColumn: "CursusId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CursusInstanties_Cursussen_CursussenCursusId",
                table: "CursusInstanties");

            migrationBuilder.DropIndex(
                name: "IX_CursusInstanties_CursussenCursusId",
                table: "CursusInstanties");

            migrationBuilder.DropColumn(
                name: "CursussenCursusId",
                table: "CursusInstanties");

            migrationBuilder.AddColumn<int>(
                name: "CursusInstantieId",
                table: "Cursussen",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cursussen_CursusInstantieId",
                table: "Cursussen",
                column: "CursusInstantieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursussen_CursusInstanties_CursusInstantieId",
                table: "Cursussen",
                column: "CursusInstantieId",
                principalTable: "CursusInstanties",
                principalColumn: "CursusInstantieId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
