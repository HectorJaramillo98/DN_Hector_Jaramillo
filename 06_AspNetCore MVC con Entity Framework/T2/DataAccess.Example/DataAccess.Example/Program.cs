using DataAccess.Example.Entities;
using System;
using System.Collections.Generic;

namespace DataAccess.Example
{
    internal class Program
    {
        const string mysqlConnectionString = "server=localhost;port=3306;database=sqltesting;user=root;password=dulce664;CharSet=utf8;SslMode=none;Pooling=false;AllowPublicKeyRetrieval=true";

        static void Main(string[] args)
        {
           var allUsers = GetUsers();

            var userFord = GetUserById(4);

            var userTesla = GetUserById(3);

            var companyResult = CreateCompany("HP", "MX", "admin@hp.com", "user@hp.com");
            Console.WriteLine("Hello World!");
        }

        private static List<User> GetUsers()
        {
            List<User> users = new List<User>();

            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);

            connection.Open();

            try
            {
                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("GetAllUsers", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User
                    {
                        Id = (int)reader["iduser"],
                        UserName = reader["username"] as string,
                        Email = reader["email"] as string,
                        CompanyId = (int)reader["idcompany"]

                    };
                    users.Add(user);
                }
            }
            finally
            {

                connection.Close();
            }

            return users;
        }

        private static User GetUserById(int userId)
        {
            User user = null;

            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);

            connection.Open();

            try
            {
                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("GetUserById", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("_id", userId);
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    user = new User
                    {
                        Id = (int)reader["iduser"],
                        UserName = reader["username"] as string,
                        Email = reader["email"] as string,
                        CompanyId = (int)reader["idcompany"]

                    };

                }
            }
            finally
            {

                connection.Close();
            }

            return user;
        }

        private static CompanyCreationResult CreateCompany(string companyName, string companyLocation,
            string adminEmail, string employeeEmail)
        {
            CompanyCreationResult result = null;

            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);

            connection.Open();

            try
            {
                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("CreateCompany", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("_companyName", companyName);
                command.Parameters.AddWithValue("_location", companyLocation);
                command.Parameters.AddWithValue("_adminEmail", adminEmail);
                command.Parameters.AddWithValue("_userEmail", employeeEmail);

                var companyIdParameter = command.Parameters.Add("_idcompany", System.Data.DbType.Int32);
                companyIdParameter.Direction = System.Data.ParameterDirection.Output;

                var adminIdParameter = command.Parameters.Add("_idadmin", System.Data.DbType.Int32);
                adminIdParameter.Direction = System.Data.ParameterDirection.Output;

                var userIdParameter = command.Parameters.Add("_iduser", System.Data.DbType.Int32);
                userIdParameter.Direction = System.Data.ParameterDirection.Output;

                command.ExecuteNonQuery();

                result = new CompanyCreationResult
                {
                    CompanyId = (int)companyIdParameter.Value,
                    AdminId = (int)adminIdParameter.Value,
                    UserId = (int)userIdParameter.Value               
                };              
            }
            finally
            {

                connection.Close();
            }

            return result;
        }
    }
}
