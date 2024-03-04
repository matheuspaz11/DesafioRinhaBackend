using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioRinhaBackend.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "tb_person");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "tb_person",
                type: "varchar(32)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tb_person",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_person",
                table: "tb_person",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_person",
                table: "tb_person");

            migrationBuilder.RenameTable(
                name: "tb_person",
                newName: "Person");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Person",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(32)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Person",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Id");
        }
    }
}
