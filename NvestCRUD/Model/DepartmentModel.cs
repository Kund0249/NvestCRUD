using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NvestApp.Model;

namespace NvestCRUD.Model
{
    public class DepartmentModel
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

        public static Department ConvertModelToEntity(DepartmentModel model)
        {
            return new Department()
            {
                DeptId = model.DeptId,
                DepartmentName = model.DepartmentName
            };
        }

        public static DepartmentModel ConvertEntityToModel(Department entity)
        {
            return new DepartmentModel()
            {
                DeptId = entity.DeptId,
                DepartmentName = entity.DepartmentName
            };
        }
    }
}
