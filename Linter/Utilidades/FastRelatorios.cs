using Linter.Dados.Repositorios;
using Linter.Dados.Contexto;
using Microsoft.EntityFrameworkCore;
using Linter.Modelos.Modelos;
using Linter.Modelos.Enumeradores;
using FastReport;
using Linter.Components.Relatorios;
using System.Runtime.CompilerServices;
using FastReport.Export.PdfSimple;
using Microsoft.AspNetCore.Components.Web;

namespace Linter.Utilidades
{
    public class FastRelatorios
    {
        public async Task<byte[]> GerarRelatorio(IEnumerable<CAX001_Movimentacoes> lstMovi, string NomeRelatorio)
        {

            var filepath = Path.Combine(Directory.GetCurrentDirectory(), "Relatorios", "Caixa", "RelatorioMovimentacoes.frx");
            var diretorio = Path.GetDirectoryName(filepath);

            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }

            var report = new Report();

            if (File.Exists(filepath))
            {
                report.Report.Load(filepath);
            }
            report.Dictionary.RegisterBusinessObject(lstMovi, "lstMovi", 10, true);
            //report.Report.SetParameterValue("ValorTotal", soma);
            report.Prepare();

            report.Report.Save(filepath);

            var pdfExport = new PDFSimpleExport();
            using (var ms = new MemoryStream())
            {
                pdfExport.Export(report, ms);
                ms.Flush();
                return ms.ToArray();
            }
        }

        public async Task<byte[]> GerarRelatorio2(IEnumerable<CAX001_Movimentacoes> lstMovi, string NomeRelatorio)
        {
            decimal soma = 0;
            foreach (var valor in lstMovi)
            {
                if (valor.Tipo == (int)Enumeradores.TipoMovimentacao.Saída)
                    soma -= valor.Valor;
                else
                    soma += valor.Valor;
            }
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), @"Relatorios/movimentacoes.frx");

            // Verificar se o diretório existe, senão criar
            var diretorio = Path.GetDirectoryName(filepath);
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }

            // Criação do objeto de relatório
            Report report = new Report();
            report.Load(filepath); // Carregar o modelo do relatório

            // Registrar o objeto de dados (lstMovi)
            report.Dictionary.RegisterBusinessObject(lstMovi, "lstMovi", 10, true);
            report.SetParameterValue("ValorTotal", soma);

            try
            {
                report.Prepare();

                // Exportar o relatório para PDF
                var pdfExport = new PDFSimpleExport();
                using (var ms = new MemoryStream())
                {
                    pdfExport.Export(report, ms);
                    ms.Flush();
                    return ms.ToArray();  // Retornar o PDF gerado
                }
            }
            catch (Exception ex)
            {
                // Se ocorrer algum erro durante a preparação ou exportação, logue o erro
                Console.WriteLine("Erro ao gerar relatório: " + ex.Message);
                throw;
            }
        }


        #region Comentado
        //public WebReport GerarRelatorioMovimentacoes(string relatorio, IEnumerable<CAX001_Movimentacoes> movimentacoes)
        //{
        //    var UserWebReport = new WebReport();
        //    try
        //    {
        //        string caminhoRelatorio = Path.Combine(Directory.GetCurrentDirectory(), $@"Relatorios/{relatorio}.fpx");


        //        if (System.IO.File.Exists(caminhoRelatorio))
        //        {
        //            UserWebReport.Report = Report.FromFile(caminhoRelatorio);
        //            UserWebReport.Report.Load(relatorio);
        //            if (UserWebReport.Report != null)
        //            {
        //                decimal soma = 0;
        //                foreach (var mov in movimentacoes.ToList())
        //                {
        //                    if (mov.Tipo == (int)Enumeradores.TipoMovimentacao.Entrada)
        //                        soma += mov.Valor;
        //                    else
        //                        soma -= mov.Valor;
        //                }
        //                UserWebReport.Report.SetParameterValue("ValorTotal", soma);
        //                UserWebReport.Report.SetParameterValue("Data", DateTime.Now);

        //                UserWebReport.Report.Prepare();
        //                //report.Dictionary.RegisterBusinessObject(movimentacoes, "CAX001", 10, true);

        //                using var pdfExport = new FastReport.Export.Pdf.PDFExport();
        //                using var reportStream = new MemoryStream();
        //                pdfExport.Export(UserWebReport.Report, reportStream);

        //                reportStream.Position = 0;
        //                UserWebReport.Report = UserWebReport.Report;
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        UserWebReport.Report.Save("debug_report.frx");
        //    }
        //    return UserWebReport;
        //}

        #endregion

    }
}
