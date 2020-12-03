using System;
using System.Windows.Forms;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult GetAllCustomers()
        {
            return null;
        }
        
    }
}