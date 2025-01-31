using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Linter.Dados.Migrations
{
    /// <inheritdoc />
    public partial class Inicial213 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_aspnetroles_tab002_cargos_id",
                table: "aspnetroles");

            migrationBuilder.DropForeignKey(
                name: "fk_aspnetuserroles_aspnetroles_roleid",
                table: "tab003_usuarioscargos");

            migrationBuilder.DropForeignKey(
                name: "fk_aspnetroleclaims_aspnetroles_roleid",
                table: "tab006_cargosdeidentidade");

            migrationBuilder.DropTable(
                name: "tab002_cargos");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "aspnetroles",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "discriminator",
                table: "aspnetroles",
                type: "character varying(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "marcadeconcorrencia",
                table: "aspnetroles",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nome",
                table: "aspnetroles",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nomenormalizado",
                table: "aspnetroles",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.InsertData(
                table: "aspnetroles",
                columns: new[] { "id", "marcadeconcorrencia", "discriminator", "nome", "nomenormalizado" },
                values: new object[,]
                {
                    { 1, "f50390ab-5171-497a-8017-a2a0f583aa70", "IdentityRole<int>", "Administrador", "ADMINISTRADOR" },
                    { 2, "67450f18-5c30-4ac9-b5fb-55d78a21c3ae", "IdentityRole<int>", "usuario", "USUARIO" },
                    { 3, "84dc8e1b-2e82-4456-b685-9973c89ba5df", "IdentityRole<int>", "suporte", "SUPORTE" }
                });

            migrationBuilder.CreateIndex(
                name: "rolenameindex",
                table: "aspnetroles",
                column: "nomenormalizado",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "fk_aspnetuserroles_aspnetroles_roleid",
                table: "tab003_usuarioscargos",
                column: "idcargo",
                principalTable: "aspnetroles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_aspnetroleclaims_aspnetroles_roleid",
                table: "tab006_cargosdeidentidade",
                column: "idcargo",
                principalTable: "aspnetroles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_aspnetuserroles_aspnetroles_roleid",
                table: "tab003_usuarioscargos");

            migrationBuilder.DropForeignKey(
                name: "fk_aspnetroleclaims_aspnetroles_roleid",
                table: "tab006_cargosdeidentidade");

            migrationBuilder.DropIndex(
                name: "rolenameindex",
                table: "aspnetroles");

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

            migrationBuilder.DropColumn(
                name: "discriminator",
                table: "aspnetroles");

            migrationBuilder.DropColumn(
                name: "marcadeconcorrencia",
                table: "aspnetroles");

            migrationBuilder.DropColumn(
                name: "nome",
                table: "aspnetroles");

            migrationBuilder.DropColumn(
                name: "nomenormalizado",
                table: "aspnetroles");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "aspnetroles",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateTable(
                name: "tab002_cargos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    marcadeconcorrencia = table.Column<string>(type: "text", nullable: true),
                    nome = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    nomenormalizado = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_aspnetroles", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "tab002_cargos",
                columns: new[] { "id", "marcadeconcorrencia", "nome", "nomenormalizado" },
                values: new object[,]
                {
                    { 1, "6920564a-46f8-4af5-9715-4609ce9c6e48", "Administrador", "ADMINISTRADOR" },
                    { 2, "acb98b10-0e50-4a42-8819-9a3988917a14", "usuario", "USUARIO" },
                    { 3, "3c3a097d-1662-4933-bca9-deefd2f117c3", "suporte", "SUPORTE" }
                });

            migrationBuilder.CreateIndex(
                name: "rolenameindex",
                table: "tab002_cargos",
                column: "nomenormalizado",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_aspnetroles_tab002_cargos_id",
                table: "aspnetroles",
                column: "id",
                principalTable: "tab002_cargos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_aspnetuserroles_aspnetroles_roleid",
                table: "tab003_usuarioscargos",
                column: "idcargo",
                principalTable: "tab002_cargos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_aspnetroleclaims_aspnetroles_roleid",
                table: "tab006_cargosdeidentidade",
                column: "idcargo",
                principalTable: "tab002_cargos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
