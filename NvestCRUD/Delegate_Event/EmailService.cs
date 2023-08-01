using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestCRUD.Delegate_Event
{
   public class EmailService
    {
        public static void SendEmail(string ReportName)
        {
            Console.WriteLine("Notification Email sent - " + ReportName);
        }
    }
}
