using DataAccess.Exercise.Entities;
using System;
using System.Collections.Generic;

namespace DataAccess.Exercise
{
    class Program
    {
        const string mysqlConnectionString = "server=localhost;port=3306;database=gymmanager;user=root;password=dulce664;CharSet=utf8;SslMode=none;Pooling=false;AllowPublicKeyRetrieval=true";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var recentMembers = RecentRegisterMembers();
            var productsForType = ProductsInStockForType(1);
            var saleProd = SaleProducts(1,1,4);
            Console.ReadKey(true);
        }

        private static List<Member> RecentRegisterMembers()
        {
            List<Member> members = new List<Member>();

            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);

            connection.Open();

            try
            {
                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("RecentRegisterMembers", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                   Member user = new Member
                    {
                        Id = (int)reader["idmember"],
                        Name = reader["name"] as string,
                        RegisteredOn = (DateTime)reader["registerdate"],
                        Membershiptype = reader["membershiptype"] as string

                    };
                    members.Add(user);
                }
            }
            finally
            {

                connection.Close();
            }

            return members;
        }

        private static List<Product> ProductsInStockForType(int idProduct)
        {
            List<Product> products = new List<Product>();

            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);

            connection.Open();

            try
            {
                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("ProductsInStockForType", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("_producttype", idProduct);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product
                    {
                        Id = (int)reader["idinventory"],
                        Name = reader["name"] as string,
                        ProductTypeId = (int)reader["producttypes_idproducttypes"],
                        ProductTypeName = reader["productype_name"] as string,
                        Stock = (int)reader["stock"]
                        

                    };
                    products.Add(product);
                }
            }
            finally
            {

                connection.Close();
            }

            return products;
        }

        private static Sale SaleProducts(int idProduct, int IdUser, int Amount)
        {
            Sale result = null;

            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);

            connection.Open();

            try
            {
                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("Sales", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("_iduser", IdUser);
                command.Parameters.AddWithValue("_idproduct", idProduct);
                command.Parameters.AddWithValue("_amount", Amount);

                command.ExecuteNonQuery();

            }
            finally
            {
                connection.Close();
            }

            return result;
        }

    }
}
