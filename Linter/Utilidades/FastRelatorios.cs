using FastReport.Web;
using FastReport;
using Linter.Dados.Repositorios;
using Linter.Dados.Contexto;
using Microsoft.EntityFrameworkCore;
using Linter.Modelos.Modelos;
using FastReport.AdvMatrix;
using Linter.Modelos.Enumeradores;

namespace Linter.Utilidades
{
    public class FastRelatorios
    {
        public WebReport GerarRelatorioMovimentacoes(string relatorio, IEnumerable<CAX001_Movimentacoes> movimentacoes)
        {
            var UserWebReport = new WebReport();
            try
            {
                string caminhoRelatorio = Path.Combine(Directory.GetCurrentDirectory(), $@"Relatorios/{relatorio}.fpx");


                if (System.IO.File.Exists(caminhoRelatorio))
                {
                    UserWebReport.Report = Report.FromFile(caminhoRelatorio);
                    UserWebReport.Report.Load(relatorio);
                    if (UserWebReport.Report != null)
                    {
                        decimal soma = 0;
                        foreach (var mov in movimentacoes.ToList())
                        {
                            if (mov.Tipo == (int)Enumeradores.TipoMovimentacao.Entrada)
                                soma += mov.Valor;
                            else
                                soma -= mov.Valor;
                        }
                        UserWebReport.Report.SetParameterValue("ValorTotal", soma);
                        UserWebReport.Report.SetParameterValue("Data", DateTime.Now);

                        UserWebReport.Report.Prepare();
                        //report.Dictionary.RegisterBusinessObject(movimentacoes, "CAX001", 10, true);

                        using var pdfExport = new FastReport.Export.Pdf.PDFExport();
                        using var reportStream = new MemoryStream();
                        pdfExport.Export(UserWebReport.Report, reportStream);

                        reportStream.Position = 0;
                        UserWebReport.Report = UserWebReport.Report;
                    }
                }
            }
            catch
            {
                UserWebReport.Report.Save("debug_report.frx");
            }
            return UserWebReport;
        }
        //public Stream GerarRelatorioPdf(object dados, string nome)
        //{

        //    string caminhoRelatorio = Path.Combine(Directory.GetCurrentDirectory(), $@"Relatorios/{nome}.fpx");
        //    // Verifica se o template existe
        //    if (!File.Exists(caminhoRelatorio))
        //    {
        //        throw new FileNotFoundException("Template de relatório não encontrado.", caminhoRelatorio);
        //    }

        //    // Cria o relatório
        //    using var relatorio = new Report();

        //    try
        //    {
        //        // Carrega o template
        //        //relatorio.Load(caminhoRelatorio);

        //        // Configura a fonte de dados
        //        relatorio.RegisterData((System.Data.DataSet)dados, "Data");

        //        // Prepara o relatório
        //        relatorio.Prepare();

        //        // Exporta para PDF
        //        using var pdfExport = new FastReport.Export.Pdf.PDFExport();
        //        using var reportStream = new MemoryStream();
        //        pdfExport.Export(relatorio.Report, reportStream);

        //        // Retorna o stream com o relatório gerado
        //        reportStream.Position = 0;
        //        return reportStream;
        //    }
        //    finally
        //    {
        //        relatorio.Dispose();
        //    }
        //}
    }
}
