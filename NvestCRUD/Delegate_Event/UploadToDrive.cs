using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestCRUD.Delegate_Event
{
   public class UploadToDrive
    {
        public static void UploadReport(string ReportName)
        {
            Console.WriteLine("Report Uploaded to Drive - " + ReportName);
        }
    }
}
