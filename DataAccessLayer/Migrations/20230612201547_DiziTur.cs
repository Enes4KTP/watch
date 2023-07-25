using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class DiziTur : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dizilers_DiziTurs_DiziTurId",
                table: "Dizilers");

            migrationBuilder.AlterColumn<int>(
                name: "DiziTurId",
                table: "Dizilers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Dizilers_DiziTurs_DiziTurId",
                table: "Dizilers",
                column: "DiziTurId",
                principalTable: "DiziTurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dizilers_DiziTurs_DiziTurId",
                table: "Dizilers");

            migrationBuilder.AlterColumn<int>(
                name: "DiziTurId",
                table: "Dizilers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Dizilers_DiziTurs_DiziTurId",
                table: "Dizilers",
                column: "DiziTurId",
                principalTable: "DiziTurs",
                principalColumn: "Id");
        }
    }
}
