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
    public class CNT001_ContasGerenciaisRepositorio
    {
        #region Propriedades
        public ApplicationDbContext context;

        #endregion

        #region Construtores
        public CNT001_ContasGerenciaisRepositorio()
        {
            context = new ApplicationDbContext();
        }
        public CNT001_ContasGerenciaisRepositorio(ApplicationDbContext _contexto)
        {
            context = _contexto;
        }
        #endregion

        #region manutencao 
        public void Inserir(CNT001_ContasGerenciais contasGerenciais)
        {
            context.CNT001_ContasGerenciais.Add(contasGerenciais);
            context.SaveChanges();
        }
        public void Atualizar(CNT001_ContasGerenciais contasGerenciais)
        {
            context.CNT001_ContasGerenciais.Update(contasGerenciais);
            context.SaveChanges();
        }
        public void Remover(CNT001_ContasGerenciais contasGerenciais)
        {
            context.CNT001_ContasGerenciais.Remove(contasGerenciais);
            context.SaveChanges();
        }
        #endregion

        #region retornos 
        public IQueryable<CNT001_ContasGerenciais> RetornaContasGerenciais()
        {
            if (context == null || context.CNT001_ContasGerenciais == null)
                throw new ApplicationException("Erro ao retornar as contas gerenciais.");

            return context.CNT001_ContasGerenciais.AsNoTracking().AsQueryable();
        }

        public CNT001_ContasGerenciais RetornaConta(int id)
        {
            if (context == null || context.CNT001_ContasGerenciais == null)
                throw new ApplicationException("Erro ao retornar esta conta.");

            var conta = context.CNT001_ContasGerenciais.FirstOrDefault(m => m.idContaGerencial== id);

            return conta == null ? throw new ApplicationException($"Conta de Nº{id} não existe no banco de dados.") : conta;
        }

        #endregion
    }
}
