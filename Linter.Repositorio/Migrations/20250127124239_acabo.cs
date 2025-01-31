using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Linter.Dados.Migrations
{
    /// <inheritdoc />
    public partial class acabo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tab002_cargos",
                keyColumn: "id",
                keyValue: 1,
                column: "marcadeconcorrencia",
                value: "6920564a-46f8-4af5-9715-4609ce9c6e48");

            migrationBuilder.UpdateData(
                table: "tab002_cargos",
                keyColumn: "id",
                keyValue: 2,
                column: "marcadeconcorrencia",
                value: "acb98b10-0e50-4a42-8819-9a3988917a14");

            migrationBuilder.UpdateData(
                table: "tab002_cargos",
                keyColumn: "id",
                keyValue: 3,
                column: "marcadeconcorrencia",
                value: "3c3a097d-1662-4933-bca9-deefd2f117c3");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tab002_cargos",
                keyColumn: "id",
                keyValue: 1,
                column: "marcadeconcorrencia",
                value: null);

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
    }
}
