using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Linter.Dados.Migrations
{
    /// <inheritdoc />
    public partial class NOME : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tab002_cargos",
                keyColumn: "id",
                keyValue: 2,
                column: "marcadeconcorrencia",
                value: "af9dac92-ad10-4b90-9e91-d5430387a555");

            migrationBuilder.UpdateData(
                table: "tab002_cargos",
                keyColumn: "id",
                keyValue: 3,
                column: "marcadeconcorrencia",
                value: "a17b1661-4e52-4479-9620-a675a887f8cd");
        }
    }
}
