using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Apartes.Repositorry

{
    internal class UserRepository
    {
        private readonly string _connectionString;

        public UserRepository()
        {
            

        }

        public bool AuthenticateUser(string email, string password)
        {
            bool isAuthenticated = false;

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T7U32P7;Initial Catalog=Apartes;Integrated Security=True"))
            {
                //Define Query
                string query = "SELECT email,password_hash FROM Users WHERE email =@email AND password_hash=@password";

                using (SqlCommand command =new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    //open connecttion 
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader()) 
                    { 
                        if (reader.HasRows)
                        {
                            isAuthenticated = true;
                        }
                    }
                }
            }

            return isAuthenticated;
        }
    }

    public class Users
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string password_hash {  get; set; }
        public bool active { get; set; }
        public string User_type {  get; set; }
    }
}
