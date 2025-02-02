using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Linter.Dados.Migrations
{
    /// <inheritdoc />
    public partial class HomeOffice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "aspnetroles",
                keyColumn: "id",
                keyValue: 1,
                column: "concurrencystamp",
                value: "d05723ef-1842-4ec0-9cdf-db90022debaa");

            migrationBuilder.UpdateData(
                table: "aspnetroles",
                keyColumn: "id",
                keyValue: 2,
                column: "concurrencystamp",
                value: "521536fc-51b8-41b1-a99f-d4961915797d");

            migrationBuilder.UpdateData(
                table: "aspnetroles",
                keyColumn: "id",
                keyValue: 3,
                column: "concurrencystamp",
                value: "6c6c27a3-8ac3-43a2-bfba-c9c6e46a24cb");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "aspnetroles",
                keyColumn: "id",
                keyValue: 1,
                column: "concurrencystamp",
                value: "6b62e097-e3cf-4e37-85cd-711a81e908ac");

            migrationBuilder.UpdateData(
                table: "aspnetroles",
                keyColumn: "id",
                keyValue: 2,
                column: "concurrencystamp",
                value: "dbcdb37a-47db-48e7-822e-85c08c2320b0");

            migrationBuilder.UpdateData(
                table: "aspnetroles",
                keyColumn: "id",
                keyValue: 3,
                column: "concurrencystamp",
                value: "a4370684-8609-42c2-bcf5-1f2ba5dc10c7");
        }
    }
}
