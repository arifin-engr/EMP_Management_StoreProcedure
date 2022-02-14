using EMP.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP.DAL
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public static string connectionString = "data source=.;database=Test_DB_25;integrated security=true";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        public void Add(Employee employee)
        {
            string query = "sp_AddAppUsser";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = employee.getFullName();
            sqlCommand.Parameters.AddWithValue("@Email", SqlDbType.NVarChar).Value = employee.Email;
            sqlCommand.Parameters.AddWithValue("@Password", SqlDbType.NVarChar).Value = employee.Designation;
            sqlCommand.Parameters.AddWithValue("@Gender", SqlDbType.NVarChar).Value = employee.Gender;
            sqlCommand.Parameters.AddWithValue("@PhoneNo", SqlDbType.NVarChar).Value = employee.PhoneNo;
            sqlCommand.Parameters.AddWithValue("@Address", SqlDbType.NVarChar).Value = employee.Address;
            sqlCommand.Parameters.AddWithValue("@Image", SqlDbType.NVarChar).Value = employee.Image;

            bool row = sqlCommand.ExecuteNonQuery() > 0;
            sqlConnection.Close();
            if (row == true)
            {
                throw new Exception("Successfully Saved..");
            }
        }

        public void Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public void getAll()
        {
            throw new NotImplementedException();
        }

        public void getById(int? id)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
