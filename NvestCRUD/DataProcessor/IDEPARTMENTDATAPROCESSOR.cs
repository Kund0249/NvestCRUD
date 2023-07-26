using NvestCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestCRUD.DataProcessor
{
   public interface IDEPARTMENTDATAPROCESSOR
    {
        bool Save(Department department, out int StatusCode, out string Messge);
    }
}
