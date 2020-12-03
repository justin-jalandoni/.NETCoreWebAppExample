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

        public IActionResult Index()
        {
            return View();
        }
        
        public CustomerController()
        {
            customerService = new CustomerService();
        }

        public IActionResult Admin()
        {
            List<Customer> ls = customerService.GetAllCustomers();
            
            return View(ls);
        }

    }
}