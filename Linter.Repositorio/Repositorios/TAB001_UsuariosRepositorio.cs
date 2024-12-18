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
    public class TAB001_UsuariosRepositorio 
    {
        private readonly ApplicationDbContext contexto;
        public TAB001_UsuariosRepositorio()
        {
            contexto = new ApplicationDbContext();
        }
        public TAB001_UsuariosRepositorio(ApplicationDbContext _contexto)
        {
            contexto = _contexto;
        }
        public async Task<List<TAB001_Usuarios>> RetornaTodos()
        {
            if (contexto != null)
            {
                return await contexto.TAB001_Usuarios.ToListAsync();
            }
            throw new ApplicationException("Contexto nulo");
        }

    }
}
