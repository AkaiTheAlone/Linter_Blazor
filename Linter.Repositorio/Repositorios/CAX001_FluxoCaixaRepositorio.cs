using Linter.Modelos.Modelos;
using Linter.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Linter.Repositorio.Repositorios
{
    public class CAX001_FluxoCaixaRepositorio
    {
        #region CRUD

        private readonly ApplicationDbContext contexto;
        public CAX001_FluxoCaixaRepositorio(ApplicationDbContext _context)
        {
            contexto = _context;
        }
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
            var movimentacao = await contexto.CAX001_Movimentacao.FirstOrDefaultAsync(m=> m.idMovimentacao == id);

            if (movimentacao == null) throw new ApplicationException($"Movimentação de ID {id} não existe no banco de dados.");

            return movimentacao;
        }

        #endregion
    }
}
