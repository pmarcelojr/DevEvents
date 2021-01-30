using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevEvents.API.Persistencia.Migrations
{
    public partial class AddInscricao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Inscricao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdEvento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Inscricao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Inscricao_tb_Evento_IdEvento",
                        column: x => x.IdEvento,
                        principalTable: "tb_Evento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_Inscricao_tb_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "tb_Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Inscricao_IdEvento",
                table: "tb_Inscricao",
                column: "IdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Inscricao_IdUsuario",
                table: "tb_Inscricao",
                column: "IdUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Inscricao");
        }
    }
}
