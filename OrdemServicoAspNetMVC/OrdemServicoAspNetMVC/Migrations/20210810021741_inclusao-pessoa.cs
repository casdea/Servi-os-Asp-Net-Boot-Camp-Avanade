using Microsoft.EntityFrameworkCore.Migrations;

namespace OrdemServicoAspNetMVC.Migrations
{
    public partial class inclusaopessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "ordensServicos");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "ordensServicos",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "idTipoServico",
                table: "ordensServicos",
                newName: "IdTipoServico");

            migrationBuilder.RenameColumn(
                name: "idTipoContrato",
                table: "ordensServicos",
                newName: "IdTipoContrato");

            migrationBuilder.RenameColumn(
                name: "idSolucaoAplicada",
                table: "ordensServicos",
                newName: "IdSolucaoAplicada");

            migrationBuilder.RenameColumn(
                name: "idDefeitoReclamado",
                table: "ordensServicos",
                newName: "IdDefeitoReclamado");

            migrationBuilder.RenameColumn(
                name: "idDefeitoIdentificado",
                table: "ordensServicos",
                newName: "IdDefeitoIdentificado");

            migrationBuilder.RenameColumn(
                name: "idColaborador",
                table: "ordensServicos",
                newName: "IdColaborador");

            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "ordensServicos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ordensServicos_PessoaId",
                table: "ordensServicos",
                column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ordensServicos_Pessoa_PessoaId",
                table: "ordensServicos",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ordensServicos_Pessoa_PessoaId",
                table: "ordensServicos");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_ordensServicos_PessoaId",
                table: "ordensServicos");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "ordensServicos");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "ordensServicos",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "IdTipoServico",
                table: "ordensServicos",
                newName: "idTipoServico");

            migrationBuilder.RenameColumn(
                name: "IdTipoContrato",
                table: "ordensServicos",
                newName: "idTipoContrato");

            migrationBuilder.RenameColumn(
                name: "IdSolucaoAplicada",
                table: "ordensServicos",
                newName: "idSolucaoAplicada");

            migrationBuilder.RenameColumn(
                name: "IdDefeitoReclamado",
                table: "ordensServicos",
                newName: "idDefeitoReclamado");

            migrationBuilder.RenameColumn(
                name: "IdDefeitoIdentificado",
                table: "ordensServicos",
                newName: "idDefeitoIdentificado");

            migrationBuilder.RenameColumn(
                name: "IdColaborador",
                table: "ordensServicos",
                newName: "idColaborador");

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "ordensServicos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
