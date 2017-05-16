using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestReports.Models;

namespace TestReports.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var dados = new List<Test>();
            dados.Add(new Test() { Id = 1, Name = "1" });
            dados.Add(new Test() { Id = 2, Name = "2" });
            dados.Add(new Test() { Id = 3, Name = "3" });
            ViewBag.ReportViewer = GerarRelatorio("PDF", "pdf", dados);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private ReportViewer GerarRelatorio(string formato, string extensao, IList<Test> dadosRelatorio)
        {
            var rptTeste = new ReportViewer();
            rptTeste.LocalReport.DataSources.Clear();
            rptTeste.Reset();

            rptTeste.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            rptTeste.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"TestReport.rdlc";
            rptTeste.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DTORelatorioContratosFormalizados_DataSet", dadosRelatorio));

            rptTeste.SizeToReportContent = true;
            rptTeste.Width = System.Web.UI.WebControls.Unit.Percentage(100);
            rptTeste.Height = System.Web.UI.WebControls.Unit.Percentage(100);

            return rptTeste;
        }
    }
}