using Microsoft.EntityFrameworkCore.Migrations;

namespace OS.Migrations
{
    public partial class NovosAtributos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FuncionarioId",
                table: "OrdemServico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrdemServicoId",
                table: "Ferramenta",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantidade_Reservada",
                table: "Ferramenta",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_FuncionarioId",
                table: "OrdemServico",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Ferramenta_OrdemServicoId",
                table: "Ferramenta",
                column: "OrdemServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferramenta_OrdemServico_OrdemServicoId",
                table: "Ferramenta",
                column: "OrdemServicoId",
                principalTable: "OrdemServico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_Funcionario_FuncionarioId",
                table: "OrdemServico",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferramenta_OrdemServico_OrdemServicoId",
                table: "Ferramenta");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_Funcionario_FuncionarioId",
                table: "OrdemServico");

            migrationBuilder.DropIndex(
                name: "IX_OrdemServico_FuncionarioId",
                table: "OrdemServico");

            migrationBuilder.DropIndex(
                name: "IX_Ferramenta_OrdemServicoId",
                table: "Ferramenta");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "OrdemServico");

            migrationBuilder.DropColumn(
                name: "OrdemServicoId",
                table: "Ferramenta");

            migrationBuilder.DropColumn(
                name: "Quantidade_Reservada",
                table: "Ferramenta");
        }
    }
}
