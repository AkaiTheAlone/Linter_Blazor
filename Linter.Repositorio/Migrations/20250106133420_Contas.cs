using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Linter.Dados.Migrations
{
    /// <inheritdoc />
    public partial class Contas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tab002_contasgerenciais");

            migrationBuilder.AddColumn<DateTime>(
                name: "datacadastro",
                table: "cnt001_contasgerenciais",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "dataexclusao",
                table: "cnt001_contasgerenciais",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "discriminator",
                table: "cnt001_contasgerenciais",
                type: "character varying(34)",
                maxLength: 34,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "idusuariocriador",
                table: "cnt001_contasgerenciais",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idusuarioexclusao",
                table: "cnt001_contasgerenciais",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "motivocancelamento",
                table: "cnt001_contasgerenciais",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "datacadastro",
                table: "cnt001_contasgerenciais");

            migrationBuilder.DropColumn(
                name: "dataexclusao",
                table: "cnt001_contasgerenciais");

            migrationBuilder.DropColumn(
                name: "discriminator",
                table: "cnt001_contasgerenciais");

            migrationBuilder.DropColumn(
                name: "idusuariocriador",
                table: "cnt001_contasgerenciais");

            migrationBuilder.DropColumn(
                name: "idusuarioexclusao",
                table: "cnt001_contasgerenciais");

            migrationBuilder.DropColumn(
                name: "motivocancelamento",
                table: "cnt001_contasgerenciais");

            migrationBuilder.CreateTable(
                name: "tab002_contasgerenciais",
                columns: table => new
                {
                    idconta = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tab002_contasgerenciais", x => x.idconta);
                });
        }
    }
}
