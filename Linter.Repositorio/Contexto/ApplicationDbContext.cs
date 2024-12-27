using Linter.Modelos.Modelos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Linter.Dados.Contexto
{
    public class ApplicationDbContext : IdentityDbContext<TAB001_Usuarios, IdentityRole<int>, int>
    {
        #region Construtor
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        #endregion

        #region Propriedades
        public DbSet<TAB001_Usuarios> TAB001_Usuarios { get; set; }
        public DbSet<CAX001_MovimentacoesCaixa> CAX001_MovimentacoesCaixa { get; set; }
        public DbSet<TAB002_ContasGerenciais> TAB002_ContasGerenciais { get; set; }
        public DbSet<CAX002_MovimentaocesCanceladas> CAX002_MovimentaocesCanceladas { get; set; }
        #endregion

        #region OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Remover aspas do Postgre

            base.OnModelCreating(modelBuilder);

            //essa funcao serve pra deixar todos os 
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.GetTableName()?.ToLower());

                foreach (var property in entity.GetProperties())
                {
                    property.SetColumnName(property.Name.ToLower());
                }

                foreach (var key in entity.GetKeys())
                {
                    key.SetName(key.GetName()?.ToLower());
                }

                foreach (var foreignKey in entity.GetForeignKeys())
                {
                    foreignKey.SetConstraintName(foreignKey.GetConstraintName()?.ToLower());
                }

                foreach (var index in entity.GetIndexes())
                {
                    index.SetDatabaseName(index.GetDatabaseName()?.ToLower());
                }
            }


            #endregion

            #region Renomeando tabelas do identity

            //conforme o uso pretendo mudar o nome dessas classes pra palavras chave mais especificas 

            modelBuilder.Entity<TAB001_Usuarios>()
                        .ToTable("tab001_usuarios");

            //tab002 proprietária

            modelBuilder.Entity<IdentityRole<int>>()
                        .ToTable("tab003_cargos");

            modelBuilder.Entity<IdentityUserRole<int>>()
                        .ToTable("tab003a_usuarioscargos");

            modelBuilder.Entity<IdentityUserLogin<int>>()
                        .ToTable("tab004_usuarioslogin");

            modelBuilder.Entity<IdentityUserToken<int>>()
                        .ToTable("tab005_usuariostokens");

            modelBuilder.Entity<IdentityRoleClaim<int>>()
                        .ToTable("tab006_cargosdeidentidade");

            modelBuilder.Entity<IdentityUserClaim<int>>()
                        .ToTable("tab007_solicitacoescargo"); //esse nome n faz sentido
            #endregion

            #region Renomear colunas das tabelas

            #region TAB001 + IdentityUser
            modelBuilder.Entity<TAB001_Usuarios>()
                        .Property(u => u.UserName)
                        .HasColumnName("nomeusuario");

            modelBuilder.Entity<TAB001_Usuarios>()
                        .Property(u => u.PasswordHash)
                        .HasColumnName("senhahash");

            modelBuilder.Entity<TAB001_Usuarios>()
                        .Property(u => u.AccessFailedCount)
                        .HasColumnName("numeroacessosfalhos");

            modelBuilder.Entity<TAB001_Usuarios>()
                       .Property(u => u.PhoneNumber)
                       .HasColumnName("numerotelefone");

            modelBuilder.Entity<TAB001_Usuarios>()
                        .Property(u => u.EmailConfirmed)
                        .HasColumnName("confirmacaoemail");

            modelBuilder.Entity<TAB001_Usuarios>()
                        .Property(u => u.TwoFactorEnabled)
                        .HasColumnName("autentificacao2fa");

            modelBuilder.Entity<TAB001_Usuarios>()
                        .Property(u => u.NormalizedUserName)
                        .HasColumnName("nomenormalizado");

            modelBuilder.Entity<TAB001_Usuarios>()
                        .Property(u => u.LockoutEnabled)
                        .HasColumnName("bloqueiohabilitado");

            modelBuilder.Entity<TAB001_Usuarios>() //essa propriedade serve pra bloquear/desbloquear uma conta
                        .Property(u => u.LockoutEnabled)
                        .HasColumnName("statusdesbloqueio");

            modelBuilder.Entity<TAB001_Usuarios>() //isso serve em complemento para a anterior, se estiver bloqueado, aqui é passado a data que vai ser desbloqueado
                        .Property(u => u.LockoutEnd)
                        .HasColumnName("datadesbloqueio");

            modelBuilder.Entity<TAB001_Usuarios>()
                       .Property(u => u.LockoutEnd)
                       .HasColumnName("datadesbloqueio");

            modelBuilder.Entity<TAB001_Usuarios>()
                        .Property(u => u.NormalizedEmail)
                        .HasColumnName("emailnormalizado");

            modelBuilder.Entity<TAB001_Usuarios>()
                       .Property(u => u.PhoneNumberConfirmed)
                       .HasColumnName("confirmacaotelefone");

            modelBuilder.Entity<TAB001_Usuarios>()
                      .Property(u => u.SecurityStamp)
                      .HasColumnName("marcadeseguranca");

            modelBuilder.Entity<TAB001_Usuarios>() //isso aq serve pra marcar o atual estado de um dado
                      .Property(u => u.ConcurrencyStamp) //ex: se um admin alterar um valor e outro admin estiver alterando ele ao mesmo tempo, algum dos dois deverá 
                      .HasColumnName("marcadeconcorrencia"); //receber um codigo de erro dizendo q a marca de concorrencia do servidor e local sao incompativeis
            #endregion

            #region TAB003 // IdentityRole

            modelBuilder.Entity<IdentityRole<int>>()
                       .Property(u => u.Name)
                       .HasColumnName("nome");

            modelBuilder.Entity<IdentityRole<int>>()
                        .Property(u => u.NormalizedName)
                        .HasColumnName("nomenormalizado");

            modelBuilder.Entity<IdentityRole<int>>()
                        .Property(u => u.ConcurrencyStamp)
                        .HasColumnName("marcadeconcorrencia");

            #endregion

            #region TAB003A // IdentityUserRole

            modelBuilder.Entity<IdentityUserRole<int>>()
                       .Property(u => u.UserId)
                       .HasColumnName("idusuario");

            modelBuilder.Entity<IdentityUserRole<int>>()
                        .Property(u => u.RoleId)
                        .HasColumnName("idcargo");

            #endregion

            #region TAB004 // IdentityUserLogin

            modelBuilder.Entity<IdentityUserLogin<int>>()
                      .Property(u => u.UserId)
                      .HasColumnName("idusuario");

            modelBuilder.Entity<IdentityUserLogin<int>>()
                        .Property(u => u.ProviderKey)
                        .HasColumnName("provedordachave");

            modelBuilder.Entity<IdentityUserLogin<int>>()
                        .Property(u => u.LoginProvider)
                        .HasColumnName("provedordelogin");

            modelBuilder.Entity<IdentityUserLogin<int>>()
                        .Property(u => u.ProviderDisplayName)
                        .HasColumnName("nomedeexibicao");

            #endregion

            #region TAB005 // IdentityUserToken

            modelBuilder.Entity<IdentityUserToken<int>>()
                      .Property(u => u.UserId)
                      .HasColumnName("idusuario");

            modelBuilder.Entity<IdentityUserToken<int>>()
                        .Property(u => u.LoginProvider)
                        .HasColumnName("provedordologin");

            modelBuilder.Entity<IdentityUserToken<int>>()
                        .Property(u => u.Value)
                        .HasColumnName("valor"); //valor de q?

            modelBuilder.Entity<IdentityUserToken<int>>()
                        .Property(u => u.Name)
                        .HasColumnName("nome");
            #endregion

            #region TAB006 // IdentityRoleClaim

            modelBuilder.Entity<IdentityRoleClaim<int>>()
                        .Property(u => u.RoleId)
                        .HasColumnName("idcargo");

            modelBuilder.Entity<IdentityRoleClaim<int>>()
                        .Property(u => u.ClaimType)
                        .HasColumnName("tiposolicitacao");

            modelBuilder.Entity<IdentityRoleClaim<int>>()
                        .Property(u => u.ClaimValue)
                        .HasColumnName("valorsolicitacao");
            #endregion

            #region TAB007 // IdentityUserClaim

            modelBuilder.Entity<IdentityUserClaim<int>>()
                       .Property(u => u.ClaimType)
                       .HasColumnName("tiposolicitacao");

            modelBuilder.Entity<IdentityUserClaim<int>>()
                        .Property(u => u.ClaimValue)
                        .HasColumnName("valorsolicitacao");

            modelBuilder.Entity<IdentityUserClaim<int>>()
                        .Property(u => u.UserId)
                        .HasColumnName("idusuario");
            #endregion

            #region CAX002_MovimentacoesCanceladas

            modelBuilder.Entity<CAX002_MovimentaocesCanceladas>().HasNoKey();

            #endregion

            #endregion
        }


        #endregion
    }

}

