using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace NvestCRUD.ExtensionMethod
{
    static class BasicCalExt
    {
        public static void Fun4(this BasicCal ob, int n1,int n2)
        {
            Console.WriteLine("Function 1 Invoked - " + n1 + " - " + n2);
        }

        public static string ConvertoString(this List<int> ob,string deliminator)
        {
            // string values = string.Empty;
            StringBuilder values = new StringBuilder();
            foreach (int item in ob)
            {
                //values += item + deliminator;
                values.Append(item + deliminator);
            }
            //values = values.Remove(values.LastIndexOf("|"));
            //return values;

            return values.ToString();
        }
    }
}
