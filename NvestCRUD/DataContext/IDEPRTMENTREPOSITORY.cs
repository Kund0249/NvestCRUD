using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NvestCRUD.Model;

namespace NvestCRUD.DataContext
{
   public interface IDEPRTMENTREPOSITORY
    {
        bool Save(DepartmentModel department,out int StatusCode,out string Messge);

        List<DepartmentModel> GetDepartments { get; }
    }
}
