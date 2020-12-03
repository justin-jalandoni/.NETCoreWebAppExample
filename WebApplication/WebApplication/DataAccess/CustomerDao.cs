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
                MySqlCommand readCommand = new MySqlCommand(QUERY_ALL_CUSTOMERS, conn);
                MySqlDataReader reader = readCommand.ExecuteReader();
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
                readCommand.Dispose();
                reader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return customers;
        }


        public bool InsertCustomer(Customer customer)
        {
            String QUERY_INSERT_CUSTOMER = "INSERT INTO CUSTOMER (id, first_name, last_name, address, state," +
                                           "country, zip_code, phone_number) VALUES (@1, @2, @3, @4, @5, @6, @7, @8)";
            try
            {
                MySqlConnection conn = GetDatabaseConnection();
                conn.Open();
                MySqlCommand insertCommand = new MySqlCommand(QUERY_INSERT_CUSTOMER, conn);
                insertCommand.Parameters.AddWithValue("@1", customer.Id);
                insertCommand.Parameters.AddWithValue("@2", customer.FirstName);
                insertCommand.Parameters.AddWithValue("@3", customer.LastName);
                insertCommand.Parameters.AddWithValue("@4", customer.Address);
                insertCommand.Parameters.AddWithValue("@5", customer.State);
                insertCommand.Parameters.AddWithValue("@6", customer.Address);
                insertCommand.Parameters.AddWithValue("@7", customer.ZipCode);
                insertCommand.Parameters.AddWithValue("@8", customer.PhoneNumber);
                insertCommand.ExecuteNonQuery();
                insertCommand.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
    }
}