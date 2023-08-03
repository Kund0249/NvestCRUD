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
    enum StatusCode
    {
        Success = 200,
        ContentExist = 401,
        BadRequest = 400,
        ServerError = 500,
    }
    class Programs
    {
        static void Main(string[] args)
        {
            DepartmentModel department = new DepartmentModel()
            {
                DeptId = 28,
                DepartmentName = "HR_U"
            };



            // List<DepartmentModel> departments =   new DEPRTMENTREPOSITORY().GetDepartments;

            IDEPARTMENTDATAPROCESSOR _processor = new DEPARTMENTDATAPROCESSOR();

            bool IsCreated = _processor.Update(DepartmentModel.ConvertModelToEntity(department), out int ResponseCode, out string ResponseMessage);
         
           
            
            if (IsCreated)
            {
                Console.WriteLine("Success : " + ResponseMessage);
            }
            else
            {
                switch (ResponseCode)
                {
                    case 400:
                        Console.WriteLine("Bad Request : " + ResponseMessage);
                        break;
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
