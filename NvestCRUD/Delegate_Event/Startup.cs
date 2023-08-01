using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestCRUD.Delegate_Event
{
    class Startup
    {
        static void Main(string[] args)
        {
            Report report = new Report();

            //report.ReportGenerated += EmailService.SendEmail;
            report.ReportGenerated += UploadToDrive.UploadReport;
            report.GenerateReport();
        }
    }
}
