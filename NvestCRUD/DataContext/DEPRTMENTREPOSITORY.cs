using NvestCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NvestCRUD.DataContext
{
    class DEPRTMENTREPOSITORY : IDEPRTMENTREPOSITORY
    {
        private string CS;
        public DEPRTMENTREPOSITORY()
        {
            CS = "data source=.;database=EmployeeDB;trusted_connection=true";
        }
        public bool Save(Department department, out int StatusCode, out string Messge)
        {
            try
            {
                StatusCode = 500;
                Messge = "System can not process this request, there is some server error";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spInsertDepartment", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            StatusCode = Convert.ToInt32(reader["StatusCode"]);
                            Messge = reader["Message"].ToString();
                        }
                    }
                   
                    con.Close();
                }

                if (StatusCode == 200)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                StatusCode = 500;
                Messge = "System can not process this request, there is some server error";
            }
            return false;
        }
    }
}
