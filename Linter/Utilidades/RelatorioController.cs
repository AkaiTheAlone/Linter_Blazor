//using FastReport;
//using FastReport.Web;
//using Linter.Modelos.Modelos;
//using Microsoft.AspNetCore.Mvc;
//using System.Reflection;
//using System.IO.MemoryMappedFiles;
//
//namespace Linter.Utilidades
//{
//    public class RelatorioController
//    {
//        public static void CriarRelatorio(string NomeRelatorio, CAX001_MovimentacoesCaixa movimentacoesCaixa)
//        {
//            var report = new Report();
//            try
//            {
//                string caminhoRelatorio = Path.Combine(Directory.GetCurrentDirectory(), $@"Relatorios/{NomeRelatorio}.frx");
//
//
//                if (!System.IO.File.Exists(caminhoRelatorio))
//                {
//                    report = Report.FromFile(caminhoRelatorio);
//
//                    //vou tentar fazer uma mapper automatico pra não perder tanto tempo
//                    //TESTAR, talvez as propriedades sejam settadas incorretamente ou até mesmo alguma exceção seja lançada
//                    //DefinirParametrosAuto(report, movimentacoesCaixa);
//
//                    if (report != null)
//                    {
//                        report.SetParameterValue("Valor", movimentacoesCaixa.Valor);
//                        report.SetParameterValue("Descricao", movimentacoesCaixa.Descritivo);
//
//                        report.Prepare();
//
//                        using var pdfExport = new FastReport.Export.PdfSimple.PDFSimpleExport();
//                        using var reportStream = new MemoryStream();
//                        pdfExport.Export(report, reportStream);
//                        File.WriteAllBytes("FINALIZADO.PDF", reportStream.ToArray());
//                    }
//                }
//            }
//            catch
//            {
//                report.Save("debug_report.frx");
//            }
//        }
//
//        public static Report DefinirParametrosAuto(Report objReport, Object Objeto)
//        {
//            //lembrando q todas as propriedades tem q ter o mesmo nome do rpt
//
//            try
//            {
//                var tipo = Objeto.GetType();
//
//                foreach (var prop in tipo.GetProperties())
//                {
//                    objReport.SetParameterValue(prop.Name, prop.GetValue(Objeto));
//                }
//
//                return objReport;
//            }
//            catch
//            {
//                objReport.Abort();
//                return objReport;
//
//            }
//
//
//
//        }
//    }
//}
//