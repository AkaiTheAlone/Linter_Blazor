using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linter.Modelos.Modelos
{
    public class CAX002_MovimentaocesCanceladas
    {
        public class CAX001_MovimentacaoCaixa
        {
            [Key]
            public int idMovimentacao { get; set; }
            public DateTime? DataMovimentacao { get; set; }
            public string Descritivo { get; set; } = string.Empty;
            public int idContaGerencial { get; set; }
            public decimal Valor { get; set; }
            public byte Tipo { get; set; } //pensando em fazer isso como um enumerador
            public string MotivoCancelamento { get; set; }
            public int idUsuarioCancelamento { get; set; }
            public DateTime DataCancelamento{ get; set; }


            [EnumDataType(typeof(Enumeradores.TipoMovimentacao))]
            [NotMapped]
            public Enumeradores.TipoMovimentacao Tipo_nrt { get; set; } //pensando em fazer isso como um enumerador
        }
    }
}
