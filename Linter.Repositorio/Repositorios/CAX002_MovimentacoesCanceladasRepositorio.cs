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
    public class CAX002_MovimentacoesCanceladasRepositorio
    {
        #region Construtores 
        private readonly ApplicationDbContext contexto;
        public CAX002_MovimentacoesCanceladasRepositorio()
        { 
            contexto = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>());
        }
        public CAX002_MovimentacoesCanceladasRepositorio(ApplicationDbContext _context)
        {
            contexto = _context;
        }
        #endregion

        #region Manutencao
        public async void InserirMovimentacao(CAX002_MovimentaocesCanceladas caixa)
        {
            if (contexto != null || caixa != null || contexto.CAX002_MovimentaocesCanceladas != null)
            {
                contexto.CAX002_MovimentaocesCanceladas.Add(caixa);
                await contexto.SaveChangesAsync();
            }
        }
        public async void ExcluirMovimentacao(int id)
        {
            if (contexto != null || id != 0 || contexto.CAX002_MovimentaocesCanceladas != null)
            {
                var movimentacao = contexto.CAX002_MovimentaocesCanceladas.FirstOrDefault(m => m.idMovimentacao == id);
                contexto.CAX002_MovimentaocesCanceladas.Remove(movimentacao);
                contexto.SaveChangesAsync();
            }
        }
        public async Task<CAX002_MovimentaocesCanceladas> EditarMovimentacao(CAX002_MovimentaocesCanceladas cancelada)
        {
            if (contexto != null || cancelada != null)
            {
                contexto.CAX002_MovimentaocesCanceladas.Update(cancelada);
                await contexto.SaveChangesAsync();
            }
            return cancelada;
        }
        #endregion

        #region Retornos 

        public IQueryable<CAX002_MovimentaocesCanceladas> RetornaMovimentacoesCanceladas()
        {
            if (contexto == null || contexto.CAX002_MovimentaocesCanceladas == null)
                throw new ApplicationException("Erro ao retornar todas as movimentações.");

             return contexto.CAX002_MovimentaocesCanceladas.AsNoTracking().AsQueryable();
        }

        public CAX002_MovimentaocesCanceladas RetornaMovimentacao(int id)
        {
            if (contexto == null || contexto.CAX002_MovimentaocesCanceladas == null)
                throw new ApplicationException("Erro ao retornar esta movimentação.");

            var movimentacao = contexto.CAX002_MovimentaocesCanceladas.FirstOrDefault(m => m.idMovimentacao == id);

            return movimentacao == null ? throw new ApplicationException($"Movimentação de Nº{id} não existe no banco de dados.") : movimentacao;
        }

        #endregion
    }
}
