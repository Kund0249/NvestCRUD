using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestCRUD.EnumExample
{
    class Startup
    {
        static void Main(string[] args)
        {
            Notifier.Notify(NotificationType.Sucess, "The record is created successfully!");

            Notifier.Notify(NotificationType.Error, "The is some error while processing this request!");

            Notifier.Notify(NotificationType.Warrning, "The record already exists!");

            Notifier.Notify(NotificationType.Info, "Incorrect value you entered!");
        
           
        }
    }
}
