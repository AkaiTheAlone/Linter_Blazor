using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Linter.Dados.Migrations
{
    /// <inheritdoc />
    public partial class jnome : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "discriminator",
                table: "aspnetroles");

            migrationBuilder.InsertData(
                table: "aspnetroles",
                columns: new[] { "id", "concurrencystamp", "name", "normalizedname" },
                values: new object[,]
                {
                    { 1, "6b62e097-e3cf-4e37-85cd-711a81e908ac", "Administrador", "ADMINISTRADOR" },
                    { 2, "dbcdb37a-47db-48e7-822e-85c08c2320b0", "usuario", "USUARIO" },
                    { 3, "a4370684-8609-42c2-bcf5-1f2ba5dc10c7", "suporte", "SUPORTE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "aspnetroles",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "aspnetroles",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "aspnetroles",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.AddColumn<string>(
                name: "discriminator",
                table: "aspnetroles",
                type: "character varying(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");
        }
    }
}
