using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioTecnico.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCondominium : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blocks_Condominiums_CondominiumId",
                table: "Blocks");

            migrationBuilder.DropIndex(
                name: "IX_Blocks_CondominiumId",
                table: "Blocks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Blocks_CondominiumId",
                table: "Blocks",
                column: "CondominiumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blocks_Condominiums_CondominiumId",
                table: "Blocks",
                column: "CondominiumId",
                principalTable: "Condominiums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
