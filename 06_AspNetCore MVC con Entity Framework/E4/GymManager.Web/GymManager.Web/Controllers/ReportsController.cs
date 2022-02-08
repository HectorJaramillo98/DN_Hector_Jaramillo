using GymManager.Core.AttendanceReport;
using GymManager.DataAccess;
using GymManager.DataAccess.Reports;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Reporting.NETCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Wkhtmltopdf.NetCore;

namespace GymManager.Web.Controllers
{
    public class ReportsController : Controller
    {
        private readonly IGeneratePdf _generatePdf;
        private readonly IWebHostEnvironment _enviroment;
        public ReportsController(IWebHostEnvironment enviroment, IGeneratePdf generatePdf)
        {
            _enviroment = enviroment;
            _generatePdf = generatePdf;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewMembers()
        {
            string path = System.IO.Path.Combine(_enviroment.ContentRootPath, "Reports\\NewMembers.rdlc");
            Stream reportDefinition = System.IO.File.OpenRead(path);

            LocalReport report = new LocalReport();
            report.EnableExternalImages = true;
            report.LoadReportDefinition(reportDefinition);

            MembersDataSet dataSet = new MembersDataSet();
            Random random = new Random();

            string[] membershipTypes = new string[] { "Basic", "Family", "Gold" };

            for (int i = 0; i < 28; i++)
            {
                MembersDataSet.MemberRow row = dataSet.Member.NewMemberRow();

                row.Name = $"Member Pérez {i}";

                int day = random.Next(1, 10) * -1;
                row.RegisteredOn = DateTime.Today.AddDays(day);

                int membershipIndex = random.Next(0, 2);
                row.MembershipType = membershipTypes[membershipIndex];

                dataSet.Member.Rows.Add(row);
            }

            byte[] streamBytes = null;
            string mimeType = "";
            string encoding = "";
            string filenameExtension = "pdf";
            string reportName = "NewMembers";
            string[] streamids = null;
            Warning[] warnings = null;

            report.SetParameters(new ReportParameter[] {
                new ReportParameter("DateFrom", DateTime.Today.AddDays(-10).ToString()),
                new ReportParameter("DateTo", DateTime.Today.ToString())
            });

            report.DataSources.Add(new ReportDataSource("Members", (System.Data.DataTable)dataSet.Member));

            streamBytes = report.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);

            return File(streamBytes, mimeType, $"{reportName}.{filenameExtension}");
        }

        public IActionResult Attendance()
        {
            

            string path = System.IO.Path.Combine(_enviroment.ContentRootPath, "Reports\\Attendance.rdlc");
            Stream reportDefinition = System.IO.File.OpenRead(path);

            LocalReport report = new LocalReport();
            report.EnableExternalImages = true;
            report.LoadReportDefinition(reportDefinition);

            MostCheckDataSet dataSet = new MostCheckDataSet();
            CheckingDataSet dataSet2 = new CheckingDataSet();
            Random random = new Random();

            string[] membershipTypes = new string[] { "Basic", "Family", "Gold" };
            ProcedureReport procedureReport = new ProcedureReport();

            

            List<CheckSQL> memberAssistsList = procedureReport.MemberChecks();
            for (int i = 0; i < memberAssistsList.Count; i++)
            {
                MostCheckDataSet.MemberChecksRow row = dataSet.MemberChecks.NewMemberChecksRow();

                row.Id = i+1;

                row.Name = memberAssistsList[i].MemberName;

                row.LastName = memberAssistsList[i].MemberLastName;

                row.Checks = memberAssistsList[i].Checks;

                dataSet.MemberChecks.Rows.Add(row);
            }
            List<WeekChecks> weekChecksList = procedureReport.LastWeekChecks();
            for (int i = 0; i < weekChecksList.Count; i++)
            {
                CheckingDataSet.CheckForDayRow row = dataSet2.CheckForDay.NewCheckForDayRow();
                row.Date = weekChecksList[i].DateDay;
                row.CheckCount = weekChecksList[i].CountChecks;

                dataSet2.CheckForDay.Rows.Add(row);
            }
            byte[] streamBytes = null;
            string mimeType = "";
            string encoding = "";
            string filenameExtension = "pdf";
            string reportName = "MemberChecks";
            string[] streamids = null;
            Warning[] warnings = null;

            report.SetParameters(new ReportParameter[] {
                new ReportParameter("DateFrom", DateTime.Today.AddDays(-10).ToString()),
                new ReportParameter("DateTo", DateTime.Today.ToString())
            });

            report.DataSources.Add(new ReportDataSource("MemberChecks", (System.Data.DataTable)dataSet.MemberChecks));
            report.DataSources.Add(new ReportDataSource("CheckForDay", (System.Data.DataTable)dataSet2.CheckForDay));

            streamBytes = report.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);

            return File(streamBytes, mimeType, $"{reportName}.{filenameExtension}");
        }


    }
}
