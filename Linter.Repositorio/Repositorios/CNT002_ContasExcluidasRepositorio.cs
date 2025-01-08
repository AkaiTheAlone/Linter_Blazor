using Linter.Dados.Contexto;
using Linter.Modelos.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linter.Dados.Repositorios
{
    public class CNT002_ContasExcluidasRepositorio
    {
        #region construtores 
        public ApplicationDbContext context;
        public CNT002_ContasExcluidasRepositorio(ApplicationDbContext _context)
        {
            context = _context;
        }
        public CNT002_ContasExcluidasRepositorio()
        {
            context = new ApplicationDbContext();
        }
        #endregion

        #region manutencao 
        public void Inserir(CNT002_ContasExcluidas conta)
        {
            context.CNT002_ContasExcluidas.Add(conta);
            context.SaveChanges();
        }
        public void Atualizar(CNT002_ContasExcluidas conta)
        {
            context.CNT002_ContasExcluidas.Update(conta);
            context.SaveChanges();
        }
        public void Remover(CNT002_ContasExcluidas conta)
        {
            context.CNT002_ContasExcluidas.Remove(conta);
            context.SaveChanges();
        }
        #endregion

        #region Retornos
         
        public IQueryable<CNT002_ContasExcluidas> RetornaTodasExcluidas()
        {
            return context.CNT002_ContasExcluidas.AsNoTracking().AsQueryable();
        }


        #endregion
    }
}
