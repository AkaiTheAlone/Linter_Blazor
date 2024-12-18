using System.ComponentModel.DataAnnotations;

namespace Linter.Modelos
{
    public class Enumeradores
    {
        #region Dicas de uso 
        //pra usar os enumeradores em uma view, é preciso usar o código deste jeito 
        //Enum.GetNames(typeof(Enumeradores.TipoMovimentacao))
        //<FluentListbox Items = "Enum.GetNames(typeof(Enumeradores.TipoMovimentacao))" ></ FluentListbox >


        #endregion


        public enum SimNao
        {
            Sim = 0,
            Não = 1
        }
        public enum TipoMovimentacao : byte
        {
            [Display(Name = "Entrada")]
            Entrada = 0,
            [Display(Name = "Saida")]
            Saída = 1
            //transferencia, troco, etc?
        }
        public enum TipoView
        {
            Criar = 0,
            Editar = 1,
            Apagar = 2,
            Exibir = 3
        }
        public enum TipoUsuario
        {
            Usuario = 0,
            Admin = 1
        }
    }
}
