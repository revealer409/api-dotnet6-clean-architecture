using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MP.ApiDotNet6.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixForeignKeyPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_compra_Pessoa_idcompra",
                table: "compra");

            migrationBuilder.CreateIndex(
                name: "IX_compra_idpessoa",
                table: "compra",
                column: "idpessoa");

            migrationBuilder.AddForeignKey(
                name: "FK_compra_Pessoa_idpessoa",
                table: "compra",
                column: "idpessoa",
                principalTable: "Pessoa",
                principalColumn: "Idpessoa",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_compra_Pessoa_idpessoa",
                table: "compra");

            migrationBuilder.DropIndex(
                name: "IX_compra_idpessoa",
                table: "compra");

            migrationBuilder.AddForeignKey(
                name: "FK_compra_Pessoa_idcompra",
                table: "compra",
                column: "idcompra",
                principalTable: "Pessoa",
                principalColumn: "Idpessoa",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
