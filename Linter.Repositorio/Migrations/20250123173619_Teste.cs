using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Linter.Dados.Migrations
{
    /// <inheritdoc />
    public partial class Teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "roleid",
                table: "tab003_usuarioscargos",
                newName: "idcargo");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "tab003_usuarioscargos",
                newName: "idusuario");

            migrationBuilder.RenameColumn(
                name: "normalizedname",
                table: "tab002_cargos",
                newName: "nomenormalizado");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "tab002_cargos",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "concurrencystamp",
                table: "tab002_cargos",
                newName: "marcadeconcorrencia");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "valorsolicitacao",
                table: "tab007_solicitacoescargo",
                newName: "claimvalue");

            migrationBuilder.RenameColumn(
                name: "tiposolicitacao",
                table: "tab007_solicitacoescargo",
                newName: "claimtype");

            migrationBuilder.RenameColumn(
                name: "idusuario",
                table: "tab007_solicitacoescargo",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "valorsolicitacao",
                table: "tab006_cargosdeidentidade",
                newName: "claimvalue");

            migrationBuilder.RenameColumn(
                name: "tiposolicitacao",
                table: "tab006_cargosdeidentidade",
                newName: "claimtype");

            migrationBuilder.RenameColumn(
                name: "idcargo",
                table: "tab006_cargosdeidentidade",
                newName: "roleid");

            migrationBuilder.RenameColumn(
                name: "valor",
                table: "tab005_usuariostokens",
                newName: "value");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "tab005_usuariostokens",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "provedordologin",
                table: "tab005_usuariostokens",
                newName: "loginprovider");

            migrationBuilder.RenameColumn(
                name: "idusuario",
                table: "tab005_usuariostokens",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "nomedeexibicao",
                table: "tab004_usuarioslogin",
                newName: "providerdisplayname");

            migrationBuilder.RenameColumn(
                name: "idusuario",
                table: "tab004_usuarioslogin",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "provedordachave",
                table: "tab004_usuarioslogin",
                newName: "providerkey");

            migrationBuilder.RenameColumn(
                name: "provedordelogin",
                table: "tab004_usuarioslogin",
                newName: "loginprovider");

            migrationBuilder.RenameColumn(
                name: "idcargo",
                table: "tab003_usuarioscargos",
                newName: "roleid");

            migrationBuilder.RenameColumn(
                name: "idusuario",
                table: "tab003_usuarioscargos",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "nomenormalizado",
                table: "tab002_cargos",
                newName: "normalizedname");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "tab002_cargos",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "marcadeconcorrencia",
                table: "tab002_cargos",
                newName: "concurrencystamp");

            migrationBuilder.RenameColumn(
                name: "statusdesbloqueio",
                table: "tab001_usuarios",
                newName: "lockoutenabled");

            migrationBuilder.RenameColumn(
                name: "senhahash",
                table: "tab001_usuarios",
                newName: "passwordhash");

            migrationBuilder.RenameColumn(
                name: "numerotelefone",
                table: "tab001_usuarios",
                newName: "phonenumber");

            migrationBuilder.RenameColumn(
                name: "numeroacessosfalhos",
                table: "tab001_usuarios",
                newName: "accessfailedcount");

            migrationBuilder.RenameColumn(
                name: "nomeusuario",
                table: "tab001_usuarios",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "nomenormalizado",
                table: "tab001_usuarios",
                newName: "normalizedusername");

            migrationBuilder.RenameColumn(
                name: "marcadeseguranca",
                table: "tab001_usuarios",
                newName: "securitystamp");

            migrationBuilder.RenameColumn(
                name: "marcadeconcorrencia",
                table: "tab001_usuarios",
                newName: "concurrencystamp");

            migrationBuilder.RenameColumn(
                name: "emailnormalizado",
                table: "tab001_usuarios",
                newName: "normalizedemail");

            migrationBuilder.RenameColumn(
                name: "datadesbloqueio",
                table: "tab001_usuarios",
                newName: "lockoutend");

            migrationBuilder.RenameColumn(
                name: "confirmacaotelefone",
                table: "tab001_usuarios",
                newName: "phonenumberconfirmed");

            migrationBuilder.RenameColumn(
                name: "confirmacaoemail",
                table: "tab001_usuarios",
                newName: "emailconfirmed");

            migrationBuilder.RenameColumn(
                name: "autentificacao2fa",
                table: "tab001_usuarios",
                newName: "twofactorenabled");

            migrationBuilder.UpdateData(
                table: "tab002_cargos",
                keyColumn: "id",
                keyValue: 2,
                column: "concurrencystamp",
                value: "af30f6f4-4639-458c-aee5-827a0913c16b");

            migrationBuilder.UpdateData(
                table: "tab002_cargos",
                keyColumn: "id",
                keyValue: 3,
                column: "concurrencystamp",
                value: "9e254f83-9795-4a67-b129-df8cb968feaa");
        }
    }
}
