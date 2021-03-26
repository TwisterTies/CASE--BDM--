using Microsoft.EntityFrameworkCore.Migrations;

namespace EindCaseBelastingDienst.Migrations
{
    public partial class CursusInstantieDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CursusInstantieId",
                table: "Cursussen",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CursusInstanties",
                columns: table => new
                {
                    CursusInstantieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CursusTijd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursusInstanties", x => x.CursusInstantieId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursussen_CursusInstanties_CursusInstantieId",
                table: "Cursussen");

            migrationBuilder.DropTable(
                name: "CursusInstanties");

            migrationBuilder.DropIndex(
                name: "IX_Cursussen_CursusInstantieId",
                table: "Cursussen");

            migrationBuilder.DropColumn(
                name: "CursusInstantieId",
                table: "Cursussen");
        }
    }
}
