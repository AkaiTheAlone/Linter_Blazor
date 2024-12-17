using Linter.Dados.Contexto;
using Linter.Modelos.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Linter.Dados.Repositorios
{
    public class CAX001_MovimentacoesRepositorio
    {
        #region Construtores 
        private readonly ApplicationDbContext contexto;
        public CAX001_MovimentacoesRepositorio(ApplicationDbContext _context)
        {
            contexto = _context;
        }

        #endregion

        #region CRUD
        public async Task<CAX001_MovimentacaoCaixa> InserirMovimentacao(CAX001_MovimentacaoCaixa caixa)
        {
            if (contexto != null || caixa != null || contexto.CAX001_Movimentacao != null)
            {
                contexto.Add(caixa);
                await contexto.SaveChangesAsync();
            }
            return caixa;
        }
        public async Task<CAX001_MovimentacaoCaixa> ExcluirMovimentacao(CAX001_MovimentacaoCaixa caixa)
        {
            if (contexto != null || caixa != null || contexto.CAX001_Movimentacao != null)
            {
                contexto.Remove(caixa);
                await contexto.SaveChangesAsync();
            }
            return caixa;
        }
        public async Task<CAX001_MovimentacaoCaixa> EditarMovimentacao(CAX001_MovimentacaoCaixa caixa)
        {
            if (contexto != null || caixa != null || contexto.CAX001_Movimentacao != null)
            {
                contexto.Update(caixa);
                await contexto.SaveChangesAsync();
            }
            return caixa;
        }
        #endregion

        #region Retornos 

        public async Task<List<CAX001_MovimentacaoCaixa>> RetornaMovimentacoes()
        {
            if (contexto == null || contexto.CAX001_Movimentacao == null)
                throw new ApplicationException("Erro ao retornar todos as movimentações.");

            return await contexto.CAX001_Movimentacao.ToListAsync();
        }

        public async Task<CAX001_MovimentacaoCaixa> RetornaMovimentacao(int id)
        {
            if (contexto == null || contexto.CAX001_Movimentacao == null)
                throw new ApplicationException("Erro ao retornar esta movimentação.");

            var movimentacao = await contexto.CAX001_Movimentacao.FirstOrDefaultAsync(m => m.idMovimentacao == id);

            return movimentacao == null ? throw new ApplicationException($"Movimentação de Nº{id} não existe no banco de dados.") : movimentacao;
        }

        #endregion
    }
}
