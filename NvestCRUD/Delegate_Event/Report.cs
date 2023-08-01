using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NvestCRUD.Delegate_Event
{
    public delegate void ReportDelegate(string ReportName);
    public class Report
    {
        public event ReportDelegate ReportGenerated;
        public void GenerateReport()
        {
            Console.WriteLine("Report Initiated...");
            Thread.Sleep(200);
            Console.Write("Report Generating : ");
            for (int i = 1; i < 100; i++)
            {
                Thread.Sleep(50);
            }
            Thread.Sleep(200);
            Console.WriteLine();
            Console.WriteLine("Report Generated.");
            onReportGenerated("Abc_Report");
        }


        public void onReportGenerated(string ReportName)
        {
            if (ReportGenerated != null)
                ReportGenerated(ReportName);
        }
    }
}
