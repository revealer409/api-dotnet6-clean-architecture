using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MP.ApiDotNet6.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTypeColumnPurchase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Pessoa_Idcompra",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Produto_Idproduto",
                table: "Compra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Compra",
                table: "Compra");

            migrationBuilder.RenameTable(
                name: "Compra",
                newName: "compra");

            migrationBuilder.RenameColumn(
                name: "Idpessoa",
                table: "compra",
                newName: "idpessoa");

            migrationBuilder.RenameColumn(
                name: "Datacompra",
                table: "compra",
                newName: "datacompra");

            migrationBuilder.RenameColumn(
                name: "Idcompra",
                table: "compra",
                newName: "idcompra");

            migrationBuilder.RenameIndex(
                name: "IX_Compra_Idproduto",
                table: "compra",
                newName: "IX_compra_Idproduto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_compra",
                table: "compra",
                column: "idcompra");

            migrationBuilder.AddForeignKey(
                name: "FK_compra_Pessoa_idcompra",
                table: "compra",
                column: "idcompra",
                principalTable: "Pessoa",
                principalColumn: "Idpessoa",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_compra_Produto_Idproduto",
                table: "compra",
                column: "Idproduto",
                principalTable: "Produto",
                principalColumn: "Idproduto",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_compra_Pessoa_idcompra",
                table: "compra");

            migrationBuilder.DropForeignKey(
                name: "FK_compra_Produto_Idproduto",
                table: "compra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_compra",
                table: "compra");

            migrationBuilder.RenameTable(
                name: "compra",
                newName: "Compra");

            migrationBuilder.RenameColumn(
                name: "idpessoa",
                table: "Compra",
                newName: "Idpessoa");

            migrationBuilder.RenameColumn(
                name: "datacompra",
                table: "Compra",
                newName: "Datacompra");

            migrationBuilder.RenameColumn(
                name: "idcompra",
                table: "Compra",
                newName: "Idcompra");

            migrationBuilder.RenameIndex(
                name: "IX_compra_Idproduto",
                table: "Compra",
                newName: "IX_Compra_Idproduto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Compra",
                table: "Compra",
                column: "Idcompra");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Pessoa_Idcompra",
                table: "Compra",
                column: "Idcompra",
                principalTable: "Pessoa",
                principalColumn: "Idpessoa",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Produto_Idproduto",
                table: "Compra",
                column: "Idproduto",
                principalTable: "Produto",
                principalColumn: "Idproduto",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
