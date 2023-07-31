using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NvestCRUD
{
    class BulkUpload
    {
        static void Main(string[] args)
        {
            DataTable table = new DataTable();

            DataColumn col1 = new DataColumn("DepartmentName", typeof(string));
           // DataColumn col2 = new DataColumn("Desc", typeof(string));

            table.Columns.Add(col1);

            DataRow row1 = table.NewRow();
            row1["DepartmentName"] = "ABC";
           // row1["Desc"] = "ABC";

            DataRow row2 = table.NewRow();
            row2["DepartmentName"] = "ABC2";

            DataRow row3 = table.NewRow();
            row3["DepartmentName"] = "ABC3";

            table.Rows.Add(row1);
            table.Rows.Add(row2);
            table.Rows.Add(row3);

            table.AcceptChanges();

            using(SqlConnection con = new SqlConnection("data source=.;database=EmployeeDB;trusted_connection=true"))
            {
                using(SqlBulkCopy sqlBulk = new SqlBulkCopy(con))
                {
                    sqlBulk.DestinationTableName = "tblDepartment";

                    sqlBulk.ColumnMappings.Add("DepartmentName", "DepartmentName");
                    //sqlBulk.ColumnMappings.Add("Desc", "DepartmentDesc");

                    con.Open();
                    sqlBulk.WriteToServer(table);
                    con.Close();
                    Console.WriteLine("Process Completed!");
                }
            }
        }
    }
}
