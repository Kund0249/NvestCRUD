using NvestApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.DataLayer.AppInterface
{
   public interface IDEPRTMENTREPOSITORY
    {
        bool Save(Department department, out int StatusCode, out string Messge);

        List<Department> GetDepartments { get; }
    }
}
