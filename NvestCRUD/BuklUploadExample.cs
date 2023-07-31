using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace NvestCRUD
{
    class BuklUploadExample
    {
        static void Main(string[] args)
        {
            string ExcelFilepath = @"C:\Users\Admin\Desktop\TDepartments.xlsx";

            //string Ext = System.IO.Path.GetExtension(ExcelFilepath);
            //Console.WriteLine(Ext);

            String CS = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            + ExcelFilepath + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";

            using (OleDbConnection con = new OleDbConnection(CS))
            {
                OleDbCommand cmd = new OleDbCommand("select * from [Sheet1$]", con);

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

                DataTable dataTablt = new DataTable();
                adapter.Fill(dataTablt);
            }
        }
    }
}
