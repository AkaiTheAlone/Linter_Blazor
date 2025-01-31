using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Linter.Dados.Migrations
{
    /// <inheritdoc />
    public partial class MAISUMA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aspnetroles",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_aspnet_roles", x => x.id);
                    table.ForeignKey(
                        name: "FK_aspnetroles_tab002_cargos_id",
                        column: x => x.id,
                        principalTable: "tab002_cargos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "tab002_cargos",
                keyColumn: "id",
                keyValue: 2,
                column: "marcadeconcorrencia",
                value: "70f5a765-793f-4f59-bcd2-0e2d37c2252d");

            migrationBuilder.UpdateData(
                table: "tab002_cargos",
                keyColumn: "id",
                keyValue: 3,
                column: "marcadeconcorrencia",
                value: "b772006f-16db-4d1f-9133-e5b2aa6d6115");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aspnetroles");

            migrationBuilder.UpdateData(
                table: "tab002_cargos",
                keyColumn: "id",
                keyValue: 2,
                column: "marcadeconcorrencia",
                value: "37532a26-b564-4f0a-a7d3-443bbd3f3a80");

            migrationBuilder.UpdateData(
                table: "tab002_cargos",
                keyColumn: "id",
                keyValue: 3,
                column: "marcadeconcorrencia",
                value: "6bac4a5e-b51f-401c-9ca8-8f1006e36bbe");
        }
    }
}
