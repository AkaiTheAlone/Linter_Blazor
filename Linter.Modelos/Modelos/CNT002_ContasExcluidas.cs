using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linter.Modelos.Modelos
{
    public class CNT002_ContasExcluidas: CNT001_ContasGerenciais
    {
        public DateTime DataExclusao { get; set; }
        public string MotivoCancelamento { get; set; } = "";
        public int idUsuarioExclusao { get; set; }
    }
}
