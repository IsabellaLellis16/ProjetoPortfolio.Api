using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoPortfolio.Api.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "Projetos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_AlunoId",
                table: "Projetos",
                column: "AlunoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Alunos_AlunoId",
                table: "Projetos",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Alunos_AlunoId",
                table: "Projetos");

            migrationBuilder.DropIndex(
                name: "IX_Projetos_AlunoId",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Projetos");
        }
    }
}
