using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;
using WebApplication.Models;

namespace WebApplication.DataAccess
{
    public class CustomerDao
    {
        private MySqlConnection GetDatabaseConnection()
        {
            const string connectionString = @"server=127.0.0.1;uid=csharpuser;pwd=password;database=customerdatabase";
            MySqlConnection dbConnection = null;
            try
            {
                Console.WriteLine("Now trying to get a database connection");
                dbConnection = new MySqlConnection(connectionString);
                Console.WriteLine("Successfully connected to Database");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Connecting to the Database:" + e.Message);
            }
            return dbConnection;
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            string QUERY_ALL_CUSTOMERS = "SELECT * FROM CUSTOMER";

            try
            {
                MySqlConnection conn = GetDatabaseConnection();
                conn.Open();
                MySqlCommand command = new MySqlCommand(QUERY_ALL_CUSTOMERS, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.Id = (int) reader.GetInt64("id");
                    customer.FirstName = reader.GetString("first_name");
                    customer.LastName = reader.GetString("last_name");
                    customer.Address = reader.GetString("address");
                    customer.State = reader.GetString("state");
                    customer.Country = reader.GetString("country");
                    customer.ZipCode = reader.GetString("zip_code");
                    customer.PhoneNumber = reader.GetString("phone_number");
                    customers.Add(customer);
                }
                command.Dispose();
                reader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return customers;
        }


        public void insertCustomer(Customer customer)
        {
            
        }
    }
}