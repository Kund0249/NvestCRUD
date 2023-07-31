using NvestApp.DataLayer.AppInterface;
using NvestApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.DataLayer.Repository
{
   public class DEPRTMENTREPOSITORY : IDEPRTMENTREPOSITORY
    {
        private string CS;
        public DEPRTMENTREPOSITORY()
        {
            CS = "data source=.;database=EmployeeDB;trusted_connection=true";
        }

        public List<Department> GetDepartments
        {
            get
            {
                List<Department> list = new List<Department>();
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("select * from tblDepartment", con);
                    //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);

                    //con.Open();
                    //SqlDataReader reader = cmd.ExecuteReader();

                    //if (reader.HasRows)
                    //{
                    //    while (reader.Read())
                    //    {
                    //        list.Add(new Department()
                    //        {
                    //            DeptId = Convert.ToInt32(reader["DeptId"]),
                    //            DepartmentName = reader["DepartmentName"].ToString()
                    //        });
                    //    }
                    //}
                    //con.Close();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    //DataSet set = new DataSet();
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    //adapter.Fill(set);

                    foreach (DataRow row in table.Rows)
                    {
                        list.Add(new Department()
                        {
                            DeptId = Convert.ToInt32(row["DeptId"]),
                            DepartmentName = row["DepartmentName"].ToString()
                        });
                    }

                }
                return list;
            }
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

        public bool Update(Department department, out int StatusCode, out string Messge)
        {
            try
            {
                StatusCode = 500;
                Messge = "System can not process this request, there is some server error";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spUpdatetDepartment", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DepartmentId", department.DeptId);
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
