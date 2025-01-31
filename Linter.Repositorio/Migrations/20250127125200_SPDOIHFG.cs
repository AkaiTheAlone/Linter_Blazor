using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Linter.Dados.Migrations
{
    /// <inheritdoc />
    public partial class SPDOIHFG : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameTable(
                name: "tab007_solicitacoescargo",
                newName: "aspnetuserclaims");

            migrationBuilder.RenameTable(
                name: "tab006_cargosdeidentidade",
                newName: "aspnetroleclaims");

            migrationBuilder.RenameTable(
                name: "tab005_usuariostokens",
                newName: "aspnetusertokens");

            migrationBuilder.RenameTable(
                name: "tab004_usuarioslogin",
                newName: "aspnetuserlogins");

            migrationBuilder.RenameTable(
                name: "tab003_usuarioscargos",
                newName: "aspnetuserroles");

            migrationBuilder.RenameTable(
                name: "tab001_usuarios",
                newName: "aspnetusers");

            migrationBuilder.RenameColumn(
                name: "nomenormalizado",
                table: "aspnetroles",
                newName: "normalizedname");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "aspnetroles",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "marcadeconcorrencia",
                table: "aspnetroles",
                newName: "concurrencystamp");

            migrationBuilder.RenameColumn(
                name: "valorsolicitacao",
                table: "aspnetuserclaims",
                newName: "claimvalue");

            migrationBuilder.RenameColumn(
                name: "tiposolicitacao",
                table: "aspnetuserclaims",
                newName: "claimtype");

            migrationBuilder.RenameColumn(
                name: "idusuario",
                table: "aspnetuserclaims",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "valorsolicitacao",
                table: "aspnetroleclaims",
                newName: "claimvalue");

            migrationBuilder.RenameColumn(
                name: "tiposolicitacao",
                table: "aspnetroleclaims",
                newName: "claimtype");

            migrationBuilder.RenameColumn(
                name: "idcargo",
                table: "aspnetroleclaims",
                newName: "roleid");

            migrationBuilder.RenameColumn(
                name: "valor",
                table: "aspnetusertokens",
                newName: "value");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "aspnetusertokens",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "provedordologin",
                table: "aspnetusertokens",
                newName: "loginprovider");

            migrationBuilder.RenameColumn(
                name: "idusuario",
                table: "aspnetusertokens",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "nomedeexibicao",
                table: "aspnetuserlogins",
                newName: "providerdisplayname");

            migrationBuilder.RenameColumn(
                name: "idusuario",
                table: "aspnetuserlogins",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "provedordachave",
                table: "aspnetuserlogins",
                newName: "providerkey");

            migrationBuilder.RenameColumn(
                name: "provedordelogin",
                table: "aspnetuserlogins",
                newName: "loginprovider");

            migrationBuilder.RenameColumn(
                name: "idcargo",
                table: "aspnetuserroles",
                newName: "roleid");

            migrationBuilder.RenameColumn(
                name: "idusuario",
                table: "aspnetuserroles",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "statusdesbloqueio",
                table: "aspnetusers",
                newName: "lockoutenabled");

            migrationBuilder.RenameColumn(
                name: "senhahash",
                table: "aspnetusers",
                newName: "passwordhash");

            migrationBuilder.RenameColumn(
                name: "numerotelefone",
                table: "aspnetusers",
                newName: "phonenumber");

            migrationBuilder.RenameColumn(
                name: "numeroacessosfalhos",
                table: "aspnetusers",
                newName: "accessfailedcount");

            migrationBuilder.RenameColumn(
                name: "nomeusuario",
                table: "aspnetusers",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "nomenormalizado",
                table: "aspnetusers",
                newName: "normalizedusername");

            migrationBuilder.RenameColumn(
                name: "marcadeseguranca",
                table: "aspnetusers",
                newName: "securitystamp");

            migrationBuilder.RenameColumn(
                name: "marcadeconcorrencia",
                table: "aspnetusers",
                newName: "concurrencystamp");

            migrationBuilder.RenameColumn(
                name: "emailnormalizado",
                table: "aspnetusers",
                newName: "normalizedemail");

            migrationBuilder.RenameColumn(
                name: "datadesbloqueio",
                table: "aspnetusers",
                newName: "lockoutend");

            migrationBuilder.RenameColumn(
                name: "confirmacaotelefone",
                table: "aspnetusers",
                newName: "phonenumberconfirmed");

            migrationBuilder.RenameColumn(
                name: "confirmacaoemail",
                table: "aspnetusers",
                newName: "emailconfirmed");

            migrationBuilder.RenameColumn(
                name: "autentificacao2fa",
                table: "aspnetusers",
                newName: "twofactorenabled");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "aspnetusertokens",
                newName: "tab005_usuariostokens");

            migrationBuilder.RenameTable(
                name: "aspnetusers",
                newName: "tab001_usuarios");

            migrationBuilder.RenameTable(
                name: "aspnetuserroles",
                newName: "tab003_usuarioscargos");

            migrationBuilder.RenameTable(
                name: "aspnetuserlogins",
                newName: "tab004_usuarioslogin");

            migrationBuilder.RenameTable(
                name: "aspnetuserclaims",
                newName: "tab007_solicitacoescargo");

            migrationBuilder.RenameTable(
                name: "aspnetroleclaims",
                newName: "tab006_cargosdeidentidade");

            migrationBuilder.RenameColumn(
                name: "normalizedname",
                table: "aspnetroles",
                newName: "nomenormalizado");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "aspnetroles",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "concurrencystamp",
                table: "aspnetroles",
                newName: "marcadeconcorrencia");

            migrationBuilder.RenameColumn(
                name: "value",
                table: "tab005_usuariostokens",
                newName: "valor");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "tab005_usuariostokens",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "loginprovider",
                table: "tab005_usuariostokens",
                newName: "provedordologin");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "tab005_usuariostokens",
                newName: "idusuario");

            migrationBuilder.RenameColumn(
                name: "username",
                table: "tab001_usuarios",
                newName: "nomeusuario");

            migrationBuilder.RenameColumn(
                name: "twofactorenabled",
                table: "tab001_usuarios",
                newName: "autentificacao2fa");

            migrationBuilder.RenameColumn(
                name: "securitystamp",
                table: "tab001_usuarios",
                newName: "marcadeseguranca");

            migrationBuilder.RenameColumn(
                name: "phonenumberconfirmed",
                table: "tab001_usuarios",
                newName: "confirmacaotelefone");

            migrationBuilder.RenameColumn(
                name: "phonenumber",
                table: "tab001_usuarios",
                newName: "numerotelefone");

            migrationBuilder.RenameColumn(
                name: "passwordhash",
                table: "tab001_usuarios",
                newName: "senhahash");

            migrationBuilder.RenameColumn(
                name: "normalizedusername",
                table: "tab001_usuarios",
                newName: "nomenormalizado");

            migrationBuilder.RenameColumn(
                name: "normalizedemail",
                table: "tab001_usuarios",
                newName: "emailnormalizado");

            migrationBuilder.RenameColumn(
                name: "lockoutend",
                table: "tab001_usuarios",
                newName: "datadesbloqueio");

            migrationBuilder.RenameColumn(
                name: "lockoutenabled",
                table: "tab001_usuarios",
                newName: "statusdesbloqueio");

            migrationBuilder.RenameColumn(
                name: "emailconfirmed",
                table: "tab001_usuarios",
                newName: "confirmacaoemail");

            migrationBuilder.RenameColumn(
                name: "concurrencystamp",
                table: "tab001_usuarios",
                newName: "marcadeconcorrencia");

            migrationBuilder.RenameColumn(
                name: "accessfailedcount",
                table: "tab001_usuarios",
                newName: "numeroacessosfalhos");

            migrationBuilder.RenameColumn(
                name: "roleid",
                table: "tab003_usuarioscargos",
                newName: "idcargo");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "tab003_usuarioscargos",
                newName: "idusuario");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "tab004_usuarioslogin",
                newName: "idusuario");

            migrationBuilder.RenameColumn(
                name: "providerdisplayname",
                table: "tab004_usuarioslogin",
                newName: "nomedeexibicao");

            migrationBuilder.RenameColumn(
                name: "providerkey",
                table: "tab004_usuarioslogin",
                newName: "provedordachave");

            migrationBuilder.RenameColumn(
                name: "loginprovider",
                table: "tab004_usuarioslogin",
                newName: "provedordelogin");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "tab007_solicitacoescargo",
                newName: "idusuario");

            migrationBuilder.RenameColumn(
                name: "claimvalue",
                table: "tab007_solicitacoescargo",
                newName: "valorsolicitacao");

            migrationBuilder.RenameColumn(
                name: "claimtype",
                table: "tab007_solicitacoescargo",
                newName: "tiposolicitacao");

            migrationBuilder.RenameColumn(
                name: "roleid",
                table: "tab006_cargosdeidentidade",
                newName: "idcargo");

            migrationBuilder.RenameColumn(
                name: "claimvalue",
                table: "tab006_cargosdeidentidade",
                newName: "valorsolicitacao");

            migrationBuilder.RenameColumn(
                name: "claimtype",
                table: "tab006_cargosdeidentidade",
                newName: "tiposolicitacao");

            migrationBuilder.InsertData(
                table: "aspnetroles",
                columns: new[] { "id", "marcadeconcorrencia", "discriminator", "nome", "nomenormalizado" },
                values: new object[,]
                {
                    { 1, "f50390ab-5171-497a-8017-a2a0f583aa70", "IdentityRole<int>", "Administrador", "ADMINISTRADOR" },
                    { 2, "67450f18-5c30-4ac9-b5fb-55d78a21c3ae", "IdentityRole<int>", "usuario", "USUARIO" },
                    { 3, "84dc8e1b-2e82-4456-b685-9973c89ba5df", "IdentityRole<int>", "suporte", "SUPORTE" }
                });
        }
    }
}
