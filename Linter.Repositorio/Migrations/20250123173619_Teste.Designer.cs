﻿// <auto-generated />
using System;
using Linter.Dados.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Linter.Dados.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250123173619_Teste")]
    partial class Teste
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Linter.Modelos.Modelos.CAX001_Movimentacoes", b =>
                {
                    b.Property<int>("idMovimentacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("idmovimentacao");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idMovimentacao"));

                    b.Property<DateTime?>("DataMovimentacao")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("datamovimentacao");

                    b.Property<string>("Descritivo")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)")
                        .HasColumnName("descritivo");

                    b.Property<byte>("Tipo")
                        .HasColumnType("smallint")
                        .HasColumnName("tipo");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric")
                        .HasColumnName("valor");

                    b.Property<int>("idContaGerencial")
                        .HasColumnType("integer")
                        .HasColumnName("idcontagerencial");

                    b.HasKey("idMovimentacao")
                        .HasName("pk_cax001_movimentacoescaixa");

                    b.ToTable("cax001_movimentacoescaixa");
                });

            modelBuilder.Entity("Linter.Modelos.Modelos.CAX002_MovimentaocesCanceladas", b =>
                {
                    b.Property<DateTime>("DataCancelamento")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("datacancelamento");

                    b.Property<DateTime?>("DataMovimentacao")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("datamovimentacao");

                    b.Property<string>("Descritivo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descritivo");

                    b.Property<byte>("Tipo")
                        .HasColumnType("smallint")
                        .HasColumnName("tipo");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric")
                        .HasColumnName("valor");

                    b.Property<int>("idContaGerencial")
                        .HasColumnType("integer")
                        .HasColumnName("idcontagerencial");

                    b.Property<int>("idMovimentacao")
                        .HasColumnType("integer")
                        .HasColumnName("idmovimentacao");

                    b.Property<int>("idUsuarioCancelamento")
                        .HasColumnType("integer")
                        .HasColumnName("idusuariocancelamento");

                    b.ToTable("cax002_movimentaocescanceladas");
                });

            modelBuilder.Entity("Linter.Modelos.Modelos.CNT001_ContasGerenciais", b =>
                {
                    b.Property<int>("idContaGerencial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("idcontagerencial");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idContaGerencial"));

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("datacadastro");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<int>("idUsuarioCriador")
                        .HasColumnType("integer")
                        .HasColumnName("idusuariocriador");

                    b.HasKey("idContaGerencial")
                        .HasName("pk_cnt001_contasgerenciais");

                    b.ToTable("cnt001_contasgerenciais");
                });

            modelBuilder.Entity("Linter.Modelos.Modelos.CNT002_ContasExcluidas", b =>
                {
                    b.Property<int>("idContaGerencial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("idcontagerencial");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idContaGerencial"));

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("datacadastro");

                    b.Property<DateTime>("DataExclusao")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("dataexclusao");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<string>("MotivoCancelamento")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("motivocancelamento");

                    b.Property<string>("UsuarioExclusao")
                        .HasColumnType("text")
                        .HasColumnName("usuarioexclusao");

                    b.Property<int>("idUsuarioCriador")
                        .HasColumnType("integer")
                        .HasColumnName("idusuariocriador");

                    b.HasKey("idContaGerencial")
                        .HasName("pk_cnt002_contasexcluidas");

                    b.ToTable("cnt002_contasexcluidas");
                });

            modelBuilder.Entity("Linter.Modelos.Modelos.TAB001_Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer")
                        .HasColumnName("numeroacessosfalhos");

                    b.Property<string>("Bairro")
                        .HasColumnType("text")
                        .HasColumnName("bairro");

                    b.Property<string>("CEP")
                        .HasColumnType("text")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .HasColumnType("text")
                        .HasColumnName("cidade");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text")
                        .HasColumnName("marcadeconcorrencia");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("email");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("confirmacaoemail");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("statusdesbloqueio");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("datadesbloqueio");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("emailnormalizado");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("nomenormalizado");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text")
                        .HasColumnName("senhahash");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("numerotelefone");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("confirmacaotelefone");

                    b.Property<string>("Rua")
                        .HasColumnType("text")
                        .HasColumnName("rua");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text")
                        .HasColumnName("marcadeseguranca");

                    b.Property<byte>("TipoUsuario")
                        .HasColumnType("smallint")
                        .HasColumnName("tipousuario");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("autentificacao2fa");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("nomeusuario");

                    b.HasKey("Id")
                        .HasName("pk_aspnetusers");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("emailindex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("usernameindex");

                    b.ToTable("tab001_usuarios", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text")
                        .HasColumnName("marcadeconcorrencia");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("nome");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("nomenormalizado");

                    b.HasKey("Id")
                        .HasName("pk_aspnetroles");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("rolenameindex");

                    b.ToTable("tab002_cargos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "af9dac92-ad10-4b90-9e91-d5430387a555",
                            Name = "usuario",
                            NormalizedName = "USUARIO"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "a17b1661-4e52-4479-9620-a675a887f8cd",
                            Name = "suporte",
                            NormalizedName = "SUPORTE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text")
                        .HasColumnName("tiposolicitacao");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text")
                        .HasColumnName("valorsolicitacao");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer")
                        .HasColumnName("idcargo");

                    b.HasKey("Id")
                        .HasName("pk_aspnetroleclaims");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_aspnetroleclaims_roleid");

                    b.ToTable("tab006_cargosdeidentidade", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text")
                        .HasColumnName("tiposolicitacao");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text")
                        .HasColumnName("valorsolicitacao");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("idusuario");

                    b.HasKey("Id")
                        .HasName("pk_aspnetuserclaims");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_aspnetuserclaims_userid");

                    b.ToTable("tab007_solicitacoescargo", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text")
                        .HasColumnName("provedordelogin");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text")
                        .HasColumnName("provedordachave");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text")
                        .HasColumnName("nomedeexibicao");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("idusuario");

                    b.HasKey("LoginProvider", "ProviderKey")
                        .HasName("pk_aspnetuserlogins");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_aspnetuserlogins_userid");

                    b.ToTable("tab004_usuarioslogin", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("idusuario");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer")
                        .HasColumnName("idcargo");

                    b.HasKey("UserId", "RoleId")
                        .HasName("pk_aspnetuserroles");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_aspnetuserroles_roleid");

                    b.ToTable("tab003_usuarioscargos", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("idusuario");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text")
                        .HasColumnName("provedordologin");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<string>("Value")
                        .HasColumnType("text")
                        .HasColumnName("valor");

                    b.HasKey("UserId", "LoginProvider", "Name")
                        .HasName("pk_aspnetusertokens");

                    b.ToTable("tab005_usuariostokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_aspnetroleclaims_aspnetroles_roleid");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Linter.Modelos.Modelos.TAB001_Usuarios", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_aspnetuserclaims_aspnetusers_userid");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Linter.Modelos.Modelos.TAB001_Usuarios", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_aspnetuserlogins_aspnetusers_userid");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_aspnetuserroles_aspnetroles_roleid");

                    b.HasOne("Linter.Modelos.Modelos.TAB001_Usuarios", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_aspnetuserroles_aspnetusers_userid");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Linter.Modelos.Modelos.TAB001_Usuarios", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_aspnetusertokens_aspnetusers_userid");
                });
#pragma warning restore 612, 618
        }
    }
}
