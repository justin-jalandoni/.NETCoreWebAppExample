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
    }
}