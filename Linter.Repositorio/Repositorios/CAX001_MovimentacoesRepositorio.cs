using Linter.Dados.Contexto;
using Linter.Modelos.Modelos;

namespace Linter.Dados.Repositorios
{
    public class CAX001_MovimentacoesRepositorio
    {
        #region Construtores 
        private readonly ApplicationDbContext contexto;
        public CAX001_MovimentacoesRepositorio()
        {
            contexto = new ApplicationDbContext();
        }
        public CAX001_MovimentacoesRepositorio(ApplicationDbContext _context)
        {
            contexto = _context;
        }
        #endregion

        #region Manutencao
        public async void InserirMovimentacao(CAX001_MovimentacoesCaixa caixa)
        {
            if (contexto != null || caixa != null || contexto.CAX001_MovimentacoesCaixa != null)
            {
                contexto.CAX001_MovimentacoesCaixa.Add(caixa);
                await contexto.SaveChangesAsync();
            }
        }
        public async void ExcluirMovimentacao(int id)
        {
            if (contexto != null || id != 0 || contexto.CAX001_MovimentacoesCaixa != null)
            {
                var movimentacao = contexto.CAX001_MovimentacoesCaixa.FirstOrDefault(m => m.idMovimentacao == id);
                contexto.CAX001_MovimentacoesCaixa.Remove(movimentacao);
                await contexto.SaveChangesAsync();
            }
        }
        public async Task<CAX001_MovimentacoesCaixa> EditarMovimentacao(CAX001_MovimentacoesCaixa caixa)
        {
            if (contexto != null || caixa != null)
            {
                contexto.CAX001_MovimentacoesCaixa.Update(caixa);
                await contexto.SaveChangesAsync();
            }
            return caixa;
        }
        #endregion

        #region Retornos 

        public IQueryable<CAX001_MovimentacoesCaixa> RetornaMovimentacoes()
        {
            if (contexto == null || contexto.CAX001_MovimentacoesCaixa == null)
                throw new ApplicationException("Erro ao retornar todas as movimentações.");

            return contexto.CAX001_MovimentacoesCaixa.AsQueryable();
        }

        public CAX001_MovimentacoesCaixa RetornaMovimentacao(int id)
        {
            if (contexto == null || contexto.CAX001_MovimentacoesCaixa == null)
                throw new ApplicationException("Erro ao retornar esta movimentação.");

            var movimentacao = contexto.CAX001_MovimentacoesCaixa.FirstOrDefault(m => m.idMovimentacao == id);

            return movimentacao == null ? throw new ApplicationException($"Movimentação de Nº{id} não existe no banco de dados.") : movimentacao;
        }

        #endregion
    }
}
