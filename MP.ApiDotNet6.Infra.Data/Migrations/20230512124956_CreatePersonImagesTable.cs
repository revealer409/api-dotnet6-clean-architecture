using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MP.ApiDotNet6.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatePersonImagesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pessoaimagem",
                columns: table => new
                {
                    idimagem = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    imagemurl = table.Column<string>(type: "text", nullable: true),
                    imagembase = table.Column<string>(type: "text", nullable: true),
                    idpessoa = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pessoaimagem", x => x.idimagem);
                    table.ForeignKey(
                        name: "FK_pessoaimagem_Pessoa_idpessoa",
                        column: x => x.idpessoa,
                        principalTable: "Pessoa",
                        principalColumn: "Idpessoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pessoaimagem_idpessoa",
                table: "pessoaimagem",
                column: "idpessoa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pessoaimagem");
        }
    }
}
