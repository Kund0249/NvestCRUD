using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NvestCRUD.Model;
using NvestCRUD.DataContext;
using NvestCRUD.DataProcessor;

namespace NvestCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department()
            {
                DepartmentName = "CS"
            };

            IDEPARTMENTDATAPROCESSOR repo = new DEPARTMENTDATAPROCESSOR();

           bool IsCreated =  repo.Save(department, out int ResponseCode, out string ResponseMessage);
            if (IsCreated)
            {
                Console.WriteLine("Success : " + ResponseMessage);
            }
            else
            {
                switch (ResponseCode)
                {
                    case 500:
                        Console.WriteLine("System Error : " + ResponseMessage);
                        break;
                    case 403:
                        Console.WriteLine("Warrning : " + ResponseMessage);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
