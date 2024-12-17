using Linter.Modelos.Modelos;
using Linter.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linter.Repositorio.Repositorios
{
    public class TAB001_UsuariosRepositorio
    {
        public ApplicationDbContext contexto { get; set; }

        public TAB001_UsuariosRepositorio(ApplicationDbContext _context)
        {
            contexto = _context;
        }

        //public async Task<TAB001_Usuarios> AdicionarUsuario(TAB001_Usuarios usuario)
        //{
        //    //if( usuario != null && contexto != null || contexto.){

        //    //}
        //    //contexto.AddAsync(usuario);
        //    //await contexto.SaveChangesAsync();
        //    //return usuario;
        //}

    }
}
