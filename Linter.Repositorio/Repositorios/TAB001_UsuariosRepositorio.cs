using Linter.Dados.Contexto;
using Linter.Modelos.Modelos;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static Linter.Modelos.Modelos.CAX002_MovimentaocesCanceladas;

namespace Linter.Dados.Repositorios
{
    public class TAB001_UsuariosRepositorio
    {
        private readonly ApplicationDbContext contexto;
        private readonly UserManager<TAB001_Usuarios> userManager;
        //sla pq eu n tenho essa bigorna
        //private readonly SignInManager<TAB001_Usuarios> signInManager;

        #region Construtores

        public TAB001_UsuariosRepositorio()
        {
            contexto = new ApplicationDbContext();
        }

        public TAB001_UsuariosRepositorio(ApplicationDbContext _contexto)
        {
            contexto = _contexto;
        }
        #endregion

        #region Retornos

        public IQueryable<TAB001_Usuarios> RetornaTodos()
        {
            if (contexto == null || contexto.TAB001_Usuarios == null)
                throw new ApplicationException("Erro ao retornar todas as movimentações.");

            return contexto.TAB001_Usuarios.AsQueryable();
        }
        #endregion

        #region Manutencao

        public async Task InserirUsuario(TAB001_Usuarios usuario, List<string> Role, List<Claim> CLAIMS)
        {

            contexto.TAB001_Usuarios.Update(usuario);

            await userManager.AddToRolesAsync(usuario, Role);

            await userManager.AddClaimsAsync(usuario, CLAIMS);
            //eu n faço a mínima ideia do q uma claim faça.
            // await userManager.AddClaimAsync(usuario, new Claim() { });
            await contexto.SaveChangesAsync();

        }
        public async Task RemoverUsuario(TAB001_Usuarios usuario, List<string> Role, List<Claim> claims)
        {
            await userManager.RemoveFromRolesAsync(usuario, Role);

            await userManager.RemoveClaimsAsync(usuario, claims);

            contexto.TAB001_Usuarios.Remove(usuario);
            await contexto.SaveChangesAsync();

        }

        public async Task AtualizarUsuario(TAB001_Usuarios usuario, List<string> rolesPart ) //Claim claim
        {
            if (contexto == null || contexto.TAB001_Usuarios == null)
                throw new ApplicationException("Erro ao Atualizar Usuário.");

            //await userManager.RemoveFromRolesAsync()
            var roles = await userManager.GetRolesAsync(usuario);
            //preciso de um ienumerable de roles pra remover 
            //o get roles retorna uma IList
            //essa conversao deve dar um erro grotesco
            await userManager.RemoveFromRolesAsync(usuario, roles);
            await userManager.AddToRolesAsync(usuario, rolesPart);
            //await userManager.RemoveClaimsAsync(usuario);
            //eu n faço a mínima ideia do q uma claim faça.
            //await userManager.AddClaimAsync(usuario, claim);

            contexto.TAB001_Usuarios.Update(usuario);
            await contexto.SaveChangesAsync();
        }

        #endregion

    }
}
