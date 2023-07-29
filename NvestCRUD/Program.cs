using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NvestCRUD.Model;
using NvestApp.Processor.ProcessorInterface;
using NvestApp.Processor.DataProcessor;


namespace NvestCRUD
{
    class Programs
    {
        static void Main(string[] args)
        {
            DepartmentModel department = new DepartmentModel()
            {
                DepartmentName = "IT"
            };



            // List<DepartmentModel> departments =   new DEPRTMENTREPOSITORY().GetDepartments;

            IDEPARTMENTDATAPROCESSOR _processor = new DEPARTMENTDATAPROCESSOR();

            bool IsCreated = _processor.Save(DepartmentModel.ConvertModelToEntity(department), out int ResponseCode, out string ResponseMessage);
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
