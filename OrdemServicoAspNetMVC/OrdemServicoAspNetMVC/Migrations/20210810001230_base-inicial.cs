using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrdemServicoAspNetMVC.Migrations
{
    public partial class baseinicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ordensServicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    idTipoServico = table.Column<int>(type: "int", nullable: false),
                    idTipoContrato = table.Column<int>(type: "int", nullable: false),
                    idColaborador = table.Column<int>(type: "int", nullable: false),
                    idDefeitoReclamado = table.Column<int>(type: "int", nullable: false),
                    idDefeitoIdentificado = table.Column<int>(type: "int", nullable: false),
                    idSolucaoAplicada = table.Column<int>(type: "int", nullable: false),
                    DataAbertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFechamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordensServicos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ordensServicos");
        }
    }
}
