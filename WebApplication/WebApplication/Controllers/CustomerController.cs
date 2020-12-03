using WebApplication.Service;

namespace WebApplication.Controllers
{
    public class CustomerController
    {
        private CustomerService customerService;


        public CustomerController()
        {
            customerService = new CustomerService();
        }
        
        public string Index()
        {
            return "fsafsafsa";
        }
        
        
    }
}