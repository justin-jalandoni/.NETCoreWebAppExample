using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using WebApplication.Service;

namespace WebApplication.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerService customerService;
        
        public CustomerController()
        {
            customerService = new CustomerService();
        }

        public IActionResult Admin()
        {
            List<Customer> ls = customerService.GetAllCustomers();
            return View(ls);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCustomer(Customer customer)
        {
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            Console.WriteLine(customer.State);
            Console.WriteLine(customer.Country);
            Console.WriteLine(customer.ZipCode);
            Console.WriteLine(customer.PhoneNumber);
            return View("create");
        }

    }
}