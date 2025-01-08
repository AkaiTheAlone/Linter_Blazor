using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Linter.Dados.Migrations
{
    /// <inheritdoc />
    public partial class TentandoHerdar : Migration
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

            migrationBuilder.AddColumn<int>(
                name: "idusuariocriador",
                table: "cnt001_contasgerenciais",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "cnt002_contasexcluidas",
                columns: table => new
                {
                    idcontagerencial = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "text", nullable: false),
                    datacadastro = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    idusuariocriador = table.Column<int>(type: "integer", nullable: false),
                    dataexclusao = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    motivocancelamento = table.Column<string>(type: "text", nullable: false),
                    idusuarioexclusao = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cnt002_contasexcluidas", x => x.idcontagerencial);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cnt002_contasexcluidas");

            migrationBuilder.DropColumn(
                name: "datacadastro",
                table: "cnt001_contasgerenciais");

            migrationBuilder.DropColumn(
                name: "idusuariocriador",
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
