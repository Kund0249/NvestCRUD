using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestCRUD.EnumExample
{
    public enum WeekDays
    {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2
    }
    public enum NotificationType
    {
        Sucess = 0,
        Error = 1,
        Warrning = 2,
        Info = 3
    }
    public static class Notifier
    {

        public static void Notify(NotificationType notificationType, string Message)
        {
            if (notificationType == NotificationType.Sucess)
            {
                Console.WriteLine("Success");
                Console.WriteLine(Message);
            }
            else if (notificationType == NotificationType.Error)
            {
                Console.WriteLine("Error");
                Console.WriteLine(Message);
            }
            else if (notificationType == NotificationType.Warrning)
            {
                Console.WriteLine("Warrning");
                Console.WriteLine(Message);
            }
            else if (notificationType == NotificationType.Info)
            {
                Console.WriteLine("Information");
                Console.WriteLine(Message);
            }
        }
        //public static void Notify(string NotificationType, string Message)
        //{
        //    switch (NotificationType)
        //    {
        //        case "Success":
        //            Console.WriteLine("Success");
        //            Console.WriteLine(Message);
        //            break;
        //        case "Error":
        //            Console.WriteLine("Error");
        //            Console.WriteLine(Message);
        //            break;
        //        case "Warrning":
        //            Console.WriteLine("Warrning");
        //            Console.WriteLine(Message);
        //            break;
        //        case "Info":
        //            Console.WriteLine("Information");
        //            Console.WriteLine(Message);
        //            break;
        //        default:
        //            break;
        //    }
        //}
    }
}
