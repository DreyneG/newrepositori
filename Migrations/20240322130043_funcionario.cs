using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace newapiCopia.Migrations
{
    /// <inheritdoc />
    public partial class funcionario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Setors_Setorid",
                table: "Funcionarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Setors",
                table: "Setors");

            migrationBuilder.RenameTable(
                name: "Setors",
                newName: "Setores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Setores",
                table: "Setores",
                column: "Setorid");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Setores_Setorid",
                table: "Funcionarios",
                column: "Setorid",
                principalTable: "Setores",
                principalColumn: "Setorid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Setores_Setorid",
                table: "Funcionarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Setores",
                table: "Setores");

            migrationBuilder.RenameTable(
                name: "Setores",
                newName: "Setors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Setors",
                table: "Setors",
                column: "Setorid");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Setors_Setorid",
                table: "Funcionarios",
                column: "Setorid",
                principalTable: "Setors",
                principalColumn: "Setorid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
