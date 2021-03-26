using Microsoft.EntityFrameworkCore.Migrations;

namespace EindCaseBelastingDienst.Migrations
{
    public partial class CursusInstantieMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cursussen",
                table: "Cursussen");

            migrationBuilder.AlterColumn<string>(
                name: "CursusCode",
                table: "Cursussen",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "CursusId",
                table: "Cursussen",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cursussen",
                table: "Cursussen",
                column: "CursusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cursussen",
                table: "Cursussen");

            migrationBuilder.DropColumn(
                name: "CursusId",
                table: "Cursussen");

            migrationBuilder.AlterColumn<string>(
                name: "CursusCode",
                table: "Cursussen",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cursussen",
                table: "Cursussen",
                column: "CursusCode");
        }
    }
}
