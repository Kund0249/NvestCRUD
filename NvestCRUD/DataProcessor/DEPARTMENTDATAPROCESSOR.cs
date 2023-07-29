using NvestCRUD.DataContext;
using NvestCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestCRUD.DataProcessor
{
    public class DEPARTMENTDATAPROCESSOR : IDEPARTMENTDATAPROCESSOR
    {
       // int n;
        private readonly IDEPRTMENTREPOSITORY repo;

        public DEPARTMENTDATAPROCESSOR()
        {
            repo = new DEPRTMENTREPOSITORY();
           // n = 10;
        }
        public bool Save(DepartmentModel department, out int StatusCode, out string Messge)
        {
            return repo.Save(department, out StatusCode,out Messge);
        }
    }
}
