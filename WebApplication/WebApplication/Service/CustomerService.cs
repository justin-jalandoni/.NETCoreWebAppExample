using System.Collections.Generic;
using WebApplication.DataAccess;
using WebApplication.Models;

namespace WebApplication.Service
{
    public class CustomerService
    {
        private CustomerDao customerDao;


        public CustomerService()
        {
            customerDao = new CustomerDao();
        }

        public List<Customer> GetAllCustomers()
        {
            return customerDao.GetAllCustomers();
        }

        public bool createCustomer(Customer customer)
        {
            return customerDao.insertCustomer(customer);
        }
    }
}