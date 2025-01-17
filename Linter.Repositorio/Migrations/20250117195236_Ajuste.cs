using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Linter.Dados.Migrations
{
    /// <inheritdoc />
    public partial class Ajuste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idusuarioexclusao",
                table: "cnt002_contasexcluidas");

            migrationBuilder.RenameTable(
                name: "tab007_solicitacoescargo",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "tab006_cargosdeidentidade",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "tab005_usuariostokens",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "tab004_usuarioslogin",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "tab003a_usuarioscargos",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "tab003_cargos",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "tab001_usuarios",
                newName: "AspNetUsers");

            migrationBuilder.RenameIndex(
                name: "rolenameindex",
                table: "AspNetRoles",
                newName: "RoleNameIndex");

            migrationBuilder.RenameIndex(
                name: "usernameindex",
                table: "AspNetUsers",
                newName: "UserNameIndex");

            migrationBuilder.RenameIndex(
                name: "emailindex",
                table: "AspNetUsers",
                newName: "EmailIndex");

            migrationBuilder.AlterColumn<DateTime>(
                name: "datacadastro",
                table: "cnt002_contasexcluidas",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AddColumn<string>(
                name: "usuarioexclusao",
                table: "cnt002_contasexcluidas",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "datacadastro",
                table: "cnt001_contasgerenciais",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "descritivo",
                table: "cax001_movimentacoescaixa",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "id", "marcadeconcorrencia", "nome", "nomenormalizado" },
                values: new object[,]
                {
                    { 1, null, "Administrador", "ADMINISTRADOR" },
                    { 2, null, "usuario", "USUARIO" },
                    { 3, null, "suporte", "SUPORTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "id", "numeroacessosfalhos", "bairro", "cep", "cidade", "marcadeconcorrencia", "email", "confirmacaoemail", "statusdesbloqueio", "datadesbloqueio", "emailnormalizado", "nomenormalizado", "senhahash", "numerotelefone", "confirmacaotelefone", "rua", "marcadeseguranca", "tipousuario", "autentificacao2fa", "nomeusuario" },
                values: new object[] { 1, 0, null, null, null, "9408b12a-6638-445e-bc99-7421f5ed61ed", "admin@ldnsistemas.com", true, false, null, "ADMIN@LDNSISTEMAS.COM", "ADMINISTRADOR", "AQAAAAIAAYagAAAAEH0zNL02dMANiExBlNGzUMGDO73ly5vBTx6HOYd4MMcpB9N8zvrnWHwVYzrVVpIFpA==", null, false, null, "10024ccc-9296-44f5-b7ad-755cea259217", (byte)0, false, "administrador" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "idcargo", "idusuario" },
                values: new object[] { 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "idcargo", "idusuario" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "usuarioexclusao",
                table: "cnt002_contasexcluidas");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "tab005_usuariostokens");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "tab001_usuarios");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "tab003a_usuarioscargos");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "tab004_usuarioslogin");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "tab007_solicitacoescargo");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "tab003_cargos");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "tab006_cargosdeidentidade");

            migrationBuilder.RenameIndex(
                name: "UserNameIndex",
                table: "tab001_usuarios",
                newName: "usernameindex");

            migrationBuilder.RenameIndex(
                name: "EmailIndex",
                table: "tab001_usuarios",
                newName: "emailindex");

            migrationBuilder.RenameIndex(
                name: "RoleNameIndex",
                table: "tab003_cargos",
                newName: "rolenameindex");

            migrationBuilder.AlterColumn<DateTime>(
                name: "datacadastro",
                table: "cnt002_contasexcluidas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idusuarioexclusao",
                table: "cnt002_contasexcluidas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "datacadastro",
                table: "cnt001_contasgerenciais",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descritivo",
                table: "cax001_movimentacoescaixa",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300);
        }
    }
}
