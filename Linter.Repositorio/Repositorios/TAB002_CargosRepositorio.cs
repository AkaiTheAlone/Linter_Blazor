using Linter.Dados.Contexto;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Linter.Dados.Repositorios
{
    public class TAB002_CargosRepositorio
    {
        #region Construtores
        private readonly ApplicationDbContext context;
        public TAB002_CargosRepositorio()
        {
                
        }
        public TAB002_CargosRepositorio(ApplicationDbContext _context)
        {
            context = _context;
        }
        #endregion

        #region Manutencao

        public async Task GravarRoles(IdentityRole<int> permissao)
        {
            await context.Roles.AddAsync(permissao);
            await context.SaveChangesAsync();   
        }
        public void AtualizarRoles(IdentityRole<int> permissao)
        {
            context.Roles.Update(permissao);
            context.SaveChangesAsync();
        }
        #endregion

        #region Retornos

        public IQueryable<IdentityRole<int>> RetornaTodosOsCargos()
        {
            return context.Roles.AsQueryable();
        }
        public async Task<IdentityRole<int>> RetornaUm(int id)
        {
            return await context.Roles.Where(X=> X.Id == id).FirstOrDefaultAsync() ?? new IdentityRole<int>();
        }

        #endregion
    }
}
