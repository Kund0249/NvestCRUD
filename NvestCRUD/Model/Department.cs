using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestCRUD.Model
{
    public class Department
    {
        public int DeptId { get; set; }

        private string _DepartmentName;
        public string DepartmentName
        {
            get { return _DepartmentName; }
            set
            {
                if(!(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) && value.Length <= 15)
                {
                    _DepartmentName = value;
                }
                else
                {
                    throw new Exception("The Value for the property DepartmentName not valid!");
                }
            }
        }
    }
}
