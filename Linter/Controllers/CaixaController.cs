using Linter.Dados.Contexto;
using Linter.Dados.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace Linter.Controllers
{
    public class CaixaController : Controller
    {
        #region Construtor
        private readonly ApplicationDbContext contexto;

        public CaixaController(ApplicationDbContext _contexto)
        {
            contexto = _contexto;
        }

        #endregion

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var caixa = new CAX001_MovimentacoesRepositorio(contexto);
            await caixa.RetornaMovimentacoes();
            return View("");
        }
    }
}
