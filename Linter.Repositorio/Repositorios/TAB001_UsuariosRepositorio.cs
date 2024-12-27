using Linter.Dados.Contexto;
using Linter.Modelos.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Linter.Modelos.Modelos.CAX002_MovimentaocesCanceladas;

namespace Linter.Dados.Repositorios
{
    public class TAB001_UsuariosRepositorio
    {
        #region Construtores
        private readonly ApplicationDbContext contexto;
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

        public async Task<IQueryable<TAB001_Usuarios>> RetornaTodos()
        {
            if (contexto == null || contexto.TAB001_Usuarios == null)
                throw new ApplicationException("Erro ao retornar todas as movimentações.");

            return contexto.TAB001_Usuarios.AsQueryable();

        }
        #endregion
        #region Manutencao

        public async Task InserirUsuario(TAB001_Usuarios usuario)
        {
            if (contexto == null || contexto.TAB001_Usuarios == null)
                throw new ApplicationException("Erro ao inserir novo usuário.");

            await contexto.TAB001_Usuarios.AddAsync(usuario);

        }
        public async Task AtualizarUsuario(TAB001_Usuarios usuario)
        {
            if (contexto == null || contexto.TAB001_Usuarios == null)
                throw new ApplicationException("Erro ao Atualizar Usuário usuário.");

            contexto.TAB001_Usuarios.Update(usuario);
        }

        #endregion

    }
}
