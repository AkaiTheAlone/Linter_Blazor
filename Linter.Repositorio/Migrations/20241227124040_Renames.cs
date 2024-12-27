using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Linter.Dados.Migrations
{
    /// <inheritdoc />
    public partial class Renames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cax001_movimentacoescaixa",
                columns: table => new
                {
                    idmovimentacao = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datamovimentacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    descritivo = table.Column<string>(type: "text", nullable: false),
                    idcontagerencial = table.Column<int>(type: "integer", nullable: false),
                    valor = table.Column<decimal>(type: "numeric", nullable: false),
                    tipo = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cax001_movimentacoescaixa", x => x.idmovimentacao);
                });

            migrationBuilder.CreateTable(
                name: "cax002_movimentaocescanceladas",
                columns: table => new
                {
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tab001_usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tipousuario = table.Column<byte>(type: "smallint", nullable: false),
                    nomeusuario = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    nomenormalizado = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    emailnormalizado = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    confirmacaoemail = table.Column<bool>(type: "boolean", nullable: false),
                    senhahash = table.Column<string>(type: "text", nullable: true),
                    marcadeseguranca = table.Column<string>(type: "text", nullable: true),
                    marcadeconcorrencia = table.Column<string>(type: "text", nullable: true),
                    numerotelefone = table.Column<string>(type: "text", nullable: true),
                    confirmacaotelefone = table.Column<bool>(type: "boolean", nullable: false),
                    autentificacao2fa = table.Column<bool>(type: "boolean", nullable: false),
                    datadesbloqueio = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    statusdesbloqueio = table.Column<bool>(type: "boolean", nullable: false),
                    numeroacessosfalhos = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_aspnetusers", x => x.id);
                });

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

            migrationBuilder.CreateTable(
                name: "tab003_cargos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    nomenormalizado = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    marcadeconcorrencia = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_aspnetroles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tab004_usuarioslogin",
                columns: table => new
                {
                    provedordelogin = table.Column<string>(type: "text", nullable: false),
                    provedordachave = table.Column<string>(type: "text", nullable: false),
                    nomedeexibicao = table.Column<string>(type: "text", nullable: true),
                    idusuario = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_aspnetuserlogins", x => new { x.provedordelogin, x.provedordachave });
                    table.ForeignKey(
                        name: "fk_aspnetuserlogins_aspnetusers_userid",
                        column: x => x.idusuario,
                        principalTable: "tab001_usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tab005_usuariostokens",
                columns: table => new
                {
                    idusuario = table.Column<int>(type: "integer", nullable: false),
                    provedordologin = table.Column<string>(type: "text", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: false),
                    valor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_aspnetusertokens", x => new { x.idusuario, x.provedordologin, x.nome });
                    table.ForeignKey(
                        name: "fk_aspnetusertokens_aspnetusers_userid",
                        column: x => x.idusuario,
                        principalTable: "tab001_usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tab007_solicitacoescargo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idusuario = table.Column<int>(type: "integer", nullable: false),
                    tiposolicitacao = table.Column<string>(type: "text", nullable: true),
                    valorsolicitacao = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_aspnetuserclaims", x => x.id);
                    table.ForeignKey(
                        name: "fk_aspnetuserclaims_aspnetusers_userid",
                        column: x => x.idusuario,
                        principalTable: "tab001_usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tab003a_usuarioscargos",
                columns: table => new
                {
                    idusuario = table.Column<int>(type: "integer", nullable: false),
                    idcargo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_aspnetuserroles", x => new { x.idusuario, x.idcargo });
                    table.ForeignKey(
                        name: "fk_aspnetuserroles_aspnetroles_roleid",
                        column: x => x.idcargo,
                        principalTable: "tab003_cargos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_aspnetuserroles_aspnetusers_userid",
                        column: x => x.idusuario,
                        principalTable: "tab001_usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tab006_cargosdeidentidade",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idcargo = table.Column<int>(type: "integer", nullable: false),
                    tiposolicitacao = table.Column<string>(type: "text", nullable: true),
                    valorsolicitacao = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_aspnetroleclaims", x => x.id);
                    table.ForeignKey(
                        name: "fk_aspnetroleclaims_aspnetroles_roleid",
                        column: x => x.idcargo,
                        principalTable: "tab003_cargos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "emailindex",
                table: "tab001_usuarios",
                column: "emailnormalizado");

            migrationBuilder.CreateIndex(
                name: "usernameindex",
                table: "tab001_usuarios",
                column: "nomenormalizado",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "rolenameindex",
                table: "tab003_cargos",
                column: "nomenormalizado",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_aspnetuserroles_roleid",
                table: "tab003a_usuarioscargos",
                column: "idcargo");

            migrationBuilder.CreateIndex(
                name: "ix_aspnetuserlogins_userid",
                table: "tab004_usuarioslogin",
                column: "idusuario");

            migrationBuilder.CreateIndex(
                name: "ix_aspnetroleclaims_roleid",
                table: "tab006_cargosdeidentidade",
                column: "idcargo");

            migrationBuilder.CreateIndex(
                name: "ix_aspnetuserclaims_userid",
                table: "tab007_solicitacoescargo",
                column: "idusuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cax001_movimentacoescaixa");

            migrationBuilder.DropTable(
                name: "cax002_movimentaocescanceladas");

            migrationBuilder.DropTable(
                name: "tab002_contasgerenciais");

            migrationBuilder.DropTable(
                name: "tab003a_usuarioscargos");

            migrationBuilder.DropTable(
                name: "tab004_usuarioslogin");

            migrationBuilder.DropTable(
                name: "tab005_usuariostokens");

            migrationBuilder.DropTable(
                name: "tab006_cargosdeidentidade");

            migrationBuilder.DropTable(
                name: "tab007_solicitacoescargo");

            migrationBuilder.DropTable(
                name: "tab003_cargos");

            migrationBuilder.DropTable(
                name: "tab001_usuarios");
        }
    }
}
