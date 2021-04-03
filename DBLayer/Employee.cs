using Models.Employee;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using IDBLayer;
using Dapper;

namespace DBLayer
{
    public class Employee : IEmployee
    {
        public int AddEmployee(EmployeeModel empModel)
        {
            int i = 0;
            using (SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                SqlCommand sco = new SqlCommand("AddEmployee", sc);
                sco.CommandType = CommandType.StoredProcedure;
                sco.Parameters.Add(new SqlParameter("@Name", empModel.Name));
                i = sco.ExecuteNonQuery();
            }
            return i;
        }

        public int UpdateEmployee(EmployeeModel empModel)
        {
            int i = 0;
            using (SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                SqlCommand sco = new SqlCommand("UpdateEmployee", sc);
                sco.CommandType = CommandType.StoredProcedure;
                sco.Parameters.Add(new SqlParameter("@EmployeeID", empModel.EmployeeID));
                sco.Parameters.Add(new SqlParameter("@Name", empModel.Name));
                i = sco.ExecuteNonQuery();
            }
            return i;
        }

        public int DeleteEmployee(int EmpId)
        {
            int i = 0;
            using (SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                SqlCommand sco = new SqlCommand("DeleteEmployee", sc);
                sco.CommandType = CommandType.StoredProcedure;
                sco.Parameters.Add(new SqlParameter("@EmployeeID", EmpId));
                i = sco.ExecuteNonQuery();
            }
            return i;
        }
    }
}
