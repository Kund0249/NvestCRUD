using NvestApp.DataLayer.AppInterface;
using NvestApp.DataLayer.Repository;
using NvestApp.Model;
using NvestApp.Processor.ProcessorInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.Processor.DataProcessor
{
  public  class DEPARTMENTDATAPROCESSOR : IDEPARTMENTDATAPROCESSOR
    {
        // int n;
        private readonly IDEPRTMENTREPOSITORY repo;

        public DEPARTMENTDATAPROCESSOR()
        {
            repo = new DEPRTMENTREPOSITORY();
            // n = 10;
        }
        public bool Save(Department department, out int StatusCode, out string Messge)
        {
            return repo.Save(department, out StatusCode, out Messge);
        }

        public bool Update(Department department, out int StatusCode, out string Messge)
        {
            if(department.DeptId == 0)
            {
                StatusCode = 400;
                Messge = "Invalid Value for the Department Id";
                return false;
            }
            return repo.Update(department, out StatusCode, out Messge);
        }
    }
}
