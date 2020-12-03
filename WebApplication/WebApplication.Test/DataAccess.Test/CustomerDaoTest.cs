using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using NUnit.Framework;
using WebApplication.DataAccess;
using WebApplication.Models;

namespace WebApplication.Test.DataAccess.Test
{
    public class Tests
    {
        [Test]
        public void TestRetrieveAllCustomers()
        {
            CustomerDao customerDao = new CustomerDao();
            List<Customer> customers = customerDao.GetAllCustomers();
            Assert.False(customers.Count == 0);
        }

        [Test]
        public void TestInsertCustomer()
        {
            Customer c = new Customer()
            {
                Id = 22,
                FirstName = "From Unit Test",
                LastName = "Last Name",
                Address = "Addess",
                State = "state",
                Country = "country",
                ZipCode = "Zip",
                PhoneNumber = "1234"
            };
            new CustomerDao().InsertCustomer(c);
        }
    }
}