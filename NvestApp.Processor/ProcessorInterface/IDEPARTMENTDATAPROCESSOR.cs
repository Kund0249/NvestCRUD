using NvestApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.Processor.ProcessorInterface
{
   public interface IDEPARTMENTDATAPROCESSOR
    {
        bool Save(Department department, out int StatusCode, out string Messge);

        bool Update(Department department, out int StatusCode, out string Messge);
    }
}
