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
    public class AppUserRepository
    {
        public static string connectionString = "data source=.;database=Test_DB_25;integrated security=true";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        public void Add(AppUser appUser)
        {
            string query = "sp_AddAppUsser";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = appUser.getFullName();
            sqlCommand.Parameters.AddWithValue("@Email", SqlDbType.NVarChar).Value = appUser.Email;
            sqlCommand.Parameters.AddWithValue("@AppUserId", SqlDbType.NVarChar).Value = appUser.AppUserId;
            sqlCommand.Parameters.AddWithValue("@Password", SqlDbType.NVarChar).Value =appUser.Password;
            sqlCommand.Parameters.AddWithValue("@Gender", SqlDbType.NVarChar).Value = appUser.Gender;
            sqlCommand.Parameters.AddWithValue("@PhoneNo", SqlDbType.NVarChar).Value = appUser.PhoneNo;
            sqlCommand.Parameters.AddWithValue("@Address", SqlDbType.NVarChar).Value = appUser.Address;
            sqlCommand.Parameters.AddWithValue("@Image", SqlDbType.NVarChar).Value = appUser.Image;
           
            bool row = sqlCommand.ExecuteNonQuery() >0;
            sqlConnection.Close();
            if (row==true)
            {
                throw new Exception("Successfully Saved.."+"UserId: "+appUser.AppUserId+" "+"Password: "+appUser.Password);
            }
        }

      

        public DataTable Data(AppUser appUser)
        {
            
            string query = "sp_Login";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@userId", SqlDbType.NVarChar).Value = appUser.AppUserId;
            sqlCommand.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value = appUser.Password;
            sqlCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt);
            sqlConnection.Close();

            return dt;

        }

       
    }
}
